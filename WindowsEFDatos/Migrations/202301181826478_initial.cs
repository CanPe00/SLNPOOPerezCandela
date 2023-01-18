namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avion",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominación = c.String(nullable: false, maxLength: 50, unicode: false),
                        LineaAereaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineaAerea", t => t.LineaAereaId, cascadeDelete: true)
                .Index(t => t.LineaAereaId);
            
            CreateTable(
                "dbo.LineaAerea",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaAereaId", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "LineaAereaId" });
            DropTable("dbo.LineaAerea");
            DropTable("dbo.Avion");
        }
    }
}
