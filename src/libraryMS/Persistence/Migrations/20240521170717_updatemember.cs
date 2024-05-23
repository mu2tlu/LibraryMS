using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updatemember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c41e8017-3e0a-408a-9b9d-4c5b40e86b4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d95d5c31-eb7f-443a-b777-40b138f6078a"));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalDebt",
                table: "Members",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("8f9455e4-345c-4e61-9872-9f713ad64a1d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 22, 226, 243, 205, 5, 190, 147, 192, 172, 18, 9, 32, 93, 236, 249, 120, 180, 7, 56, 183, 195, 45, 226, 98, 209, 231, 168, 55, 241, 89, 22, 90, 142, 238, 160, 42, 167, 12, 169, 94, 236, 115, 232, 240, 81, 172, 139, 156, 54, 96, 203, 112, 181, 202, 55, 118, 104, 112, 134, 31, 12, 151, 199, 195 }, new byte[] { 56, 69, 64, 75, 80, 29, 62, 135, 48, 91, 189, 0, 81, 54, 132, 98, 197, 40, 191, 139, 217, 221, 239, 71, 11, 163, 182, 35, 182, 249, 245, 70, 104, 11, 10, 190, 40, 176, 2, 148, 138, 51, 161, 14, 72, 210, 46, 134, 3, 83, 178, 140, 127, 35, 192, 125, 103, 106, 57, 206, 104, 251, 4, 204, 60, 170, 232, 228, 30, 59, 182, 3, 228, 59, 0, 222, 189, 56, 173, 20, 68, 52, 129, 125, 31, 19, 221, 110, 2, 126, 159, 125, 202, 228, 194, 97, 17, 214, 119, 96, 145, 190, 54, 199, 2, 111, 99, 134, 38, 21, 160, 208, 116, 21, 58, 18, 203, 226, 249, 239, 208, 93, 237, 251, 152, 151, 42, 86 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b61703ca-e4f6-47fd-817e-7fa4dd0c5e24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("8f9455e4-345c-4e61-9872-9f713ad64a1d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b61703ca-e4f6-47fd-817e-7fa4dd0c5e24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f9455e4-345c-4e61-9872-9f713ad64a1d"));

            migrationBuilder.DropColumn(
                name: "TotalDebt",
                table: "Members");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d95d5c31-eb7f-443a-b777-40b138f6078a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 111, 217, 5, 148, 134, 182, 77, 245, 43, 254, 235, 249, 229, 245, 7, 199, 165, 158, 13, 83, 32, 226, 165, 147, 248, 105, 134, 238, 182, 85, 244, 80, 129, 214, 122, 213, 137, 54, 165, 35, 134, 223, 154, 84, 148, 4, 13, 20, 76, 214, 84, 251, 235, 124, 127, 224, 238, 53, 96, 68, 87, 239, 34, 50 }, new byte[] { 166, 57, 15, 195, 37, 28, 56, 209, 111, 36, 135, 16, 204, 7, 186, 120, 137, 223, 78, 215, 25, 24, 127, 204, 35, 41, 233, 209, 138, 204, 192, 15, 172, 107, 98, 91, 204, 177, 218, 93, 210, 41, 58, 77, 188, 22, 114, 96, 0, 86, 10, 77, 23, 201, 215, 113, 143, 116, 71, 252, 83, 132, 58, 55, 205, 88, 21, 185, 193, 47, 137, 15, 121, 225, 37, 255, 93, 200, 154, 94, 39, 18, 23, 51, 26, 19, 40, 82, 144, 145, 33, 138, 116, 153, 5, 178, 16, 253, 231, 230, 73, 69, 139, 6, 212, 155, 195, 209, 161, 105, 47, 172, 193, 48, 8, 85, 253, 235, 85, 50, 164, 50, 90, 60, 219, 54, 120, 159 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c41e8017-3e0a-408a-9b9d-4c5b40e86b4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d95d5c31-eb7f-443a-b777-40b138f6078a") });
        }
    }
}
