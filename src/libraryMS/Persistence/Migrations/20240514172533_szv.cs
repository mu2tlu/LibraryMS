using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class szv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ee18c68e-a7a7-4eb3-ad05-bc95c2351dbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("122c52c4-3a85-47a1-b0ba-cebd24f8cf4b"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("86a8969f-97d2-444e-b415-4bd482a5afa1"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 102, 196, 46, 63, 80, 131, 193, 85, 46, 146, 126, 88, 29, 183, 157, 28, 198, 154, 134, 167, 15, 240, 79, 150, 185, 111, 95, 154, 126, 36, 243, 156, 5, 77, 122, 28, 243, 141, 207, 254, 35, 73, 213, 189, 70, 129, 174, 118, 235, 46, 7, 208, 236, 226, 84, 233, 88, 83, 225, 108, 96, 64, 84, 219 }, new byte[] { 65, 65, 211, 69, 2, 13, 59, 46, 2, 53, 86, 136, 44, 127, 181, 96, 75, 8, 88, 84, 179, 45, 249, 133, 226, 106, 31, 56, 89, 77, 125, 196, 68, 9, 1, 178, 147, 221, 215, 2, 12, 127, 103, 54, 119, 41, 91, 195, 18, 194, 45, 210, 37, 248, 179, 156, 33, 158, 142, 17, 55, 8, 129, 182, 94, 5, 5, 53, 176, 124, 231, 56, 5, 61, 55, 90, 163, 1, 28, 188, 160, 252, 64, 96, 253, 14, 8, 204, 212, 60, 49, 248, 177, 172, 63, 63, 63, 195, 249, 64, 120, 133, 22, 77, 24, 76, 41, 82, 200, 110, 167, 46, 211, 27, 139, 215, 96, 172, 246, 224, 176, 86, 227, 184, 37, 113, 248, 216 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("495d3e29-9a16-47ff-932e-151372910fca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("86a8969f-97d2-444e-b415-4bd482a5afa1") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("495d3e29-9a16-47ff-932e-151372910fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86a8969f-97d2-444e-b415-4bd482a5afa1"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("122c52c4-3a85-47a1-b0ba-cebd24f8cf4b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 10, 21, 205, 48, 133, 99, 114, 150, 55, 38, 228, 131, 121, 23, 199, 217, 248, 7, 113, 31, 192, 140, 102, 208, 198, 17, 37, 49, 190, 137, 88, 231, 39, 59, 26, 137, 36, 140, 73, 167, 235, 251, 173, 66, 231, 199, 235, 155, 188, 74, 93, 130, 72, 231, 122, 231, 80, 174, 41, 34, 205, 244, 206, 19 }, new byte[] { 138, 61, 92, 35, 239, 94, 97, 108, 90, 19, 158, 239, 105, 207, 114, 2, 21, 72, 129, 191, 31, 156, 234, 88, 187, 16, 230, 124, 191, 100, 71, 254, 148, 82, 238, 165, 152, 224, 247, 204, 170, 135, 76, 243, 58, 252, 2, 78, 251, 137, 61, 3, 116, 73, 63, 104, 55, 29, 2, 224, 172, 228, 133, 75, 194, 216, 58, 12, 13, 138, 67, 16, 141, 202, 97, 200, 134, 131, 107, 9, 19, 122, 255, 141, 12, 131, 229, 254, 24, 226, 34, 184, 252, 190, 96, 95, 252, 32, 211, 57, 75, 154, 201, 169, 65, 191, 187, 218, 129, 226, 216, 8, 192, 215, 95, 181, 134, 26, 250, 71, 61, 93, 37, 203, 206, 174, 91, 174 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("ee18c68e-a7a7-4eb3-ad05-bc95c2351dbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("122c52c4-3a85-47a1-b0ba-cebd24f8cf4b") });
        }
    }
}
