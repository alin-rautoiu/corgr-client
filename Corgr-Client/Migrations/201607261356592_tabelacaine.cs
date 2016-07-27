namespace Corgr_Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelacaine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Dg.Dog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Face = c.String(maxLength: 150),
                        Name = c.String(maxLength: 50),
                        Liked = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Dg.Dog");
        }
    }
}
