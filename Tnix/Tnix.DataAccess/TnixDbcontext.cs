using System;
using System.Collections.Generic;
using System.Text;
using Tnix.Core;
using Tnix.Core.DataAccess;

using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tnix.DataAccess
{
    public class TnixDbcontext : DbContext
    {
        public TnixDbcontext(DbContextOptions<TnixDbcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddEntityConfigurationsFromAssembly(GetType().GetTypeInfo().Assembly);
        }

    }
}
