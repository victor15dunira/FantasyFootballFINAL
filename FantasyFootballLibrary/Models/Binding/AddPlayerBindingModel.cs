using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyFootballWebLibrary.Models.Binding
{
    public class AddPlayerBindingModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public string Position { get; set; }

        public int TeamID { get; set; }

    }
}
