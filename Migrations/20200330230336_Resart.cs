using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class Resart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                columns: new[] { "Content", "Group", "PostDate", "UserName" },
                values: new object[] { "Bartholomew's fancy hats", "Shark", new DateTime(2017, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "noodle_boi_hat" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                columns: new[] { "Group", "PostDate", "UserName" },
                values: new object[] { "Shopping Boi's", new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "noodle_boi_hat" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                columns: new[] { "Content", "Group", "UserName" },
                values: new object[] { "doppledonger", "Firework Sales", "Female" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                columns: new[] { "Content", "Group", "PostDate", "UserName" },
                values: new object[] { "bart", "Shark", new DateTime(2015, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7,
                columns: new[] { "Content", "PostDate", "UserName" },
                values: new object[] { "bart", new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "leggo" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Content", "Group", "PostDate", "UserName" },
                values: new object[,]
                {
                    { 1, "where the tp", "Shopping Boi's", new DateTime(2015, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female" },
                    { 2, "Pip", "Shark", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "leggo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                columns: new[] { "Content", "Group", "PostDate", "UserName" },
                values: new object[] { "where the tp", "Shopping Boi's", new DateTime(2015, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                columns: new[] { "Group", "PostDate", "UserName" },
                values: new object[] { "Shark", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "leggo" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                columns: new[] { "Content", "Group", "UserName" },
                values: new object[] { "Bartholomew's fancy hats", "Shark", "noodle_boi_hat" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6,
                columns: new[] { "Content", "Group", "PostDate", "UserName" },
                values: new object[] { "Pip", "Shopping Boi's", new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "noodle_boi_hat" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7,
                columns: new[] { "Content", "PostDate", "UserName" },
                values: new object[] { "doppledonger", new DateTime(2017, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Content", "Group", "PostDate", "UserName" },
                values: new object[,]
                {
                    { 8, "bart", "Shark", new DateTime(2015, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female" },
                    { 9, "bart", "Firework Sales", new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "leggo" }
                });
        }
    }
}
