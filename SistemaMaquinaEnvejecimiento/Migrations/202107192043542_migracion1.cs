namespace SistemaMaquinaEnvejecimiento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Temperatura = c.Single(nullable: false),
                        Humedad = c.Single(nullable: false),
                        EstatusLuz = c.Boolean(nullable: false),
                        CicloTrabajo = c.String(),
                        Fecha = c.Int(nullable: false),
                        PruebaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pruebas", t => t.PruebaID, cascadeDelete: true)
                .Index(t => t.PruebaID);
            
            CreateTable(
                "dbo.Pruebas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Material = c.String(),
                        FechaInicio = c.Int(nullable: false),
                        FechaTermino = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioID, cascadeDelete: true)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Nombre = c.String(),
                        Email = c.String(),
                        Contrasenia = c.String(),
                        Token_ = c.String(),
                        Token_recovery = c.String(),
                        Date_created = c.DateTime(nullable: false),
                        Date_update = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pruebas", "UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Medicions", "PruebaID", "dbo.Pruebas");
            DropIndex("dbo.Pruebas", new[] { "UsuarioID" });
            DropIndex("dbo.Medicions", new[] { "PruebaID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Pruebas");
            DropTable("dbo.Medicions");
        }
    }
}
