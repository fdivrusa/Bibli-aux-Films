using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Bibliothèque
{
    public partial class FenetreEncodage : Form //Ici on encodera toute nos informations avant de créée notre fiche et de "l'envoyée" à notre fenêtre principale
    {

        FenetrePrincipale principale;
        Film filmModif;

        //******** CONSTRUCTEURS **********//

        public FenetreEncodage(FenetrePrincipale p) //Le fait de mettre la fenetre principale en paramètre va permettre d'ajouter directement les films dans la liste de ma fenêtre principale
        {
            principale = p;
            InitializeComponent();
        }

        public FenetreEncodage(Film f, FenetrePrincipale m) //On utilisera ce constructeur pour modifier les films, on place en paramètre notre film à modifier et notre fenêtre principale
        {
            filmModif = f;
            principale = m;
            InitializeComponent();
        }

        public FenetreEncodage() //Constructeur par défaut
        {
            InitializeComponent();
        }

        //******** SETTERS *********//

        public void setTbTitre(string newTitre)
        {
            TbTitre.Text = newTitre;
        }

        public void setTbActeur(string newActeur)
        {
            TbActeurs.Text = newActeur;
        }

        public void setTbRealisateur(string newRealisateur)
        {
            TbRealisateurs.Text = newRealisateur;
        }

        public void setTbGenre(string newGenre)
        {
            TbGenre.Text = newGenre;
        }

        public void setTbPath(string newPath)
        {
            TbPath.Text = newPath;
        }

        public void setRtbResume(string newResume)
        {
            RtbResume.Text = newResume;
        }

        public void setDtpDate(DateTime newDate)
        {
            Dtp.Value = newDate;
        }


        //******* EVENEMENTS **********//

        private void BtParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog folder = new OpenFileDialog();

            folder.Title = "Sélection de l'image";
            folder.CheckFileExists = true; //Si le fichier demandé est introuvable, on affiche un message d'erreur
            folder.Multiselect = false; //Inutile de choisir plusieurs images ici 
            folder.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp"; //On n'acceptera que les fichiers PNG, JPEG ou BMP

            if (folder.ShowDialog() == DialogResult.OK)
            {
                TbPath.Text = folder.FileName; //Lorsque on aura sélectionner une image et appuyé sur OK, le chemin de l'image s'affichera dans la textBox
            }
        }

        private void BtEnregistrerFermer_Click(object sender, EventArgs e)
        {

            string chemin = Path.Combine(Environment.CurrentDirectory, "Copies Images"); //Je vais dans mon dossier ou j'ai copier mes images
            string[] nomImage = Directory.GetFiles(chemin); //Je stocke le chemin de mes images dans mon tableau    

            if (principale.getModif() == false) //Si on décide d'ajouter un film, autant qu'il n'y ai pas deux fois le même titre ou la même image
            {
                foreach (string titre in principale.getListBox().Items) //Vérifie si le titre entré n'est pas le même que un déja dans la listBox
                {

                    if (TbTitre.Text == titre.ToString())
                    {
                        MessageBox.Show("Un autre film se nomme déja " + TbTitre.Text + " \nVeuillez en choisir un autre titre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return; //Si c'est le cas, je ne propose pas à l'utilisateur d'enregistrer
                    }
                }
            }

            if (TbTitre.Text == "" || TbRealisateurs.Text == "" || TbActeurs.Text == "" // on vérifie que tout est bien complété                                                                               
                         || TbGenre.Text == "" || TbPath.Text == "" || RtbResume.Text == "")     //Je ne vérifie pas pour la date car il y aura d'office quelque chose de sélectionné                                                     
            {
                MessageBox.Show("Veuillez remplir tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else //Sinon si il n'y a aucune erreur, on crée notre objet, on le stocke dans notre liste et on ferme la fenêtre
            {

                if (MessageBox.Show("Êtes-vous sûr ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Pour que l'enregistrement se fasse, l'utilisateur doit confirmer qu'il veut enregistrer et fermer
                {

                    if (principale.getModif() == false) //Si le bool est à false, ça veut dire que on a appuyer sur le bouton "ajouter"
                    {

                        copieImage(TbPath.Text);
                        ajoutFilm();
                        this.Close(); //On demande si l'utilisateur est sûr de ses informations saisie, si oui, on quitte la fenêtre
                    }
                    else //Sinon si on a appuyer sur le bouton "modifier"
                    {

                        foreach (string image in nomImage)
                        {
                            if (Path.GetFileName(TbPath.Text) == Path.GetFileName(image)) //Si l'utilisateur veux garder la même image
                            {
                                modifFilm(); //Je modifie le film   
                                this.Close(); //Je ferme 
                                return; //Je quitte la fonction afin de ne pas réengistrer une image déja enregistrée
                            }
                            else
                            {
                                copieImage(TbPath.Text);
                                modifFilm();
                                this.Close(); //On demande si l'utilisateur est sûr de ses informations saisie, si oui, on quitte la fenêtre
                            }
                        }
                    }
                }
            }
        }

        //******** METHODES *********//

        private void ajoutFilm() //Cette méthode créée et ajoute nos films dans la liste de la fenêtre principale
        {

            string nom = Path.GetFileName(TbPath.Text);
            string image = Path.Combine(Environment.CurrentDirectory, "Copies Images\\" + nom);

            Film filmAjouter = new Film(TbTitre.Text, TbActeurs.Text, TbRealisateurs.Text, RtbResume.Text, TbGenre.Text, image, Dtp.Value);
            principale.getListe().Add(filmAjouter); //L'instance est maintenant dans la liste de notre fenêtre principale
            principale.getListBox().Items.Add(filmAjouter.getTitre()); //Je place dans ma listBox le titre de mon film
            majPrincipale(filmAjouter); //Mise à jour de l'affichage
        }

        private void modifFilm() //Cette fonction modifiera les attributs de mon films sélectionné 
        {

            //Modification des informations du film sélectionné
            filmModif.setTitre(TbTitre.Text);
            filmModif.setActeur(TbActeurs.Text);
            filmModif.setRealisateur(TbRealisateurs.Text);
            filmModif.setGenre(TbGenre.Text);
            filmModif.setPath(Path.Combine(Environment.CurrentDirectory, "Copies Images" + "\\" + Path.GetFileName(TbPath.Text)));
            filmModif.setResume(RtbResume.Text);
            filmModif.setDate(Dtp.Value);

            //Mise à jour de l'affichage
            majPrincipale(filmModif);

            //Je change également dans la listBox
            principale.getListBox().Items[principale.getListBox().SelectedIndex] = filmModif.getTitre();
        }

        private void majPrincipale(Film film) //Cela va permettre de mettre à jour le contenu de la fenêtre principale à chaque modification
        {
            //Je modifie le contenu de ma fenêtre principale
            principale.setLbTitre(film.getTitre());
            principale.setLbActeur(film.getActeur());
            principale.setLbDate(film.getDate().ToShortDateString());
            principale.setLbGenre(film.getGenre());
            principale.setLbRealisateur(film.getRealisateur());
            principale.setPictureBox(film.getPath());
            principale.setRtbResume(film.getResume());

        }

        private void copieImage(string cheminImageACopier) //Cette fonction va nous servir à sauvegarder notre image
        {
            string acces = Path.Combine(Environment.CurrentDirectory, "Copies Images"); //Mon chemin ou je vais copier mes images
            string nom = Path.GetFileName(TbPath.Text); //Le nom de mon image  

            try
            {
                File.Copy(TbPath.Text, Path.Combine(acces, nom)); //je copie mon image qui se trouve à TbPath.Text dans mon dossier "acces" et avec le nom "nom" 
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}

