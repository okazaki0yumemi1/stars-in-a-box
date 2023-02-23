using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace stars_in_a_box.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GalaxyClusters",
                columns: table => new
                {
                    GalaxyClusterID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numberOfGalaxies = table.Column<int>(type: "integer", nullable: false),
                    totalMass = table.Column<float>(type: "real", nullable: false),
                    diameter = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalaxyClusters", x => x.GalaxyClusterID);
                });

            migrationBuilder.CreateTable(
                name: "Galaxies",
                columns: table => new
                {
                    GalaxyID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shape = table.Column<byte>(type: "smallint", nullable: false),
                    mass = table.Column<float>(type: "real", nullable: false),
                    size = table.Column<int>(type: "integer", nullable: false),
                    numberOfStars = table.Column<int>(type: "integer", nullable: false),
                    GalaxyClusterID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galaxies", x => x.GalaxyID);
                    table.ForeignKey(
                        name: "FK_Galaxies_GalaxyClusters_GalaxyClusterID",
                        column: x => x.GalaxyClusterID,
                        principalTable: "GalaxyClusters",
                        principalColumn: "GalaxyClusterID");
                });

            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    StarID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    luminosity = table.Column<float>(type: "real", nullable: false),
                    diameter = table.Column<long>(type: "bigint", nullable: false),
                    rotation = table.Column<int>(type: "integer", nullable: false),
                    surfaceTemperature = table.Column<int>(type: "integer", nullable: false),
                    mass = table.Column<float>(type: "real", nullable: false),
                    GalaxyID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.StarID);
                    table.ForeignKey(
                        name: "FK_Stars_Galaxies_GalaxyID",
                        column: x => x.GalaxyID,
                        principalTable: "Galaxies",
                        principalColumn: "GalaxyID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Galaxies_GalaxyClusterID",
                table: "Galaxies",
                column: "GalaxyClusterID");

            migrationBuilder.CreateIndex(
                name: "IX_Stars_GalaxyID",
                table: "Stars",
                column: "GalaxyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stars");

            migrationBuilder.DropTable(
                name: "Galaxies");

            migrationBuilder.DropTable(
                name: "GalaxyClusters");
        }
    }
}
