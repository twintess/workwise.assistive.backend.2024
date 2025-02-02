using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace workwise.assistive.backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_AspNetUsers_Id",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "PortalUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortalUsers",
                table: "PortalUsers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "057fab4a-6566-45a2-ba4c-212492ea901e", null, "surver-interaction-reader", "SURVER-INTERACTION-READER" },
                    { "368fac30-b44c-4053-9ca9-6694d93adf6f", null, "disk-request-reader", "DISK-REQUEST-READER" },
                    { "36bfb857-83f5-4fe8-9302-cecf680737ff", null, "popup-distribution-reader", "POPUP-DISTRIBUTION-READER" },
                    { "3c602f16-26d4-4cdb-a86c-4a1f73eda974", null, "domain-reader", "DOMAIN-READER" },
                    { "43ea34ea-a2e6-4106-ba95-cb7f2a090bdc", null, "personalization-lockscreen-reader", "PERSONALIZATION-LOCKSCREEN-READER" },
                    { "46c7807f-93e3-4d51-a1b8-a33181f5fe8f", null, "popup-schedule-reader", "POPUP-SCHEDULE-READER" },
                    { "494fa66f-dc0f-4ea0-b369-52d0b000ee6e", null, "survey-report-reader", "SURVEY-REPORT-READER" },
                    { "4ecd3239-23e4-4e8c-8bf7-9ae1a9c53bd6", null, "user-password-reset-operator", "USER-PASSWORD-RESET-OPERATOR" },
                    { "522befd6-e589-46aa-8e09-29db6fc805ba", null, "personalization-schedule-reader", "PERSONALIZATION-SCHEDULE-READER" },
                    { "64cf548e-17e5-4004-944a-ea318c78566b", null, "disk-request-contributor", "DISK-REQUEST-CONTRIBUTOR" },
                    { "6b8e732c-bb57-4785-9200-e9598da9007c", null, "audit-settings-reader", "AUDIT-SETTINGS-READER" },
                    { "82263b55-a2e0-4312-a6b7-3b1a467c829f", null, "popup-window-contributor", "POPUP-WINDOW-CONTRIBUTOR" },
                    { "953a8367-49e8-4afb-a03a-5605b54bf6da", null, "new-account-request-reader", "NEW-ACCOUNT-REQUEST-READER" },
                    { "9fef5610-603f-436c-96f8-74c302af3453", null, "popup-window-reader", "POPUP-WINDOW-READER" },
                    { "abb7cd0e-bc00-4367-a008-c9b0cc20a7a1", null, "new-account-request-contributor", "NEW-ACCOUNT-REQUEST-CONTRIBUTOR" },
                    { "c4ab97da-a236-4c8c-a81a-9cc3cfd9616a", null, "portal-admin", "PORTAL-ADMIN" },
                    { "d213b27e-0098-46c7-9880-85a28a372e2f", null, "zabbix-statistics-reader", "ZABBIX-STATISTICS-READER" },
                    { "d8a57d1a-1940-444d-8565-0e517d61669f", null, "audit-reader", "AUDIT-READER" },
                    { "e0352f9d-f441-4f7e-a669-773746dac1e1", null, "popup-distribution-contributor", "POPUP-DISTRIBUTION-CONTRIBUTOR" },
                    { "e07e0d1a-444f-4e09-8800-fa5e4d2740eb", null, "zabbix-servers-report-reader", "ZABBIX-SERVERS-REPORT-READER" },
                    { "e23a6d00-c3be-48aa-bb3d-774e868e730b", null, "zabbix-incidents-reader", "ZABBIX-INCIDENTS-READER" },
                    { "f75dae6c-19a7-4832-8ad3-23f018fb0a37", null, "user-mfa-details-reader", "USER-MFA-DETAILS-READER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PortalUsers_AspNetUsers_Id",
                table: "PortalUsers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortalUsers_AspNetUsers_Id",
                table: "PortalUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortalUsers",
                table: "PortalUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "057fab4a-6566-45a2-ba4c-212492ea901e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "368fac30-b44c-4053-9ca9-6694d93adf6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36bfb857-83f5-4fe8-9302-cecf680737ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c602f16-26d4-4cdb-a86c-4a1f73eda974");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43ea34ea-a2e6-4106-ba95-cb7f2a090bdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c7807f-93e3-4d51-a1b8-a33181f5fe8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "494fa66f-dc0f-4ea0-b369-52d0b000ee6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ecd3239-23e4-4e8c-8bf7-9ae1a9c53bd6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "522befd6-e589-46aa-8e09-29db6fc805ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64cf548e-17e5-4004-944a-ea318c78566b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b8e732c-bb57-4785-9200-e9598da9007c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82263b55-a2e0-4312-a6b7-3b1a467c829f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "953a8367-49e8-4afb-a03a-5605b54bf6da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fef5610-603f-436c-96f8-74c302af3453");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abb7cd0e-bc00-4367-a008-c9b0cc20a7a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4ab97da-a236-4c8c-a81a-9cc3cfd9616a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d213b27e-0098-46c7-9880-85a28a372e2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a57d1a-1940-444d-8565-0e517d61669f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0352f9d-f441-4f7e-a669-773746dac1e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e07e0d1a-444f-4e09-8800-fa5e4d2740eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e23a6d00-c3be-48aa-bb3d-774e868e730b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f75dae6c-19a7-4832-8ad3-23f018fb0a37");

            migrationBuilder.RenameTable(
                name: "PortalUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AspNetUsers_Id",
                table: "Users",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
