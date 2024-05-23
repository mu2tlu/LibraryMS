using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdwqe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a254411a-21b0-4663-b3e0-dd8fd1fb9f9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1008915f-351b-477d-8ac5-c96f53a9f2a0"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Fines");

            migrationBuilder.DropColumn(
                name: "FineType",
                table: "Fines");

            migrationBuilder.AddColumn<string>(
                name: "CreditCardNo",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreditCartHolderName",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cvc",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "MemberId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("01ad421e-2dba-4305-a5f1-14a1881708d4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 207, 23, 192, 59, 7, 26, 48, 249, 205, 111, 79, 177, 46, 148, 123, 110, 122, 182, 114, 216, 220, 187, 153, 180, 163, 57, 37, 51, 209, 144, 230, 25, 123, 47, 202, 204, 56, 131, 148, 159, 93, 223, 127, 18, 89, 29, 23, 76, 137, 137, 4, 41, 66, 103, 242, 71, 122, 23, 250, 157, 80, 94, 128, 248 }, new byte[] { 183, 240, 135, 14, 9, 207, 217, 39, 245, 201, 202, 95, 101, 3, 14, 225, 161, 171, 84, 253, 232, 148, 58, 148, 138, 39, 162, 128, 155, 234, 157, 113, 145, 97, 56, 129, 6, 199, 13, 62, 109, 2, 123, 123, 236, 126, 200, 72, 13, 100, 134, 124, 144, 45, 208, 14, 250, 107, 223, 152, 111, 59, 236, 106, 4, 145, 51, 182, 177, 177, 49, 235, 86, 182, 95, 34, 16, 49, 85, 202, 196, 6, 130, 191, 71, 182, 241, 95, 234, 157, 106, 250, 71, 113, 115, 70, 253, 222, 206, 159, 126, 242, 199, 125, 146, 192, 23, 137, 189, 94, 140, 116, 103, 248, 129, 23, 25, 146, 184, 102, 31, 231, 242, 107, 246, 221, 133, 150 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("2a9460a4-203e-4441-bdb2-3d7b6b5bddba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("01ad421e-2dba-4305-a5f1-14a1881708d4") });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MemberId",
                table: "Payments",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Members_MemberId",
                table: "Payments",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Members_MemberId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_MemberId",
                table: "Payments");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2a9460a4-203e-4441-bdb2-3d7b6b5bddba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01ad421e-2dba-4305-a5f1-14a1881708d4"));

            migrationBuilder.DropColumn(
                name: "CreditCardNo",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CreditCartHolderName",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Cvc",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Payments");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Fines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FineType",
                table: "Fines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("1008915f-351b-477d-8ac5-c96f53a9f2a0"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 104, 148, 60, 105, 1, 197, 73, 252, 190, 126, 227, 151, 190, 73, 122, 135, 191, 8, 74, 251, 99, 126, 213, 78, 113, 41, 194, 192, 40, 145, 192, 124, 192, 120, 131, 181, 18, 221, 235, 84, 25, 35, 199, 85, 82, 206, 56, 220, 2, 160, 192, 176, 11, 237, 179, 136, 231, 74, 123, 14, 197, 15, 72, 114 }, new byte[] { 131, 128, 138, 85, 14, 11, 120, 121, 43, 214, 106, 73, 204, 249, 62, 155, 131, 234, 77, 119, 254, 223, 222, 240, 45, 33, 240, 227, 253, 229, 219, 48, 159, 211, 225, 62, 74, 18, 39, 50, 85, 244, 23, 42, 114, 140, 147, 158, 61, 50, 43, 231, 231, 169, 191, 115, 85, 191, 66, 91, 170, 56, 10, 251, 207, 86, 24, 77, 29, 222, 68, 66, 110, 254, 116, 110, 104, 141, 77, 239, 218, 203, 237, 59, 210, 36, 252, 26, 31, 53, 26, 7, 219, 39, 225, 194, 121, 208, 227, 29, 214, 239, 137, 252, 239, 105, 46, 89, 93, 114, 124, 45, 206, 151, 74, 24, 40, 201, 40, 194, 208, 35, 35, 251, 17, 92, 231, 20 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("a254411a-21b0-4663-b3e0-dd8fd1fb9f9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("1008915f-351b-477d-8ac5-c96f53a9f2a0") });
        }
    }
}
