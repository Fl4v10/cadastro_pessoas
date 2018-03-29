using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PersonRegister.Impl.Migrations
{
    public partial class RenameField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "POSTAL_CODE",
                table: "ADDRESS");

            migrationBuilder.RenameColumn(
                name: "INDENTIFICATION_DOCUMENT",
                table: "PERSON",
                newName: "IDENTIFICATION_DOCUMENT");

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "PERSON",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IDENTIFICATION_DOCUMENT",
                table: "PERSON",
                newName: "INDENTIFICATION_DOCUMENT");

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "PERSON",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "POSTAL_CODE",
                table: "ADDRESS",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }
    }
}
