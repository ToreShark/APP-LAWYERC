using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using APP_LAWYER.BLL;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers
{
    public class RssController : Controller
    {
        private readonly UOW _uow;
        public RssController(UOW uow)
        {
            _uow = uow;
        }
        [Route("/rss.xml")]
        public async Task RssXml()
        {
            var host = "https://primelegal.kz/";

            Response.ContentType = "application/xml";
            var memoryStream = new MemoryStream();
            using (var xml = XmlWriter.Create(memoryStream, new XmlWriterSettings { Indent = true }))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("rss");
                xml.WriteAttributeString("xmlns", "turbo", null, "http://turbo.yandex.ru");
                xml.WriteStartElement("channel");
                xml.WriteElementString("title", "Prime Legal");
                xml.WriteElementString("link", host);
                xml.WriteElementString("description", "Prime Legal");
                xml.WriteElementString("language", "ru");

                var categories = await _uow.CategoriRepository.ListAllAsync();

                foreach (var category in categories)
                {
                    var subcategories = await _uow.SubcategoryRepository.GetSubcategoriesForCategory(category.Id);

                    foreach (var subcategory in subcategories)
                    {
                        xml.WriteStartElement("item");
                        xml.WriteAttributeString("turbo", "true");
                        xml.WriteAttributeString("xmlns", "turbo", null, "http://turbo.yandex.ru");
                        xml.WriteElementString("title", subcategory.Name);
                        xml.WriteElementString("link", host + "Subcategory?slug=" + subcategory.Slug);
                        xml.WriteStartElement("turbo", "content", null);
                        xml.WriteCData(subcategory.Description);
                        xml.WriteEndElement();
                        // xml.WriteElementString("pubDate", subcategory.CreatedAt.ToString("R"));
                        xml.WriteEndElement();
                    }
                }
                xml.WriteEndElement();
                xml.WriteEndElement();
            }
            memoryStream.Position = 0;
            await memoryStream.CopyToAsync(Response.Body);
        }
    }
}