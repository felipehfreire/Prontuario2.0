using H1.Model.Context;
using H1.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Repository
{
    public class RepositoryBase
    {
        protected readonly ApplicationDbContext Context;

        public RepositoryBase()
        {
            Context = new ApplicationDbContext();
        }
        

    }
}

