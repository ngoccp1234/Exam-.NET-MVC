namespace Exam_ASP_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        Subject = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        ClassRoom = c.Int(nullable: false),
                        Faculty = c.Int(nullable: false),
                        ExamDate = c.DateTime(nullable: false, precision: 0),
                        StartTime = c.String(unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
