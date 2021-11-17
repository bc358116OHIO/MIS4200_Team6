using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MIS4200_Team6.Models;

namespace MIS4200_Team6.DAL
{
    public class MIS4200Team6Context : DbContext 
    {
        public MIS4200Team6Context() : base ("name=Defaultconnection")
        {
          
        }

        public System.Data.Entity.DbSet<MIS4200_Team6.Models.UserData> userdatas { get; set; }
        public DbSet<Recognition> recognitions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  // note: this is all one line!
        }

        public System.Data.Entity.DbSet<MIS4200_Team6.Models.CoreValues> CoreValues { get; set; }
    }
}