using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public System.Data.Entity.DbSet<MIS4200_Team6.Models.UserData> UserDatas { get; set; }
        public DbSet<Recognition> recognitions { get; set; }

        public DbSet<CoreValues> corevalues { get; set; }

    }
}