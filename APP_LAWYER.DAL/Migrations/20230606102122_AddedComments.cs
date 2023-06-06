using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c0f820a-3943-4678-89f6-8f5ed76a28d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1532549-5362-4161-a9db-ece564bbad67"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3cd465e8-cdb6-496f-b1f0-a97b012aba24"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6cc6f5f6-d632-4704-9639-a0e86726c1ee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a84ae8d3-2b7c-4386-a70b-6a72fe2a7ca5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cf529606-816a-42d6-ad8b-8a539316165a"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("dbb40dc5-58d2-4eec-ba8d-3c179fff6835"), new Guid("20e7061f-a147-423e-a219-e1e81cd06643") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("dbb40dc5-58d2-4eec-ba8d-3c179fff6835"), new Guid("40bf4f19-270a-4d3d-a607-c1f29ba9d34f") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("e4df1c2a-775f-4573-8210-3130a11ae3a4"), new Guid("85223da7-ec7b-4d8f-9cff-caddbd84936c") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("dbb40dc5-58d2-4eec-ba8d-3c179fff6835"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e4df1c2a-775f-4573-8210-3130a11ae3a4"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("20e7061f-a147-423e-a219-e1e81cd06643"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("40bf4f19-270a-4d3d-a607-c1f29ba9d34f"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("85223da7-ec7b-4d8f-9cff-caddbd84936c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1dc7127d-4c86-41f3-af08-4bd145072f69"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("488099d9-00ce-4b90-a473-1ebda1aebcc6"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" },
                    { new Guid("a5205ea6-7d56-4957-bbb9-464fe6e7edab"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" },
                    { new Guid("d6ee0529-70a0-463c-bf54-e072e10634ec"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("37cec8ae-c878-4546-921e-26905b18b65b"), 2 },
                    { new Guid("61278fa0-2fe9-408a-b479-ddbeff40fd90"), 1 },
                    { new Guid("7a822931-4bab-484a-8e7d-e56710be9ef6"), 3 },
                    { new Guid("96d88778-eff2-4906-9b7e-0c577ba94d3b"), 4 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("17dc4922-8eb5-47f1-8b00-e05ab4d07bf2"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("5a119861-5536-45c0-970f-d168b8e5250e"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("741d3ae1-edd0-4c05-80b7-9649ce06c0ef"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("680beae1-3acc-482a-9a54-759a2453e7dd"), new Guid("d6ee0529-70a0-463c-bf54-e072e10634ec"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" },
                    { new Guid("7c307bb6-021b-487e-ac7d-41fc474995c8"), new Guid("d6ee0529-70a0-463c-bf54-e072e10634ec"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("680beae1-3acc-482a-9a54-759a2453e7dd"), new Guid("741d3ae1-edd0-4c05-80b7-9649ce06c0ef") },
                    { new Guid("7c307bb6-021b-487e-ac7d-41fc474995c8"), new Guid("17dc4922-8eb5-47f1-8b00-e05ab4d07bf2") },
                    { new Guid("7c307bb6-021b-487e-ac7d-41fc474995c8"), new Guid("5a119861-5536-45c0-970f-d168b8e5250e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("488099d9-00ce-4b90-a473-1ebda1aebcc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5205ea6-7d56-4957-bbb9-464fe6e7edab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("37cec8ae-c878-4546-921e-26905b18b65b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("61278fa0-2fe9-408a-b479-ddbeff40fd90"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7a822931-4bab-484a-8e7d-e56710be9ef6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("96d88778-eff2-4906-9b7e-0c577ba94d3b"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("680beae1-3acc-482a-9a54-759a2453e7dd"), new Guid("741d3ae1-edd0-4c05-80b7-9649ce06c0ef") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("7c307bb6-021b-487e-ac7d-41fc474995c8"), new Guid("17dc4922-8eb5-47f1-8b00-e05ab4d07bf2") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("7c307bb6-021b-487e-ac7d-41fc474995c8"), new Guid("5a119861-5536-45c0-970f-d168b8e5250e") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("680beae1-3acc-482a-9a54-759a2453e7dd"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("7c307bb6-021b-487e-ac7d-41fc474995c8"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("17dc4922-8eb5-47f1-8b00-e05ab4d07bf2"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("5a119861-5536-45c0-970f-d168b8e5250e"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("741d3ae1-edd0-4c05-80b7-9649ce06c0ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6ee0529-70a0-463c-bf54-e072e10634ec"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("1dc7127d-4c86-41f3-af08-4bd145072f69"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" },
                    { new Guid("8c0f820a-3943-4678-89f6-8f5ed76a28d5"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" },
                    { new Guid("f1532549-5362-4161-a9db-ece564bbad67"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("3cd465e8-cdb6-496f-b1f0-a97b012aba24"), 1 },
                    { new Guid("6cc6f5f6-d632-4704-9639-a0e86726c1ee"), 3 },
                    { new Guid("a84ae8d3-2b7c-4386-a70b-6a72fe2a7ca5"), 4 },
                    { new Guid("cf529606-816a-42d6-ad8b-8a539316165a"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("20e7061f-a147-423e-a219-e1e81cd06643"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("40bf4f19-270a-4d3d-a607-c1f29ba9d34f"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("85223da7-ec7b-4d8f-9cff-caddbd84936c"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("dbb40dc5-58d2-4eec-ba8d-3c179fff6835"), new Guid("1dc7127d-4c86-41f3-af08-4bd145072f69"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" },
                    { new Guid("e4df1c2a-775f-4573-8210-3130a11ae3a4"), new Guid("1dc7127d-4c86-41f3-af08-4bd145072f69"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("dbb40dc5-58d2-4eec-ba8d-3c179fff6835"), new Guid("20e7061f-a147-423e-a219-e1e81cd06643") },
                    { new Guid("dbb40dc5-58d2-4eec-ba8d-3c179fff6835"), new Guid("40bf4f19-270a-4d3d-a607-c1f29ba9d34f") },
                    { new Guid("e4df1c2a-775f-4573-8210-3130a11ae3a4"), new Guid("85223da7-ec7b-4d8f-9cff-caddbd84936c") }
                });
        }
    }
}
