namespace WebImobiliaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gabriel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovels", "ProprietarioId", c => c.Int(nullable: false));
            DropColumn("dbo.Imovels", "Proprietario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imovels", "Proprietario", c => c.Int(nullable: false));
            DropColumn("dbo.Imovels", "ProprietarioId");
        }
    }
}
