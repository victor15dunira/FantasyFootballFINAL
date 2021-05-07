using FantasyFootballWebLibrary.Models.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballWebLibrary.Models.Views
{
   public class TeamViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PictureURL { get; set; }

        public Numberofplayers Numberofplayers { get; set; }

        public string TeamColour { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
