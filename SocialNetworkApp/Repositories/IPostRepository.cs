using SocialNetworkApp.Models;

namespace SocialNetworkApp.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
    }

}
