using ClassLibrary.Enum;
using ClassLibrary.Models;

namespace ChickenLife.Models.Account
{
    public class UserOutput
    {
        public int A_ID { get; set; } 
        public string A_Name { get; set; } 
        public string UserName { get; set; } 
        public Gender A_Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int P_id { get; set; } = 1;
        public Product Product { get; set; } 
        public string A_Email { get; set; } 
        public string? A_Phone { get; set; } 
        public string? A_add { get; set; } 
        public string? A_NickName { get; set; }
        public int A_Coin { get; set; }

        public string? VerifycationToken { get; set; }
        //public DateTime? ResetTokenExpries { get; set; }
    }
}
