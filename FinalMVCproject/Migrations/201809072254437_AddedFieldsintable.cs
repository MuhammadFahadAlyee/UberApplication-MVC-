namespace FinalMVCproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFieldsintable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Fname", c => c.String());
            AddColumn("dbo.AspNetUsers", "Usertypes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Usertypes");
            DropColumn("dbo.AspNetUsers", "Fname");
        }
    }
}
