using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Data.Migrations
{
    public partial class fluentAPIRepositories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_PublishingCompany_PublisherId",
                table: "Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Autor_AutorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Book_BooksId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Genre_GenresId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_BookSubject_Book_BooksId",
                table: "BookSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_Storage_Book_BookId",
                table: "Storage");

            migrationBuilder.DropForeignKey(
                name: "FK_Storage_PublishingCompany_PublisherId",
                table: "Storage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storage",
                table: "Storage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishingCompany",
                table: "PublishingCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autor",
                table: "Autor");

            migrationBuilder.RenameTable(
                name: "Storage",
                newName: "Storages");

            migrationBuilder.RenameTable(
                name: "PublishingCompany",
                newName: "PublishingCompanies");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "Autor",
                newName: "Autors");

            migrationBuilder.RenameIndex(
                name: "IX_Storage_PublisherId",
                table: "Storages",
                newName: "IX_Storages_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Storage_BookId",
                table: "Storages",
                newName: "IX_Storages_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AutorId",
                table: "Books",
                newName: "IX_Books_AutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Autor_PublisherId",
                table: "Autors",
                newName: "IX_Autors_PublisherId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subject",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Storages",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostPrice",
                table: "Storages",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PublishingCompanies",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Autors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storages",
                table: "Storages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishingCompanies",
                table: "PublishingCompanies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autors",
                table: "Autors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPercent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StorageId = table.Column<int>(type: "int", nullable: true),
                    DiscountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_Name",
                table: "Subject",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_CostPrice",
                table: "Storages",
                column: "CostPrice");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_CreateDate",
                table: "Storages",
                column: "CreateDate");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_Quantity",
                table: "Storages",
                column: "Quantity");

            migrationBuilder.CreateIndex(
                name: "IX_PublishingCompanies_Name",
                table: "PublishingCompanies",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Name",
                table: "Books",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Pages",
                table: "Books",
                column: "Pages");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublishedYear",
                table: "Books",
                column: "PublishedYear");

            migrationBuilder.CreateIndex(
                name: "IX_Autors_BirthYear",
                table: "Autors",
                column: "BirthYear");

            migrationBuilder.CreateIndex(
                name: "IX_Autors_Name",
                table: "Autors",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_End",
                table: "Discounts",
                column: "End");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_IsPercent",
                table: "Discounts",
                column: "IsPercent");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_Reduction",
                table: "Discounts",
                column: "Reduction");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_Start",
                table: "Discounts",
                column: "Start");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Date",
                table: "Orders",
                column: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiscountId",
                table: "Orders",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Price",
                table: "Orders",
                column: "Price");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StorageId",
                table: "Orders",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Autors_PublishingCompanies_PublisherId",
                table: "Autors",
                column: "PublisherId",
                principalTable: "PublishingCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Books_BooksId",
                table: "BookGenre",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Genres_GenresId",
                table: "BookGenre",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Autors_AutorId",
                table: "Books",
                column: "AutorId",
                principalTable: "Autors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookSubject_Books_BooksId",
                table: "BookSubject",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Books_BookId",
                table: "Storages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_PublishingCompanies_PublisherId",
                table: "Storages",
                column: "PublisherId",
                principalTable: "PublishingCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autors_PublishingCompanies_PublisherId",
                table: "Autors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Books_BooksId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Genres_GenresId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Autors_AutorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookSubject_Books_BooksId",
                table: "BookSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Books_BookId",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_PublishingCompanies_PublisherId",
                table: "Storages");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Subject_Name",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storages",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_CostPrice",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_CreateDate",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_Quantity",
                table: "Storages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishingCompanies",
                table: "PublishingCompanies");

            migrationBuilder.DropIndex(
                name: "IX_PublishingCompanies_Name",
                table: "PublishingCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_Name",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Name",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Pages",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublishedYear",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autors",
                table: "Autors");

            migrationBuilder.DropIndex(
                name: "IX_Autors_BirthYear",
                table: "Autors");

            migrationBuilder.DropIndex(
                name: "IX_Autors_Name",
                table: "Autors");

            migrationBuilder.RenameTable(
                name: "Storages",
                newName: "Storage");

            migrationBuilder.RenameTable(
                name: "PublishingCompanies",
                newName: "PublishingCompany");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "Autors",
                newName: "Autor");

            migrationBuilder.RenameIndex(
                name: "IX_Storages_PublisherId",
                table: "Storage",
                newName: "IX_Storage_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Storages_BookId",
                table: "Storage",
                newName: "IX_Storage_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AutorId",
                table: "Book",
                newName: "IX_Book_AutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Autors_PublisherId",
                table: "Autor",
                newName: "IX_Autor_PublisherId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subject",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Storage",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostPrice",
                table: "Storage",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PublishingCompany",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Autor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storage",
                table: "Storage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishingCompany",
                table: "PublishingCompany",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autor",
                table: "Autor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_PublishingCompany_PublisherId",
                table: "Autor",
                column: "PublisherId",
                principalTable: "PublishingCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Autor_AutorId",
                table: "Book",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Book_BooksId",
                table: "BookGenre",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Genre_GenresId",
                table: "BookGenre",
                column: "GenresId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookSubject_Book_BooksId",
                table: "BookSubject",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storage_Book_BookId",
                table: "Storage",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Storage_PublishingCompany_PublisherId",
                table: "Storage",
                column: "PublisherId",
                principalTable: "PublishingCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
