using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedDocTemplate123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97eb8208-1708-41ec-96ad-0aafe7cabced"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8036956-70e2-4f54-a716-a84c7ed1150d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2273b821-8f63-4fb5-adda-31039cb4641c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3c839693-98a1-4a64-8e0d-612f7dfdd8c4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d24771f7-9423-4ae6-bf84-a01a7c7b3326"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fd009892-56aa-4a8b-9966-1496f03e5ef7"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("2ebe3575-d42e-4baa-b5f4-449d403031c9"), new Guid("4e001cb3-527e-4341-804d-8102c8ec0fc0") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("2ebe3575-d42e-4baa-b5f4-449d403031c9"), new Guid("d41de196-10d7-4592-a757-138c860cc5ac") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("e2abb890-4080-49bc-aee9-6dc074275713"), new Guid("81c8486c-ac4c-46a5-b4da-2f0b11f583db") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("2ebe3575-d42e-4baa-b5f4-449d403031c9"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e2abb890-4080-49bc-aee9-6dc074275713"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("4e001cb3-527e-4341-804d-8102c8ec0fc0"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("81c8486c-ac4c-46a5-b4da-2f0b11f583db"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("d41de196-10d7-4592-a757-138c860cc5ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca9cb851-4a6f-4f10-877e-3a51c91fd73d"));

            migrationBuilder.CreateTable(
                name: "DocumentTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTemplates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("22dda934-02ca-43f3-8699-ffe12871aa4f"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" },
                    { new Guid("34400723-ad6f-474b-8aea-634425e7881a"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" },
                    { new Guid("69f10dc0-3792-4ca4-9a02-aa9c3ed04949"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("5675873f-5872-41ea-989b-33720f7000c5"), 2 },
                    { new Guid("5b9682ed-14d2-45fc-ae56-5897bf23bff2"), 4 },
                    { new Guid("ba122783-55bf-42d3-8e1d-36cdbc352dfe"), 1 },
                    { new Guid("e6b9dd73-8f32-4241-93a5-e0adb2553cc8"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("decd37e4-6a8d-4b31-8a6f-712182cb443f"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("e88f7e4e-f535-418c-98f6-4f764cbca0ed"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("eb96f93c-7aee-48e8-9866-d09d9d9b01ac"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("3387731c-932b-419a-bb95-52628d88df62"), new Guid("34400723-ad6f-474b-8aea-634425e7881a"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" },
                    { new Guid("7a3e42b8-3993-4b5d-9966-6f7383002350"), new Guid("34400723-ad6f-474b-8aea-634425e7881a"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("3387731c-932b-419a-bb95-52628d88df62"), new Guid("decd37e4-6a8d-4b31-8a6f-712182cb443f") },
                    { new Guid("3387731c-932b-419a-bb95-52628d88df62"), new Guid("eb96f93c-7aee-48e8-9866-d09d9d9b01ac") },
                    { new Guid("7a3e42b8-3993-4b5d-9966-6f7383002350"), new Guid("e88f7e4e-f535-418c-98f6-4f764cbca0ed") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentTemplates");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22dda934-02ca-43f3-8699-ffe12871aa4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69f10dc0-3792-4ca4-9a02-aa9c3ed04949"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5675873f-5872-41ea-989b-33720f7000c5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5b9682ed-14d2-45fc-ae56-5897bf23bff2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ba122783-55bf-42d3-8e1d-36cdbc352dfe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e6b9dd73-8f32-4241-93a5-e0adb2553cc8"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("3387731c-932b-419a-bb95-52628d88df62"), new Guid("decd37e4-6a8d-4b31-8a6f-712182cb443f") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("3387731c-932b-419a-bb95-52628d88df62"), new Guid("eb96f93c-7aee-48e8-9866-d09d9d9b01ac") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("7a3e42b8-3993-4b5d-9966-6f7383002350"), new Guid("e88f7e4e-f535-418c-98f6-4f764cbca0ed") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("3387731c-932b-419a-bb95-52628d88df62"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7a3e42b8-3993-4b5d-9966-6f7383002350"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("decd37e4-6a8d-4b31-8a6f-712182cb443f"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("e88f7e4e-f535-418c-98f6-4f764cbca0ed"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("eb96f93c-7aee-48e8-9866-d09d9d9b01ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34400723-ad6f-474b-8aea-634425e7881a"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("97eb8208-1708-41ec-96ad-0aafe7cabced"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" },
                    { new Guid("ca9cb851-4a6f-4f10-877e-3a51c91fd73d"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" },
                    { new Guid("d8036956-70e2-4f54-a716-a84c7ed1150d"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("2273b821-8f63-4fb5-adda-31039cb4641c"), 3 },
                    { new Guid("3c839693-98a1-4a64-8e0d-612f7dfdd8c4"), 2 },
                    { new Guid("d24771f7-9423-4ae6-bf84-a01a7c7b3326"), 1 },
                    { new Guid("fd009892-56aa-4a8b-9966-1496f03e5ef7"), 4 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("4e001cb3-527e-4341-804d-8102c8ec0fc0"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("81c8486c-ac4c-46a5-b4da-2f0b11f583db"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("d41de196-10d7-4592-a757-138c860cc5ac"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("2ebe3575-d42e-4baa-b5f4-449d403031c9"), new Guid("ca9cb851-4a6f-4f10-877e-3a51c91fd73d"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" },
                    { new Guid("e2abb890-4080-49bc-aee9-6dc074275713"), new Guid("ca9cb851-4a6f-4f10-877e-3a51c91fd73d"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("2ebe3575-d42e-4baa-b5f4-449d403031c9"), new Guid("4e001cb3-527e-4341-804d-8102c8ec0fc0") },
                    { new Guid("2ebe3575-d42e-4baa-b5f4-449d403031c9"), new Guid("d41de196-10d7-4592-a757-138c860cc5ac") },
                    { new Guid("e2abb890-4080-49bc-aee9-6dc074275713"), new Guid("81c8486c-ac4c-46a5-b4da-2f0b11f583db") }
                });
        }
    }
}
