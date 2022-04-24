using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Filmes.Models
{
    public class FilmeModel
    {
        private int id;
        private string name;
        private string description;
        private string genre;
        private double note;
        private string author;



        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Genre { get => genre; set => genre = value; }
        public double Note { get => note; set => note = value; }
        public string Author { get => author; set => author = value; }

        public FilmeModel() { }

        public FilmeModel(int Id, string Name, string Description, string Genre, double Note, string Author)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Genre = Genre;
            this.Note = Note;
            this.Author = Author;
        }
    }
}