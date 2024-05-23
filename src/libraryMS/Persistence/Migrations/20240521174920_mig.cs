using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b61703ca-e4f6-47fd-817e-7fa4dd0c5e24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f9455e4-345c-4e61-9872-9f713ad64a1d"));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Member");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Employee");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "Fines.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Fines.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Fines.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "Fines.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Fines.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "Fines.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Items.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "Items.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Items.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "Items.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "Items.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "Items.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "ItemAuthors.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "ItemAuthors.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "ItemAuthors.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "ItemAuthors.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "ItemAuthors.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "ItemAuthors.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Libraries.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Libraries.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Libraries.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Libraries.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Libraries.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Libraries.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "LibraryMembers.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "LibraryMembers.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "LibraryMembers.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "LibraryMembers.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "LibraryMembers.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "LibraryMembers.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "Locations.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "Locations.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "Locations.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Locations.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Locations.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 79,
                column: "Name",
                value: "Locations.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "Members.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "Members.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "Members.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Members.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Members.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "Members.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "Payments.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Payments.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "Payments.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Payments.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "Payments.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "Payments.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "Publishers.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "Publishers.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "Publishers.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 95,
                column: "Name",
                value: "Publishers.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "Publishers.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "Publishers.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "Reports.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Reports.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 100,
                column: "Name",
                value: "Reports.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 101,
                column: "Name",
                value: "Reports.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 102,
                column: "Name",
                value: "Reports.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 103,
                column: "Name",
                value: "Reports.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "Reservations.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 105,
                column: "Name",
                value: "Reservations.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 106,
                column: "Name",
                value: "Reservations.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 107,
                column: "Name",
                value: "Reservations.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 108,
                column: "Name",
                value: "Reservations.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 109,
                column: "Name",
                value: "Reservations.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 110,
                column: "Name",
                value: "Reviews.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "Reviews.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "Reviews.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Reviews.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "Reviews.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 115,
                column: "Name",
                value: "Reviews.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "LibraryMembers.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 117,
                column: "Name",
                value: "LibraryMembers.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 118,
                column: "Name",
                value: "LibraryMembers.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "LibraryMembers.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "LibraryMembers.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 121,
                column: "Name",
                value: "LibraryMembers.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 122,
                column: "Name",
                value: "Borrows.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 123,
                column: "Name",
                value: "Borrows.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 124,
                column: "Name",
                value: "Borrows.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 125,
                column: "Name",
                value: "Borrows.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 126,
                column: "Name",
                value: "Borrows.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 127,
                column: "Name",
                value: "Borrows.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "Fines.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 129,
                column: "Name",
                value: "Fines.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 130,
                column: "Name",
                value: "Fines.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 131,
                column: "Name",
                value: "Fines.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 132,
                column: "Name",
                value: "Fines.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 133,
                column: "Name",
                value: "Fines.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 134,
                column: "Name",
                value: "Fines.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 135,
                column: "Name",
                value: "Fines.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 136,
                column: "Name",
                value: "Fines.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 137,
                column: "Name",
                value: "Fines.Create");

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fines.Update", null },
                    { 139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fines.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("1008915f-351b-477d-8ac5-c96f53a9f2a0"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 104, 148, 60, 105, 1, 197, 73, 252, 190, 126, 227, 151, 190, 73, 122, 135, 191, 8, 74, 251, 99, 126, 213, 78, 113, 41, 194, 192, 40, 145, 192, 124, 192, 120, 131, 181, 18, 221, 235, 84, 25, 35, 199, 85, 82, 206, 56, 220, 2, 160, 192, 176, 11, 237, 179, 136, 231, 74, 123, 14, 197, 15, 72, 114 }, new byte[] { 131, 128, 138, 85, 14, 11, 120, 121, 43, 214, 106, 73, 204, 249, 62, 155, 131, 234, 77, 119, 254, 223, 222, 240, 45, 33, 240, 227, 253, 229, 219, 48, 159, 211, 225, 62, 74, 18, 39, 50, 85, 244, 23, 42, 114, 140, 147, 158, 61, 50, 43, 231, 231, 169, 191, 115, 85, 191, 66, 91, 170, 56, 10, 251, 207, 86, 24, 77, 29, 222, 68, 66, 110, 254, 116, 110, 104, 141, 77, 239, 218, 203, 237, 59, 210, 36, 252, 26, 31, 53, 26, 7, 219, 39, 225, 194, 121, 208, 227, 29, 214, 239, 137, 252, 239, 105, 46, 89, 93, 114, 124, 45, 206, 151, 74, 24, 40, 201, 40, 194, 208, 35, 35, 251, 17, 92, 231, 20 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("a254411a-21b0-4663-b3e0-dd8fd1fb9f9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("1008915f-351b-477d-8ac5-c96f53a9f2a0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a254411a-21b0-4663-b3e0-dd8fd1fb9f9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1008915f-351b-477d-8ac5-c96f53a9f2a0"));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Fines.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Fines.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "Fines.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Fines.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Fines.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "Fines.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Items.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "Items.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Items.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "Items.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Items.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "Items.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "ItemAuthors.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "ItemAuthors.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "ItemAuthors.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "ItemAuthors.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "ItemAuthors.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "ItemAuthors.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "Libraries.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Libraries.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Libraries.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Libraries.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Libraries.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Libraries.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "LibraryMembers.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "LibraryMembers.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "LibraryMembers.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "LibraryMembers.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "LibraryMembers.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "LibraryMembers.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "Locations.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "Locations.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "Locations.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "Locations.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "Locations.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Locations.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Members.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 79,
                column: "Name",
                value: "Members.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "Members.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "Members.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "Members.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Members.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Payments.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "Payments.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "Payments.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Payments.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "Payments.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Payments.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "Publishers.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "Publishers.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "Publishers.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "Publishers.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "Publishers.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 95,
                column: "Name",
                value: "Publishers.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "Reports.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "Reports.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "Reports.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Reports.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 100,
                column: "Name",
                value: "Reports.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 101,
                column: "Name",
                value: "Reports.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 102,
                column: "Name",
                value: "Reservations.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 103,
                column: "Name",
                value: "Reservations.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "Reservations.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 105,
                column: "Name",
                value: "Reservations.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 106,
                column: "Name",
                value: "Reservations.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 107,
                column: "Name",
                value: "Reservations.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 108,
                column: "Name",
                value: "Reviews.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 109,
                column: "Name",
                value: "Reviews.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 110,
                column: "Name",
                value: "Reviews.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "Reviews.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "Reviews.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Reviews.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "LibraryMembers.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 115,
                column: "Name",
                value: "LibraryMembers.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "LibraryMembers.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 117,
                column: "Name",
                value: "LibraryMembers.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 118,
                column: "Name",
                value: "LibraryMembers.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "LibraryMembers.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "Borrows.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 121,
                column: "Name",
                value: "Borrows.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 122,
                column: "Name",
                value: "Borrows.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 123,
                column: "Name",
                value: "Borrows.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 124,
                column: "Name",
                value: "Borrows.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 125,
                column: "Name",
                value: "Borrows.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 126,
                column: "Name",
                value: "Fines.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 127,
                column: "Name",
                value: "Fines.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "Fines.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 129,
                column: "Name",
                value: "Fines.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 130,
                column: "Name",
                value: "Fines.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 131,
                column: "Name",
                value: "Fines.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 132,
                column: "Name",
                value: "Fines.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 133,
                column: "Name",
                value: "Fines.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 134,
                column: "Name",
                value: "Fines.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 135,
                column: "Name",
                value: "Fines.Create");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 136,
                column: "Name",
                value: "Fines.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 137,
                column: "Name",
                value: "Fines.Delete");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("8f9455e4-345c-4e61-9872-9f713ad64a1d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 22, 226, 243, 205, 5, 190, 147, 192, 172, 18, 9, 32, 93, 236, 249, 120, 180, 7, 56, 183, 195, 45, 226, 98, 209, 231, 168, 55, 241, 89, 22, 90, 142, 238, 160, 42, 167, 12, 169, 94, 236, 115, 232, 240, 81, 172, 139, 156, 54, 96, 203, 112, 181, 202, 55, 118, 104, 112, 134, 31, 12, 151, 199, 195 }, new byte[] { 56, 69, 64, 75, 80, 29, 62, 135, 48, 91, 189, 0, 81, 54, 132, 98, 197, 40, 191, 139, 217, 221, 239, 71, 11, 163, 182, 35, 182, 249, 245, 70, 104, 11, 10, 190, 40, 176, 2, 148, 138, 51, 161, 14, 72, 210, 46, 134, 3, 83, 178, 140, 127, 35, 192, 125, 103, 106, 57, 206, 104, 251, 4, 204, 60, 170, 232, 228, 30, 59, 182, 3, 228, 59, 0, 222, 189, 56, 173, 20, 68, 52, 129, 125, 31, 19, 221, 110, 2, 126, 159, 125, 202, 228, 194, 97, 17, 214, 119, 96, 145, 190, 54, 199, 2, 111, 99, 134, 38, 21, 160, 208, 116, 21, 58, 18, 203, 226, 249, 239, 208, 93, 237, 251, 152, 151, 42, 86 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b61703ca-e4f6-47fd-817e-7fa4dd0c5e24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("8f9455e4-345c-4e61-9872-9f713ad64a1d") });
        }
    }
}
