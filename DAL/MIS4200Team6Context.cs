using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.DAL
{
    public class MIS4200Team6Context : DbContext 
    {
        public MIS4200Team6Context() : base ("name=Defaultconnection")
        {
          
        }

        public System.Data.Entity.DbSet<MIS4200_Team6.Models.UserData> UserDatas { get; set; }
    }
}