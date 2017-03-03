using Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class LoginSecurity : ILoginSecurity
    {
        public bool CheckLogin(string Username, string Password)
        {
            //var Dcryptusername = AESEncrytDecry.DecryptStringAES("TS3W1Fp9K455KiYZg6bWVg==");
            //var Enteredpassword = AESEncrytDecry.DecryptStringAES("TS3W1Fp9K455KiYZg6bWVg==");

            //DBConnectionClass objConn = new DBConnectionClass();
            //this._conn = objConn.OpenConnection();
            //string strPassword = _conn.Query<string>("select Password from TBLLogin where Username='" + Dcryptusername + "'").FirstOrDefault();
            //var password = AESEncrytDecry.DecryptStringAES(strPassword);
            return true;
        }
    }
}
