using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8a858010-3dba-4302-b1af-ca4f16d7b46a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("adb976d9-487f-4c7d-9b05-209c47d38987"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("1e9d440e-578f-42d4-877b-958dec76daff"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 253, 35, 213, 160, 150, 170, 242, 67, 75, 178, 50, 140, 55, 2, 89, 10, 197, 40, 80, 247, 92, 238, 25, 12, 132, 207, 213, 65, 87, 228, 166, 69, 147, 90, 222, 70, 90, 198, 58, 63, 137, 141, 134, 229, 56, 20, 191, 81, 64, 138, 232, 76, 249, 96, 173, 3, 148, 33, 251, 203, 73, 17, 70, 178 }, new byte[] { 11, 120, 174, 69, 146, 243, 45, 88, 47, 96, 188, 27, 133, 234, 98, 239, 206, 186, 54, 60, 216, 214, 26, 123, 240, 43, 205, 227, 148, 11, 140, 178, 172, 49, 177, 133, 68, 224, 12, 136, 236, 45, 127, 219, 13, 14, 192, 71, 52, 252, 94, 45, 242, 143, 144, 89, 249, 43, 157, 222, 26, 162, 1, 151, 44, 185, 23, 43, 221, 6, 116, 113, 117, 169, 76, 73, 198, 195, 227, 135, 26, 60, 120, 36, 248, 224, 4, 216, 20, 59, 16, 11, 100, 151, 10, 68, 248, 152, 189, 236, 135, 170, 55, 208, 231, 66, 167, 237, 203, 49, 237, 40, 40, 63, 62, 122, 83, 170, 91, 146, 181, 208, 71, 230, 143, 241, 248, 38 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("5fdbeab4-dcb3-4d92-885f-ce8f1e2c5df1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("1e9d440e-578f-42d4-877b-958dec76daff") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5fdbeab4-dcb3-4d92-885f-ce8f1e2c5df1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e9d440e-578f-42d4-877b-958dec76daff"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("adb976d9-487f-4c7d-9b05-209c47d38987"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 185, 179, 95, 100, 21, 65, 30, 178, 21, 6, 136, 111, 207, 169, 206, 242, 72, 21, 7, 233, 127, 87, 39, 6, 198, 206, 20, 225, 91, 50, 123, 155, 208, 162, 218, 94, 79, 254, 180, 110, 252, 14, 158, 10, 22, 137, 99, 124, 160, 114, 154, 74, 175, 110, 197, 9, 175, 100, 119, 56, 186, 207, 189, 73 }, new byte[] { 199, 32, 143, 8, 140, 140, 237, 80, 135, 69, 228, 226, 84, 191, 238, 77, 231, 146, 179, 235, 179, 246, 11, 228, 200, 169, 182, 138, 33, 224, 88, 118, 243, 33, 139, 33, 170, 173, 170, 111, 175, 20, 88, 217, 191, 73, 17, 223, 145, 234, 97, 117, 226, 6, 149, 57, 5, 206, 239, 65, 254, 145, 47, 43, 16, 208, 172, 170, 106, 157, 22, 241, 59, 114, 54, 59, 109, 113, 129, 182, 117, 186, 143, 146, 140, 15, 109, 174, 169, 137, 68, 159, 81, 51, 30, 189, 51, 76, 212, 91, 114, 200, 133, 162, 86, 162, 25, 191, 61, 223, 145, 165, 171, 225, 240, 252, 64, 61, 170, 13, 255, 71, 55, 253, 196, 214, 85, 213 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8a858010-3dba-4302-b1af-ca4f16d7b46a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("adb976d9-487f-4c7d-9b05-209c47d38987") });
        }
    }
}
