using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class wesz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b653e95-8df1-4009-ac29-91b7a48d8bf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c05d140-e5f0-4d4e-8009-9ee635832354"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d95d5c31-eb7f-443a-b777-40b138f6078a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 111, 217, 5, 148, 134, 182, 77, 245, 43, 254, 235, 249, 229, 245, 7, 199, 165, 158, 13, 83, 32, 226, 165, 147, 248, 105, 134, 238, 182, 85, 244, 80, 129, 214, 122, 213, 137, 54, 165, 35, 134, 223, 154, 84, 148, 4, 13, 20, 76, 214, 84, 251, 235, 124, 127, 224, 238, 53, 96, 68, 87, 239, 34, 50 }, new byte[] { 166, 57, 15, 195, 37, 28, 56, 209, 111, 36, 135, 16, 204, 7, 186, 120, 137, 223, 78, 215, 25, 24, 127, 204, 35, 41, 233, 209, 138, 204, 192, 15, 172, 107, 98, 91, 204, 177, 218, 93, 210, 41, 58, 77, 188, 22, 114, 96, 0, 86, 10, 77, 23, 201, 215, 113, 143, 116, 71, 252, 83, 132, 58, 55, 205, 88, 21, 185, 193, 47, 137, 15, 121, 225, 37, 255, 93, 200, 154, 94, 39, 18, 23, 51, 26, 19, 40, 82, 144, 145, 33, 138, 116, 153, 5, 178, 16, 253, 231, 230, 73, 69, 139, 6, 212, 155, 195, 209, 161, 105, 47, 172, 193, 48, 8, 85, 253, 235, 85, 50, 164, 50, 90, 60, 219, 54, 120, 159 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c41e8017-3e0a-408a-9b9d-4c5b40e86b4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d95d5c31-eb7f-443a-b777-40b138f6078a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c41e8017-3e0a-408a-9b9d-4c5b40e86b4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d95d5c31-eb7f-443a-b777-40b138f6078a"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9c05d140-e5f0-4d4e-8009-9ee635832354"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 94, 112, 110, 252, 59, 161, 206, 240, 176, 178, 196, 150, 247, 143, 52, 118, 122, 171, 163, 244, 121, 167, 129, 92, 90, 95, 97, 87, 138, 38, 146, 50, 156, 189, 201, 41, 186, 252, 171, 108, 248, 14, 232, 182, 133, 245, 191, 89, 235, 227, 86, 147, 153, 12, 254, 161, 237, 226, 50, 177, 223, 220, 230, 188 }, new byte[] { 17, 42, 132, 6, 250, 23, 97, 222, 148, 252, 17, 50, 112, 32, 170, 12, 92, 27, 236, 94, 114, 110, 30, 196, 144, 40, 100, 238, 130, 246, 174, 209, 104, 77, 146, 219, 52, 255, 193, 141, 21, 49, 148, 219, 141, 110, 144, 247, 90, 55, 90, 210, 128, 209, 164, 60, 75, 62, 214, 41, 63, 39, 205, 133, 153, 253, 250, 142, 22, 204, 42, 121, 227, 58, 170, 192, 20, 225, 242, 117, 23, 114, 241, 40, 154, 142, 54, 12, 77, 193, 146, 118, 201, 47, 197, 225, 194, 239, 254, 95, 242, 9, 161, 34, 178, 120, 81, 214, 152, 249, 211, 196, 14, 76, 118, 162, 15, 199, 126, 126, 152, 81, 95, 83, 164, 25, 222, 101 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("6b653e95-8df1-4009-ac29-91b7a48d8bf0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9c05d140-e5f0-4d4e-8009-9ee635832354") });
        }
    }
}
