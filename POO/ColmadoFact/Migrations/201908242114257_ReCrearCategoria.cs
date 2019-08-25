namespace ColmadoFact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReCrearCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 100),
                        Activa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categorias");
        }
    }
}
