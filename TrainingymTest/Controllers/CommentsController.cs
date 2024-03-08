using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using TrainingymTest.DTOs;

namespace TrainingymTest.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly string apiUrl = "https://jsonplaceholder.typicode.com/comments";

        [HttpGet("most-comment-posts")]
        public async Task<IActionResult> MostCommentPosts()
        {
            var comments = await GetCommentsFromAPI();
            if (comments != null)
            {
                var topPostIds = comments
                    .GroupBy(comment => comment.PostId)
                    .OrderByDescending(group => group.Count())
                    .Take(3)
                    .Select(group => group.Key)
                    .ToList();

                return Ok(topPostIds);
            }
            else
            {
                return BadRequest("Error retrieving comments from the API.");
            }
        }

        private async Task<List<CommentDTO>> GetCommentsFromAPI()
        {
            try
            {
                var client = new RestClient(apiUrl);
                var request = new RestRequest();
                var response = await client.ExecuteAsync(request);
                List<CommentDTO> comments = JsonConvert.DeserializeObject<List<CommentDTO>>(response.Content);
                return comments;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: {ex.Message}");
                return null;
            }
        }

    }
}
