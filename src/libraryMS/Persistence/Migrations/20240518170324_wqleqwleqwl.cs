using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class wqleqwleqwl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5fdbeab4-dcb3-4d92-885f-ce8f1e2c5df1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e9d440e-578f-42d4-877b-958dec76daff"));

            migrationBuilder.RenameColumn(
                name: "Issn",
                table: "Items",
                newName: "Isbn");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("9c05d140-e5f0-4d4e-8009-9ee635832354"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 94, 112, 110, 252, 59, 161, 206, 240, 176, 178, 196, 150, 247, 143, 52, 118, 122, 171, 163, 244, 121, 167, 129, 92, 90, 95, 97, 87, 138, 38, 146, 50, 156, 189, 201, 41, 186, 252, 171, 108, 248, 14, 232, 182, 133, 245, 191, 89, 235, 227, 86, 147, 153, 12, 254, 161, 237, 226, 50, 177, 223, 220, 230, 188 }, new byte[] { 17, 42, 132, 6, 250, 23, 97, 222, 148, 252, 17, 50, 112, 32, 170, 12, 92, 27, 236, 94, 114, 110, 30, 196, 144, 40, 100, 238, 130, 246, 174, 209, 104, 77, 146, 219, 52, 255, 193, 141, 21, 49, 148, 219, 141, 110, 144, 247, 90, 55, 90, 210, 128, 209, 164, 60, 75, 62, 214, 41, 63, 39, 205, 133, 153, 253, 250, 142, 22, 204, 42, 121, 227, 58, 170, 192, 20, 225, 242, 117, 23, 114, 241, 40, 154, 142, 54, 12, 77, 193, 146, 118, 201, 47, 197, 225, 194, 239, 254, 95, 242, 9, 161, 34, 178, 120, 81, 214, 152, 249, 211, 196, 14, 76, 118, 162, 15, 199, 126, 126, 152, 81, 95, 83, 164, 25, 222, 101 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("6b653e95-8df1-4009-ac29-91b7a48d8bf0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("9c05d140-e5f0-4d4e-8009-9ee635832354") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b653e95-8df1-4009-ac29-91b7a48d8bf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c05d140-e5f0-4d4e-8009-9ee635832354"));

            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "Items",
                newName: "Issn");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("1e9d440e-578f-42d4-877b-958dec76daff"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 253, 35, 213, 160, 150, 170, 242, 67, 75, 178, 50, 140, 55, 2, 89, 10, 197, 40, 80, 247, 92, 238, 25, 12, 132, 207, 213, 65, 87, 228, 166, 69, 147, 90, 222, 70, 90, 198, 58, 63, 137, 141, 134, 229, 56, 20, 191, 81, 64, 138, 232, 76, 249, 96, 173, 3, 148, 33, 251, 203, 73, 17, 70, 178 }, new byte[] { 11, 120, 174, 69, 146, 243, 45, 88, 47, 96, 188, 27, 133, 234, 98, 239, 206, 186, 54, 60, 216, 214, 26, 123, 240, 43, 205, 227, 148, 11, 140, 178, 172, 49, 177, 133, 68, 224, 12, 136, 236, 45, 127, 219, 13, 14, 192, 71, 52, 252, 94, 45, 242, 143, 144, 89, 249, 43, 157, 222, 26, 162, 1, 151, 44, 185, 23, 43, 221, 6, 116, 113, 117, 169, 76, 73, 198, 195, 227, 135, 26, 60, 120, 36, 248, 224, 4, 216, 20, 59, 16, 11, 100, 151, 10, 68, 248, 152, 189, 236, 135, 170, 55, 208, 231, 66, 167, 237, 203, 49, 237, 40, 40, 63, 62, 122, 83, 170, 91, 146, 181, 208, 71, 230, 143, 241, 248, 38 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("5fdbeab4-dcb3-4d92-885f-ce8f1e2c5df1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("1e9d440e-578f-42d4-877b-958dec76daff") });
        }
    }
}
