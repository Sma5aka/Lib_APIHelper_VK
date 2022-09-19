# vkAPIhelper
## Clases
## APIHelper
### Methods
* Constructor
``` public APIHelper(string access_token, string api_ver = "5.131")```
* Get all posts as JSON
```
public async Task<string> get_posts_json
            (HttpClient client, int owner_id = 0, uint count = 1, string domain = "imct_fefu",
            uint offset = 0, string filter = "",
            bool extended = false, string fields = "")
```
* Get stats as JSON
``` public async Task<string> get_stats_json
            (HttpClient client, string group_id = "imct_fefu", 
            string group_ids="")
```
* Get comments for post with id as JSON
``` public async Task<string> get_comms_json
            (HttpClient client, int post_id, int owner_id = -206944280, uint start_comment_id=0,
            uint offset = 0, uint count = 100, string sort = "asc", uint preview_length = 0)
```
* Get  \* only with moder's access token
``` public async Task<string> get_members_json(HttpClient client, string group_id="imct_fefu", string sort= "time_asc") ```
* Get posts as List of Post elements
``` public async Task<List<Post_Item>> get_posts
            (HttpClient client, uint count = 1, int owner_id = 0, string domain = "imct_fefu",
            uint offset = 0, string filter = "",
            bool extended = false, string fields = "")
```
* Get count of posts as INT      \*Also count of posts can be obtained from ```get_posts_json```
``` public async Task<int> get_posts_count
            (HttpClient client, uint count = 1, int owner_id = 0, string domain = "imct_fefu",
            uint offset = 0, string filter = "",
            bool extended = false, string fields = "")
```
* Get stats as List of Group_Item elements
``` public async Task<List<Group_Item>> get_stats
            (HttpClient client, string group_id = "imct_fefu",
            string group_ids = "")
```
* Get a specific post as List of Post elements
``` public async Task<List<Post_Item>> get_post
            (HttpClient client, string posts, bool extended=false, int copy_history_depth=0, string fields="")
```
* Get count of likes on most liked post as array of int where array[0] - post id and array[1] count of likes
``` public async Task<int[]> get_top_liked(HttpClient client, string owner_id = "", string domain = "imct_fefu") ```
* Get count of reposts on most reposted post as array of int where array[0] - post id and array[1] count of reposts
``` public async Task<int[]> get_top_reposted(HttpClient client, string owner_id = "", string domain = "imct_fefu") ```
* Get sum of likes on all posts as INT
``` public async Task<int> get_likes_sum(HttpClient client, string owner_id = "", string domain = "imct_fefu") ```
* Get sum of reposts on all posts as INT
``` public async Task<int> get_reposts_sum(HttpClient client, string owner_id = "", string domain = "imct_fefu") ```
### Fields
* ```access_token```
* ```api_ver``` - version of api vk
## Post_Item
### Fields
* ``` id ```
* ``` from_id ```
* ``` created_id ```
* ``` date ```
* ``` marked_as_ads ```
* ``` text ```
* ``` reply_owner_id ```
* ``` reply_post_id ```
* ``` friends_only ```
* ``` comments ```
* !!!!!!!!!!! ``` copyrght ```
* ``` likes ```
* ``` reposts ```
* ``` views ```
* !!!!!!!!!!!``` post_source ```
* ``` post_type ```
* ``` attachments ```
* ``` geo ```
* ``` signer_id ```
* ``` can_pin ```
* ``` can_delete ```
* ``` can_edit ```
* ``` is_pinned ```
* ``` is_favorite ```
* ``` donut ```
* ``` postponed_id ```
* ``` copy_history ```
