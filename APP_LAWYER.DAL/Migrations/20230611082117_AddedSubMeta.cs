using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedSubMeta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Subcategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "Subcategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle",
                table: "Subcategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageUrl", "ImageUrlMedium", "ImageUrlSmall", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("3820555b-938c-4383-87d9-9f84a540139b"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "https://images.pexels.com/photos/4792282/pexels-photo-4792282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", "Гражданское дело", "grazhdanskoe-delo" },
                    { new Guid("5e675feb-47d3-4729-a470-ad3308984a5f"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1479142506502-19b3a3b7ff33?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "Уголовное дело", "ugolovnoe-delo" },
                    { new Guid("d9fbc216-e429-4755-a69c-85c88a5573ca"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "https://images.unsplash.com/photo-1608657872827-9fbdb711bdc4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80", "Административное дело", "administrativnoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("8d4944bb-7d30-4fec-9660-d5f44b7e1118"), 1 },
                    { new Guid("b668e34c-a676-49b3-8e3e-bd2ba4350786"), 3 },
                    { new Guid("b78f0be8-0c02-40f6-b11c-773dd8c6704b"), 4 },
                    { new Guid("bc4a3b11-e907-4b73-9127-d585054b12b8"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Url" },
                values: new object[,]
                {
                    { new Guid("0c73d569-6c55-499d-84ab-46b5605a5709"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("bbce1bfa-adb8-466c-b243-ff8a74780e6e"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { new Guid("fbd181a3-2bff-42e5-af87-b82e0a623d57"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "MetaDescription", "MetaKeywords", "MetaTitle", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("592f3ed8-ecf0-4e04-8493-ecf3f6bede72"), new Guid("5e675feb-47d3-4729-a470-ad3308984a5f"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://images.unsplash.com/photo-1605806616949-1e87b487fc2f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Описание убийства по неосторожности в контексте уголовного дела: состав, особенности расследования и подробности события", "убийство по неосторожности, уголовное дело, расследование, уголовное право", "Убийство по неосторожности: Категория уголовного дела и расследование", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" },
                    { new Guid("855ad3a6-718f-4cd0-914e-73e95223566b"), new Guid("5e675feb-47d3-4729-a470-ad3308984a5f"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Описание убийства в контексте уголовного дела: состав, особенности расследования и подробности события", "убийство, уголовное дело, расследование, уголовное право", "Убийство: Категория уголовного дела и особенности расследования", "Убийство", "ubiystvo" }
                });

            migrationBuilder.InsertData(
                table: "SubcategoryVideos",
                columns: new[] { "SubcategoryId", "VideoId" },
                values: new object[,]
                {
                    { new Guid("592f3ed8-ecf0-4e04-8493-ecf3f6bede72"), new Guid("bbce1bfa-adb8-466c-b243-ff8a74780e6e") },
                    { new Guid("592f3ed8-ecf0-4e04-8493-ecf3f6bede72"), new Guid("fbd181a3-2bff-42e5-af87-b82e0a623d57") },
                    { new Guid("855ad3a6-718f-4cd0-914e-73e95223566b"), new Guid("0c73d569-6c55-499d-84ab-46b5605a5709") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3820555b-938c-4383-87d9-9f84a540139b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9fbc216-e429-4755-a69c-85c88a5573ca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d4944bb-7d30-4fec-9660-d5f44b7e1118"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b668e34c-a676-49b3-8e3e-bd2ba4350786"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b78f0be8-0c02-40f6-b11c-773dd8c6704b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bc4a3b11-e907-4b73-9127-d585054b12b8"));

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("592f3ed8-ecf0-4e04-8493-ecf3f6bede72"), new Guid("bbce1bfa-adb8-466c-b243-ff8a74780e6e") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("592f3ed8-ecf0-4e04-8493-ecf3f6bede72"), new Guid("fbd181a3-2bff-42e5-af87-b82e0a623d57") });

            migrationBuilder.DeleteData(
                table: "SubcategoryVideos",
                keyColumns: new[] { "SubcategoryId", "VideoId" },
                keyValues: new object[] { new Guid("855ad3a6-718f-4cd0-914e-73e95223566b"), new Guid("0c73d569-6c55-499d-84ab-46b5605a5709") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("592f3ed8-ecf0-4e04-8493-ecf3f6bede72"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("855ad3a6-718f-4cd0-914e-73e95223566b"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("0c73d569-6c55-499d-84ab-46b5605a5709"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("bbce1bfa-adb8-466c-b243-ff8a74780e6e"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("fbd181a3-2bff-42e5-af87-b82e0a623d57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e675feb-47d3-4729-a470-ad3308984a5f"));

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Subcategories");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "Subcategories");

            migrationBuilder.DropColumn(
                name: "MetaTitle",
                table: "Subcategories");

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
    }
}
