namespace DoBancoAoEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carros", "cor", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carros", "cor");
        }
    }
}
