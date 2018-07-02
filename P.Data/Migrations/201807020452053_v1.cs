namespace P.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AmendmentCs",
                c => new
                    {
                        IdAm = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.IdAm);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        idCla = c.Int(nullable: false, identity: true),
                        classe = c.Int(nullable: false),
                        Classe_idCla = c.Int(),
                        user_idUser = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idCla)
                .ForeignKey("dbo.Classes", t => t.Classe_idCla)
                .ForeignKey("dbo.Users", t => t.user_idUser)
                .Index(t => t.Classe_idCla)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "dbo.RCPrices",
                c => new
                    {
                        idRCP = c.Int(nullable: false, identity: true),
                        price = c.Single(nullable: false),
                        classe_idCla = c.Int(),
                        fiscalPower_IdFiscalPower = c.Int(),
                        RCPrice_idRCP = c.Int(),
                    })
                .PrimaryKey(t => t.idRCP)
                .ForeignKey("dbo.Classes", t => t.classe_idCla)
                .ForeignKey("dbo.FiscalPowers", t => t.fiscalPower_IdFiscalPower)
                .ForeignKey("dbo.RCPrices", t => t.RCPrice_idRCP)
                .Index(t => t.classe_idCla)
                .Index(t => t.fiscalPower_IdFiscalPower)
                .Index(t => t.RCPrice_idRCP);
            
            CreateTable(
                "dbo.FiscalPowers",
                c => new
                    {
                        IdFiscalPower = c.Int(nullable: false, identity: true),
                        FPower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdFiscalPower);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        IdVehicle = c.Int(nullable: false, identity: true),
                        Registration = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Brand = c.String(unicode: false),
                        Model = c.String(unicode: false),
                        SeatsNumber = c.Int(nullable: false),
                        ValueWhenNew = c.Double(nullable: false),
                        ValueWhenVenal = c.Double(nullable: false),
                        InitTraficDate = c.DateTime(nullable: false, precision: 0),
                        Users_idUser = c.String(maxLength: 128, storeType: "nvarchar"),
                        FiscalPowers_IdFiscalPower = c.Int(),
                    })
                .PrimaryKey(t => t.IdVehicle)
                .ForeignKey("dbo.Users", t => t.Users_idUser)
                .ForeignKey("dbo.FiscalPowers", t => t.FiscalPowers_IdFiscalPower)
                .Index(t => t.Users_idUser)
                .Index(t => t.FiscalPowers_IdFiscalPower);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        idCont = c.Int(nullable: false, identity: true),
                        codeCont = c.Int(nullable: false),
                        dateCre = c.DateTime(nullable: false, precision: 0),
                        dateDeb = c.DateTime(nullable: false, precision: 0),
                        dateFin = c.DateTime(nullable: false, precision: 0),
                        paiement = c.Double(nullable: false),
                        reconductible = c.Boolean(nullable: false),
                        state = c.String(unicode: false),
                        Contract_idCont = c.Int(),
                        user_idUser = c.String(maxLength: 128, storeType: "nvarchar"),
                        vehicle_IdVehicle = c.Int(),
                    })
                .PrimaryKey(t => t.idCont)
                .ForeignKey("dbo.Contracts", t => t.Contract_idCont)
                .ForeignKey("dbo.Users", t => t.user_idUser)
                .ForeignKey("dbo.Vehicles", t => t.vehicle_IdVehicle)
                .Index(t => t.Contract_idCont)
                .Index(t => t.user_idUser)
                .Index(t => t.vehicle_IdVehicle);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        idUser = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        LastName = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        Gender = c.String(unicode: false),
                        Address_Country = c.String(unicode: false),
                        Address_City = c.String(unicode: false),
                        Address_Street = c.String(unicode: false),
                        Address_ZipCode = c.String(unicode: false),
                        Address_HouseNumber = c.Int(nullable: false),
                        role = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        EmailConfirmed = c.Boolean(nullable: false),
                        password = c.String(unicode: false),
                        SecurityStamp = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 0),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "dbo.CustomUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ClaimType = c.String(unicode: false),
                        ClaimValue = c.String(unicode: false),
                        User_idUser = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_idUser)
                .Index(t => t.User_idUser);
            
            CreateTable(
                "dbo.CustomUserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginProvider = c.String(unicode: false),
                        ProviderKey = c.String(unicode: false),
                        UserId = c.Int(nullable: false),
                        User_idUser = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_idUser)
                .Index(t => t.User_idUser);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        idNotif = c.Int(nullable: false, identity: true),
                        notification = c.Int(nullable: false),
                        credate = c.DateTime(nullable: false, precision: 0),
                        Notification_idNotif = c.Int(),
                        user_idUser = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idNotif)
                .ForeignKey("dbo.Notifications", t => t.Notification_idNotif)
                .ForeignKey("dbo.Users", t => t.user_idUser)
                .Index(t => t.Notification_idNotif)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "dbo.CustomUserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        User_idUser = c.String(maxLength: 128, storeType: "nvarchar"),
                        CustomRole_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_idUser)
                .ForeignKey("dbo.CustomRoles", t => t.CustomRole_Id)
                .Index(t => t.User_idUser)
                .Index(t => t.CustomRole_Id);
            
            CreateTable(
                "dbo.WarrantyAssignments",
                c => new
                    {
                        idCont = c.Int(nullable: false),
                        idWrr = c.Int(nullable: false),
                        date = c.DateTime(nullable: false, precision: 0),
                        WarrantyAssignment_idCont = c.Int(),
                        WarrantyAssignment_idWrr = c.Int(),
                    })
                .PrimaryKey(t => new { t.idCont, t.idWrr })
                .ForeignKey("dbo.Contracts", t => t.idCont, cascadeDelete: true)
                .ForeignKey("dbo.Warranties", t => t.idWrr, cascadeDelete: true)
                .ForeignKey("dbo.WarrantyAssignments", t => new { t.WarrantyAssignment_idCont, t.WarrantyAssignment_idWrr })
                .Index(t => t.idCont)
                .Index(t => t.idWrr)
                .Index(t => new { t.WarrantyAssignment_idCont, t.WarrantyAssignment_idWrr });
            
            CreateTable(
                "dbo.Warranties",
                c => new
                    {
                        idWrr = c.Int(nullable: false, identity: true),
                        title = c.String(unicode: false),
                        cPrice = c.Double(nullable: false),
                        pPrice = c.Double(nullable: false),
                        mandatory = c.Int(nullable: false),
                        VDCFranchiseLevel_idVDCFL = c.Int(),
                        Warranty_idWrr = c.Int(),
                    })
                .PrimaryKey(t => t.idWrr)
                .ForeignKey("dbo.VDCFranchiseLevels", t => t.VDCFranchiseLevel_idVDCFL)
                .ForeignKey("dbo.Warranties", t => t.Warranty_idWrr)
                .Index(t => t.VDCFranchiseLevel_idVDCFL)
                .Index(t => t.Warranty_idWrr);
            
            CreateTable(
                "dbo.VDCFranchiseLevels",
                c => new
                    {
                        idVDCFL = c.Int(nullable: false, identity: true),
                        FLevel = c.Int(nullable: false),
                        BPrice = c.Double(nullable: false),
                        PPrice = c.Double(nullable: false),
                        VDCFranchiseLevel_idVDCFL = c.Int(),
                    })
                .PrimaryKey(t => t.idVDCFL)
                .ForeignKey("dbo.VDCFranchiseLevels", t => t.VDCFranchiseLevel_idVDCFL)
                .Index(t => t.VDCFranchiseLevel_idVDCFL);
            
            CreateTable(
                "dbo.Folders",
                c => new
                    {
                        IdFolder = c.Int(nullable: false, identity: true),
                        FolderTitle = c.String(unicode: false),
                        ModificationDate = c.DateTime(nullable: false, precision: 0),
                        BonusMalus = c.Int(nullable: false),
                        Renewable = c.Boolean(nullable: false),
                        RefundedAmount = c.Int(nullable: false),
                        Comment = c.String(nullable: false, unicode: false),
                        Vehicles_IdVehicle = c.Int(),
                    })
                .PrimaryKey(t => t.IdFolder)
                .ForeignKey("dbo.Vehicles", t => t.Vehicles_IdVehicle)
                .Index(t => t.Vehicles_IdVehicle);
            
            CreateTable(
                "dbo.Sinisters",
                c => new
                    {
                        IdSinister = c.Int(nullable: false, identity: true),
                        Garage_IdGarage = c.String(maxLength: 128, storeType: "nvarchar"),
                        Vehicle_IdVehicle = c.Int(),
                    })
                .PrimaryKey(t => t.IdSinister)
                .ForeignKey("dbo.Garages", t => t.Garage_IdGarage)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_IdVehicle)
                .Index(t => t.Garage_IdGarage)
                .Index(t => t.Vehicle_IdVehicle);
            
            CreateTable(
                "dbo.Garages",
                c => new
                    {
                        IdGarage = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        NameGarage = c.String(unicode: false),
                        PlaceGarage = c.String(unicode: false),
                        ManagerGarage = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdGarage);
            
            CreateTable(
                "dbo.WreckReports",
                c => new
                    {
                        IdWReport = c.Int(nullable: false, identity: true),
                        WreckValue = c.Double(nullable: false),
                        Indemnity = c.Double(nullable: false),
                        Vehicle_IdVehicle = c.Int(),
                    })
                .PrimaryKey(t => t.IdWReport)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_IdVehicle)
                .Index(t => t.Vehicle_IdVehicle);
            
            CreateTable(
                "dbo.CustomRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Thirds",
                c => new
                    {
                        IdThird = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.IdThird);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        RoleId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.HistoryRows",
                c => new
                    {
                        MigrationId = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        ContextKey = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Model = c.Binary(),
                        ProductVersion = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MigrationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomUserRoles", "CustomRole_Id", "dbo.CustomRoles");
            DropForeignKey("dbo.RCPrices", "RCPrice_idRCP", "dbo.RCPrices");
            DropForeignKey("dbo.WreckReports", "Vehicle_IdVehicle", "dbo.Vehicles");
            DropForeignKey("dbo.Sinisters", "Vehicle_IdVehicle", "dbo.Vehicles");
            DropForeignKey("dbo.Sinisters", "Garage_IdGarage", "dbo.Garages");
            DropForeignKey("dbo.Folders", "Vehicles_IdVehicle", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "FiscalPowers_IdFiscalPower", "dbo.FiscalPowers");
            DropForeignKey("dbo.WarrantyAssignments", new[] { "WarrantyAssignment_idCont", "WarrantyAssignment_idWrr" }, "dbo.WarrantyAssignments");
            DropForeignKey("dbo.WarrantyAssignments", "idWrr", "dbo.Warranties");
            DropForeignKey("dbo.Warranties", "Warranty_idWrr", "dbo.Warranties");
            DropForeignKey("dbo.Warranties", "VDCFranchiseLevel_idVDCFL", "dbo.VDCFranchiseLevels");
            DropForeignKey("dbo.VDCFranchiseLevels", "VDCFranchiseLevel_idVDCFL", "dbo.VDCFranchiseLevels");
            DropForeignKey("dbo.WarrantyAssignments", "idCont", "dbo.Contracts");
            DropForeignKey("dbo.Contracts", "vehicle_IdVehicle", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "Users_idUser", "dbo.Users");
            DropForeignKey("dbo.CustomUserRoles", "User_idUser", "dbo.Users");
            DropForeignKey("dbo.Notifications", "user_idUser", "dbo.Users");
            DropForeignKey("dbo.Notifications", "Notification_idNotif", "dbo.Notifications");
            DropForeignKey("dbo.CustomUserLogins", "User_idUser", "dbo.Users");
            DropForeignKey("dbo.Contracts", "user_idUser", "dbo.Users");
            DropForeignKey("dbo.Classes", "user_idUser", "dbo.Users");
            DropForeignKey("dbo.CustomUserClaims", "User_idUser", "dbo.Users");
            DropForeignKey("dbo.Contracts", "Contract_idCont", "dbo.Contracts");
            DropForeignKey("dbo.RCPrices", "fiscalPower_IdFiscalPower", "dbo.FiscalPowers");
            DropForeignKey("dbo.RCPrices", "classe_idCla", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Classe_idCla", "dbo.Classes");
            DropIndex("dbo.WreckReports", new[] { "Vehicle_IdVehicle" });
            DropIndex("dbo.Sinisters", new[] { "Vehicle_IdVehicle" });
            DropIndex("dbo.Sinisters", new[] { "Garage_IdGarage" });
            DropIndex("dbo.Folders", new[] { "Vehicles_IdVehicle" });
            DropIndex("dbo.VDCFranchiseLevels", new[] { "VDCFranchiseLevel_idVDCFL" });
            DropIndex("dbo.Warranties", new[] { "Warranty_idWrr" });
            DropIndex("dbo.Warranties", new[] { "VDCFranchiseLevel_idVDCFL" });
            DropIndex("dbo.WarrantyAssignments", new[] { "WarrantyAssignment_idCont", "WarrantyAssignment_idWrr" });
            DropIndex("dbo.WarrantyAssignments", new[] { "idWrr" });
            DropIndex("dbo.WarrantyAssignments", new[] { "idCont" });
            DropIndex("dbo.CustomUserRoles", new[] { "CustomRole_Id" });
            DropIndex("dbo.CustomUserRoles", new[] { "User_idUser" });
            DropIndex("dbo.Notifications", new[] { "user_idUser" });
            DropIndex("dbo.Notifications", new[] { "Notification_idNotif" });
            DropIndex("dbo.CustomUserLogins", new[] { "User_idUser" });
            DropIndex("dbo.CustomUserClaims", new[] { "User_idUser" });
            DropIndex("dbo.Contracts", new[] { "vehicle_IdVehicle" });
            DropIndex("dbo.Contracts", new[] { "user_idUser" });
            DropIndex("dbo.Contracts", new[] { "Contract_idCont" });
            DropIndex("dbo.Vehicles", new[] { "FiscalPowers_IdFiscalPower" });
            DropIndex("dbo.Vehicles", new[] { "Users_idUser" });
            DropIndex("dbo.RCPrices", new[] { "RCPrice_idRCP" });
            DropIndex("dbo.RCPrices", new[] { "fiscalPower_IdFiscalPower" });
            DropIndex("dbo.RCPrices", new[] { "classe_idCla" });
            DropIndex("dbo.Classes", new[] { "user_idUser" });
            DropIndex("dbo.Classes", new[] { "Classe_idCla" });
            DropTable("dbo.HistoryRows");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Thirds");
            DropTable("dbo.CustomRoles");
            DropTable("dbo.WreckReports");
            DropTable("dbo.Garages");
            DropTable("dbo.Sinisters");
            DropTable("dbo.Folders");
            DropTable("dbo.VDCFranchiseLevels");
            DropTable("dbo.Warranties");
            DropTable("dbo.WarrantyAssignments");
            DropTable("dbo.CustomUserRoles");
            DropTable("dbo.Notifications");
            DropTable("dbo.CustomUserLogins");
            DropTable("dbo.CustomUserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.Contracts");
            DropTable("dbo.Vehicles");
            DropTable("dbo.FiscalPowers");
            DropTable("dbo.RCPrices");
            DropTable("dbo.Classes");
            DropTable("dbo.AmendmentCs");
        }
    }
}
