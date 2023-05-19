using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
//using MessagePack;

namespace ClassLibrary.ViewModels.WardrobeViewModel
{
        public class WardrobeViewModel
        {
        //[Key]
        public int UserID { get; set; } = default!;
        public List<int> OrderID { get; set; } = new List<int>();
        public List<IEnumerable<int>> ProductID { get; set; } = new List<IEnumerable<int>>();
        public List<IEnumerable<string>> ProductName { get; set; } = new List<IEnumerable<string>>();
        public List<IEnumerable<string>> ProductImage { get; set; } = new List<IEnumerable<string>>();
        }
}
