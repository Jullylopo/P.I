namespace P.I.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Perfils",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Nome_usuario = c.String(),
                        Dt_nascimento = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Perfils");
        }
    }
}
