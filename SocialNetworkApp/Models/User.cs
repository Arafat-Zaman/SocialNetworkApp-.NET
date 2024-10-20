namespace SocialNetworkApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  // e.g., Admin, User
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }
    }

}
