namespace TreinaWeb.Musicas.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ALB_ALBUNS", "ALB_EMAIL", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.ALB_ALBUNS", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ALB_ALBUNS", "Type", c => c.String());
            DropColumn("dbo.ALB_ALBUNS", "ALB_EMAIL");
        }
    }
}
