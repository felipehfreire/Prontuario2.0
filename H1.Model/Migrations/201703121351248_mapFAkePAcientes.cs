namespace H1.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mapFAkePAcientes : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.@FLAGCADPAC",
            //    c => new
            //        {
            //            Code = c.String(nullable: false, maxLength: 128),
            //            U_CODPAC = c.String(),
            //            U_NOMPAC = c.String(),
            //            U_NUMEROPRONTUARIO = c.String(),
            //        })
            //    .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.@FLAGCADPAC");
        }
    }
}
