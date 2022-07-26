using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkAPIhelper
{
    internal interface IAttachment
    {
        int id { get; }
        int owner_id { get; }
        int user_id { get; }
    }

    public class Photo : Attachment
    {
        public int id { get; set; }
        public int owner_id { get; set; }
        public int user_id { get; set; }
        public int album_id { get; set; }
        public string? text { get; set; }
        public int date { get; set; }
        public Photo_Sizes[] sizes { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    public class Photo_Sizes
    {
        public string type { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    public class Attachment
    {
        public string? type { get; set; }
        public Photo photo { get; set; }
        public object posted_photo { get; set; }
        public object audio { get; set; }
        public object video { get; set; }
        public object doc { get; set; }
        public object graffiti { get; set; }
        public object link { get; set; }
        public object note { get; set; }
        public object app { get; set; }
        public object poll { get; set; }
        public object page { get; set; }
        public object album { get; set; }
        public string[] photos_list { get; set; }
        public object market { get; set; }
        public object market_album { get; set; }
        public object sticker { get; set; }
        public object pretty_cards { get; set; }
        public object event_ { get; set; }
        
    }
}
