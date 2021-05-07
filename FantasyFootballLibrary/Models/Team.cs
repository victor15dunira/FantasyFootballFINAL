
using FantasyFootballWebLibrary.Models.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyFootballWebLibrary.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PictureURL { get; set; }

        public Numberofplayers Numberofplayers { get; set; }

        public string TeamColour { get; set; }

        public DateTime CreatedAt { get; set;  }

        //Relationships

        //public List<Visit> Visits{ get; set; } //linking Cats to Visits, a cat can have many visits 


        public virtual List<Player> Players { get; set; } //linking Cats to Kittens using "virtual"

    }



   

}



