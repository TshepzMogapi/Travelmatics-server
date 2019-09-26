using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travelmatics.Migrations
{
    public partial class TestMigration : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
