namespace Veritas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProfileImages", "UserId", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProfileImages", "UserId", c => c.Int(nullable: false));
        }
    }
}
