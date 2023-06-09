using System.Security.Claims;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers;

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
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null) return BadRequest("User claim not found.");
        var userId = Guid.Parse(userIdClaim.Value);
        var documents = await _uow.DocumentRepository.ListAllAsync();
        var userDocuments = documents.Where(d => d.UserId == userId);
        return View(userDocuments);
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var documentTemplates =
            await _uow.DocumentTemplateRepository
                .ListAllAsync(); // Измените на ваш метод для получения всех шаблонов документов
        return View(documentTemplates);
    }

    private async Task<string> GenerateContentAsync(Guid templateId, Guid userId)
    {
        var user = await _uow.UserRepository.GetByGuidAsync(userId);
        var template = await _uow.DocumentTemplateRepository.GetByGuidAsync(templateId);

        if (user == null || template == null) return null;
        var content = $"{template.Title}\n\n{template.Description}";
        return content;
    }

    [HttpPost]
    public async Task<IActionResult> CreateDocumentForUser(Guid templateId, string documentContent)
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        Console.WriteLine($"User ID Claim: {userIdClaim}");
        if (userIdClaim == null) return BadRequest("User claim not found.");
        var userId = Guid.Parse(userIdClaim.Value);
        Console.WriteLine($"User ID: {userId}");

        var user = await _uow.UserRepository.GetByGuidAsync(userId);
        if (user == null) return NotFound();

        var documentTemplate = await _uow.DocumentTemplateRepository.GetByGuidAsync(templateId);
        if (documentTemplate == null) return NotFound();
        var generatedDocumentContent = await GenerateContentAsync(templateId, userId);
        if (generatedDocumentContent == null) return BadRequest("Could not generate document content.");
        var document = new DocumentEntity
        {
            UserId = userId,
            Name = documentTemplate.Title,
            Description = documentContent
            // Fill in other fields as necessary...
        };
        // Insert the new document into the DocumentEntityRepository
        await _uow.DocumentRepository.InsertAsync(document);

        // Save changes to the database
        // await _uow.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Update(Guid id)
    {
        var document = await _uow.DocumentRepository.GetByGuidAsync(id);
        if (document == null) return NotFound();
        return View(document);
    }

    [HttpPost]
    public async Task<IActionResult> Update(DocumentEntity document)
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null)
        {
            Console.WriteLine("User claim not found Test Radik.", ClaimTypes.NameIdentifier);
            return BadRequest("User claim not found.");
        }

        var userId = Guid.Parse(userIdClaim.Value);

        // Получить существующий документ из базы данных
        var existingDocument = await _uow.DocumentRepository.GetByGuidAsync(document.Id);
        if (existingDocument == null) return NotFound();

        // Обновите поля существующего документа
        existingDocument.Name = document.Name;
        existingDocument.Description = document.Description;
        // Обновите другие поля по мере необходимости...

        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors) Console.WriteLine("TEST TORE", error.ErrorMessage);
            return View(document);
        }

        // Сохраните обновленный документ
        await _uow.DocumentRepository.UpdateAsync(existingDocument);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        var document = await _uow.DocumentRepository.GetByGuidAsync(id);
        if (document != null) await _uow.DocumentRepository.DeleteAsync(document);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> EditProfile()
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null) return BadRequest("User claim not found.");
        var userId = Guid.Parse(userIdClaim.Value);
        var user = await _uow.UserRepository.GetByGuidAsync(userId);
        if (user == null) return NotFound();
        return View(user);
    }

    [HttpPost]
    public async Task<IActionResult> EditProfile(User model)
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null) return BadRequest("User claim not found.");
        var userId = Guid.Parse(userIdClaim.Value);
        var user = await _uow.UserRepository.GetByGuidAsync(userId);
        if (user == null) return NotFound();
        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.Email = model.Email;
        await _uow.UserRepository.UpdateAsync(user);
        return RedirectToAction("Index");
    }
}