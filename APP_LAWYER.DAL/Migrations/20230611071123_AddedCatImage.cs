using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedCatImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08e6b94c-619a-41a8-a7e9-82525cd0800a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45b258cd-0156-45d6-a6e5-c98800f25dfa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00512e8f-9f2e-4782-900b-b776984584f8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab7f0d21-5261-479f-bb34-2242726cf9ab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b5f616d2-d8dd-4839-a352-43226140014d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ba213d7c-7f28-4957-b398-d4fc6b247c10"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("9d947f1e-c608-458f-a25a-0cb6aea93831"), new Guid("4faba2ef-d0b5-4c14-979e-8f9d58189e3a") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("9f2589ec-4eaf-4d40-96d0-046e67b7b825"), new Guid("271b9621-2248-43d9-8135-9cb78d2e5395") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("9f2589ec-4eaf-4d40-96d0-046e67b7b825"), new Guid("337beb77-5ca4-413f-9c35-f531c611ac93") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9d947f1e-c608-458f-a25a-0cb6aea93831"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("9f2589ec-4eaf-4d40-96d0-046e67b7b825"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("271b9621-2248-43d9-8135-9cb78d2e5395"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("337beb77-5ca4-413f-9c35-f531c611ac93"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("4faba2ef-d0b5-4c14-979e-8f9d58189e3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa6c440c-e1a1-4b6a-a779-d9dd6204a284"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("11ff3335-3d07-40fd-b3d4-74e036047c14"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "Уголовное дело", "ugolovnoe-delo" },
                    { new Guid("9fb0a681-a45f-4813-b9c2-dc098dcc3929"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "Административное дело", "administrativnoe-delo" },
                    { new Guid("b085b83d-1ba6-490e-ac2a-9ace36da76dd"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Гражданское дело", "grazhdanskoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("2a579768-9dad-4ba7-9f31-1545411f2b2d"), 1 },
                    { new Guid("87761a9c-3739-4e35-a6a0-f2b51a12ecef"), 4 },
                    { new Guid("99b5c23a-1818-49f7-85a4-44ac9dfbb236"), 3 },
                    { new Guid("ccf3ce0f-2345-4300-8b39-65eba6aaa5a2"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("0050e04f-ec23-4f03-b624-802fba2780e9"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("c923d930-5804-4a12-a3b1-b6e00dd98a6e"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("dd8b821f-436b-4f5c-af9e-82b779adf269"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("1663c5e1-2da1-48a9-add4-29e075d22e15"), new Guid("11ff3335-3d07-40fd-b3d4-74e036047c14"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" },
                    { new Guid("e2104ac9-72cf-44f1-8ff0-d58b44774302"), new Guid("11ff3335-3d07-40fd-b3d4-74e036047c14"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("1663c5e1-2da1-48a9-add4-29e075d22e15"), new Guid("c923d930-5804-4a12-a3b1-b6e00dd98a6e") },
                    { new Guid("e2104ac9-72cf-44f1-8ff0-d58b44774302"), new Guid("0050e04f-ec23-4f03-b624-802fba2780e9") },
                    { new Guid("e2104ac9-72cf-44f1-8ff0-d58b44774302"), new Guid("dd8b821f-436b-4f5c-af9e-82b779adf269") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9fb0a681-a45f-4813-b9c2-dc098dcc3929"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b085b83d-1ba6-490e-ac2a-9ace36da76dd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2a579768-9dad-4ba7-9f31-1545411f2b2d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("87761a9c-3739-4e35-a6a0-f2b51a12ecef"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("99b5c23a-1818-49f7-85a4-44ac9dfbb236"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ccf3ce0f-2345-4300-8b39-65eba6aaa5a2"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("1663c5e1-2da1-48a9-add4-29e075d22e15"), new Guid("c923d930-5804-4a12-a3b1-b6e00dd98a6e") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("e2104ac9-72cf-44f1-8ff0-d58b44774302"), new Guid("0050e04f-ec23-4f03-b624-802fba2780e9") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("e2104ac9-72cf-44f1-8ff0-d58b44774302"), new Guid("dd8b821f-436b-4f5c-af9e-82b779adf269") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("1663c5e1-2da1-48a9-add4-29e075d22e15"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("e2104ac9-72cf-44f1-8ff0-d58b44774302"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("0050e04f-ec23-4f03-b624-802fba2780e9"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("c923d930-5804-4a12-a3b1-b6e00dd98a6e"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("dd8b821f-436b-4f5c-af9e-82b779adf269"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11ff3335-3d07-40fd-b3d4-74e036047c14"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("08e6b94c-619a-41a8-a7e9-82525cd0800a"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" },
                    { new Guid("45b258cd-0156-45d6-a6e5-c98800f25dfa"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" },
                    { new Guid("aa6c440c-e1a1-4b6a-a779-d9dd6204a284"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("00512e8f-9f2e-4782-900b-b776984584f8"), 1 },
                    { new Guid("ab7f0d21-5261-479f-bb34-2242726cf9ab"), 3 },
                    { new Guid("b5f616d2-d8dd-4839-a352-43226140014d"), 4 },
                    { new Guid("ba213d7c-7f28-4957-b398-d4fc6b247c10"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("271b9621-2248-43d9-8135-9cb78d2e5395"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("337beb77-5ca4-413f-9c35-f531c611ac93"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("4faba2ef-d0b5-4c14-979e-8f9d58189e3a"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("9d947f1e-c608-458f-a25a-0cb6aea93831"), new Guid("aa6c440c-e1a1-4b6a-a779-d9dd6204a284"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" },
                    { new Guid("9f2589ec-4eaf-4d40-96d0-046e67b7b825"), new Guid("aa6c440c-e1a1-4b6a-a779-d9dd6204a284"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("9d947f1e-c608-458f-a25a-0cb6aea93831"), new Guid("4faba2ef-d0b5-4c14-979e-8f9d58189e3a") },
                    { new Guid("9f2589ec-4eaf-4d40-96d0-046e67b7b825"), new Guid("271b9621-2248-43d9-8135-9cb78d2e5395") },
                    { new Guid("9f2589ec-4eaf-4d40-96d0-046e67b7b825"), new Guid("337beb77-5ca4-413f-9c35-f531c611ac93") }
                });
        }
    }
}
