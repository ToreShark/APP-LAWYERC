using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using APP_LAWYER.BLL;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers
{
    public class RobotsController : Controller
    {
        private readonly UOW _uow;
        public RobotsController(UOW uow)
        {
            _uow = uow;
        }
        [Route("/robots.txt")]
        public IActionResult RobotTxt()
        {
            var sb = new StringBuilder();
            sb.AppendLine("User-agent: *");
            sb.AppendLine("Disallow: ''");
            sb.AppendLine($"Sitemap: {Request.Scheme}://{Request.Host}/sitemap.xml");
            return Content(sb.ToString(), "text/plain", Encoding.UTF8);
        }

        [Route("/sitemap.xml")]
        public async Task SitemapXml()
        {
            var host = "https://primelegal.kz/";

            Response.ContentType = "application/xml";
            var memoryStream = new MemoryStream();
            using (var xml = XmlWriter.Create(memoryStream, new XmlWriterSettings { Indent = true }))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("urlset", "http://www.sitemaps.org/schemas/sitemap/0.9");

                var categories = await _uow.CategoriRepository.ListAllAsync();

                foreach (var category in categories)
                {
                    var subcategories = await _uow.SubcategoryRepository.GetSubcategoriesForCategory(category.Id);

                    foreach (var subcategory in subcategories)
                    {
                        xml.WriteStartElement("url");
                        xml.WriteElementString("loc", host + "Subcategory?slug=" + subcategory.Slug);
                        xml.WriteEndElement();
                    }
                }

                xml.WriteEndElement();
            }

            memoryStream.Position = 0;
            await memoryStream.CopyToAsync(Response.Body);
        }
    }
}