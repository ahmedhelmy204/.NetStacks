using Stacks.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Data
{
    public class DbStacksContext : DbContext, IDbContext
    {
        public DbStacksContext()
            : base("name=StacksConnectionString")
        {
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

    }
}
