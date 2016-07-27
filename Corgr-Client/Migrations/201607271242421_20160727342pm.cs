namespace Corgr_Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20160727342pm : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("Dg.Dog");
            AlterColumn("Dg.Dog", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("Dg.Dog", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("Dg.Dog");
            AlterColumn("Dg.Dog", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("Dg.Dog", "Id");
        }
    }
}
