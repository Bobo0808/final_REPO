using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Item
    {
        [Key]
        public int I_ID { get; set; }
        public string? I_Name { get; set; }
        public string? I_Type { get; set; }
        public string? I_Image { get; set; }
        public int? I_Price { get; set; }
        public DateTime? I_Date { get; set; }
        public string? I_Description { get; set; }
    }
}
