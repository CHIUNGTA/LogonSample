using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginStyle2.Models.ViewModels
{
    public class LogonViewModel
    {
        [EmailAddress]
        public string Account { get; set; }
        [StringLength(20,MinimumLength =4,ErrorMessage ="需輸入4~20字串之密碼!!")]
        public string Password { get; set; }
        //[EmailAddress]
        //public string Email { get; set; }
    }
}