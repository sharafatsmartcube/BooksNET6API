﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksNET6API.Migrations
{
    public partial class AddBooktoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
