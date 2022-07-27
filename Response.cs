namespace vkAPIhelper
{
    public class Response_Posts
    {
        public _Response_posts? response { get; set; }
    }
    public class _Response_posts
    {
        public int count { get; set; }
        public Post_Item[]? items { get; set; }
    }
    public class Response_Stats
    {
        public Group_Item[]? response { get; set; }
    }
    public class Response_Post
    {
        public Post_Item[]? response { get; set; }
    }
}
