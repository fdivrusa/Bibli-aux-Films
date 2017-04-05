using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bibliothèque
{
    public partial class FenetrePrincipale : Form
    {

        //Initialisation de la liste qui contiendra mes films
        private List<Film> listeFilms = new List<Film>();

        //Cette variable va me permettre de determiner si je modifie un film ou si j'en ajoute un
        private bool modif = false;

        //****** GETTERS *******//
        //Les getters me permettront d'avoir accès aux composants de cette fenêtre dans l'autre

        public List<Film> getListe()
        {
            return listeFilms;
        }

        public ListBox getListBox()
        {
            return LbxFilms;
        }

        public bool getModif() //Cette fonction permettra de savoir si il faut ajouter ou bien modifier
        {
            return modif;
        }

        public string getPath()
        {
            return pictureBox1.ImageLocation;
        }


        //****** SETTERS ******//
        //Les setters vont me permettre de modifier directement les composants de la fenêtre principale à la création de mon nouveau film
        //Cela permettra de se retrouver directement sur la fiche que l'utilisateur vient de créée

        public void setLbTitre(string newTitre)
        {
            LbTitre.Text = newTitre;
        }

        public void setLbActeur(string newActeur)
        {
            LbActeur.Text = newActeur;
        }

        public void setLbRealisateur(string newRea)
        {
            LbRealisateur.Text = newRea;
        }

        public void setLbDate(string newDate)
        {
            LbDate.Text = newDate;
        }

        public void setLbGenre(string newGenre)
        {
            LbGenre.Text = newGenre;
        }

        public void setPictureBox(string newPath)
        {

            FileStream fs = new FileStream(newPath, FileMode.Open);
            pictureBox1.Image = Image.FromStream(fs); //Je place l'image dans le pictureBox
            fs.Dispose(); //Je libère les ressources utilisées par fs
            fs.Close();//je ferme le flux

        }

        public void setRtbResume(string newResume)
        {
            richTextBox1.Text = newResume;
        }

        public void setModif(bool newModif)
        {
            modif = newModif;
        }

        //****** CONSTRUCTEUR ********//

        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        //****** METHODE *********//

        private Film selectionFilm() //Retourne l'objet du film sélectionné dans la listBox pour permettre de le modifier ou de le supprimer
        {
            Film filmSelect = null;

            foreach (Film film in listeFilms)
            {
                if (film.getTitre().Equals(Convert.ToString(LbxFilms.SelectedItem))) //On regarde quel est l'objet sélectionné dans la listBox et on le modifiera directement dans la liste
                {
                    filmSelect = film;
                }
            }

            return filmSelect;
        }

        private void refreshFenetre() //Va permettre de vider tout les champs de la fenêtre
        {
            LbTitre.Text = "";
            LbActeur.Text = "";
            LbRealisateur.Text = "";
            LbGenre.Text = "";
            LbDate.Text = "";
            richTextBox1.Text = "";
            pictureBox1.Image = null;

        }

        private void serialisationListe(string fichier, List<Film> liste) //Va permettre de sauvegarder ma liste d'objet dans un fichier 
        {
            try
            {
                FileStream flux = new FileStream(fichier, FileMode.Create); //Je crée mon fichier de sauvegarde, il sera écrasé à chaque nouvelle sauvegarde
                BinaryFormatter bf = new BinaryFormatter(); //Je crée une instance de classe BinaryFormater pour enregistrer ma liste
                bf.Serialize(flux, liste); //Je sauve ma liste dans le dossier désigné
                flux.Close(); //Je ferme le flux (IMPORTANT)
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void deserialisationListe(string fichier, List<Film> liste) //Va permettre de charger la liste de films dans l'application 
        {

            List<Film> tempListe = new List<Film>(); //Je créé une liste temporaire 

            try
            {
                FileStream flux = new FileStream(fichier, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                tempListe = (List<Film>)bf.Deserialize(flux); //Je récupère la liste de mon fichier

                foreach (Film film in tempListe)
                {
                    Film newFilm = new Film(film.getTitre(), film.getActeur(), film.getRealisateur(), film.getResume(), film.getGenre(), film.getPath(), film.getDate()); //Je réinstancie mes films avec les informations de la liste, sinon il considère que je n'ai aucune instances
                    liste.Add(newFilm); //j'ajoute mon instance dans ma liste
                    LbxFilms.Items.Add(newFilm.getTitre()); //je remplis également ma listBox
                }

                flux.Close(); //je ferme mon fichier
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //********* GESTION DES EVENEMENTS *********//

        private void BtAjouter_Click(object sender, EventArgs e) //En cliquant sur le bouton, on ouvre la fenêtre d'encodage des informations
        {
            modif = false;
            FenetreEncodage encodage = new FenetreEncodage(this); //La fenêtre d'encodage prend en paramètre notre fenêtre principale
            encodage.Show();
        }

        private void BtSupprimer_Click(object sender, EventArgs e) //On supprime le film sélectionné dans la liste des films
        {
            if (LbxFilms.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un film à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer le film sélectionné ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Film filmASupprimer = selectionFilm();

                    LbxFilms.Items.Remove(LbxFilms.SelectedItem); //je supprime dans ma listeBox     
                    listeFilms.Remove(filmASupprimer); // En dernier, je supprime dans ma liste
                    refreshFenetre(); //Je supprime de ma fenêtre les informations du film que j'ai supprimé                       
                }
            }
        }

        private void BtModifier_Click(object sender, EventArgs e) //Modifie la fiche du film sélectionné dans la liste
        {
            if (LbxFilms.SelectedItem == null) //Si l'utilisateur ne sélectionne rien, on n'ouvre juste un message d'erreur
            {
                MessageBox.Show("Veuillez choisir un film à modifier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else //Sinon, on ouvre la fenetre avec les informations du film 
            {

                modif = true;
                Film filmAModifier = selectionFilm(); //On stocke notre film selectionné dans une variable
                FenetreEncodage encodageModif = new FenetreEncodage(filmAModifier, this); //Le fait de prendre en paramètre le film sélectionner va permettre de remplir la fenêtre d'encodage à son ouverture
                                                                                          //je prend en paramètre ma fenêtre pour pouvoir changer mon titre dans la listBox
                encodageModif.setTbTitre(filmAModifier.getTitre());
                encodageModif.setTbActeur(filmAModifier.getActeur());
                encodageModif.setTbGenre(filmAModifier.getGenre());
                encodageModif.setTbRealisateur(filmAModifier.getRealisateur());
                encodageModif.setRtbResume(filmAModifier.getResume());
                encodageModif.setTbPath(filmAModifier.getPath());
                encodageModif.setDtpDate(Convert.ToDateTime(filmAModifier.getDate().ToShortDateString())); //Avec le ToShortDateString, je garde uniquement la date, sinon j'aurais eu l'heure avec, Je le reconvertis ensuite en DateTime                                                                                                           //
                encodageModif.ShowDialog();
            }
        }

        private void BtQuitter_Click(object sender, EventArgs e) //Permet de quitter le programme. Bien évidemment, on effectuera une sauvegarde durant la fermeture
        {
            if (MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Si l'utilisateur appuie sur oui, on ferme l'application
            {
                Application.Exit();
            }
        }

        private void LbxFilms_SelectedIndexChanged(object sender, EventArgs e) //Au moment ou on change d'élément dans la listBox, on affichera celui qui est sélectionné
        {
            Film filmAffichage = selectionFilm();

            try
            {
                LbTitre.Text = filmAffichage.getTitre();
                LbActeur.Text = filmAffichage.getActeur();
                LbDate.Text = filmAffichage.getDate().ToShortDateString();
                LbGenre.Text = filmAffichage.getGenre();
                LbRealisateur.Text = filmAffichage.getRealisateur();
                richTextBox1.Text = filmAffichage.getResume();

                //Je suis obliger d'utiliser un FileStream pour ma pictureBox afin de pouvoir le fermer, sinon une erreur apparait et me dit que le processus est encore ouvert
                FileStream fs = new FileStream(filmAffichage.getPath(), FileMode.Open);
                pictureBox1.Image = Image.FromStream(fs); //Je place l'image dans le pictureBox
                fs.Dispose(); //Je libère les ressources utilisées par fs
                fs.Close();//je ferme le flux


            }
            catch (System.NullReferenceException error) //Lorsque je modifie un film, le programme pense que je sélectionne un items sans texte dans la listBox, du coup il ne le trouve pas dans la liste. Comme ceci, plus de problèmes
            {
                Console.WriteLine(error.Message);
            }
        }

        private void réinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir réinitialiser la bibliothèque ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Je vide ma liste
                listeFilms.Clear();

                //Je vide ma listBox
                LbxFilms.Items.Clear();

                //Je réinitialise ma fenêtre
                refreshFenetre();

                //Je vide également mon fichier de copie
                string chemin = Path.Combine(Environment.CurrentDirectory, "Copies Images");
                string[] nomImage = Directory.GetFiles(chemin); //Je stocke le nom de mes images dans mon tableau    

                foreach (string image in nomImage)
                {
                    File.Delete(image); //Je supprime toute les images de mon dossier de copie
                }

            }
        }

        private void RtbRecherche_TextChanged(object sender, EventArgs e) //Pour rechercher un film, il suffira de taper son nom dans la barre de recherche
        {
            foreach (Film film in listeFilms)
            {
                if (RtbRecherche.Text == film.getTitre())
                {
                    LbxFilms.Items.Clear();
                    LbxFilms.Items.Add(film.getTitre());
                }
            }

            if (RtbRecherche.Text == "")
            {
                LbxFilms.Items.Clear();

                foreach (Film film in listeFilms)
                {
                    LbxFilms.Items.Add(film.getTitre());
                }
            }
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            deserialisationListe("sauvegarde.mls", listeFilms); //Au lancement de ma fenêtre, je charge mes films
        }

        private void FenetrePrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialisationListe("sauvegarde.mls", listeFilms);
        }

        private void auteur_Click(object sender, EventArgs e) //Information à propos de l'auteur
        {
            MessageBox.Show("Auteur : Di Vrusa Florian\nOption : Informatique et systèmes\nAnnée académique 2015 - 2016", "A propos de l'auteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void application_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projet réalisé dans le cadre du cours de M. Malaise.\nCe projet permet d'enregistrer des fiches de films ainsi que leurs caractéristiques.", "A propos de l'application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ajouterUnFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour ajouter un film, appuyez sur le bouton 'Ajouter un film' et encodez vos informations", "Ajouter un film", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void supprimerUnFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour supprimer un film, selectionnez le film dans la liste, appuyez sur le bouton 'Supprimer le film' et confirmez votre choix", "Supprimer un film", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modifierUnFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour modifier un film, selectionnez le film dans la liste, appuyez sur le bouton 'Modifier le film' et encodez vos informations", "Ajouter un film", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aideGénéraleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce programme sauvegarde automatiquement les films. Si vous voulez tout supprimer, allez dans 'option', 'réinitialiser' ");
        }

    }
}
