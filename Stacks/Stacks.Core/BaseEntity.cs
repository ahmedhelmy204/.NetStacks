using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.Core
{
    /// <summary>
    /// Base class for all entities
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity insertion
        /// </summary>
        public DateTime InsertedOn { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity inserting user
        /// </summary>
        public Nullable<int> InsertedBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity update
        /// </summary>
        public Nullable<System.DateTime> UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity updating user
        /// </summary>
        public Nullable<int> UpdatedBy { get; set; }
    }
}
