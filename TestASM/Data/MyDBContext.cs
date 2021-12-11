using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestASM.Models;

namespace TestASM.Data
{
    public class MyDBContext: MyDBContext 
    {
            public MyDBContext() : base("name = MyDBContext")
            {

            }
            public DbSet<Student> Students { get; set; }
        }
}