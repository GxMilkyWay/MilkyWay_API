using MilkyWay_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyWay_API.Contract
{
    internal interface IUserRepository: IGenericRepository<User>
    {
        //Define User specific implementation inside this interface.
    }
}
