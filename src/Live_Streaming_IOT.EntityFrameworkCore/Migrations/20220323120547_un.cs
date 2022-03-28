using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Live_Streaming_IOT.Migrations
{
    public partial class un : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommodityInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodityId = table.Column<int>(type: "int", nullable: false),
                    CommodityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommoditySubtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityDisplay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommoditySaleBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommoditySalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommodiSPromotion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommodityDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityWeight = table.Column<int>(type: "int", nullable: false),
                    CommodityBarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityState = table.Column<int>(type: "int", nullable: false),
                    CommodityBorwseNum = table.Column<int>(type: "int", nullable: false),
                    CommoditySaleNum = table.Column<int>(type: "int", nullable: false),
                    CommodityEvaluaNum = table.Column<int>(type: "int", nullable: false),
                    CommodityAttrName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityInfoIntegrity = table.Column<int>(type: "int", nullable: false),
                    CommodSpeciId = table.Column<int>(type: "int", nullable: false),
                    CommodTypeId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommodityType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommodTypeId = table.Column<int>(type: "int", nullable: false),
                    CommodTypeAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodTypeOrder = table.Column<int>(type: "int", nullable: false),
                    CommodTypeDisplay = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommodityInfo");

            migrationBuilder.DropTable(
                name: "CommodityType");
        }
    }
}
