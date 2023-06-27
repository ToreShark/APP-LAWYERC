using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "1")]
public class DocumentTemplateController : Controller
{
    private readonly UOW _uow;

    public DocumentTemplateController(UOW uow)
    {
        _uow = uow;
    }

    public async Task<IActionResult> Index()
    {
        var templates = await _uow.DocumentTemplateRepository.ListAllAsync();
        return View(templates);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(DocumentTemplate documentTemplate)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.ErrorMessage));
            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
            return View(documentTemplate);
        }

        Console.WriteLine("Model is valid");
        await _uow.DocumentTemplateRepository.InsertAsync(documentTemplate);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(Guid id)
    {
        Console.WriteLine("Searching for document template with id: " + id);
        var documentTemplate = await _uow.DocumentTemplateRepository.GetByGuidAsync(id);
        if (documentTemplate == null)
        {
            Console.WriteLine("Document template not found");
            return NotFound();
        }

        return View(documentTemplate);
    }

    [HttpPost]
    public async Task<IActionResult> Update(DocumentTemplate documentTemplate)
    {
        if (ModelState.IsValid)
        {
            await _uow.DocumentTemplateRepository.UpdateAsync(documentTemplate);
            return RedirectToAction(nameof(Index));
        }
        return View(documentTemplate);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(Guid id)
    {
        var documentTemplate = await _uow.DocumentTemplateRepository.GetByGuidAsync(id);
        if (documentTemplate == null) return NotFound();
        return View(documentTemplate);
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var documentTemplate = await _uow.DocumentTemplateRepository.GetByGuidAsync(id);
        await _uow.DocumentTemplateRepository.DeleteAsync(documentTemplate);
        return RedirectToAction(nameof(Index));
    }
}