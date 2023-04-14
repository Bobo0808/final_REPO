﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class LoginStaus
    {
        [Key]
        public int L_ID { get; set; }
        [ForeignKey("Account")]
        public int? A_ID { get; set; }
        public Account? Account { get; set; }
        public DateTime L_cTime { get; set; }
        public DateTime L_dcTime { get; set; }
    }
}
