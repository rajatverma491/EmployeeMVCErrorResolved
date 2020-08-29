namespace WebChecking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDepartmentdata : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Departments(DName) values('Hr')");
            Sql("insert into Departments(DName) values('Admin')");
            Sql("insert into Departments(DName) values('Production')");
        }
        
        public override void Down()
        {
        }
    }
}
