using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investment.Account.Migrations
{
    /// <inheritdoc />
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public partial class accountentries : Migration
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvestmentaccountEntry",
                columns: table => new
                {
                    InvestmentEntryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvestmentAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePrShare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentaccountEntry", x => x.InvestmentEntryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestmentaccountEntry");
        }
    }
}
