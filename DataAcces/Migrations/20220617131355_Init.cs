using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cari",
                columns: table => new
                {
                    CariId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Unvan = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cari", x => x.CariId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullanciId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullanciId);
                });

            migrationBuilder.CreateTable(
                name: "KurVeris",
                columns: table => new
                {
                    KurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Birim = table.Column<int>(nullable: false),
                    DovizKodu = table.Column<decimal>(nullable: false),
                    DovizCinsi = table.Column<decimal>(nullable: false),
                    DovizAlis = table.Column<decimal>(nullable: false),
                    DovizSatis = table.Column<decimal>(nullable: false),
                    EfektifAlıs = table.Column<decimal>(nullable: false),
                    EfektifSatis = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KurVeris", x => x.KurId);
                });

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    AdresId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdresAcıklama = table.Column<string>(nullable: false),
                    CariId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.AdresId);
                    table.ForeignKey(
                        name: "FK_Adres_Cari_CariId",
                        column: x => x.CariId,
                        principalTable: "Cari",
                        principalColumn: "CariId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefon",
                columns: table => new
                {
                    TelefonId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TelefonNo = table.Column<string>(nullable: false),
                    CariId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefon", x => x.TelefonId);
                    table.ForeignKey(
                        name: "FK_Telefon_Cari_CariId",
                        column: x => x.CariId,
                        principalTable: "Cari",
                        principalColumn: "CariId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adres_CariId",
                table: "Adres",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefon_CariId",
                table: "Telefon",
                column: "CariId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "KurVeris");

            migrationBuilder.DropTable(
                name: "Telefon");

            migrationBuilder.DropTable(
                name: "Cari");
        }
    }
}
