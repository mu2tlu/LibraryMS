using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class borrow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("495d3e29-9a16-47ff-932e-151372910fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86a8969f-97d2-444e-b415-4bd482a5afa1"));

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ISSN",
                table: "Items",
                newName: "Issn");

            migrationBuilder.AlterColumn<string>(
                name: "Issn",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("2dffa77f-7314-4b46-b5af-d6bc9d75726c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 113, 168, 37, 14, 195, 238, 120, 246, 245, 189, 36, 169, 133, 33, 251, 133, 143, 52, 202, 227, 106, 226, 132, 176, 119, 187, 183, 160, 64, 49, 58, 121, 131, 184, 250, 225, 93, 191, 14, 205, 172, 238, 85, 99, 245, 154, 201, 28, 175, 40, 190, 199, 253, 54, 154, 233, 64, 103, 208, 184, 180, 221, 172, 235 }, new byte[] { 213, 118, 254, 113, 220, 133, 250, 86, 159, 141, 218, 233, 149, 2, 173, 11, 218, 250, 97, 73, 46, 62, 190, 93, 194, 220, 204, 208, 12, 241, 36, 6, 53, 149, 108, 119, 157, 104, 236, 131, 252, 184, 33, 226, 52, 221, 224, 64, 6, 214, 112, 34, 179, 63, 212, 215, 17, 215, 47, 52, 58, 147, 165, 198, 210, 120, 105, 16, 68, 145, 1, 163, 191, 114, 129, 79, 181, 33, 188, 129, 149, 160, 67, 136, 169, 44, 129, 161, 162, 134, 188, 22, 210, 32, 211, 201, 1, 180, 25, 92, 203, 144, 64, 216, 57, 83, 134, 196, 17, 123, 110, 200, 165, 179, 18, 184, 195, 185, 134, 0, 235, 236, 117, 115, 254, 83, 151, 112 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8e21dd07-5251-476f-b97b-e806ce1e1d58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2dffa77f-7314-4b46-b5af-d6bc9d75726c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8e21dd07-5251-476f-b97b-e806ce1e1d58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dffa77f-7314-4b46-b5af-d6bc9d75726c"));

            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Issn",
                table: "Items",
                newName: "ISSN");

            migrationBuilder.AlterColumn<string>(
                name: "ISSN",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EmployeeStatus",
                table: "Employees",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("86a8969f-97d2-444e-b415-4bd482a5afa1"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 102, 196, 46, 63, 80, 131, 193, 85, 46, 146, 126, 88, 29, 183, 157, 28, 198, 154, 134, 167, 15, 240, 79, 150, 185, 111, 95, 154, 126, 36, 243, 156, 5, 77, 122, 28, 243, 141, 207, 254, 35, 73, 213, 189, 70, 129, 174, 118, 235, 46, 7, 208, 236, 226, 84, 233, 88, 83, 225, 108, 96, 64, 84, 219 }, new byte[] { 65, 65, 211, 69, 2, 13, 59, 46, 2, 53, 86, 136, 44, 127, 181, 96, 75, 8, 88, 84, 179, 45, 249, 133, 226, 106, 31, 56, 89, 77, 125, 196, 68, 9, 1, 178, 147, 221, 215, 2, 12, 127, 103, 54, 119, 41, 91, 195, 18, 194, 45, 210, 37, 248, 179, 156, 33, 158, 142, 17, 55, 8, 129, 182, 94, 5, 5, 53, 176, 124, 231, 56, 5, 61, 55, 90, 163, 1, 28, 188, 160, 252, 64, 96, 253, 14, 8, 204, 212, 60, 49, 248, 177, 172, 63, 63, 63, 195, 249, 64, 120, 133, 22, 77, 24, 76, 41, 82, 200, 110, 167, 46, 211, 27, 139, 215, 96, 172, 246, 224, 176, 86, 227, 184, 37, 113, 248, 216 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("495d3e29-9a16-47ff-932e-151372910fca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("86a8969f-97d2-444e-b415-4bd482a5afa1") });
        }
    }
}
