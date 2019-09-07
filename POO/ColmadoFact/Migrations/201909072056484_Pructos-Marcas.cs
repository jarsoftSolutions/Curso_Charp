namespace ColmadoFact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PructosMarcas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 250),
                        Detalle = c.String(maxLength: 250),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioLimite = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Referencia = c.String(maxLength: 50),
                        Activo = c.Boolean(nullable: false),
                        FRegistro = c.DateTime(nullable: false),
                        Impuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Caduca = c.Boolean(nullable: false),
                        FechaVencimiento = c.DateTime(),
                        Costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EsCombo = c.Boolean(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.MarcaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productoes", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Productoes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Productoes", new[] { "MarcaId" });
            DropIndex("dbo.Productoes", new[] { "CategoriaId" });
            DropTable("dbo.Productoes");
            DropTable("dbo.Marcas");
        }
    }
}
