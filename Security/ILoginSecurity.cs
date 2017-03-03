using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
   interface   ILoginSecurity
    {
         bool CheckLogin(string Username, string Password);
    }
}
