using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GACD_StackOverflow_Project.Models
{
    public class AccountResetPasswordModel
    {
        [Required(ErrorMessage = "*This Field is required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "*This Field is required")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassword{ get; set; }
    }
}