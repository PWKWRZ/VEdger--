namespace VEdger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchStatus",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        primary_user_id = c.Int(nullable: false),
                        secondary_user_id = c.Int(nullable: false),
                        relationship = c.Int(nullable: false),
                        conversation_fs_path = c.String(),
                        UserData_id = c.Int(),
                        PrimaryUser_id = c.Int(),
                        SecondaryUser_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserDatas", t => t.UserData_id)
                .ForeignKey("dbo.UserDatas", t => t.PrimaryUser_id)
                .ForeignKey("dbo.UserDatas", t => t.SecondaryUser_id)
                .Index(t => t.UserData_id)
                .Index(t => t.PrimaryUser_id)
                .Index(t => t.SecondaryUser_id);
            
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        first_name = c.String(),
                        last_name = c.String(),
                        date_of_birth = c.DateTime(nullable: false),
                        created_at = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        location = c.String(),
                        food_preference = c.Int(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fs_path = c.String(),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserDatas", t => t.User_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.MatchStatus", "SecondaryUser_id", "dbo.UserDatas");
            DropForeignKey("dbo.MatchStatus", "PrimaryUser_id", "dbo.UserDatas");
            DropForeignKey("dbo.Photos", "User_id", "dbo.UserDatas");
            DropForeignKey("dbo.MatchStatus", "UserData_id", "dbo.UserDatas");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Photos", new[] { "User_id" });
            DropIndex("dbo.MatchStatus", new[] { "SecondaryUser_id" });
            DropIndex("dbo.MatchStatus", new[] { "PrimaryUser_id" });
            DropIndex("dbo.MatchStatus", new[] { "UserData_id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Photos");
            DropTable("dbo.UserDatas");
            DropTable("dbo.MatchStatus");
        }
    }
}
