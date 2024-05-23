using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class libraryseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7df1cf5a-a76a-4cd6-987c-47fd1c3d6114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74f0a53a-5610-4b44-8f48-a53cba758c3f"));

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DeletedDate", "Name", "PhoneNumber", "UpdatedDate", "Website" },
                values: new object[] { new Guid("480aedf0-b072-44c3-9448-8f8ba0f2e403"), "İstanbul Sarıyer", "İstanbul", new DateTime(2024, 5, 22, 18, 44, 19, 365, DateTimeKind.Local).AddTicks(7520), null, "Ninova Kütüphanesi", "", null, "localhost:4200" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3764810c-a60a-4558-958b-f1ddb6d8486d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 86, 237, 63, 196, 235, 57, 85, 11, 247, 71, 54, 161, 41, 43, 123, 58, 194, 105, 38, 8, 85, 191, 108, 27, 149, 12, 209, 118, 4, 177, 182, 179, 202, 78, 219, 203, 24, 114, 175, 191, 183, 150, 103, 144, 248, 148, 156, 5, 233, 55, 255, 167, 204, 52, 239, 229, 104, 200, 90, 83, 232, 255, 228, 243 }, new byte[] { 197, 164, 202, 128, 69, 255, 73, 99, 7, 75, 176, 39, 199, 209, 35, 98, 181, 183, 110, 41, 180, 243, 72, 222, 3, 162, 246, 222, 251, 34, 108, 222, 10, 149, 151, 23, 134, 159, 94, 54, 200, 147, 155, 184, 96, 184, 58, 104, 198, 65, 153, 140, 152, 155, 211, 151, 3, 186, 174, 226, 98, 228, 10, 16, 67, 87, 138, 206, 148, 125, 94, 156, 91, 199, 157, 164, 151, 235, 86, 101, 134, 182, 34, 228, 123, 131, 74, 47, 82, 117, 85, 235, 224, 52, 122, 73, 119, 162, 231, 94, 128, 133, 198, 1, 182, 228, 23, 79, 64, 168, 14, 130, 15, 85, 138, 166, 176, 241, 82, 169, 188, 168, 244, 201, 194, 182, 164, 70 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("9a67bb84-9cb8-4ab5-9be3-f0499f8d9460"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3764810c-a60a-4558-958b-f1ddb6d8486d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: new Guid("480aedf0-b072-44c3-9448-8f8ba0f2e403"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9a67bb84-9cb8-4ab5-9be3-f0499f8d9460"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3764810c-a60a-4558-958b-f1ddb6d8486d"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("74f0a53a-5610-4b44-8f48-a53cba758c3f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 240, 160, 18, 241, 24, 180, 213, 237, 128, 216, 10, 137, 219, 196, 60, 44, 243, 21, 109, 148, 6, 51, 205, 89, 184, 218, 253, 107, 190, 203, 221, 142, 229, 109, 251, 156, 11, 115, 59, 83, 135, 165, 206, 251, 36, 105, 232, 195, 20, 183, 78, 210, 12, 225, 93, 134, 181, 221, 156, 221, 139, 207, 231, 243 }, new byte[] { 235, 51, 235, 167, 131, 221, 83, 48, 158, 52, 9, 137, 108, 99, 92, 87, 47, 197, 88, 179, 191, 20, 103, 127, 234, 206, 53, 104, 175, 142, 252, 68, 78, 85, 212, 8, 74, 96, 81, 209, 18, 249, 202, 123, 115, 47, 161, 186, 58, 77, 65, 25, 66, 198, 220, 2, 6, 114, 221, 110, 128, 9, 185, 154, 112, 35, 5, 107, 77, 77, 171, 1, 196, 109, 125, 208, 205, 197, 195, 18, 218, 10, 103, 163, 92, 78, 61, 63, 196, 135, 226, 162, 168, 89, 182, 162, 79, 251, 79, 249, 146, 227, 89, 233, 200, 233, 202, 76, 205, 224, 234, 33, 80, 123, 194, 254, 199, 200, 148, 70, 94, 234, 8, 161, 106, 82, 61, 7 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7df1cf5a-a76a-4cd6-987c-47fd1c3d6114"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("74f0a53a-5610-4b44-8f48-a53cba758c3f") });
        }
    }
}
