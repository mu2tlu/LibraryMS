using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Son : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3068f0d8-d10b-4907-924c-19fd4717d541"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf9c1da8-8092-44c2-b1b2-632931abd78c"));

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "Employees",
                newName: "NationalIdentity");

            migrationBuilder.AddColumn<string>(
                name: "NationalIdentity",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmployeeStatus",
                table: "Employees",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("122c52c4-3a85-47a1-b0ba-cebd24f8cf4b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 10, 21, 205, 48, 133, 99, 114, 150, 55, 38, 228, 131, 121, 23, 199, 217, 248, 7, 113, 31, 192, 140, 102, 208, 198, 17, 37, 49, 190, 137, 88, 231, 39, 59, 26, 137, 36, 140, 73, 167, 235, 251, 173, 66, 231, 199, 235, 155, 188, 74, 93, 130, 72, 231, 122, 231, 80, 174, 41, 34, 205, 244, 206, 19 }, new byte[] { 138, 61, 92, 35, 239, 94, 97, 108, 90, 19, 158, 239, 105, 207, 114, 2, 21, 72, 129, 191, 31, 156, 234, 88, 187, 16, 230, 124, 191, 100, 71, 254, 148, 82, 238, 165, 152, 224, 247, 204, 170, 135, 76, 243, 58, 252, 2, 78, 251, 137, 61, 3, 116, 73, 63, 104, 55, 29, 2, 224, 172, 228, 133, 75, 194, 216, 58, 12, 13, 138, 67, 16, 141, 202, 97, 200, 134, 131, 107, 9, 19, 122, 255, 141, 12, 131, 229, 254, 24, 226, 34, 184, 252, 190, 96, 95, 252, 32, 211, 57, 75, 154, 201, 169, 65, 191, 187, 218, 129, 226, 216, 8, 192, 215, 95, 181, 134, 26, 250, 71, 61, 93, 37, 203, 206, 174, 91, 174 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("ee18c68e-a7a7-4eb3-ad05-bc95c2351dbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("122c52c4-3a85-47a1-b0ba-cebd24f8cf4b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ee18c68e-a7a7-4eb3-ad05-bc95c2351dbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("122c52c4-3a85-47a1-b0ba-cebd24f8cf4b"));

            migrationBuilder.DropColumn(
                name: "NationalIdentity",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "NationalIdentity",
                table: "Employees",
                newName: "NationalId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("cf9c1da8-8092-44c2-b1b2-632931abd78c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 28, 207, 142, 191, 131, 83, 3, 166, 87, 255, 15, 4, 64, 57, 188, 144, 19, 51, 116, 229, 213, 33, 16, 134, 93, 177, 185, 114, 114, 9, 30, 187, 68, 158, 52, 124, 128, 19, 24, 196, 106, 164, 88, 119, 184, 93, 175, 101, 58, 221, 162, 119, 249, 77, 228, 106, 46, 187, 47, 108, 39, 47, 111, 43 }, new byte[] { 41, 89, 196, 47, 97, 102, 132, 181, 136, 2, 37, 166, 128, 13, 154, 215, 38, 53, 49, 15, 82, 141, 17, 86, 139, 193, 148, 148, 46, 167, 78, 247, 9, 142, 81, 116, 11, 42, 217, 141, 36, 232, 245, 7, 133, 76, 203, 115, 65, 100, 57, 188, 83, 114, 31, 156, 170, 93, 226, 71, 1, 11, 85, 18, 243, 150, 181, 160, 82, 67, 154, 118, 209, 180, 230, 68, 65, 140, 123, 72, 99, 109, 190, 59, 77, 34, 71, 55, 127, 243, 53, 44, 47, 178, 245, 153, 93, 198, 102, 11, 88, 43, 204, 12, 68, 189, 123, 59, 42, 84, 72, 69, 14, 5, 1, 26, 170, 148, 130, 60, 221, 47, 208, 120, 240, 185, 210, 141 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("3068f0d8-d10b-4907-924c-19fd4717d541"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("cf9c1da8-8092-44c2-b1b2-632931abd78c") });
        }
    }
}
