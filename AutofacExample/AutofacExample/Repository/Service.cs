using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacExample.Repository
{
    public class Service : IService
    {
        public string Execute(string Name, string Surname)
        {
            return Name.Substring(0, 1).ToString().ToUpper() + Name.Substring(1) + Surname.ToUpper();
        }
    }
}