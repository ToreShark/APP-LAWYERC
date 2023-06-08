using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers
{
    public class ReplyController : Controller
    {
        private readonly UOW _uow;

        public ReplyController(UOW uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index(Guid commentId)
        {
            var replies = await _uow.ReplyRepository.GetByCommentIdAsync(commentId);
            return View(replies);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReplyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
            {
                return BadRequest("User claim not found.");
            }

            var userId = Guid.Parse(userIdClaim.Value);

            var reply = new Reply
            {
                Text = model.Text,
                CommentId = model.CommentId, // This is now a Guid
                UserId = userId
                // Assign other fields as necessary
            };

            await _uow.ReplyRepository.InsertAsync(reply);

            // Redirect back to the same comment page after creating the reply.
            // return RedirectToAction("Index", "Comment", new { id = model.CommentId });
            return Json(new { success = true, reply = reply });
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, [FromBody] Reply reply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingReply = await _uow.ReplyRepository.GetByGuidAsync(id);

            if (existingReply == null)
            {
                return NotFound();
            }

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
            {
                return BadRequest("User claim not found.");
            }

            var userId = Guid.Parse(userIdClaim.Value);

            // Check if the current user is the author of the reply
            if (existingReply.UserId != userId)
            {
                return Forbid("You are not the author of this reply.");
            }

            // Map the updated fields to the existing reply
            existingReply.Text = reply.Text;
            // Add other fields to be updated

            await _uow.ReplyRepository.UpdateAsync(existingReply);
            return Ok();
        }
    }
}