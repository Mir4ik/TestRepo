﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MegaProject.Data.Contracts;

namespace MegaProject.Data.NHibernate.Helpers
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepositoryBase Create()
        {
            return new Repository();
        }

        public IRepositoryBase Create(INHUnitOfWork uow)
        {
            return new Repository(uow);
        }
    }
}
