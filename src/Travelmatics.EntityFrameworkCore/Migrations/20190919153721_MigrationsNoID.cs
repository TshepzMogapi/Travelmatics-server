using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travelmatics.Migrations
{
    public partial class MigrationsNoID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Contacts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AbpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "AbpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    ContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => new { x.UserId, x.ContactId });
                    table.ForeignKey(
                        name: "FK_UserContacts_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserContacts_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_ContactId",
                table: "UserContacts",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AbpUsers_UserId",
                table: "Contacts",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AbpUsers_UserId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "UserContacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "AbpUsers");
        }
    }
}
