using FantasyFootballWebLibrary.Models.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballWebLibrary.Models.Views
{
    public class PlayerViewModel
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public string Position { get; set; }
        public string PictureURL { get; set; }
        public DateTime CreatedAt { get; set; }



    }
}
