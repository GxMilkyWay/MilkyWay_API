using MilkyWay_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilkyWay_API.Repository.Contract
{

    internal interface ILogin  
    {
        //Define User specific implementation inside this interface.
        bool AddUser(LoginData obj);
        bool VerifyLogin(LoginData obj);

    }
}