namespace TodoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TempDatainTask : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Tasks(TaskName,Description) values('Wash Car','I have to wash car today')");
        }
        
        public override void Down()
        {
        }
    }
}
