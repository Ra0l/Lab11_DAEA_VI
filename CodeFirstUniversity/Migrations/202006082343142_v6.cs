namespace CodeFirstUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Activo", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Activo", c => c.String());
        }
    }
}
