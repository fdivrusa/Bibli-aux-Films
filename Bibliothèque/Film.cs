using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothèque
{
    [Serializable]
    public class Film
    {

        //******** DECLARATIONS DES ATTRIBUTS DE "FILM" ************//

        private string titre;
        private string acteur;
        private string realisateur;
        private string resume;
        private string genre;
        private string path;
        private DateTime date;

        //******** CONSTRUCTEUR ********//

        public Film(string titre, string acteur, string realisateur, string resume, string genre, string path, DateTime date) 
        {
            this.titre = titre;
            this.acteur = acteur;
            this.realisateur = realisateur;
            this.resume = resume;
            this.genre = genre;
            this.path = path;
            this.date = date;
        }


        //******** GETTERS DE "FILM" ********//

        public string getTitre()
        {
            return titre;
        }

        public string getActeur()
        {
            return acteur;
        }

        public string getRealisateur()
        {
            return realisateur;
        }

        public string getResume()
        {
            return resume;
        }

        public string getGenre()
        {
            return genre;
        }

        public string getPath()
        {
            return path;
        }

        public DateTime getDate()
        {
            return Convert.ToDateTime(date.ToShortDateString());
        }

        //******** SETTERS DE "FILM" ********//

        public void setTitre(string newTitre)
        {
            this.titre = newTitre;
        }

        public void setActeur(string newActeur)
        {
            this.acteur = newActeur;
        }

        public void setRealisateur(string newRealisateur)
        {
            this.realisateur = newRealisateur;
        }

        public void setResume(string newResume)
        {
            this.resume = newResume;
        }

        public void setGenre(string newGenre)
        {
            this.genre = newGenre;
        }

        public void setPath(string newPath)
        {
            this.path = newPath;
        }

        public void setDate(DateTime newDate)
        {
            this.date = newDate;
        }

    }
}
