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

    }
    public class _Response_stats
    {

    }
}
