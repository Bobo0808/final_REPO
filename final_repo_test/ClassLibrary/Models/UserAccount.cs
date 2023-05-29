using ClassLibrary.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public class UserAccount
    {
        [Key]
        public int A_ID { get; set; } = default!;
        public string A_Name { get; set; } = "admin";
        public string UserName { get; set; } = "admin";
        public string UserPWD { get; set; } = "admin";
        public Gender A_Gender { get; set; } = default!;
        [Column(TypeName = "Date")]
        public DateTime Birthday { get; set; }
        [ForeignKey("Product")]
        public int P_id { get; set; } = 1;
        public Product Product { get; set; } = default!;
        public int A_level { get; set; } =0;
        public string A_Email { get; set; } = default!;
        public string? A_Phone { get; set; } = "";
        public string? A_add { get; set; }= "";
        [Column(TypeName = "Date")]
        public DateTime A_RegisteredAt { get; set; } =DateTime.Now;
        public string? A_NickName { get; set; } = "";
        public int A_Coin { get; set; } = 3000;


        public string? VerifycationToken { get; set; }

        public DateTime? VerifiedAt { get; set; }

        public string? PasswordRestToken { get; set; }

        public DateTime? ResetTokenExpries { get; set; }

        public byte[] PasswordHash { get; set; } = new byte[32];

        public byte[] PasswordSalt { get; set; } = new byte[32];




        public ICollection<CardOrder>? CardOrders { get; set; }
        public ICollection<Order> Orders { get; set; } = default!;
        //[InverseProperty(nameof(Report.Account))]
        public ICollection<Report>? Reports { get; set; }
        //[InverseProperty(nameof(Report.ReportedAccount))]
        public ICollection<Report>? ReportedReports { get; set; }
        //[InverseProperty(nameof(Society.Account))]
        public ICollection<Society>? Societies { get; set; }
        //[InverseProperty(nameof(Society.TargetAccount))]
        public ICollection<Society>? TargetSocieties { get; set; }
        public ICollection<DebugLog>? DebugLogs { get; set; }
        public ICollection<LoginStaus>? LoginStaus { get; set; }

    }
}
