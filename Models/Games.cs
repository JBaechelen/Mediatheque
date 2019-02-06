using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mediatheque.Models
{
    [Table("Games")]
    public class Games : Model
    {
        public string VisualImage { get; set; }

        public string Categorie { get; set; }

        public string Title { get; set; }

        public string Developer { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Synopsis { get; set; }

        public string Link { get; set; }

        public Games()
        {

        }

        public override void UpdateFrom(Model source)
        {
            if (source is Games games && games.Id == Id)
            {
                VisualImage = games.VisualImage;
                Categorie = games.Categorie;
                Title = games.Title;
                Developer = games.Developer;
                ReleaseDate = games.ReleaseDate;
                Synopsis = games.Synopsis;
                Link = games.Link;
            }
        }
    }
}