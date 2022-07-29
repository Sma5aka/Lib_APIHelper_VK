namespace vkAPIhelper
{
    public class Response_Posts
    {
        public _Response_posts? response { get; set; }
    }
    public class _Response_posts
    {
        public int count { get; set; }
        public List<Post_Item>? items { get; set; }
    }
    public class Response_Stats
    {
        public List<Group_Item>? response { get; set; }
    }
    public class Response_Post
    {
        public List<Post_Item>? response { get; set; }
    }
}
