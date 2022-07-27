using Newtonsoft.Json;

namespace vkAPIhelper
{
    public class APIHelper
    {
        public APIHelper(string access_token, string api_ver = "5.131")
        {
            this.access_token = access_token;
            this.api_ver = api_ver;
        }
        public string access_token { get; set; } = "undefiend";
        public string api_ver { get; set; } = "5.131";

        private string api_call = "https://api.vk.com/method/";

        private string default_group = "imct_fefu";
        private int default_owner_id = -206944280;
        public async Task<string> get_posts_json
            (HttpClient client, int owner_id = 0, uint count = 1, string domain = "imct_fefu", 
            uint offset = 0, string filter = "", 
            bool extended = false, string fields = "")
        {

            if (count < 100)
            {

                string paramers = "";
                if (owner_id != 0)
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
            } else
            {
                return "まだできません";
            }
        }

        public async Task<string> get_stats_json
            (HttpClient client, string group_id = "imct_fefu", 
            string group_ids="")
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

        public async Task<string> get_comms_json
            (HttpClient client, int post_id, int owner_id = -206944280, uint start_comment_id=0,
            uint offset = 0, uint count = 100, string sort = "asc", uint preview_length = 0)
        {
            string paramers = $"&post_id={post_id}";         
            paramers = $"{paramers}&owner_id={owner_id.ToString()}";
            
            if (start_comment_id != 0)
            {
                paramers = $"{paramers}&start_comment_id={start_comment_id}";
            }
            if (offset != 0)
            {
                paramers = $"{paramers}&offset={offset}";
            }
            if (count != 0)
            {
                paramers = $"{paramers}&count={count}";
            }
            if (sort != null)
            {
                paramers = $"{paramers}&sort={sort}";
            }
            if (preview_length != 0)
            {
                paramers = $"{paramers}&preview_length={preview_length}";
            }
            string request_url = $"{api_call}wall.getComments?{paramers}&access_token={access_token}&v={api_ver}";

            string response = await client.GetStringAsync(request_url);
            return response;
        }

        public async Task<string> get_members_json(HttpClient client, string group_id="imct_fefu", string sort= "time_asc")
        {
            string paramers = "";
            if (group_id != null)
            {
                paramers = $"{paramers}&group_id={group_id}";
            }
            if (sort != null)
            {
                paramers = $"{paramers}&sort={sort}";
            }
            string request_url = $"{api_call}groups.getMembers?{paramers}&access_token={access_token}&v={api_ver}";

            string response = await client.GetStringAsync(request_url);
            return response;
        }

        public async Task<Post_Item[]> get_posts
            (HttpClient client, uint count = 1, int owner_id = 0, string domain = "imct_fefu",
            uint offset = 0, string filter = "",
            bool extended = false, string fields = "")
        {
            string res = await get_posts_json(client, owner_id, count, domain, offset, filter, extended, fields);

            Response_Posts response = JsonConvert.DeserializeObject<Response_Posts>(res);
            Post_Item[] posts_arr = response.response.items;
            return posts_arr;
        }
        
        public async Task<Group_Item[]> get_stats
            (HttpClient client, string group_id = "imct_fefu",
            string group_ids = "")
        {
            string res = await get_stats_json(client, group_id, group_ids);

            Response_Stats response = JsonConvert.DeserializeObject<Response_Stats>(res);
            Group_Item[] stats_arr = response.response;
            return stats_arr;
        }
        
        public async Task<Post_Item[]> get_post
            (HttpClient client, string posts, bool extended=false, int copy_history_depth=0, string fields="")
        {
            string paramers = "";
            if (posts != null)
            {
                paramers = $"{paramers}&posts={default_owner_id.ToString()}_{posts}";
            }
            if (extended)
            {
                paramers = $"{paramers}&extended=1";
            }
            if(fields != null)
            {
                paramers = $"{paramers}&fields={fields}";
            }
            if(copy_history_depth != 0)
            {
                paramers = $"{paramers}&copy_history_depth={copy_history_depth}";
            }

            string request_url = $"{api_call}wall.getById?{paramers}&access_token={access_token}&v={api_ver}";

            string res = await client.GetStringAsync(request_url);

            Response_Post response = JsonConvert.DeserializeObject<Response_Post>(res);
            Post_Item[] posts_arr = response.response;
            return posts_arr;
        }

        //вот ети все можно каким-нибудь способом сшить в один метод, но пока так)
        public async Task<int[]> get_top_liked(HttpClient client, string owner_id = "", string domain = "imct_fefu")
        {
            //uint all = 100; //variable that need to be delete, because soon, all posts will be getting
            
            Post_Item[] posts = await get_posts(client, 99);

            int max_likes = 0;
            int max_likes_id = 0;
            foreach (Post_Item post in posts)
            {
                if (post.likes.count > max_likes)
                {
                    max_likes = post.likes.count;
                    max_likes_id = post.id;
                }
            }
            int[] max_likes_post = {max_likes_id, max_likes};
            return max_likes_post;
        }

        public async Task<int[]> get_top_reposted(HttpClient client, string owner_id = "", string domain = "imct_fefu")
        {
            //uint all = 100; //variable that need to be delete, because soon, all posts will be getting

            Post_Item[] posts = await get_posts(client, 99);

            int max_reposts = 0;
            int max_reposts_id = 0;
            foreach (Post_Item post in posts)
            {
                if (post.reposts.count > max_reposts)
                {
                    max_reposts = post.likes.count;
                    max_reposts_id = post.id;
                }
            }
            int[] max_reposts_post = { max_reposts_id, max_reposts };
            return max_reposts_post;
        }

        public async Task<int> get_likes_sum(HttpClient client, string owner_id = "", string domain = "imct_fefu")
        {
            //uint all = 100; //variable that need to be delete, because soon, all posts will be getting

            Post_Item[] posts = await get_posts(client, 99);

            int likes_sum = 0;
            foreach (Post_Item post in posts)
            {
                likes_sum += post.likes.count;
            }
            
            return likes_sum;
        }

        public async Task<int> get_reposts_sum(HttpClient client, string owner_id = "", string domain = "imct_fefu")
        {
            //uint all = 100; //variable that need to be delete, because soon, all posts will be getting

            Post_Item[] posts = await get_posts(client, 99);

            int reposts_sum = 0;
            foreach (Post_Item post in posts)
            {
                reposts_sum += post.reposts.count;
            }

            return reposts_sum;
        }

    }
}