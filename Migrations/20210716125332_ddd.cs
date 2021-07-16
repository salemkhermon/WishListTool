using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WishList.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LogsData_RequestsResponses_requestResponseId",
                table: "LogsData");

            migrationBuilder.DropIndex(
                name: "IX_LogsData_requestResponseId",
                table: "LogsData");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "RequestsResponses");

            migrationBuilder.DropColumn(
                name: "OperationName",
                table: "RequestsResponses");

            migrationBuilder.DropColumn(
                name: "requestResponseId",
                table: "LogsData");

            migrationBuilder.AddColumn<int>(
                name: "OperationType",
                table: "RequestsResponses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "LogsData",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "LogsData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationType",
                table: "RequestsResponses");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "LogsData");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Companies");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "RequestsResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OperationName",
                table: "RequestsResponses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LogsData",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "requestResponseId",
                table: "LogsData",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogsData_requestResponseId",
                table: "LogsData",
                column: "requestResponseId");

            migrationBuilder.AddForeignKey(
                name: "FK_LogsData_RequestsResponses_requestResponseId",
                table: "LogsData",
                column: "requestResponseId",
                principalTable: "RequestsResponses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
