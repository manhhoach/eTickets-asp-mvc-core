using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class create_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Producers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Producers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Producers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Producers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Cinemas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Cinemas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cinemas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Cinemas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Actors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Actors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Actors",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Actors");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
