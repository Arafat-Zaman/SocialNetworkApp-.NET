using Microsoft.AspNetCore.Mvc;
using SocialNetworkApp.Models;
using SocialNetworkApp.Repositories;

namespace SocialNetworkApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public IActionResult GetAllPosts() => Ok(_postRepository.GetAllPosts());

        [HttpGet("{id}")]
        public IActionResult GetPostById(int id) => Ok(_postRepository.GetPostById(id));

        [HttpPost]
        public IActionResult CreatePost([FromBody] Post post)
        {
            _postRepository.AddPost(post);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePost(int id, [FromBody] Post post)
        {
            _postRepository.UpdatePost(post);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            _postRepository.DeletePost(id);
            return Ok();
        }
    }

}
