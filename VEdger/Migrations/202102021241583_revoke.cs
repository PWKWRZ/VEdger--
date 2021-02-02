namespace VEdger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revoke : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserDatas", "idLogowania");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDatas", "idLogowania", c => c.String());
        }
    }
}
