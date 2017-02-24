namespace TelefonRehberi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmanName = c.String(),
                        DepartmanManager = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        TelephoneNo = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        DepartmanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departmen", t => t.DepartmanId, cascadeDelete: true)
                .Index(t => t.DepartmanId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleEmployees",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.Employee_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoleEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.RoleEmployees", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Employees", "DepartmanId", "dbo.Departmen");
            DropIndex("dbo.RoleEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.RoleEmployees", new[] { "Role_Id" });
            DropIndex("dbo.Employees", new[] { "DepartmanId" });
            DropTable("dbo.RoleEmployees");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.Departmen");
        }
    }
}
