namespace UsersDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastNameField_Change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "LastName");
        }
    }
}
