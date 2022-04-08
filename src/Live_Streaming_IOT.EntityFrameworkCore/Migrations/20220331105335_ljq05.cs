using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Live_Streaming_IOT.Migrations
{
    public partial class ljq05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

           
            migrationBuilder.CreateTable(
                name: "Brand_List",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branddescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandSort = table.Column<int>(type: "int", nullable: false),
                    BrandShow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand_List", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category_listings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_listings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Detalis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DetailsImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetailTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalis", x => x.Id);
                });

           
           


            

            migrationBuilder.CreateTable(
                name: "Showcase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShowcaseMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagelinks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowCaseSort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Showcase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SKU",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SKUColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKUBatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKUSellPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKUNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Productlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPU",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductBelong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductNum = table.Column<int>(type: "int", nullable: false),
                    ProductNumber = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdictMarket = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductHight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdictRecommend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductGift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductWelfare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductParameter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPU", x => x.Id);
                });  
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            
        }
    }
}
