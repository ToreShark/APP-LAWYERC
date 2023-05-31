using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APP_LAWYER.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSubCategorySeedsAdmCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab0ff61b-b423-4ec3-84f4-23c649c442b6"));

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 2, new Guid("b22c84cf-4b8e-4374-8b4e-ec7136185fc3") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 1, new Guid("c25aacd8-001d-4610-97d5-6cd01ea20866") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 2, new Guid("c25aacd8-001d-4610-97d5-6cd01ea20866") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 1, new Guid("eeac93a3-df42-4c95-bf9b-86a02d310a61") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 1, new Guid("fcc26a14-8c43-47f1-8d73-a02b6ff1cc4f") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("b22c84cf-4b8e-4374-8b4e-ec7136185fc3"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c25aacd8-001d-4610-97d5-6cd01ea20866"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("eeac93a3-df42-4c95-bf9b-86a02d310a61"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("fcc26a14-8c43-47f1-8d73-a02b6ff1cc4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5685ff16-2c4f-4e7c-ac20-4e59476007b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c52e228d-80bf-4e80-a434-73688cfa3efd"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("09cff8da-6fbc-408b-8bec-02baaf93b522"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" },
                    { new Guid("54c8dda7-aa81-44b6-a60f-96e0173d171f"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" },
                    { new Guid("604de7bb-0c41-4d55-9495-2af14c7d263e"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("168a0c72-b7d9-4752-9dd0-470201d8b8f6"), new Guid("09cff8da-6fbc-408b-8bec-02baaf93b522"), "Краткое описание иска о взыскании в твердой денежной сумме", "Видеоурок и образец иска о взыскании в твердой денежной сумме", "https://plus.unsplash.com/premium_photo-1664355810344-6f8131758d11?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=2942&q=80", "Иск о взыскании алиментов", "isk-o-vzyiskanii-alimentov" },
                    { new Guid("5ada59fa-82f7-4a2d-8ac5-bdf7b03bfd5d"), new Guid("604de7bb-0c41-4d55-9495-2af14c7d263e"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" },
                    { new Guid("88e3ed0f-56fd-484b-aa3e-41fc67fd681d"), new Guid("09cff8da-6fbc-408b-8bec-02baaf93b522"), "Краткое описание иска о взыскании в твердой денежной сумме", "Видеоурок и образец иска о взыскании в твердой денежной сумме", "https://plus.unsplash.com/premium_photo-1664355810344-6f8131758d11?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=2942&q=80", "Иск о взыскании алиментов в твердой денежной сумме", "isk-o-vzyiskanii-v-tverdoy-deneyshnoy-summe" },
                    { new Guid("98106d76-2b9d-44c1-98fa-f2a01dc885aa"), new Guid("604de7bb-0c41-4d55-9495-2af14c7d263e"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" },
                    { new Guid("c3950485-a892-4e17-bbd3-cc3e8c45f4cb"), new Guid("54c8dda7-aa81-44b6-a60f-96e0173d171f"), "Краткое описание состава ДТП и особенности расследования таких дел", "Краткое описание состава ДТП", "https://images.unsplash.com/photo-1573068111653-f18bef611c8a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1374&q=80", "ДТП", "dtp" }
                });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "Id", "SubcategoryId", "Description", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("168a0c72-b7d9-4752-9dd0-470201d8b8f6"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { 2, new Guid("168a0c72-b7d9-4752-9dd0-470201d8b8f6"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/1VxXyBo62yM" },
                    { 1, new Guid("5ada59fa-82f7-4a2d-8ac5-bdf7b03bfd5d"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { 1, new Guid("88e3ed0f-56fd-484b-aa3e-41fc67fd681d"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { 2, new Guid("98106d76-2b9d-44c1-98fa-f2a01dc885aa"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { 1, new Guid("c3950485-a892-4e17-bbd3-cc3e8c45f4cb"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 1, new Guid("168a0c72-b7d9-4752-9dd0-470201d8b8f6") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 2, new Guid("168a0c72-b7d9-4752-9dd0-470201d8b8f6") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 1, new Guid("5ada59fa-82f7-4a2d-8ac5-bdf7b03bfd5d") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 1, new Guid("88e3ed0f-56fd-484b-aa3e-41fc67fd681d") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 2, new Guid("98106d76-2b9d-44c1-98fa-f2a01dc885aa") });

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumns: new[] { "Id", "SubcategoryId" },
                keyValues: new object[] { 1, new Guid("c3950485-a892-4e17-bbd3-cc3e8c45f4cb") });

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("168a0c72-b7d9-4752-9dd0-470201d8b8f6"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5ada59fa-82f7-4a2d-8ac5-bdf7b03bfd5d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("88e3ed0f-56fd-484b-aa3e-41fc67fd681d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("98106d76-2b9d-44c1-98fa-f2a01dc885aa"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("c3950485-a892-4e17-bbd3-cc3e8c45f4cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09cff8da-6fbc-408b-8bec-02baaf93b522"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54c8dda7-aa81-44b6-a60f-96e0173d171f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("604de7bb-0c41-4d55-9495-2af14c7d263e"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("5685ff16-2c4f-4e7c-ac20-4e59476007b8"), "Категория 'Гражданское дело' на нашем юридическом сайте предоставляет все необходимые инструменты для успешного решения ваших гражданских проблем.", "Гражданское дело", "grazhdanskoe-delo" },
                    { new Guid("ab0ff61b-b423-4ec3-84f4-23c649c442b6"), "Категория 'Административное дело' на нашем юридическом сайте предоставляет важную информацию для тех, кто столкнулся с административными проблемами.", "Административное дело", "administrativnoe-delo" },
                    { new Guid("c52e228d-80bf-4e80-a434-73688cfa3efd"), "Категория 'Уголовное дело' на нашем юридическом сайте предназначена для тех, кто ищет надежную поддержку в разбирательствах с законом.", "Уголовное дело", "ugolovnoe-delo" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Content", "Description", "Image", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("b22c84cf-4b8e-4374-8b4e-ec7136185fc3"), new Guid("c52e228d-80bf-4e80-a434-73688cfa3efd"), "Краткое описание состава убийства по неосторожности и особенности расследования таких дел", "Описание убийства по неосторожности", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство по неосторожности", "ubiystvo-po-neostorozhnosti" },
                    { new Guid("c25aacd8-001d-4610-97d5-6cd01ea20866"), new Guid("5685ff16-2c4f-4e7c-ac20-4e59476007b8"), "Краткое описание иска о взыскании в твердой денежной сумме", "Видеоурок и образец иска о взыскании в твердой денежной сумме", "https://plus.unsplash.com/premium_photo-1664355810344-6f8131758d11?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=2942&q=80", "Иск о взыскании алиментов", "isk-o-vzyiskanii-alimentov" },
                    { new Guid("eeac93a3-df42-4c95-bf9b-86a02d310a61"), new Guid("5685ff16-2c4f-4e7c-ac20-4e59476007b8"), "Краткое описание иска о взыскании в твердой денежной сумме", "Видеоурок и образец иска о взыскании в твердой денежной сумме", "https://plus.unsplash.com/premium_photo-1664355810344-6f8131758d11?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=2942&q=80", "Иск о взыскании алиментов в твердой денежной сумме", "isk-o-vzyiskanii-v-tverdoy-deneyshnoy-summe" },
                    { new Guid("fcc26a14-8c43-47f1-8d73-a02b6ff1cc4f"), new Guid("c52e228d-80bf-4e80-a434-73688cfa3efd"), "Краткое описание состава убийства и особенности расследования таких дел", "Описание убийства", "https://plus.unsplash.com/premium_photo-1661714112996-c782972c03e7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWgelFyX8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80", "Убийство", "ubiystvo" }
                });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "Id", "SubcategoryId", "Description", "Url" },
                values: new object[,]
                {
                    { 2, new Guid("b22c84cf-4b8e-4374-8b4e-ec7136185fc3"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { 1, new Guid("c25aacd8-001d-4610-97d5-6cd01ea20866"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { 2, new Guid("c25aacd8-001d-4610-97d5-6cd01ea20866"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/1VxXyBo62yM" },
                    { 1, new Guid("eeac93a3-df42-4c95-bf9b-86a02d310a61"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" },
                    { 1, new Guid("fcc26a14-8c43-47f1-8d73-a02b6ff1cc4f"), "<div class='App' style='text-align: center;'><h1>Заявление</h1><p>от [name]</p><p>для [nameFor]</p><p><a href='https://github.com/remarkablemark/html-react-parser' target='_blank' rel='noopener noreferrer'>View GitHub repository</a></p><hr class='remove'></div>", "https://youtu.be/AmUenqhE1mw" }
                });
        }
    }
}
