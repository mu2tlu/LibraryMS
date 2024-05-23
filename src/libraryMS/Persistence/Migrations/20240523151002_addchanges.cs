using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Libraries",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "DeletedDate", "Name", "PhoneNumber", "UpdatedDate", "Website" },
                values: new object[] { new Guid("bc90afa1-7ccc-40ce-98a4-4bd19d3b2ccc"), "İstanbul Sarıyer", "İstanbul", new DateTime(2024, 5, 23, 18, 10, 1, 806, DateTimeKind.Local).AddTicks(8163), null, "Ninova Kütüphanesi", "", null, "localhost:4200" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3e595927-b46e-4a0a-8ef0-a4530db3b2bd"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 15, 202, 48, 251, 129, 133, 77, 42, 54, 83, 227, 200, 48, 17, 119, 249, 223, 126, 243, 96, 248, 148, 115, 127, 250, 60, 135, 209, 31, 204, 150, 65, 165, 175, 199, 114, 198, 96, 3, 22, 80, 7, 211, 210, 152, 184, 60, 152, 50, 47, 49, 43, 208, 140, 70, 112, 158, 196, 186, 147, 91, 189, 152, 27 }, new byte[] { 111, 132, 251, 175, 184, 224, 131, 197, 248, 128, 97, 38, 247, 134, 85, 27, 219, 101, 255, 7, 51, 192, 14, 38, 56, 120, 187, 185, 250, 55, 74, 86, 173, 174, 197, 186, 118, 83, 38, 13, 247, 194, 23, 159, 241, 55, 134, 66, 65, 129, 44, 58, 169, 82, 158, 7, 61, 61, 164, 174, 138, 149, 96, 19, 128, 35, 152, 221, 207, 4, 228, 109, 242, 4, 253, 26, 254, 223, 92, 128, 113, 228, 123, 168, 100, 222, 37, 84, 223, 71, 117, 217, 23, 33, 139, 249, 46, 255, 131, 141, 170, 101, 163, 118, 53, 254, 108, 33, 4, 161, 128, 87, 89, 178, 106, 147, 252, 116, 188, 86, 30, 238, 30, 169, 114, 249, 57, 57 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("0ac9b677-d25e-48c0-943d-37c6e5307a8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3e595927-b46e-4a0a-8ef0-a4530db3b2bd") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: new Guid("bc90afa1-7ccc-40ce-98a4-4bd19d3b2ccc"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("0ac9b677-d25e-48c0-943d-37c6e5307a8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e595927-b46e-4a0a-8ef0-a4530db3b2bd"));

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
    }
}
