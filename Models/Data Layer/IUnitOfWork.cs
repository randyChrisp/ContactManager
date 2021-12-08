﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public interface IUnitOfWork
    {
        IRepository<Contact> Contacts { get; }
        IRepository<Category> Categories { get; }

        void Save();
    }
}
