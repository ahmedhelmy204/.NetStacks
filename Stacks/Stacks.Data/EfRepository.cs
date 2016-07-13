using Stacks.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Data
{
    /// <summary>
    /// Entity Framework repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region Fields

        private readonly IDbContext _context;
        private IDbSet<T> _entities;

        #endregion Fields

        #region Ctor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Object context</param>
        public EfRepository(IDbContext context)
        {
            this._context = context;

        }

        #endregion Ctor


        #region Properties

        /// <summary>
        /// Gets a table
        /// </summary>
        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        /// <summary>
        /// Entities
        /// </summary>
        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }

        #endregion Properties
    }

    public partial class EfStacksRepository<T> : EfRepository<T> where T : BaseEntity
    {
        public EfStacksRepository(IDbStacksContext context)
            : base(context)
        {

        }
    }
}
