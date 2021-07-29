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
                        IdMedicion = c.Int(nullable: false, identity: true),
                        Temperatura = c.Single(nullable: false),
                        Humedad = c.Single(nullable: false),
                        EstatusLuz = c.String(),
                        CicloTrabajo = c.String(),
                        Fecha = c.Int(nullable: false),
                        IdPrueba = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdMedicion)
                .ForeignKey("dbo.Pruebas", t => t.IdPrueba, cascadeDelete: true)
                .Index(t => t.IdPrueba);
            
            CreateTable(
                "dbo.Pruebas",
                c => new
                    {
                        IdPrueba = c.Int(nullable: false, identity: true),
                        Material = c.String(),
                        FechaInicio = c.Int(nullable: false),
                        FechaTermino = c.Int(nullable: false),
                        Privacidad = c.String(),
                        IdUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPrueba)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Nombre = c.String(),
                        Email = c.String(),
                        Contrasenia = c.String(),
                        Token_ = c.String(),
                        Token_recovery = c.String(),
                        Date_created = c.Int(nullable: false),
                        Date_update = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicions", "IdPrueba", "dbo.Pruebas");
            DropForeignKey("dbo.Pruebas", "IdUsuario", "dbo.Usuarios");
            DropIndex("dbo.Pruebas", new[] { "IdUsuario" });
            DropIndex("dbo.Medicions", new[] { "IdPrueba" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Pruebas");
            DropTable("dbo.Medicions");
        }
    }
}
