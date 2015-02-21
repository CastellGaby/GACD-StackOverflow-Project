using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GACD_StackOverflow_Project.Models
{
    public class AccountProfileModel
    {
        public string Username{ get; set; }

        public string Full_Name{ get; set; }

        public string Age{ get; set; }

        [DataType(DataType.EmailAddress)]
        public string  E_mail{ get; set; }

        [DataType(DataType.DateTime)]
        public string DateJoin { get; set; }

    }
}