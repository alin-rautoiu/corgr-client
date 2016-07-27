namespace Corgr_Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20160727344pm : DbMigration
    {
        public override void Up()
        {
            AddColumn("Dg.Dog", "Index", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Dg.Dog", "Index");
        }
    }
}
