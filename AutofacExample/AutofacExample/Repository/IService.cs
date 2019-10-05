using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacExample.Repository
{
    public interface IService
    {
        string Execute(string Name, string Surname);
    }
}
