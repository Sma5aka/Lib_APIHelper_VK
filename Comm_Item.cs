
namespace vkAPIhelper
{
    public class Comm_Item
    {
        public int id { get; set; }
        public int from_id { get; set; }
        public int date { get; set; }
        public string? text { get; set; }
        public object? donut { get; set; }
        public int reply_to_user { get; set; }
        public int reply_to_post { get; set; }
        public object? attachments { get; set; }
        public Comm_Item[]? parent_stack { get; set; }
        public Thread? thread { get; set; }

    }
}
