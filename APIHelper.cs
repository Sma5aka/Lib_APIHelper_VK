using Newtonsoft.Json;

namespace vkAPIhelper
{
    public class Views
    {
        public int count { get; set; }
    }
    public class APIHelper
    {
        public string access_token { get; set; } = "undefiend";
        public string api_ver { get; set; } = "5.131";

        private string api_call = "https://api.vk.com/method/";
        public async Task<string> get_posts
            (HttpClient client, string owner_id = "", string domain = "imct_fefu", 
            uint offset = 0, uint count = 100, string filter = "", 
            bool extended = false, string fields = "")
        {
            string paramers = "";
            if (owner_id != null)
            {
                paramers = $"{paramers}&owner_id={owner_id}";
            }
            if (domain != null)
            {
                paramers = $"{paramers}&domain={domain}";
            }
            if (offset != 0)
            {
                paramers = $"{paramers}&offset={offset.ToString()}";
            }
            if (count != 0)
            {
                paramers = $"{paramers}&count={count.ToString()}";
            }
            if (filter != null)
            {
                paramers = $"{paramers}&filter={filter}";
            }
            if (extended)
            {
                paramers = $"{paramers}&extended={1}";
            }
            if (fields != null)
            {
                paramers = $"{paramers}&fields={fields}";
            }

            string request_url = $"{api_call}wall.get?{paramers}&access_token={access_token}&v={api_ver}";

            string response = await client.GetStringAsync(request_url);
            return response;
        }
        public async Task<string> get_stats
            (HttpClient client, string group_ids,
            string group_id="imct_fefu")
        {
            string paramers = "";

            string fields = "members_count,description,activity";

            if (group_ids != null)
            {
                paramers = $"{paramers}&group_id={group_id}";
            }
            paramers = $"{paramers}&fields={fields}";

            string request_url = $"{api_call}groups.getById?{paramers}&access_token={access_token}&v={api_ver}";

            string response = await client.GetStringAsync(request_url);
            return response;
        }
    }
}