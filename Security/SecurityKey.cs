using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
   public class SecurityKey
    {
       public static byte[] Keybytes()
       {
         return Encoding.UTF8.GetBytes("8080808080808080"); 
       }
       public static byte[]   IVBytes()
       {          
           return Encoding.UTF8.GetBytes("8080808080808080");
       }
    }
}
