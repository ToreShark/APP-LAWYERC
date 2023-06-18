using System.Security.Claims;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers;

public class CommentController : Controller
{
    private readonly UOW _uow;

    public CommentController(UOW uow)
    {
        _uow = uow;
    }

    public async Task<IActionResult> Index(Guid id)
    {
        var comments = await _uow.CommentRepository.GetByCommentIdAsync(id);
        return View(comments);
    }

    public IActionResult Comment()
    {
        var model = new CommentViewModel();
        // Заполняйте модель здесь
        return View(model);
    }

    [HttpPost]
    public async Task<ActionResult> Create(CommentViewModel model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null) return BadRequest("User claim not found.");

        var userId = Guid.Parse(userIdClaim.Value);

        var comment = new Comment
        {
            Content = model.Content,
            SubcategoryId = model.SubcategoryId,
            UserId = userId,
            CreatedAt = DateTime.UtcNow
            // Assign other fields as necessary
        };
        await _uow.CommentRepository.InsertAsync(comment);

        // Redirect back to the same subcategory page after creating the comment.
        return Json(comment);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(Guid id, [FromBody] Comment comment)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var existingComment = await _uow.CommentRepository.GetByGuidAsync(id);

        if (existingComment == null) return NotFound();

        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null) return BadRequest("User claim not found.");

        var userId = Guid.Parse(userIdClaim.Value);

        // Check if the current user is the author of the comment
        if (existingComment.UserId != userId) return Forbid("You are not the author of this comment.");

        // Map the updated fields to the existing comment
        existingComment.Content = comment.Content;
        // Add other fields to be updated

        await _uow.CommentRepository.UpdateAsync(existingComment);
        return Ok();
    }
}