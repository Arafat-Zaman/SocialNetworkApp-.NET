namespace SocialNetworkApp.DTOs
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }  // Include author's username
    }

}
