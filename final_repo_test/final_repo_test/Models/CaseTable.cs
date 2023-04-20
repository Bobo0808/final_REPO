﻿using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class CaseTable
    {
        [Key]
        public int Case_ID { get; set; } = default!;
        public string Case_Name { get; set; } = default!;
        public int Case_PricePerDay { get; set; } = default!;
        public ICollection<Ads>? Ads { get; set; }
        public ICollection<Map_ADArea>? Map_ADAreas { get; set; } 

    }
}
