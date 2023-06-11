using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedCatImageSmMd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrlMedium",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrlSmall",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageUrl", "ImageUrlMedium", "ImageUrlSmall", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("02a7730d-5aea-4a7e-a801-160017689f18"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "Административное дело", "administrativnoe-delo" },
                    { new Guid("2f25c773-8242-42bd-a35e-4d627848d799"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "Уголовное дело", "ugolovnoe-delo" },
                    { new Guid("49836997-8210-4607-be17-c764b782f97e"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Гражданское дело", "grazhdanskoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("3b9e74f5-58f6-4434-a13c-110140f2c0ce"), 3 },
                    { new Guid("5fe87ae0-dc10-4668-97f5-9d35c6f5c281"), 1 },
                    { new Guid("b61fe00b-b225-4f5b-afa9-f7bd7bd03dfa"), 4 },
                    { new Guid("c1f684bb-0ed2-4f8f-a3b1-c44612889823"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("2ffb3630-67b6-4860-b3be-f9d9718304c3"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("6a559389-fac1-45f9-9621-abaff543edd2"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("b00850bd-fc54-49aa-93ad-2f93007beae8"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("28609b53-3153-462c-bef1-2798bec16422"), new Guid("2f25c773-8242-42bd-a35e-4d627848d799"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" },
                    { new Guid("4c46293b-b021-4a40-9bc6-97f62e440820"), new Guid("2f25c773-8242-42bd-a35e-4d627848d799"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("28609b53-3153-462c-bef1-2798bec16422"), new Guid("2ffb3630-67b6-4860-b3be-f9d9718304c3") },
                    { new Guid("28609b53-3153-462c-bef1-2798bec16422"), new Guid("b00850bd-fc54-49aa-93ad-2f93007beae8") },
                    { new Guid("4c46293b-b021-4a40-9bc6-97f62e440820"), new Guid("6a559389-fac1-45f9-9621-abaff543edd2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02a7730d-5aea-4a7e-a801-160017689f18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49836997-8210-4607-be17-c764b782f97e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3b9e74f5-58f6-4434-a13c-110140f2c0ce"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5fe87ae0-dc10-4668-97f5-9d35c6f5c281"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b61fe00b-b225-4f5b-afa9-f7bd7bd03dfa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c1f684bb-0ed2-4f8f-a3b1-c44612889823"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("28609b53-3153-462c-bef1-2798bec16422"), new Guid("2ffb3630-67b6-4860-b3be-f9d9718304c3") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("28609b53-3153-462c-bef1-2798bec16422"), new Guid("b00850bd-fc54-49aa-93ad-2f93007beae8") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("4c46293b-b021-4a40-9bc6-97f62e440820"), new Guid("6a559389-fac1-45f9-9621-abaff543edd2") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("28609b53-3153-462c-bef1-2798bec16422"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("4c46293b-b021-4a40-9bc6-97f62e440820"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("2ffb3630-67b6-4860-b3be-f9d9718304c3"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("6a559389-fac1-45f9-9621-abaff543edd2"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("b00850bd-fc54-49aa-93ad-2f93007beae8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f25c773-8242-42bd-a35e-4d627848d799"));

            migrationBuilder.DropColumn(
                name: "ImageUrlMedium",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ImageUrlSmall",
                table: "Categories");

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
    }
}
