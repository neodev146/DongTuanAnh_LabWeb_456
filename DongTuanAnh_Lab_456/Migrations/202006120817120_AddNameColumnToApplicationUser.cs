namespace DongTuanAnh_Lab_456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            RenameColumn(table: "dbo.Courses", name: "Lecturer_Id", newName: "LecturerId");
            RenameIndex(table: "dbo.Courses", name: "IX_Lecturer_Id", newName: "IX_LecturerId");
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Courses", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropColumn("dbo.AspNetUsers", "Name");
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerId", newName: "IX_Lecturer_Id");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "Lecturer_Id");
            CreateIndex("dbo.Courses", "CategoryID");
        }
    }
}
