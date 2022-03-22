using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "times",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSlot = table.Column<string>(nullable: false),
                    Day = table.Column<string>(nullable: false),
                    IsTaken = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_times", x => x.TimeId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_responses_times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "times",
                        principalColumn: "TimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 1, "Monday", false, "8:00AM - 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 61, "Saturday", false, "8:00AM - 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 60, "Friday", false, "8:00PM - 9:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 59, "Friday", false, "6:00PM - 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 58, "Friday", false, "5:00PM - 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 57, "Friday", false, "4:00PM - 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 56, "Friday", false, "3:00PM - 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 55, "Friday", false, "2:00PM - 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 54, "Friday", false, "1:00PM - 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 53, "Friday", false, "12:00PM - 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 52, "Friday", false, "11:00AM - 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 51, "Friday", false, "10:00AM - 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 50, "Friday", false, "9:00AM - 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 49, "Friday", false, "8:00AM - 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 48, "Thursday", false, "8:00PM - 9:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 47, "Thursday", false, "6:00PM - 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 46, "Thursday", false, "5:00PM - 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 45, "Thursday", false, "4:00PM - 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 62, "Saturday", false, "9:00AM - 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 44, "Thursday", false, "3:00PM - 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 63, "Saturday", false, "10:00AM - 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 65, "Saturday", false, "12:00PM - 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 82, "Sunday", false, "5:00PM - 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 81, "Sunday", false, "4:00PM - 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 80, "Sunday", false, "3:00PM - 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 79, "Sunday", false, "2:00PM - 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 78, "Sunday", false, "1:00PM - 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 77, "Sunday", false, "12:00PM - 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 76, "Sunday", false, "11:00AM - 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 75, "Sunday", false, "10:00AM - 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 74, "Sunday", false, "9:00AM - 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 73, "Sunday", false, "8:00AM - 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 72, "Saturday", false, "8:00PM - 9:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 71, "Saturday", false, "6:00PM - 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 70, "Saturday", false, "5:00PM - 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 69, "Saturday", false, "4:00PM - 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 68, "Saturday", false, "3:00PM - 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 67, "Saturday", false, "2:00PM - 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 66, "Saturday", false, "1:00PM - 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 64, "Saturday", false, "11:00AM - 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 43, "Thursday", false, "2:00PM - 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 42, "Thursday", false, "1:00PM - 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 41, "Thursday", false, "12:00PM - 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 18, "Tuesday", false, "1:00PM - 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 17, "Tuesday", false, "12:00PM - 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 16, "Tuesday", false, "11:00AM - 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 15, "Tuesday", false, "10:00AM - 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 14, "Tuesday", false, "9:00AM - 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 13, "Tuesday", false, "8:00AM - 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 12, "Monday", false, "8:00PM - 9:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 11, "Monday", false, "6:00PM - 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 10, "Monday", false, "5:00PM - 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 9, "Monday", false, "4:00PM - 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 8, "Monday", false, "3:00PM - 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 7, "Monday", false, "2:00PM - 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 6, "Monday", false, "1:00PM - 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 5, "Monday", false, "12:00PM - 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 4, "Monday", false, "11:00AM - 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 3, "Monday", false, "10:00AM - 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 2, "Monday", false, "9:00AM - 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 19, "Tuesday", false, "2:00PM - 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 20, "Tuesday", false, "3:00PM - 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 21, "Tuesday", false, "4:00PM - 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 22, "Tuesday", false, "5:00PM - 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 40, "Thursday", false, "11:00AM - 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 39, "Thursday", false, "10:00AM - 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 38, "Thursday", false, "9:00AM - 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 37, "Thursday", false, "8:00AM - 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 36, "Wednesday", false, "8:00PM - 9:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 35, "Wednesday", false, "6:00PM - 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 34, "Wednesday", false, "5:00PM - 6:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 33, "Wednesday", false, "4:00PM - 5:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 83, "Sunday", false, "6:00PM - 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 32, "Wednesday", false, "3:00PM - 4:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 30, "Wednesday", false, "1:00PM - 2:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 29, "Wednesday", false, "12:00PM - 1:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 28, "Wednesday", false, "11:00AM - 12:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 27, "Wednesday", false, "10:00AM - 11:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 26, "Wednesday", false, "9:00AM - 10:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 25, "Wednesday", false, "8:00AM - 9:00AM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 24, "Tuesday", false, "8:00PM - 9:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 23, "Tuesday", false, "6:00PM - 7:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 31, "Wednesday", false, "2:00PM - 3:00PM" });

            migrationBuilder.InsertData(
                table: "times",
                columns: new[] { "TimeId", "Day", "IsTaken", "TimeSlot" },
                values: new object[] { 84, "Sunday", false, "8:00PM - 9:00PM" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_TimeId",
                table: "responses",
                column: "TimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "times");
        }
    }
}
