﻿using System.ComponentModel.DataAnnotations;
using ClassLibrary.Enum;
using ClassLibrary.Models;

namespace ClassLibrary.ViewModels.Login
{
    public class LoginViewModel
    {

        //[Display(Name ="Kullanıcı Adı", Prompt ="johndoe")]
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
        public string E_UserName { get; set; } 

        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Password can be max 16 characters.")]
        public string E_Pwd { get; set; } 
    }
}
