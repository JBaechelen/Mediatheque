using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mediatheque.Models
{
    //creation d'une classe abstraite pour ne pas repeter la ligne Id en cas de modeles multiple.
    abstract public class Model
    {
        public int Id { get; set; }

        abstract public void UpdateFrom(Model source);
    }
}