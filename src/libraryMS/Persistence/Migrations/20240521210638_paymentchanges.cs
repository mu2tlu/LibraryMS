using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class paymentchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2a9460a4-203e-4441-bdb2-3d7b6b5bddba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01ad421e-2dba-4305-a5f1-14a1881708d4"));

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentAmount",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "Payments");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("18f47144-14d1-40bd-a237-614135e7d668"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 196, 77, 203, 8, 192, 115, 182, 64, 24, 189, 75, 24, 22, 55, 119, 211, 137, 184, 225, 205, 11, 127, 177, 174, 120, 193, 218, 59, 95, 127, 233, 192, 41, 93, 146, 188, 61, 81, 84, 12, 140, 188, 122, 222, 217, 144, 154, 185, 183, 154, 104, 114, 117, 217, 73, 167, 210, 72, 202, 83, 190, 83, 190, 1 }, new byte[] { 17, 17, 123, 194, 173, 247, 146, 231, 202, 83, 90, 102, 156, 31, 18, 156, 93, 164, 147, 211, 221, 105, 235, 72, 142, 210, 30, 66, 129, 53, 8, 157, 4, 105, 6, 99, 196, 53, 175, 212, 48, 85, 19, 86, 5, 113, 24, 138, 207, 78, 234, 187, 140, 138, 189, 80, 253, 139, 10, 229, 101, 207, 167, 57, 17, 195, 224, 233, 51, 10, 84, 70, 174, 118, 230, 232, 6, 11, 178, 242, 53, 60, 87, 58, 142, 113, 100, 159, 14, 45, 213, 77, 194, 92, 45, 14, 53, 236, 121, 202, 180, 233, 55, 56, 122, 61, 139, 191, 2, 130, 50, 97, 151, 184, 130, 120, 130, 86, 30, 126, 68, 208, 115, 16, 186, 0, 159, 248 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("60260c47-dacb-4b2a-ad0e-f7ee94b5dc7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("18f47144-14d1-40bd-a237-614135e7d668") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("60260c47-dacb-4b2a-ad0e-f7ee94b5dc7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18f47144-14d1-40bd-a237-614135e7d668"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PaymentAmount",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("01ad421e-2dba-4305-a5f1-14a1881708d4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 207, 23, 192, 59, 7, 26, 48, 249, 205, 111, 79, 177, 46, 148, 123, 110, 122, 182, 114, 216, 220, 187, 153, 180, 163, 57, 37, 51, 209, 144, 230, 25, 123, 47, 202, 204, 56, 131, 148, 159, 93, 223, 127, 18, 89, 29, 23, 76, 137, 137, 4, 41, 66, 103, 242, 71, 122, 23, 250, 157, 80, 94, 128, 248 }, new byte[] { 183, 240, 135, 14, 9, 207, 217, 39, 245, 201, 202, 95, 101, 3, 14, 225, 161, 171, 84, 253, 232, 148, 58, 148, 138, 39, 162, 128, 155, 234, 157, 113, 145, 97, 56, 129, 6, 199, 13, 62, 109, 2, 123, 123, 236, 126, 200, 72, 13, 100, 134, 124, 144, 45, 208, 14, 250, 107, 223, 152, 111, 59, 236, 106, 4, 145, 51, 182, 177, 177, 49, 235, 86, 182, 95, 34, 16, 49, 85, 202, 196, 6, 130, 191, 71, 182, 241, 95, 234, 157, 106, 250, 71, 113, 115, 70, 253, 222, 206, 159, 126, 242, 199, 125, 146, 192, 23, 137, 189, 94, 140, 116, 103, 248, 129, 23, 25, 146, 184, 102, 31, 231, 242, 107, 246, 221, 133, 150 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("2a9460a4-203e-4441-bdb2-3d7b6b5bddba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("01ad421e-2dba-4305-a5f1-14a1881708d4") });
        }
    }
}
