namespace P.I.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CPF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Perfils", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Perfils", "CPF");
        }
    }
}
