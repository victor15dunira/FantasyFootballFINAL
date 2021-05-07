using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyFootballWebLibrary.Models.Binding
{
    public class UpdateTeamBindingModel
    {
        public string Name { get; set; }
        public string PictureURL { get; set; }

        public Numberofplayers Numberofplayers { get; set; }

        public string TeamColour { get; set; }

    }
}
