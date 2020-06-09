namespace CodeFirstUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OfficeAssignments", "Activo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OfficeAssignments", "Activo");
        }
    }
}
