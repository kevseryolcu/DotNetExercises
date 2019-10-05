using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutofacExample.Repository
{
    public class MailService : IMailService
    {
        public string CheckdMail(string mail)
        {
            var email = new EmailAddressAttribute();
            return new EmailAddressAttribute().IsValid(mail) ? "Valid" : "Invalid";
        }
    }
}