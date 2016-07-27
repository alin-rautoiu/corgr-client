namespace Corgr_Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20160727350pm : DbMigration
    {
        public override void Up()
        {
            CreateIndex("Dg.Dog", "Index", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("Dg.Dog", new[] { "Index" });
        }
    }
}
