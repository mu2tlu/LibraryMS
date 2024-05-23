using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class borrow1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8e21dd07-5251-476f-b97b-e806ce1e1d58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dffa77f-7314-4b46-b5af-d6bc9d75726c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("7927c151-2096-47ec-b5c5-860426d8974e"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 170, 164, 244, 2, 21, 23, 77, 142, 49, 246, 76, 92, 200, 93, 216, 88, 18, 240, 15, 28, 159, 240, 66, 166, 19, 76, 210, 232, 26, 179, 109, 242, 113, 94, 235, 52, 198, 230, 33, 251, 253, 127, 214, 139, 251, 134, 133, 134, 183, 8, 163, 38, 53, 0, 124, 131, 11, 192, 110, 3, 227, 66, 113, 126 }, new byte[] { 186, 146, 233, 125, 253, 133, 11, 125, 223, 85, 93, 63, 205, 81, 90, 13, 115, 7, 233, 222, 99, 243, 147, 155, 252, 20, 73, 196, 40, 223, 61, 183, 0, 103, 55, 173, 214, 154, 229, 121, 213, 209, 17, 232, 46, 143, 49, 165, 228, 150, 207, 14, 104, 114, 134, 24, 114, 14, 193, 255, 200, 173, 139, 37, 32, 100, 102, 162, 99, 47, 137, 133, 38, 122, 160, 247, 188, 22, 240, 161, 78, 218, 38, 205, 130, 47, 46, 190, 147, 138, 224, 166, 35, 238, 62, 127, 245, 66, 45, 162, 245, 138, 75, 56, 102, 40, 125, 47, 216, 180, 169, 28, 101, 20, 162, 130, 13, 218, 60, 51, 11, 130, 211, 235, 239, 212, 207, 160 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("37f379fa-e061-445e-8f72-a603ccf3f55a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("7927c151-2096-47ec-b5c5-860426d8974e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("37f379fa-e061-445e-8f72-a603ccf3f55a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7927c151-2096-47ec-b5c5-860426d8974e"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("2dffa77f-7314-4b46-b5af-d6bc9d75726c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 113, 168, 37, 14, 195, 238, 120, 246, 245, 189, 36, 169, 133, 33, 251, 133, 143, 52, 202, 227, 106, 226, 132, 176, 119, 187, 183, 160, 64, 49, 58, 121, 131, 184, 250, 225, 93, 191, 14, 205, 172, 238, 85, 99, 245, 154, 201, 28, 175, 40, 190, 199, 253, 54, 154, 233, 64, 103, 208, 184, 180, 221, 172, 235 }, new byte[] { 213, 118, 254, 113, 220, 133, 250, 86, 159, 141, 218, 233, 149, 2, 173, 11, 218, 250, 97, 73, 46, 62, 190, 93, 194, 220, 204, 208, 12, 241, 36, 6, 53, 149, 108, 119, 157, 104, 236, 131, 252, 184, 33, 226, 52, 221, 224, 64, 6, 214, 112, 34, 179, 63, 212, 215, 17, 215, 47, 52, 58, 147, 165, 198, 210, 120, 105, 16, 68, 145, 1, 163, 191, 114, 129, 79, 181, 33, 188, 129, 149, 160, 67, 136, 169, 44, 129, 161, 162, 134, 188, 22, 210, 32, 211, 201, 1, 180, 25, 92, 203, 144, 64, 216, 57, 83, 134, 196, 17, 123, 110, 200, 165, 179, 18, 184, 195, 185, 134, 0, 235, 236, 117, 115, 254, 83, 151, 112 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8e21dd07-5251-476f-b97b-e806ce1e1d58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2dffa77f-7314-4b46-b5af-d6bc9d75726c") });
        }
    }
}
