﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MilkyWay_API.Contract
{
    interface IDBConnectionClass
    {
        IDbConnection OpenConnection();
    }
}

