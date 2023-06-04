using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedDocTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66f8eb0e-46cb-4ef2-bc7b-38e18400f71d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8cdc4161-60a0-4b91-978b-b776f16d90b0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4aa35355-76a9-4ba1-b6c0-4c613e4ebba8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68c2afab-ed0c-4d48-83c8-3ddbd8cc4389"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6e6a9257-f100-4969-a64a-aed781a50ced"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bfc57fc1-fecb-496e-bfcf-2134cc3fc1e8"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("571ef634-cc1b-4158-9590-eb4d4f3b2d34"), new Guid("4144d776-25d2-414b-a7e6-80fc20af635b") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("7c3e1f30-5094-4b56-89b4-a07f9a0145a4"), new Guid("21205da9-7952-4635-ba2d-8cb59b3d586c") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("7c3e1f30-5094-4b56-89b4-a07f9a0145a4"), new Guid("2c7e9275-0e69-41ce-ae41-2041fe2ac6d2") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("571ef634-cc1b-4158-9590-eb4d4f3b2d34"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7c3e1f30-5094-4b56-89b4-a07f9a0145a4"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("21205da9-7952-4635-ba2d-8cb59b3d586c"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("2c7e9275-0e69-41ce-ae41-2041fe2ac6d2"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("4144d776-25d2-414b-a7e6-80fc20af635b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("168c38c8-8955-4abc-a597-3c6c2de66e92"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("168c38c8-8955-4abc-a597-3c6c2de66e92"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" },
                    { new Guid("66f8eb0e-46cb-4ef2-bc7b-38e18400f71d"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" },
                    { new Guid("8cdc4161-60a0-4b91-978b-b776f16d90b0"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("4aa35355-76a9-4ba1-b6c0-4c613e4ebba8"), 3 },
                    { new Guid("68c2afab-ed0c-4d48-83c8-3ddbd8cc4389"), 1 },
                    { new Guid("6e6a9257-f100-4969-a64a-aed781a50ced"), 4 },
                    { new Guid("bfc57fc1-fecb-496e-bfcf-2134cc3fc1e8"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("21205da9-7952-4635-ba2d-8cb59b3d586c"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("2c7e9275-0e69-41ce-ae41-2041fe2ac6d2"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("4144d776-25d2-414b-a7e6-80fc20af635b"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("571ef634-cc1b-4158-9590-eb4d4f3b2d34"), new Guid("168c38c8-8955-4abc-a597-3c6c2de66e92"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" },
                    { new Guid("7c3e1f30-5094-4b56-89b4-a07f9a0145a4"), new Guid("168c38c8-8955-4abc-a597-3c6c2de66e92"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("571ef634-cc1b-4158-9590-eb4d4f3b2d34"), new Guid("4144d776-25d2-414b-a7e6-80fc20af635b") },
                    { new Guid("7c3e1f30-5094-4b56-89b4-a07f9a0145a4"), new Guid("21205da9-7952-4635-ba2d-8cb59b3d586c") },
                    { new Guid("7c3e1f30-5094-4b56-89b4-a07f9a0145a4"), new Guid("2c7e9275-0e69-41ce-ae41-2041fe2ac6d2") }
                });
        }
    }
}
