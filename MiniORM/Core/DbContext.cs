using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.Core
{
    public class DbContext
    {
        protected DbContext()
        {

        }
        protected DbContext(object any)
        {

        }
        protected DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            //string entity = typeof(TEntity).Name;
            return new DbSet<TEntity>();
        }
    }
}
