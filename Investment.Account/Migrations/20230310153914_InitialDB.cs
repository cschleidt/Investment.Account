using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investment.Account.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investmentaccount",
                columns: table => new
                {
                    InvestmentAccountNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductInstanceReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestmentAccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentPositionHolding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investmentaccount", x => x.InvestmentAccountNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investmentaccount");
        }
    }
}
