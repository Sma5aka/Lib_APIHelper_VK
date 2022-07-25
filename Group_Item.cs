namespace vkAPIhelper
{
    public class Group_Item
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? screen_name { get; set; }
        public int is_closed { get; set; }
        public string? deactivated { get; set; }
        public int is_admin { get; set; }
        public int admin_level { get; set; }
        public int is_member { get; set; }
        public int is_advertised { get; set; }
        public int invited_by { get; set; }
        public string? type { get; set; }
        public string? photo_50 { get; set; }
        public string? photo_100 { get; set; }
        public string? photo_200 { get; set; }
        public int members_count { get; set; }
        public string? description { get; set; }
        public string? activity { get; set; }
    }
}
