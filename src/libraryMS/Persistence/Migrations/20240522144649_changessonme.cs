using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class changessonme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("60260c47-dacb-4b2a-ad0e-f7ee94b5dc7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18f47144-14d1-40bd-a237-614135e7d668"));

            migrationBuilder.AlterColumn<double>(
                name: "TotalDebt",
                table: "Members",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "FineAmount",
                table: "Fines",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("74f0a53a-5610-4b44-8f48-a53cba758c3f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 240, 160, 18, 241, 24, 180, 213, 237, 128, 216, 10, 137, 219, 196, 60, 44, 243, 21, 109, 148, 6, 51, 205, 89, 184, 218, 253, 107, 190, 203, 221, 142, 229, 109, 251, 156, 11, 115, 59, 83, 135, 165, 206, 251, 36, 105, 232, 195, 20, 183, 78, 210, 12, 225, 93, 134, 181, 221, 156, 221, 139, 207, 231, 243 }, new byte[] { 235, 51, 235, 167, 131, 221, 83, 48, 158, 52, 9, 137, 108, 99, 92, 87, 47, 197, 88, 179, 191, 20, 103, 127, 234, 206, 53, 104, 175, 142, 252, 68, 78, 85, 212, 8, 74, 96, 81, 209, 18, 249, 202, 123, 115, 47, 161, 186, 58, 77, 65, 25, 66, 198, 220, 2, 6, 114, 221, 110, 128, 9, 185, 154, 112, 35, 5, 107, 77, 77, 171, 1, 196, 109, 125, 208, 205, 197, 195, 18, 218, 10, 103, 163, 92, 78, 61, 63, 196, 135, 226, 162, 168, 89, 182, 162, 79, 251, 79, 249, 146, 227, 89, 233, 200, 233, 202, 76, 205, 224, 234, 33, 80, 123, 194, 254, 199, 200, 148, 70, 94, 234, 8, 161, 106, 82, 61, 7 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7df1cf5a-a76a-4cd6-987c-47fd1c3d6114"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("74f0a53a-5610-4b44-8f48-a53cba758c3f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7df1cf5a-a76a-4cd6-987c-47fd1c3d6114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74f0a53a-5610-4b44-8f48-a53cba758c3f"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalDebt",
                table: "Members",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FineAmount",
                table: "Fines",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("18f47144-14d1-40bd-a237-614135e7d668"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 196, 77, 203, 8, 192, 115, 182, 64, 24, 189, 75, 24, 22, 55, 119, 211, 137, 184, 225, 205, 11, 127, 177, 174, 120, 193, 218, 59, 95, 127, 233, 192, 41, 93, 146, 188, 61, 81, 84, 12, 140, 188, 122, 222, 217, 144, 154, 185, 183, 154, 104, 114, 117, 217, 73, 167, 210, 72, 202, 83, 190, 83, 190, 1 }, new byte[] { 17, 17, 123, 194, 173, 247, 146, 231, 202, 83, 90, 102, 156, 31, 18, 156, 93, 164, 147, 211, 221, 105, 235, 72, 142, 210, 30, 66, 129, 53, 8, 157, 4, 105, 6, 99, 196, 53, 175, 212, 48, 85, 19, 86, 5, 113, 24, 138, 207, 78, 234, 187, 140, 138, 189, 80, 253, 139, 10, 229, 101, 207, 167, 57, 17, 195, 224, 233, 51, 10, 84, 70, 174, 118, 230, 232, 6, 11, 178, 242, 53, 60, 87, 58, 142, 113, 100, 159, 14, 45, 213, 77, 194, 92, 45, 14, 53, 236, 121, 202, 180, 233, 55, 56, 122, 61, 139, 191, 2, 130, 50, 97, 151, 184, 130, 120, 130, 86, 30, 126, 68, 208, 115, 16, 186, 0, 159, 248 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("60260c47-dacb-4b2a-ad0e-f7ee94b5dc7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("18f47144-14d1-40bd-a237-614135e7d668") });
        }
    }
}
