namespace DangXuanBang_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        MaNhaCungCap = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 128),
                        TenSanPham = c.String(),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
            DropTable("dbo.NhaCungCaps");
        }
    }
}
