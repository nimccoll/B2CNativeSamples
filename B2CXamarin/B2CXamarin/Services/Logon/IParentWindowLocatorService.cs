﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B2CXamarin.Services.Logon
{
    /// <summary>
    /// Simple platform specific service that is responsible for locating a 
    /// </summary>
    public interface IParentWindowLocatorService
    {
       object GetCurrentParentWindow();
    }
}
