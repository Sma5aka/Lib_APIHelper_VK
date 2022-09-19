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
* ``` id ``` - id of post as int
* ``` from_id ``` - 
* ``` created_id ``` - 
* ``` date ``` - date of create
* ``` marked_as_ads ``` - 1 if marked, 0 if not
* ``` text ``` - text in post
* ``` reply_owner_id ``` - owner account's id
* ``` reply_post_id ``` - if reply on other post
* ``` friends_only ``` - vision
* ``` comments ``` - branch of main comments, without comment tree
* !!!!!!!!!!! ``` copyrght ``` - 
* ``` likes ``` - as Likes object
* ``` reposts ``` - as Reposts object
* ``` views ``` - as Views object
* !!!!!!!!!!!``` post_source ``` - 
* ``` post_type ``` - string
* ``` attachments ``` - as List of Attachment
* ``` geo ``` - as Geo object
* ``` signer_id ``` - as int
* ``` can_pin ``` - int
* ``` can_delete ``` - int
* ``` can_edit ``` - int
* ``` is_pinned ``` - int
* ``` is_favorite ``` - bool
* ``` donut ``` - donut object
* ``` postponed_id ``` - int
* ``` copy_history ``` - as List of Post_Item objects
## Group_Item
### Fields
* ``` id ``` - int
* ``` name ``` - name of group as string
* ``` screen_name ``` - string
* ``` is_closed ``` - 1 if closed, 0 if not
* ``` deactivated ``` - string
* ``` is_admin ``` - int
* ``` admin_level ``` - int
* ``` is_member ``` - int
* ``` is_advertised ``` - int
* ``` type ``` - string
* ``` photo_50 ``` - link as string
* ``` photo_100 ``` - link as string
* ``` photo_200 ``` - link as string
* ``` members_count ``` - int
* ``` description ``` - string
* ``` activity ``` - string
## Likes
### Fields 
* ``` count ``` - int
* ``` user_likes ``` - 1 if user likes, 0 if not
## Views
### Fields
* ```count``` - int
## Reposts
### Fields
* ``` count ``` - int
* ``` wall_count ``` - count of reposts on the wall
* ``` mail_count ``` - count of reposts in mail
* ``` user_reposted ``` - 1 if user reposted, 0 if not
## Comm_Item
### Fields
* ``` id ``` - int
* ``` from_id ``` - user id
* ``` date ``` - int
* ``` text ``` - string
* ``` donut ``` - donut object
* ``` reply_to_user ``` - user id as int
* ``` reply_to_post ``` - post id as int
* ``` attachments ``` - List of Attachment objects
* ``` parent_stack ``` - List if Comm_Item
* ``` thread ``` - Thread object
## Attachment
### Fields
* ```  ```
