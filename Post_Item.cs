namespace vkAPIhelper
{
    public class Post_Item
    {
        public int id { get; set; }
        public int from_id { get; set; }
        public int created_id { get; set; }
        public int date { get; set; }
        public int marked_as_ads { get; set; }
        public string text { get; set; }
        public int reply_owner_id { get; set; }
        public int reply_post_id { get; set; }
        public int friends_only{ get; set; }
        public Comm_Item comments { get; set; }
        public object copyright { get; set; }
        public Likes likes { get; set; }
        public Reposts reposts { get; set; }
        public Views views { get; set; }
        public object post_source { get; set; }
        public string post_type { get; set; }
        public object[] attachments { get; set; }
        public Geo geo { get; set; }
        public int signer_id { get; set; }
        public int can_pin { get; set; }
        public int can_delete { get; set; }
        public int can_edit { get; set; }
        public int is_pinnned { get; set; }
        public bool is_favorite { get; set; }
        public object donut { get; set; }
        public int postponed_id { get; set; }
    }
}
