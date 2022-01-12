using Infraestructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Context
{
    /// <summary>
    /// Class DataBaseContext.
    /// Implements the <see cref="Microsoft.EntityFrameworkCore.DbContext" />
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBaseContext" /> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        { }

        /// <summary>
        /// Gets or sets the owners.
        /// </summary>
        /// <value>The owners.</value>
        public DbSet<Owner> Owners { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public DbSet<Property> Properties { get; set; }

        /// <summary>
        /// Gets or sets the property image.
        /// </summary>
        /// <value>The property image..</value>
        public DbSet<PropertyImage> PropertyImages { get; set; }

        /// <summary>
        /// Gets or sets the PropertyTrace.
        /// </summary>
        /// <value>The PropertyTrace..</value>
        public DbSet<PropertyTrace> PropertyTraces { get; set; }



    }
}
