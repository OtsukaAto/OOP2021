using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Text;

namespace SampleEntityFramework.Models {
    public class Configuration 
        :DbMigrationsConfiguration<BooksDbContext>
    {
        public Configuration() 
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SampleEntityFramework.Models.BooksDbContext";
        
        }
    }
}
