using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UOW _uow;

        public UserController(UOW uow)
        {
            _uow = uow;
        }
       
        public async Task<IActionResult> Index()
        {
            return View(await _uow.DocumentRepository.ListAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var documentTemplates = await _uow.DocumentTemplateRepository.ListAllAsync(); // Измените на ваш метод для получения всех шаблонов документов
            return View(documentTemplates);
        }

        private async Task<string> GenerateContentAsync(Guid templateId, Guid userId)
        {
            User user = await _uow.UserRepository.GetByGuidAsync(userId);
            DocumentTemplate template = await _uow.DocumentTemplateRepository.GetByGuidAsync(templateId);

            if (user == null || template == null)
            {
                return null;
            }
            string content = $"{template.Title}\n\n{template.Description}";
            return content;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDocumentForUser(Guid templateId, string documentContent)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            Console.WriteLine($"User ID Claim: {userIdClaim}");
            if (userIdClaim == null)
            {
                return BadRequest("User claim not found.");
            }
            var userId = Guid.Parse(userIdClaim.Value);
            Console.WriteLine($"User ID: {userId}");

            User user = await _uow.UserRepository.GetByGuidAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            DocumentTemplate documentTemplate = await _uow.DocumentTemplateRepository.GetByGuidAsync(templateId);
            if (documentTemplate == null)
            {
                return NotFound();
            }
            string generatedDocumentContent = await GenerateContentAsync(templateId, userId);
            if (generatedDocumentContent == null)
            {
                return BadRequest("Could not generate document content.");
            }
            var document = new DocumentEntity
            {
                UserId = userId,
                Name = documentTemplate.Title,
                Description = documentContent,
                // Fill in other fields as necessary...
            };
            // Insert the new document into the DocumentEntityRepository
            await _uow.DocumentRepository.InsertAsync(document);

            // Save changes to the database
            // await _uow.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}