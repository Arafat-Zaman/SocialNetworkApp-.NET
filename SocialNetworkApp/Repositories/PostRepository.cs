using SocialNetworkApp.Data;
using SocialNetworkApp.Models;

namespace SocialNetworkApp.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAllPosts() => _context.Posts.Include(p => p.User).Include(p => p.Comments).Include(p => p.Likes).ToList();

        public Post GetPostById(int id) => _context.Posts.Find(id);

        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            var post = _context.Posts.Find(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                _context.SaveChanges();
            }
        }
    }

}
