using ClassLibrary.Enum;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.ViewModels.Account
{
    public class AddVM
    {
        public int A_ID { get; set; } = default!;
        public string A_Name { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string UserPWD { get; set; } = default!;
        public Gender A_Gender { get; set; }
        public int P_id { get; set; } = default!;
        public Product Product { get; set; } = default!;
        public DateTime Birthday { get; set; } = default!;
        public int A_level { get; set; } = default!;
        public string A_Email { get; set; } = default!;
        public string A_Phone { get; set; } = default!;
        public string A_add { get; set; } = default!;
        public DateTime A_RegisteredAt { get; set; } = default!;
        public string A_NickName { get; set; } = default!;
        public int A_Coin { get; set; } = default!;
    }
}
