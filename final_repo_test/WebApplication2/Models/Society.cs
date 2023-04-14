﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Society
    {
        [Key]
        public int S_ID { get; set; } = default!;
        [ForeignKey("Account")]
        public int A_ID { get; set; } = default!;
        public Account Account { get; set; } = default!;
        [ForeignKey("TargetAccount")]
        public int TargetA_ID { get; set; } = default!;
        public Account TargetAccount { get; set; } = default!;
        public DateTime CreateAt { get; set; } = default!;
        public DateTime UpdateAt { get; set; } = default!;
        public string S_Notes { get; set; } = default!;
    }
}
