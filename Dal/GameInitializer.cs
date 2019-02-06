using Mediatheque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mediatheque.Dal
{
    //classe pour alimenter la base de données qui se vide automatiquement en cas de changement sur le modele.
    public class GameInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            var games = new List<Games>
            {
                new Games{VisualImage="/Content/img/octopath_traveler.jpg", Categorie="rpg",
                    Title ="Octopath Travler", Developer="Square Enix", ReleaseDate=DateTime.Parse("13/07/2018"),
                    Synopsis ="L'intrigue comporte huit protagonistes différents parmi lesquels le joueur peut choisir " +
                    "celui qu'il désire au début du jeu, puis progresse vers les personnages suivants dans l'ordre de son choix.",
                    Link ="https://www.nintendo.fr/Jeux/Nintendo-Switch/OCTOPATH-TRAVELER-1275922.html"},
                new Games{VisualImage="/Content/img/zelda.jpg", Categorie="aventure",
                    Title ="Zelda Breath of the Wild", Developer="Nintendo", ReleaseDate=DateTime.Parse("03/03/2017"),
                    Synopsis ="Link se réveille après un long sommeil d'une centaine d'années7 dans le « Sanctuaire de la Renaissance ». " +
                    "Une voix l'appelle. Ainsi va commencer cette aventure dans un Hyrule largement dévasté.",
                    Link ="https://www.zelda.com/breath-of-the-wild/fr/"},
                new Games{VisualImage="/Content/img/MarioKart8.jpg", Categorie="course", Title="Mario Kart 8", Developer="Nintendo",
                    ReleaseDate=DateTime.Parse("28/04/2017"), Synopsis="Huitième jeux de la serie des Mario Kart.",
                    Link ="https://mariokart8.nintendo.com/fr/"}
            };

            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();
        }
    }
}