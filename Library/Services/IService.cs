// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;

namespace Library.Services
{
    /// <summary>
    /// Allows services to notify when their
    /// underlying data model changes
    /// </summary>
    interface IService
    {
        event EventHandler Updated;
    }
}
