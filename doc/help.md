[toc]

# OpenAPI文档


## Token

    
#### 1 Client_Credentials授权
```
POST https://oauth.cnblogs.com/connect/token
```


>Header

|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|    
|`Content-Type`|string|1||application/x-www-form-urlencoded|

>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`client_id`|string|1|客户端ID|client_id|
|`client_secret`|string|1|客户端密钥|client_secret|
|`grant_type`|string|1|授权类型|client_credentials|

> 详细说明
    
client_credentials 授权方式获取 token

> 返回示例

```json
{
    "access_token": "this token string",
    "expires_in": 86400,
    "token_type": "Bearer"
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`access_token`|string|访问令牌|
|`expires_in`|number|过期时间|
|`token_type`|string|令牌类型|
#### 2.1 获取授权码 (需在浏览器中操作)
```
POST https://oauth.cnblogs.com/connect/authorize
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`client_id`|string|1|申请的client_id|your client_id|
|`scope`|string|1|申请的权限范围|openid profile CnBlogsApi offline_access|
|`response_type`|string|1|响应类型|code id_token|
|`redirect_uri`|string|1|默认回调地址(可以联系管理员修改)|https://oauth.cnblogs.com/auth/callback|
|`state`|string|1|可以指定任意值(必填)|cnblogs.com|
|`nonce`|string|1|随机字符串（自己创建）|cnblogs.com|



> 详细说明
    
1.在浏览器中请求该地址，会引导用户到博客园的登录页面。<div>2.登录成功后,重定向到 <span style="font-style: italic;">https://oauth.cnblogs.com/auth/callback</span>（默认回调页面）并带上code参数。</div><div>3.截取Url中的code换取token,详情请见(2.2 Authorization_code授权)</div>


#### 2.2 Authorization_Code授权
```
POST https://oauth.cnblogs.com/connect/token
```


>Header

|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|    
|`Content-Type`|string|1||application/x-www-form-urlencoded|

>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`client_id`|string|1|授权ID|client_id|
|`client_secret`|string|1|密钥|client_secret|
|`grant_type`|string|1|授权模式|password|
|`code`|string|1|授权码|code|
|`redirect_uri`|string|1|回调地址(默认)|https://oauth.cnblogs.com/auth/callback|

> 详细说明
    
code参数值需要用户登陆才能获取到，请看获取授权码文档

> 返回示例

```json
{
    "access_token": "this is token string",
    "expires_in": 586400,
    "token_type": "Bearer",
    "refresh_token": "this is refresh token string"
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`access_token`|string|访问令牌|
|`expires_in`|number|过期时间|
|`token_type`|string|令牌类型|
|`refresh_token`|string|更新令牌|
## Users

    
#### 获取当前登录用户信息
```
GET https://api.cnblogs.com/api/users
```


>Header

|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|    
|`Authorization`|string|1||Bearer your access_token|


> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取当前登录用户信息</span>

> 返回示例

```json
{
  "UserId": "4566ea6b-f2b3",
  "SpaceUserId": 2,
  "BlogId": 3,
  "DisplayName": "sample string 4",
  "Face": "sample string 5",
  "Avatar": "sample string 6",
  "Seniority": "sample string 7",
  "BlogApp": "sample string 8"
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`UserId`|string|用户id|
|`SpaceUserId`|number|用户显示名称id|
|`BlogId`|number|博客id|
|`DisplayName`|string|显示名称|
|`Face`|string|头像url|
|`Avatar`|string|头像url|
|`Seniority`|string|园龄|
|`BlogApp`|string|博客名|
## Blogs

    
#### 获取个人博客信息
```
GET https://api.cnblogs.com/api/blogs/{blogApp}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`blogApp`|string|1|博客名|hellocnblogs|

>Header

|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|    
|`Authorization`|string|1||Bearer your access_token|


> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取个人博客信息</span>

> 返回示例

```json
{
    "blogId": 40823,
    "title": "it新闻",
    "subtitle": "提供最新IT资讯",
    "postCount": 33,
    "pageSize": 10,
    "enableScript": false
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`blogId`|number|博客id|
|`title`|string|标题|
|`subtitle`|string|子标题|
|`postCount`|number|博客数量|
|`pageSize`|number|页容量|
|`enableScript`|boolean|是否加密|
## Bookmarks

    
#### 根据URL检查收藏是否已存在
```
HEAD https://api.cnblogs.com/api/Bookmarks?url={url}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`url`|string|1|收藏链接|www.cnblogs.com|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据URL检查收藏是否已存在</span>


#### 根据url删除收藏
```
DELETE https://api.cnblogs.com/api/Bookmarks?url={url}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`url`|string|1|收藏编号|www.cnblogs.com|

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据url删除收藏，url需要编码</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 修改收藏
```
PATCH https://api.cnblogs.com/api/bookmarks/{id}
```



>Body

```json
{
  "WzLinkId": 1,
  "Title": "sample string 2",
  "LinkUrl": "sample string 3",
  "Summary": "sample string 4",
  "Tags": [
    "sample string 1",
    "sample string 2"
  ]
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`id`|string|1|收藏编号||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">修改收藏</span>


#### 添加收藏
```
POST https://api.cnblogs.com/api/Bookmarks
```




> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">添加收藏</span>


#### 分页获取收藏列表
```
GET https://api.cnblogs.com/api/Bookmarks?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取收藏列表</span>

> 返回示例

```json
[

  {

    "WzLinkId": 1,

    "Title": "sample string 2",

    "LinkUrl": "sample string 3",

    "Summary": "sample string 4",

    "Tags": [

      "sample string 1",

      "sample string 2"

    ],

    "DateAdded": "2017-06-25T19:42:03.8765962+08:00",

    "FromCNBlogs": true

  },

  {

    "WzLinkId": 1,

    "Title": "sample string 2",

    "LinkUrl": "sample string 3",

    "Summary": "sample string 4",

    "Tags": [

      "sample string 1",

      "sample string 2"

    ],

    "DateAdded": "2017-06-25T19:42:03.8765962+08:00",

    "FromCNBlogs": true

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`WzLinkId`|string|收藏编号|
|`Title`|string|标题|
|`LinkUrl`|string|收藏链接|
|`Summary`|string|收藏标题|
|`Tags`|string|标签|
|`DateAdded`|string|添加时间|
|`FromCNBlogs`|string|是否来自博客园|
#### 根据id删除收藏
```
DELETE https://api.cnblogs.com/api/bookmarks/{id}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`id`|number|1|收藏编号|112233|

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据id删除收藏</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 获取网摘数量（Response.Headers(&quot;X-Count&quot;)）
```
HEAD https://api.cnblogs.com/api/Bookmarks
```




> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取网摘数量（Response.Headers("X-Count")）</span>


## BlogPosts

    
#### 获取个人博客随笔列表
```
GET https://api.cnblogs.com/api/blogs/{blogApp}/posts?pageIndex={pageIndex}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`blogApp`|string|1|博客名|cnblogs|
|`pageIndex`|number|1|页码|1|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取个人博客随笔列表</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Url": "sample string 3",

    "Description": "sample string 4",

    "Author": "sample string 5",

    "BlogApp": "sample string 6",

    "Avatar": "sample string 7",

    "PostDate": "2017-06-25T20:15:30.2514989+08:00",

    "ViewCount": 9,

    "CommentCount": 10,

    "DiggCount": 11

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Url": "sample string 3",

    "Description": "sample string 4",

    "Author": "sample string 5",

    "BlogApp": "sample string 6",

    "Avatar": "sample string 7",

    "PostDate": "2017-06-25T20:15:30.2514989+08:00",

    "ViewCount": 9,

    "CommentCount": 10,

    "DiggCount": 11

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Title`|string|标题|
|`Url`|string|博文链接|
|`Description`|string|摘要|
|`Author`|string|作者|
|`BlogApp`|string|博客名|
|`Avatar`|string|头像|
|`PostDate`|string|发布时间|
|`ViewCount`|number|浏览次数|
|`CommentCount`|number|评论次数|
|`DiggCount`|number|点击次数|
#### 获取博文内容
```
GET https://api.cnblogs.com/api/blogposts/{id}/body
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`id`|number|1|博文编号|1111|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取博文内容</span>

> 返回示例

```json
"sample string 1"
```
#### 分页获取精华区博文列表
```
GET https://api.cnblogs.com/api/blogposts/@picked?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|string|1|页码|1|
|`pageSize`|string|1|页容量|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取精华区博文列表</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Url": "sample string 3",

    "Description": "sample string 4",

    "Author": "sample string 5",

    "BlogApp": "sample string 6",

    "Avatar": "sample string 7",

    "PostDate": "2017-06-25T20:13:38.892135+08:00",

    "ViewCount": 9,

    "CommentCount": 10,

    "DiggCount": 11

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Url": "sample string 3",

    "Description": "sample string 4",

    "Author": "sample string 5",

    "BlogApp": "sample string 6",

    "Avatar": "sample string 7",

    "PostDate": "2017-06-25T20:13:38.892135+08:00",

    "ViewCount": 9,

    "CommentCount": 10,

    "DiggCount": 11

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Title`|string|标题|
|`Url`|string|博文链接|
|`Description`|string|简介|
|`Author`|string|作者|
|`BlogApp`|string|博客名|
|`Avatar`|date|头像|
|`PostDate`|string|发布时间|
|`ViewCount`|number|浏览次数|
|`CommentCount`|number|评论次数|
|`DiggCount`|number|点击次数|
#### 分页获取网站首页博文列表
```
GET https://api.cnblogs.com/api/blogposts/@sitehome?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|string|1|页码|1|
|`pageSize`|string|1|页容量|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取网站首页博文列表</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Url": "sample string 3",

    "Description": "sample string 4",

    "Author": "sample string 5",

    "BlogApp": "sample string 6",

    "Avatar": "sample string 7",

    "PostDate": "2017-06-25T20:11:47.0952592+08:00",

    "ViewCount": 9,

    "CommentCount": 10,

    "DiggCount": 11

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Url": "sample string 3",

    "Description": "sample string 4",

    "Author": "sample string 5",

    "BlogApp": "sample string 6",

    "Avatar": "sample string 7",

    "PostDate": "2017-06-25T20:11:47.0952592+08:00",

    "ViewCount": 9,

    "CommentCount": 10,

    "DiggCount": 11

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Title`|string|标题|
|`Url`|string|链接|
|`Description`|string|说明|
|`Author`|string|作者|
|`BlogApp`|string|博客名|
|`Avatar`|string|头像链接|
|`PostDate`|string|发布时间|
|`ViewCount`|number|浏览次数|
|`CommentCount`|number|评论次数|
|`DiggCount`|number|点击次数|
## BlogPostComments

    
#### 添加博文评论
```
POST https://api.cnblogs.com/api/blogs/{blogApp}/posts/{postId}/comments
```



>Body

```json
{
    "body":"Coding changes the world"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`blogApp`|string|1|博客名||
|`postId`|string|1|博客编号||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">添加博文评论</span>


#### 获取博文的评论列表
```
GET https://api.cnblogs.com/api/blogs/{blogApp}/posts/{postId}/comments?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`blogApp`|string|1|博客名|cnblogs|
|`postId`|number|1|博文编号|112233|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取博文的评论列表</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Body": "sample string 2",

    "Author": "sample string 3",

    "AuthorUrl": "sample string 4",

    "FaceUrl": "sample string 5",

    "Floor": 6,

    "DateAdded": "2017-06-25T19:59:07.8609221+08:00"

  },

  {

    "Id": 1,

    "Body": "sample string 2",

    "Author": "sample string 3",

    "AuthorUrl": "sample string 4",

    "FaceUrl": "sample string 5",

    "Floor": 6,

    "DateAdded": "2017-06-25T19:59:07.8609221+08:00"

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Body`|string|内容|
|`Author`|string|作者|
|`AuthorUrl`|string|作者链接|
|`FaceUrl`|string|头像链接|
|`Floor`|string||
|`DateAdded`|string|添加时间|
## KbArticles

    
#### 分页获取知识库文章列表
```
GET https://api.cnblogs.com/api/KbArticles?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|string|1|页码||
|`pageSize`|string|1|页容量||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取知识库文章列表</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "Author": "sample string 4",

    "ViewCount": 5,

    "DiggCount": 6,

    "DateAdded": "2017-06-25T19:56:33.5328019+08:00"

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "Author": "sample string 4",

    "ViewCount": 5,

    "DiggCount": 6,

    "DateAdded": "2017-06-25T19:56:33.5328019+08:00"

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|string|编号|
|`Title`|string|标题|
|`Summary`|string|标题|
|`Author`|string|作者|
|`ViewCount`|string|查看次数|
|`DiggCount`|string|点击次数|
|`DateAdded`|string|添加时间|
#### 获取文章内容
```
GET https://api.cnblogs.com/api/kbarticles/{id}/body
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`id`|string|1|||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取文章内容</span>

> 返回示例

```json
"sample string 1"
```
## NewsItems

    
#### 分页获取新闻列表
```
GET https://api.cnblogs.com/api/NewsItems?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|string|1|页码|1|
|`pageSize`|string|1|页容量|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取新闻列表</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T06:31:05.9725356+08:00"

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T06:31:05.9725356+08:00"

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Title`|string|标题|
|`Summary`|string|标题|
|`TopicId`|string||
|`TopicIcon`|string||
|`ViewCount`|number|浏览次数|
|`CommentCount`|number|评论次数|
|`DiggCount`|number|点击次数|
|`DateAdded`|string|添加时间|
#### 获取新闻内容
```
GET https://api.cnblogs.com/api/newsitems/{id}/body
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`id`|string|1|新闻编号||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取新闻内容</span>

> 返回示例

```json
"sample string 1"
```
#### 分页获取热门新闻
```
GET https://api.cnblogs.com/api/newsitems/@hot?startDate={startDate}&amp;endDate={endDate}&amp;pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`startDate`|string|1|开始时间||
|`endDate`|string|1|结束时间||
|`pageIndex`|string|1|页码||
|`pageSize`|string|1|页容量||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取热门新闻</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T20:04:48.7202819+08:00"

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T20:04:48.7202819+08:00"

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Title`|string|标题|
|`Summary`|string|标题|
|`TopicId`|string||
|`TopicIcon`|string||
|`ViewCount`|number|浏览次数|
|`CommentCount`|number|评论次数|
|`DiggCount`|number|点击次数|
|`DateAdded`|string|添加时间|
#### 分页获取本周内热门新闻
```
GET https://api.cnblogs.com/api/newsitems/@hot-week?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取本周内热门新闻</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T20:06:56.0952729+08:00"

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T20:06:56.0952729+08:00"

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Title`|string|标题|
|`Summary`|string|标题|
|`TopicId`|string||
|`TopicIcon`|string||
|`ViewCount`|number|浏览次数|
|`CommentCount`|number|评论次数|
|`DiggCount`|number|点击次数|
|`DateAdded`|string|添加时间|
#### 分页获取推荐新闻
```
GET https://api.cnblogs.com/api/newsitems/@recommended?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">分页获取推荐新闻</span>

> 返回示例

```json
[

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T20:03:09.204658+08:00"

  },

  {

    "Id": 1,

    "Title": "sample string 2",

    "Summary": "sample string 3",

    "TopicId": 4,

    "TopicIcon": "sample string 5",

    "ViewCount": 6,

    "CommentCount": 7,

    "DiggCount": 8,

    "DateAdded": "2017-06-25T20:03:09.204658+08:00"

  }

]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Id`|number|编号|
|`Title`|string|标题|
|`Summary`|string|标题|
|`TopicId`|string||
|`TopicIcon`|string||
|`ViewCount`|number|浏览次数|
|`CommentCount`|number|评论次数|
|`DiggCount`|number|点击次数|
|`DateAdded`|string|添加时间|
## NewsComments

    
#### 修改新闻评论
```
PATCH https://api.cnblogs.com/api/newscomments/{id}
```



>Body

```json
{
    "Content":"comment content test"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`id`|string|1|评论编号||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">修改新闻评论</span>

> 返回示例

```json
"sample string 1"
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 发布新闻评论
```
POST https://api.cnblogs.com/api/news/{newsId}/comments
```



>Body

```json
{
  "ParentId": 1,
  "Content": "sample string 2"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`newsId`|number|1|新闻编号|528994|

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">发布新闻评论</span><br>


#### 根据新闻Id分页获取新闻评论
```
GET https://api.cnblogs.com/api/news/{newsId}/comments
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`newsId`|string|1|新闻id||
|`pageIndex`|number|1|页码||
|`pageSize`|number|1|页容量||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据新闻Id分页获取新闻列表</span>

> 返回示例

```json
[
    {
        "commentID": 287365,
        "contentID": 528922,
        "commentContent": "单纯想象一下就觉得很疯狂啊。",
        "userGuid": "e14bccfd-3ed8-df11-ac81-842b2b196315",
        "userId": 168112,
        "userName": "Firen",
        "faceUrl": "https://pic.cnblogs.com/face/168112/20151104135814.png",
        "floor": 1,
        "dateAdded": "2015-09-11T17:02:49.653",
        "agreeCount": 0,
        "antiCount": 0,
        "parentCommentID": 0,
        "parentComment": null
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`commentID`|number|评论编号|
|`contentID`|number|内容编号|
|`commentContent`|string|评论内容|
|`userGuid`|string|用户编号|
|`userId`|number|用户编号|
|`userName`|string|用户名|
|`faceUrl`|string|头像地址|
|`floor`|number||
|`dateAdded`|string|添加时间|
|`agreeCount`|number|赞同人数|
|`antiCount`|number|反对人数|
|`parentCommentID`|number||
|`parentComment`|string||
#### 删除新闻评论
```
DELETE https://api.cnblogs.com/api/newscomments/{id}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`id`|string|1|评论编号||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">删除新闻评论</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
## Statuses

    
#### 获取最新一条闪存内容
```
GET https://api.cnblogs.com/api/statuses/recent
```




> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取最新一条闪存内容</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 发布闪存评论
```
POST https://api.cnblogs.com/api/statuses/{statusId}/comments
```



>Body

```json
{
  "ReplyTo": 1,
  "ParentCommentId": 2,
  "Content": "sample string 3"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`statusId`|string|1|闪存编号||
|`ReplyTo`|string|1|||
|`ParentCommentId`|string|1|||
|`Content`|string|1|内容||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">发布闪存评论</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 删除闪存
```
DELETE https://api.cnblogs.com/api/statuses/{id}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`id`|string|1|闪存编号||

> 详细说明
    
<p style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">删除闪存</p><div><br></div>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 获取闪存评论
```
GET https://api.cnblogs.com/api/statuses/{statusId}/comments
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`statusId`|string|1|闪存编号||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取闪存评论</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 发布闪存
```
POST https://api.cnblogs.com/api/statuses
```



>Body

```json
{
  "Content": "sample string 1",
  "IsPrivate": true
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`Content`|string|1|内容||
|`IsPrivate`|string|1|是否私有||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">发布闪存</span>

> 返回示例

```json
{

  "Content": "sample string 1",

  "IsPrivate": true

}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 删除闪存评论
```
DELETE https://api.cnblogs.com/api/statuses/{statusId}/comments/{id}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`statusId`|string|1|||
|`id`|string|1|||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">删除闪存评论</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 根据类型获取闪存列表
```
GET https://api.cnblogs.com/api/statuses/@{type}?pageIndex={pageIndex}&amp;pageSize={pageSize}&amp;tag={tag}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`type`|string|1|类型||
|`pageIndex`|string|1|页码||
|`pageSize`|string|1|页容量||
|`tag`|string|1|标签||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据类型获取闪存列表</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 根据Id获取闪存
```
GET https://api.cnblogs.com/api/statuses/{id}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`id`|string|1|闪存编号||



> 详细说明
    
<p>根据Id获取闪存</p>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
## Question

    
#### 提问
```
POST https://api.cnblogs.com/api/questions
```



>Body

```json
{
    "Title" : "WebApi 提问（标题（6～200字符））",
    "Content" :"WebApi 提问内容（20～100000字符）",
    "Tags": "sample string 3（不超过五个标签）",
    "Flags": "1",
    "UserID":1001
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`Title`|string|1|问题标题||
|`Content`|string|1|问题内容||
|`Tags`|string|1|问题标签||
|`Flags`|number|1|发布标志|1  表示发布至首页，2表示不发布至首页|
|`UserID`|string|1|用户ID||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">提问</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 评论
```
POST https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}/comments?loginName={XXX}
```



>Body

```json
{
    "Content" :"Robert Comment From Question Api",
    "ParentCommentId":0,
    "PostUserID":1111
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|number|1|问题id||
|`answerId`|number|1|回答id||
|`Content`|string|1|评论内容||
|`ParentCommentId`|number|1|父评论ID||
|`PostUserID`|number|1|提交者用户ID||
|`loginName`|string|1|提交者用户名||

> 详细说明
    
发布评论

> 返回示例

```json
{

  "Content": "sample string 1",

  "ParentCommentId": 2

}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 获取单个回答的评论列表
```
GET https://api.cnblogs.com/api/questions/answers/{answerId}/comments
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`answerId`|string|1|回答ID||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据回答ID，返回该回答的评论列表。</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 判断用户是否回答过某个问题
```
HEAD https://api.cnblogs.com/api/questions/{questionId}?userId={userId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`questionId`|string|1|问题ID||
|`userId`|string|1|用户ID||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据 “用户的ID” 以及 “问题ID” 判断用户是否回答过某个问题。</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 删除回答
```
DELETE https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|string|1|||
|`answerId`|string|1|||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据问题ID 以及回答ID 来删除回答，<span style="background-color: yellow;">只能删除自己的回答。</span></span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 修改回答
```
PATCH https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}
```



>Body

```json
{
    "Answer":"XXx",
    "UserID": 1001
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|string|1|问题ID||
|`answerId`|string|1|回答ID||
|`Answer`|string|1|回答内容||
|`UserID`|string|1|用户ID||

> 详细说明
    
<h1 style="margin-top: 20px; margin-bottom: 10px; font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; line-height: normal; color: rgb(51, 51, 51);">修改回答<br></h1>

> 返回示例

```json
{

  "Answer": "sample string 1"

}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 根据类型获取问题列表
```
GET https://api.cnblogs.com/api/questions/@{type}?pageIndex={pageIndex}&amp;pageSize={pageSize}&amp;spaceUserId={spaceUserId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`type`|string|1|列表类型|高分问题，已解决，新回答等|
|`pageIndex`|number|1|页码|默认为 1|
|`pageSize`|number|1|页面容量|默认为 25|
|`spaceUserId`|number|1|用户ID|默认为 0|



> 详细说明
    
根据列表类型，获取相对应的问题列表，主要有下面几种类型：<div><ul><li>问题首页列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "unsolved"</li><li>高分问题列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "highscore"</li><li>零回答问题列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "noanswer"</li><li>已解决问题列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "solved"</li><li>某个用户提问的问题列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "myquestion"&nbsp;</li><li>某个用户未解决的问题列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "myunsolved"&nbsp;</li><li>某个用户回答的问题列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "myanswer"&nbsp;</li><li>某个用户回答被采纳的问题列表:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;type = "mybestanswer"&nbsp;</li></ul><div><div><div><span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">默认spaceUserId 为 0, 当需要获取某个用户的某个类型的问题列表时，需要带上 spaceUserId 参数。<br></span><div><span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;"><br></span></div></div></div></div></div>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 获取单个问题对应的回答列表
```
GET https://api.cnblogs.com/api/questions/{questionId}/answers
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`questionId`|string|1|问题ID||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据问题ID返回该问题的回答列表。</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 修改问题
```
PATCH https://api.cnblogs.com/api/questions/{questionId}
```



>Body

```json
{
    "Title" : "WebApi 提问（标题（6～200字符））",
    "Content" :"WebApi 提问内容（20～100000字符）",
    "Tags": "sample string 3（不超过五个标签）",
    "Flags": "1",
    "UserID":1001
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|string|1|问题ID||
|`Title`|string|1|问题标题||
|`Content`|string|1|问题内容||
|`Tags`|string|1|问题标签||
|`Flags`|string|1|问题标志|1  表示发布至首页，2表示不发布至首页|
|`UserID`|number|1|用户ID||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">修改问题</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 删除评论
```
DELETE https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}/comments/{commentId}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|string|1|问题id||
|`answerId`|string|1|回答id||
|`commentId`|string|1|评论id||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据问题ID，回答ID， 以及评论ID 来删除评论，<span style="background-color: yellow;">只能删除自己的评论。</span></span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 回答
```
POST https://api.cnblogs.com/api/questions/{questionId}/answers?loginName={&quot;XXX&quot;}
```



>Body

```json
{
    "Answer":"XXx",
    "UserID": 1001,
    "UserName":""
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|number|1||回答的问题ID|
|`loginName`|string|1||用户名|
|`Answer`|string|1||回答内容|
|`UserID`|number|1|||
|`UserName`|string|1|||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">发布回答</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 更新评论
```
PATCH https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}/comments/{commentId}
```



>Body

```json
{
    "Content" :"Robert Comment From Question Api",
    "PostUserID":1111
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|number|1|问题id||
|`answerId`|number|1|问题id||
|`commentId`|number|1|评论Id||
|`Content`|string|1|||
|`PostUserID`|number|1|提交者ID||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">更新评论</span>

> 返回示例

```json
{

  "Content": "sample string 1",

  "ParentCommentId": 2

}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 获取首页问题列表
```
GET https://api.cnblogs.com/api/questions/@sitehome?pageIndex={pageIndex}&amp;pageSize={pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`pageIndex`|number|1|页码|默认为 1|
|`pageSize`|number|1|页面容量|默认为 25|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">获取博问首页问题列表</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 删除问题
```
DELETE https://api.cnblogs.com/api/questions/{questionId}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`questionId`|string|1|问题Id||

> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据问题ID 来删除问题，只能删除用户自己</span>提的问题，<span style="color: rgb(0, 0, 0); background-color: yellow;">无法删除已结贴的问题。</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
#### 获取单个问题的详情
```
GET https://api.cnblogs.com/api/questions/{questionId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`questionId`|number|1|问题ID||



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">根据输入的'questionId' ，返回该问题的详细信息。</span>


> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Version`|string||
|`Content`|string||
|`StatusCode`|string||
|`ReasonPhrase`|string||
|`Headers`|string||
|`RequestMessage`|string||
|`IsSuccessStatusCode`|string||
## Edu

    
#### 删除投票
```
DELETE https://api.cnblogs.com/api/edu/vote/remove/{schoolClassId}/{voteId}
```




> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 参与投票
```
POST https://api.cnblogs.com/api/edu/vote/commit/{voteId}
```



>Body

```json
{
    "schoolClassId": 1,
    "voteOptionIds": [ 3,5 ]
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`voteId`|number|1|投票Id||
|`schoolClassId`|number|1|操作人班级Id||
|`voteOptionIds`|array|1|投票选项Id列表||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容


#### 发起投票
```
POST https://api.cnblogs.com/api/edu/vote/publish
```



>Body

```json
{
    "schoolClassId": 1,
    "name": "职业规划",
    "content": "毕业后想从事什么方向?",
    "privacy": 1,
    "deadline": "2017-09-10 17:00",
    "voteContents": [
        {
            "title": "毕业后想从事什么方向",
            "voteMode": 1,
            "picture": null,
            "voteOptions": [
                {
                    "option": "web前端开发"
                },
                {
                    "option": "后端开发"
                },
                {
                    "option": "软件测试"
                }
            ]
        }
    ]
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`schoolClassId`|number|1|操作人班级Id||
|`name`|string|1|名称||
|`content`|string|1|内容||
|`privacy`|number|1|隐私（1.公开、2.匿名）||
|`deadline`|string|1|截止时间||
|`voteContents`|array|1|投票内容列表||
|`voteContents.title`|string|1|标题||
|`voteContents.voteMode`|number|1|模式（1.单选、2.多选）||
|`voteContents.picture`|string|1|图片链接||
|`voteContents.voteOptions`|array|1|投票选项列表||
|`voteContents.voteOptions.option`|string|1|投票选项||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容


#### 获取成员投票项
```
GET https://api.cnblogs.com/api/edu/vote/committed/options/{memberId}/{voteId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`memberId`|number|1|成员Id|1|
|`voteId`|number|1|投票Id|1|




> 返回示例

```json
{
    "1": [
        "一般，我会写好的"
    ]
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`1`|array|投票内容Id|
#### 获取参与投票成员
```
GET https://api.cnblogs.com/api/edu/vote/committed/members/{schoolClassId}/{voteId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|
|`voteId`|number|1|投票Id|1|




> 返回示例

```json
[
    {
        "memberId": 1070,
        "studentNo": "1231242124",
        "realName": "李思雨",
        "displayName": "lisiyu",
        "blogId": 270178,
        "postCount": 1,
        "blogUrl": "http://www.cnblogs.com/lisiyu/",
        "avatarUrl": "/images/noavatar.png",
        "membership": 1
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`memberId`|number|成员Id|
|`studentNo`|string|学号|
|`realName`|string|真实姓名|
|`displayName`|string|园子昵称|
|`blogId`|number|博客Id|
|`postCount`|number|博文数|
|`blogUrl`|string|博客链接|
|`avatarUrl`|string|头像链接|
|`membership`|number|身份（1.学生、2.老师、3.助教）|
#### 判断是否参与投票
```
GET https://api.cnblogs.com/api/edu/vote/iscommitted/{memberId}/{voteId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`memberId`|number|1|成员Id|1|
|`voteId`|number|1|投票Id|1|




> 返回示例

```json
false
```
#### 获取当前班级投票
```
GET https://api.cnblogs.com/api/edu/votes/current/{schoolClassId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|




> 返回示例

```json
[
    {
        "voteId": 8,
        "name": "第一次作业情况调查",
        "description": "第一次作业已经开始，你觉得第一个编程题目如何？",
        "voteCount": 1,
        "blogUrl": "http://www.cnblogs.com/sunle/",
        "publisher": "sun-le",
        "dateAdded": "2017-09-10T18:01:46.011604"
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`voteId`|number|投票Id|
|`name`|string|名称|
|`description`|string|描述|
|`voteCount`|number|参与数|
|`blogUrl`|string|发起人博客|
|`publisher`|string|发起人|
|`dateAdded`|datetime|发起时间|
#### 获取投票统计
```
GET https://api.cnblogs.com/api/edu/vote/stats/{voteId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`voteId`|number|1|投票Id|1|



> 详细说明
    
非排名模式无需“scoreValue”字段

> 返回示例

```json
{
    "1": [
        {
            "voteOptionId": 21,
            "voteOption": "No.2 web前端开发",
            "recordCount": 0,
            "percent": 0,
            "scoreValue": 0
        },
        {
            "voteOptionId": 22,
            "voteOption": "No.1 后端开发",
            "recordCount": 0,
            "percent": 0,
            "scoreValue": 0
        },
        {
            "voteOptionId": 23,
            "voteOption": "No.3 软件测试",
            "recordCount": 1,
            "percent": 100,
            "scoreValue": 0
        }
    ]
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`1`|string|投票内容Id|
|`voteOptionId`|number|投票选项Id|
|`voteOption`|string|投票选项|
|`recordCount`|number|投票数|
|`percent`|number|百分比|
|`scoreValue`|string|分值|
#### 获取投票选项记录
```
GET https://api.cnblogs.com/api/edu/vote/record/{schoolClassId}/{voteOptionId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|
|`voteOptionId`|number|1|投票选项Id|19|





> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`voteOption`|string|投票选项|
|`recordCount`|number|投票数|
|`votedMembers`|array|投票人列表|
|`votedMembers.memberId`|number|成员Id|
|`votedMembers.studentNo`|string|学号|
|`votedMembers.realName`|string|真实姓名|
|`votedMembers.displayName`|string|园子昵称|
|`votedMembers.blogId`|number|博客Id|
|`votedMembers.postCount`|number|博文数|
|`votedMembers.blogUrl`|string|博客链接|
|`votedMembers.avatarUrl`|string|头像链接|
|`votedMembers.membership`|number|身份（1.学生、2.老师、3.助教）|
#### 获取投票内容
```
GET https://api.cnblogs.com/api/edu/vote/contents/{voteId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`voteId`|number|1|投票Id|1|





> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`voteContentId`|number|投票内容Id|
|`title`|string|内容标题|
|`voteMode`|number|模式（1.单选、2.多选、3.排名）|
|`picture`|string|图片链接|
|`voteId`|number|投票Id|
|`voteOptions`|array|投票选项列表|
|`voteOptions.voteOptionId`|number|投票选项Id|
|`voteOptions.option`|string|投票选项|
#### 根据Id获取投票信息
```
GET https://api.cnblogs.com/api/edu/vote/{voteId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`voteId`|number|1|投票Id|1|




> 返回示例

```json
{
    "voteId": 8,
    "name": "第一次作业情况调查",
    "content": "第一次作业已经开始，你觉得第一个编程题目如何？",
    "description": "第一次作业已经开始，你觉得第一个编程题目如何？",
    "privacy": 1,
    "voteCount": 0,
    "blogUrl": "http://www.cnblogs.com/sunle/",
    "publisher": "sun-le",
    "publisherId": 45,
    "schoolClassId": 8,
    "deadline": "2017-09-10T20:00:00",
    "dateAdded": "2017-09-09T18:01:46.011604",
    "isFinished": true
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`voteId`|number|投票Id|
|`name`|string|名称|
|`content`|string|内容|
|`description`|string|描述|
|`privacy`|number|隐私（1.公开、2.匿名）|
|`voteCount`|number|参与数|
|`blogUrl`|string|发起人博客|
|`publisher`|string|发起人|
|`publisherId`|number|发起人Id|
|`schoolClassId`|number|班级Id|
|`deadline`|datetime|截止时间|
|`dateAdded`|datetime|发起时间|
|`isFinished`|boolean|是否完成|
#### 删除公告
```
DELETE https://api.cnblogs.com/api/edu/bulletin/remove/{schoolClassId}/{bulletinId}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`bulletinId`|number|1|公告Id||
|`schoolClassId`|number|1|操作人班级Id||
|`blogId`|number|1|操作人博客Id||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 重发公告
```
POST https://api.cnblogs.com/api/edu/bulletin/republish/{schoolClassId}/{bulletinId}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`bulletinId`|number|1|公告Id||
|`schoolClassId`|number|1|操作人班级Id||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容


#### 修改公告
```
PATCH https://api.cnblogs.com/api/edu/bulletin/modify/{bulletinId}
```



>Body

```json
{
    "schoolClassId": 8,
    "content": "请大家将开题报告以markdown的方式发到别人的博客上"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`bulletinId`|number|1|公告Id||
|`schoolClassId`|number|1|操作人班级Id||
|`content`|string|1|内容||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 发布公告
```
POST https://api.cnblogs.com/api/edu/bulletin/publish
```



>Body

```json
{
    "schoolClassId": 1,
    "content": "请大家将开题报告以markdown的方式发到自己的博客上"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`schoolClassId`|number|1|操作人班级Id||
|`content`|string|1|内容||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 获取当前班级公告
```
GET https://api.cnblogs.com/api/edu/bulletin/current/{schoolClassId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|




> 返回示例

```json
"沈航软件工程13级默认班级公告"
```
#### 根据Id获取公告信息
```
GET https://api.cnblogs.com/api/edu/bulletin/{bulletinId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`bulletinId`|number|1|公告Id|1|




> 返回示例

```json
"沈航软件工程13级默认班级公告"
```
#### 答案评语
```
PATCH https://api.cnblogs.com/api/edu/answer/suggest/{answerId}
```



>Body

```json
{
    "schoolClassId": 1,
    "suggestion": "部分探讨的内容深度还要加强。"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`answerId`|number|1|答案Id||
|`schoolClassId`|number|1|操作人班级Id||
|`suggestion`|string|1|评语||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 答案打分
```
PATCH https://api.cnblogs.com/api/edu/answer/marking/{answerId}
```



>Body

```json
{
    "schoolClassId": 1,
    "score": 9.2
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`answerId`|number|1|答案Id||
|`schoolClassId`|number|1|操作人班级Id||
|`score`|number|1|分数||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 修改答案
```
PATCH https://api.cnblogs.com/api/edu/answer/modify/{answerId}
```



>Body

```json
{
    "schoolClassId": 1,
    "title": "软件工程-构建之法 团队",
    "url": "http://www.cnblogs.com/lisiyu/p/5419159.html",
    "postId": 10000,
    "remark": null
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`answerId`|number|1|答案Id||
|`schoolClassId`|number|1|操作人班级Id||
|`title`|string|1|标题||
|`url`|string|1|链接||
|`postId`|number|1|博文Id||
|`remark`|string|1|备注||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 提交答案
```
POST https://api.cnblogs.com/api/edu/answer/commit
```



>Body

```json
{
    "schoolClassId": 1,
    "homeworkId": 1,
    "title": "软件工程-构建之法 团队",
    "url": "http://www.cnblogs.com/lisiyu/p/5419159.html",
    "postId": 10000,
    "remark": null
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`schoolClassId`|number|1|操作人班级Id||
|`homeworkId`|number|1|作业Id||
|`title`|string|1|标题||
|`url`|string|1|链接||
|`postId`|number|1|博文Id||
|`remark`|string|1|备注||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 获取未提交答案成员
```
GET https://api.cnblogs.com/api/edu/answer/uncommitted/{schoolClassId}/{homeworkId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|
|`homeworkId`|number|1|作业Id|1|




> 返回示例

```json
[
    {
        "memberId": 59,
        "studentNo": "1513012005",
        "realName": "彭瑶",
        "displayName": "彭瑶",
        "blogId": 268394,
        "score": null,
        "rank": 0,
        "postCount": 0,
        "blogUrl": "http://www.cnblogs.com/pytlr520/",
        "avatarUrl": "/images/noavatar.png",
        "membership": 1,
        "dateAdded": "2017-08-31T17:35:11.9273282"
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`memberId`|number|成员Id|
|`studentNo`|string|学号|
|`realName`|string|真实姓名|
|`displayName`|string|园子昵称|
|`blogId`|number|博客Id|
|`score`|number|总分数|
|`rank`|number|优秀学生排名（1～10）|
|`postCount`|number|博文数|
|`blogUrl`|string|博客链接|
|`avatarUrl`|string|头像链接|
|`membership`|number|身份（1.学生、2.老师、3.助教）|
|`dateAdded`|datetime|创建时间|
#### 判断是否题交答案
```
GET https://api.cnblogs.com/api/edu/answer/iscommitted/{memberId}/{homeworkId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`memberId`|number|1|成员Id|1|
|`homeworkId`|number|1|作业Id|1|




> 返回示例

```json
true
```
#### 获取成员提交答案
```
GET https://api.cnblogs.com/api/edu/{memberId}/{homeworkId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`memberId`|number|1|成员Id|1|
|`homeworkId`|number|1|作业Id|1|




> 返回示例

```json
{
    "answerId": 2,
    "title": "软件工程-构建之法 团队",
    "url": "http://www.cnblogs.com/lisiyu/p/5419159.html",
    "remark": null,
    "score": null,
    "entryId": 23,
    "suggestion": null,
    "dateAdded": "2017-09-02T19:07:16.1649235"
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`answerId`|number|答案Id|
|`title`|string|标题|
|`url`|string|链接|
|`remark`|string|学生备注|
|`score`|number|分数|
|`entryId`|number|博文Id|
|`suggestion`|string|老师建议|
|`dateAdded`|datetime|提交时间|
#### 获取成员博文列表
```
GET https://api.cnblogs.com/api/edu/answer/posts/{blogId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`blogId`|number|1|博客Id|10000|




> 返回示例

```json
[
    {
        "id": 3,
        "title": "软件工程学习进度条",
        "url": "http://www.cnblogs.com/sunle/p/5372010.html",
        "description": "第一周 第二周 第三周 第四周 第五周 第六周 学习时间 四小时 六小时 七小时 十二小时 十五小时 十五小时 代码量 100 100 150 150 200 200 博客量 100 200 200 300 300 400 学习到的知识 随机函数 四则运算与git的配置 git的使用 统计词频 网页",
        "viewCount": 10,
        "diggCount": 0,
        "commentCount": 0,
        "author": "sun-le",
        "blogUrl": "http://www.cnblogs.com/sunle/",
        "dateAdded": "2016-04-09T16:55:00"
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`id`|number|博文Id|
|`title`|string|标题|
|`url`|string|链接|
|`description`|string|描述|
|`viewCount`|number|浏览数|
|`diggCount`|number|推荐数|
|`commentCount`|number|评论数|
|`author`|string|作者|
|`blogUrl`|string|博客链接|
|`dateAdded`|datetime|发布时间|
#### 删除作业
```
DELETE https://api.cnblogs.com/api/edu/homework/remove/{schoolClassId}/{homeworkId}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`homeworkId`|string|1|作业Id||
|`schoolClassId`|string|1|操作人班级Id||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 关闭作业
```
PATCH https://api.cnblogs.com/api/edu/homework/close/{schoolClassId}/{homeworkId}
```




> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容


#### 编辑作业
```
PATCH https://api.cnblogs.com/api/edu/homework/edit/{homeworkId}
```



>Body

```json
{
    "schoolClassId": 1,
    "title": "作业要求 20170907",
    "startTime": "2017-09-10 12:00",
    "deadline": "2017-09-12 17:00",
    "content": "<p>评分规则</p><p>截止时间前提交，有分。<br />补交，0分; 先计为负分，一周内补交改为0分。<br />晚交，倒扣; 迟于截止时间一周，倒扣本题分数。<br />抄袭，倒扣本次作业分数。<br />按教师和专家意见修改，在截止时间以前完成的，计入成绩。</p>",
    "formatType": 1,
    "IsShowInHome": true
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`homeworkId`|number|1|作业Id||
|`operatorInfo`|object|1|操作人信息||
|`operatorInfo.schoolClassId`|number|1|操作人班级Id||
|`operatorInfo.blogId`|number|1|操作人博客Id||
|`title`|string|1|标题||
|`startTime`|datetime|1|起始时间||
|`deadline`|datetime|1|截止时间||
|`content`|string|1|内容||
|`formatType`|number|1|格式类型（1.TinyMce、2.Markdown）||
|`IsShowInHome`|boolean|1|是否首页显示||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 发布作业
```
POST https://api.cnblogs.com/api/edu/homework/publish
```



>Body

```json
{
    "schoolClassId": 1,
    "title": "作业要求 20170907",
    "startTime": null,
    "deadline": "2017-09-10 17:00",
    "content": "<p>评分规则</p><p>截止时间前提交，有分。<br />补交，0分; 先计为负分，一周内补交改为0分。<br />晚交，倒扣; 迟于截止时间一周，倒扣本题分数。<br />抄袭，倒扣本次作业分数。<br />按教师和专家意见修改，在截止时间以前完成的，计入成绩。</p>",
    "formatType": 1,
    "IsShowInHome": false
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`schoolClassId`|number|1|操作人班级Id||
|`title`|string|1|标题||
|`startTime`|string|1|起始时间||
|`deadline`|string|1|截止时间||
|`content`|string|1|内容||
|`formatType`|number|1|格式类型（1.TinyMce、2.Markdown）||
|`IsShowInHome`|boolean|1|是否首页显示||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 获取答案提交列表
```
GET https://api.cnblogs.com/api/edu/homework/answers/{homeworkId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`homeworkId`|string|1|作业Id|1|




> 返回示例

```json
[
    {
        "answerId": 2,
        "title": "软件工程-构建之法 团队",
        "url": "http://www.cnblogs.com/lisiyu/p/5419159.html",
        "remark": null,
        "score": null,
        "entryId": 23,
        "suggestion": null,
        "answererId": 69,
        "answerer": "lisiyu",
        "studentNo": "1513042005",
        "realName": "李思雨",
        "blogUrl": "http://www.cnblogs.com/lisiyu/",
        "dateAdded": "2017-09-02T19:07:16.1649235"
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`answerId`|number|答案Id|
|`title`|string|标题|
|`url`|string|链接|
|`remark`|string|学生备注|
|`score`|number|得分|
|`entryId`|number|博文Id|
|`suggestion`|string|老师建议|
|`answererId`|number|学生Id|
|`answerer`|string|学生|
|`studentNo`|string|学号|
|`realName`|string|真实姓名|
|`blogUrl`|string|学生博客|
|`dateAdded`|datetime|提交时间|
#### 获取当前班级作业
```
GET https://api.cnblogs.com/api/edu/homeworks/current/{schoolClassId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|string|1|班级Id|1|




> 返回示例

```json
[
    {
        "homeworkId": 10,
        "title": "使用markdown编辑器",
        "description": "使用markdown编辑器",
        "answerCount": 0,
        "publisher": "sun-le",
        "blogUrl": "http://www.cnblogs.com/sunle/",
        "displayTime": "2017-09-11T12:06:36.478281"
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`homeworkId`|number|作业Id|
|`title`|string|标题|
|`description`|string|描述|
|`answerCount`|number|答案数|
|`publisher`|string|发布者|
|`blogUrl`|string|发布者博客|
|`displayTime`|datetime|发布时间|
#### 根据Id获取作业信息
```
GET https://api.cnblogs.com/api/edu/homework/{homeworkId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`homeworkId`|number|1|作业Id|1|



> 详细说明
    
格式类型为markdown时，需要使用“convertedContent”字段来显示作业内容

> 返回示例

```json
{
    "homeworkId": 9,
    "title": "作业要求 20170907",
    "content": "&lt;p&gt;评分规则&lt;/p&gt;\n&lt;p&gt;截止时间前提交，有分。&lt;br /&gt;补交，0分; 先计为负分，一周内补交改为0分。&lt;br /&gt;晚交，倒扣; 迟于截止时间一周，倒扣本题分数。&lt;br /&gt;抄袭，倒扣本次作业分数。&lt;br /&gt;按教师和专家意见修改，在截止时间以前完成的，计入成绩。&lt;/p&gt;",
    "formatType": 1,
    "convertedContent": null,
    "description": "评分规则 截止时间前提交，有分。补交，0分; 先计为负分，一周内补交改为0分。晚交，倒扣; 迟于截止时间一周，倒扣本题分数。抄袭，倒扣本次作业分数。按教师和专家意见修改，在截止时间以前完成的，计入成绩。",
    "answerCount": 0,
    "isClosed": false,
    "publisher": "sun-le",
    "displayName": null,
    "blogUrl": "http://www.cnblogs.com/sunle/",
    "avatarUrl": null,
    "schoolClassId": 8,
    "startTime": null,
    "deadline": "2017-09-10T17:00:00",
    "isShowInHome": false,
    "isFinished": true,
    "displayTime": "2017-09-10T16:24:05.2909972"
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`homeworkId`|number|作业Id|
|`title`|string|标题|
|`content`|string|内容|
|`formatType`|number|格式类型（1.TinyMce、2.Markdown）|
|`convertedContent`|string|markdown转换内容|
|`description`|string|描述|
|`answerCount`|number|答案数|
|`isClosed`|boolean|是否关闭|
|`publisher`|string|发布者|
|`blogUrl`|string|发布者博客|
|`avatarUrl`|string|发布者头像|
|`schoolClassId`|number|班级Id|
|`startTime`|datetime|起始时间|
|`deadline`|datetime|截止时间|
|`isShowInHome`|boolean|是否首页显示|
|`isFinished`|boolean|是否完成|
|`displayTime`|datetime|发布时间|
#### 删除班级成员
```
DELETE https://api.cnblogs.com/api/edu/member/remove/{schoolClassId}/{memberId}
```



>Body

```json

```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`memberId`|number|1|成员Id||
|`schoolClassId`|number|1|操作人班级Id||
|`blogId`|number|1|操作人博客Id||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 修改成员信息
```
PATCH https://api.cnblogs.com/api/edu/member/modify/{memberId}
```



>Body

```json
{
    "schoolClassId": 1,
    "realName": "测试",
    "role": 1,
    "studentNo": "1513933002"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`memberId`|number|1|成员Id||
|`schoolClassId`|number|1|操作人班级Id||
|`realName`|string|1|真实姓名||
|`role`|number|1|身份（1.学生、2.老师、3.助教）||
|`studentNo`|string|1|学号(学生学号不允许修改)||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 按博客链接添加成员
```
POST https://api.cnblogs.com/api/edu/member/register/blogUrl
```



>Body

```json
{
    "schoolClassId": 1,
    "blogUrl": "http://www.cnblogs.com/test/",
    "realName": "测试",
    "role": 1,
    "studentNo": "1513933002"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`schoolClassId`|number|1|操作人班级Id||
|`blogUrl`|string|1|博客链接||
|`realName`|string|1|真实姓名||
|`role`|number|1|身份（1.学生、2.老师、3.助教）||
|`studentNo`|string|1|学号||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```
#### 按园子昵称添加成员
```
POST https://api.cnblogs.com/api/edu/member/register/displayName
```



>Body

```json
{
    "schoolClassId": 1,
    "displayName": "test",
    "realName": "测试",
    "role": 1,
    "studentNo": "1513933002"
}
```
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|--|
|`schoolClassId`|number|1|操作人班级Id||
|`displayName`|string|1|园子昵称||
|`realName`|string|1|真实姓名||
|`role`|number|1|身份（1.学生、2.老师、3.助教）||
|`studentNo`|string|1|学号||

> 详细说明
    
返回值“isWarning”为true时，则对应“message”字段中的内容

> 返回示例

```json
{
    "isSuccess": false,
    "isWarning": true,
    "isError": false,
    "message": "您输入的园子昵称有误！"
}
```
#### 获取用户班级列表
```
GET https://api.cnblogs.com/api/edu/member/schoolclasses
```





> 返回示例

```json
[
    {
        "schoolClassId": 1,
        "url": "/campus/ruc/software-engineering-13",
        "nameCn": "软件工程13级",
        "universityNameCn": "中国人民大学",
        "courseEnd": null
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`schoolClassId`|number|班级Id|
|`url`|string|班级链接|
|`nameCn`|string|班级中文名|
|`universityNameCn`|string|校区中文名|
|`courseEnd`|datetime|结课时间|
#### 根据博客Id获取成员信息
```
GET https://api.cnblogs.com/api/edu/member/{blogId}/{schoolClassId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`blogId`|string|1|博客Id|10000|
|`schoolClassId`|string|1|班级Id|1|





> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`memberId`|number|成员Id|
|`studentNo`|string|学号|
|`realName`|string|真实姓名|
|`schoolClassId`|number|班级Id|
|`membership`|number|身份（1.学生、2.老师、3.助教）|
|`dateAdded`|datetime|创建时间|
#### 根据成员Id获取成员信息
```
GET https://api.cnblogs.com/api/edu/member/{memberId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`memberId`|number|1|成员Id|1|




> 返回示例

```json
{
    "memberId": 1,
    "studentNo": "1513933002",
    "realName": "胡玲碧",
    "displayName": "happylb",
    "schoolClassId": 8,
    "membership": 1
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`memberId`|number|成员Id|
|`studentNo`|string|学号|
|`realName`|string|真实姓名|
|`displayName`|string|园子昵称|
|`schoolClassId`|number|班级Id|
|`membership`|number|身份（1.学生、2.老师、3.助教）|
#### 获取班级成员列表
```
GET https://api.cnblogs.com/api/edu/schoolclass/members/{schoolClassId}?filter={filter}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|
|`filter`|string|0|筛选条件（昵称、姓名、学号）|happylb|




> 返回示例

```json
[
    {
        "memberId": 60,
        "studentNo": "1513933002",
        "realName": "胡玲碧",
        "displayName": "happylb",
        "blogId": 262939,
        "score": 138,
        "rank": 0,
        "postCount": 0,
        "blogUrl": "http://www.cnblogs.com/happylb/",
        "avatarUrl": "/images/noavatar.png",
        "membership": 1,
        "dateAdded": "2017-08-31T17:35:11.9467634"
    }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`memberId`|number|成员Id|
|`studentNo`|string|学号|
|`realName`|string|真实姓名|
|`displayName`|string|园子昵称|
|`blogId`|number|博客Id|
|`score`|number|总得分|
|`rank`|number|优秀学生排名（1～10）|
|`postCount`|number|博文数|
|`blogUrl`|string|博客链接|
|`avatarUrl`|string|头像链接|
|`membership`|number|身份（1.学生、2.老师、3.助教）|
|`dateAdded`|datetime|创建时间|
#### 分页获取班级投票列表
```
GET https://api.cnblogs.com/api/edu/schoolclass/votes/{schoolClassId}/{pageIndex}-{pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|




> 返回示例

```json
{
    "totalCount": 10,
    "votes": [
        {
            "voteId": 8,
            "name": "第一次作业情况调查",
            "url": "/campus/bjwzxy/test/vote/8",
            "description": "第一次作业已经开始，你觉得第一个编程题目如何？",
            "voteCount": 0,
            "blogUrl": "http://www.cnblogs.com/sunle/",
            "avatarUrl": "/images/noavatar.png",
            "displayName": "sun-le",
            "deadline": "2017-09-10T20:00:00",
            "dateAdded": "2017-09-09T18:01:46.011604",
            "isFinished": false
        }
    ]
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`totalCount`|number|投票总数|
|`votes`|array|投票列表|
|`votes.voteId`|number|投票Id|
|`votes.name`|string|名称|
|`votes.url`|string|链接|
|`votes.description`|string|描述|
|`votes.voteCount`|number|参与数|
|`votes.blogUrl`|string|发起人博客|
|`votes.avatarUrl`|string|发起人头像|
|`votes.displayName`|string|发起人|
|`votes.deadline`|datetime|截止时间|
|`votes.dateAdded`|datetime|发起时间|
|`votes.isFinished`|boolean|是否完成|
#### 分页获取班级公告列表
```
GET https://api.cnblogs.com/api/edu/schoolclass/bulletins/{schoolClassId}/{pageIndex}-{pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|




> 返回示例

```json
{
    "totalCount": 10,
    "bulletins": [
        {
            "bulletinId": 10,
            "content": "沈航软件工程13级默认班级公告",
            "publisher": "sun-le",
            "blogUrl": "http://www.cnblogs.com/sunle/",
            "dateAdded": "2017-09-06T11:38:35.9192169"
        }
    ]
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`totalCount`|number|公告总数|
|`bulletins`|array|公告列表|
|`bulletins.bulletinId`|number|公告Id|
|`bulletins.content`|string|内容|
|`bulletins.publisher`|string|发布者|
|`bulletins.blogUrl`|string|发布者博客|
|`bulletins.dateAdded`|datetime|发布时间|
#### 分页获取班级作业列表
```
GET https://api.cnblogs.com/api/edu/schoolclass/homeworks/{withoutPostponed}/{schoolClassId}/{pageIndex}-{pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`withoutPostponed`|boolean|1|不显示未开始的作业|false|
|`schoolClassId`|number|1|班级Id|1|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|




> 返回示例

```json
{
    "totalCount": 10,
    "homeworks": [
        {
            "homeworkId": 9,
            "title": "作业要求 20170907",
            "url": "/campus/bjwzxy/test/homework/9",
            "description": "评分规则 截止时间前提交，有分。补交，0分; 先计为负分，一周内补交改为0分。晚交，倒扣; 迟于截止时间一周，倒扣本题分数。抄袭，倒扣本次作业分数。按教师和专家意见修改，在截止时间以前完成的，计入成绩。",
            "answerCount": 0,
            "isClosed": false,
            "displayName": "sun-le",
            "blogUrl": "http://www.cnblogs.com/sunle/",
            "avatarUrl": "/images/noavatar.png",
            "startTime": null,
            "deadline": "2017-09-10T17:00:00",
            "isFinished": false,
            "displayTime": "2017-09-10T16:24:05.2909972"
        }
    ]
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`totalCount`|number|作业总数|
|`homeworks`|array|作业列表|
|`homeworks.homeworkId`|number|作业Id|
|`homeworks.title`|string|标题|
|`homeworks.url`|string|链接|
|`homeworks.description`|string|描述|
|`homeworks.answerCount`|number|答案数|
|`homeworks.isClosed`|boolean|是否关闭|
|`homeworks.displayName`|string|发布人|
|`homeworks.blogUrl`|string|发布人博客|
|`homeworks.avatarUrl`|string|发布人头像|
|`homeworks.startTime`|datetime|起始时间|
|`homeworks.deadline`|datetime|截止时间|
|`homeworks.isFinished`|boolean|是否完成|
|`homeworks.displayTime`|datetime|发布时间|
#### 分页获取班级评论列表
```
GET https://api.cnblogs.com/api/edu/schoolclass/comments/{schoolClassId}/{pageIndex}-{pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|





> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`totalCount`|number|评论总数|
|`comments`|array|评论列表|
|`comments.title`|string|标题|
|`comments.url`|string|链接|
|`comments.sourceUrl`|string|博文链接|
|`comments.formattedBody`|string|评论内容|
|`comments.commenterName`|string|评论人|
|`comments.commenterUrl`|string|评论人博客|
|`comments.commenterAvatar`|string|评论人头像|
|`comments.dateAdded`|datetime|评论时间|
#### 分页获取班级博文列表
```
GET https://api.cnblogs.com/api/edu/schoolclass/posts/{filter}/{schoolClassId}/{pageIndex}-{pageSize}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`filter`|string|1|筛选条件|tutor|
|`schoolClassId`|number|1|班级Id|1|
|`pageIndex`|number|1|页码|1|
|`pageSize`|number|1|页容量|10|



> 详细说明
    
筛选条件包含：no_comment（零回复）、tutor（<span style="color: rgb(34, 34, 34); font-family: Menlo, monospace; font-size: 12px; white-space: pre-wrap;">老师/助教</span>）、<span style="color: rgb(34, 34, 34); font-family: Menlo, monospace; font-size: 12px; white-space: pre-wrap;">student（学生）、all（所有）</span>

> 返回示例

```json
{
    "totalCount": 10,
    "blogPosts": [
        {
            "title": "结对编程之黄金分割",
            "url": "http://www.cnblogs.com/QuanQingli/p/5372570.html",
            "description": "结对编程之队友信息 队友：彭扬阳。博客地址http://www.cnblogs.com/zxyoyo/ 结对项目：黄金分割游戏。题目地址http://www.cnblogs.com/qingxu/p/5316897.html 结对编程之队友介绍 这次编程能很有幸和彭同学一组，彭同学平时是一个觉得沉默",
            "viewCount": 45,
            "diggCount": 0,
            "commentCount": 3,
            "author": "正能量制造机",
            "displayName": "正能量制造机(李全清)",
            "blogId": 269776,
            "blogUrl": "http://www.cnblogs.com/QuanQingli/",
            "avatarUrl": "/images/noavatar.png",
            "dateAdded": "2016-04-09T20:36:00"
        }
    ]
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`totalCount`|number|博文总数|
|`blogPosts`|array|博文列表|
|`blogPosts.title`|string|标题|
|`blogPosts.url`|string|链接|
|`blogPosts.description`|string|描述|
|`blogPosts.viewCount`|number|浏览数|
|`blogPosts.diggCount`|number|推荐数|
|`blogPosts.commentCount`|number|评论数|
|`blogPosts.author`|string|作者|
|`blogPosts.displayName`|string|显示名|
|`blogPosts.blogId`|number|博客Id|
|`blogPosts.blogUrl`|string|博客链接|
|`blogPosts.avatarUrl`|string|作者头像|
|`blogPosts.dateAdded`|datetime|发表日期|
#### 根据英文名获取班级信息
```
GET https://api.cnblogs.com/api/edu/schoolclass/{universityNameEn}/{classNameEn}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`universityNameEn`|string|1|校区英文名|ruc|
|`classNameEn`|string|1|班级英文名|software-engineering-13|




> 返回示例

```json
{
    "schoolClassId": 1,
    "icon": "http://images2015.cnblogs.com/blog/1/201604/1-20160430154644191-2093926076.png",
    "url": "/campus/ruc/software-engineering-13",
    "nameCn": "软件工程13级",
    "nameEn": "software-engineering-13",
    "postCount": 22,
    "memberCount": 0,
    "bulletinCount": 0,
    "universityId": 1,
    "creatorBlogId": 0,
    "lastPostTime": "2016-04-11T22:48:00",
    "universityNameCn": "中国人民大学",
    "universityNameEn": "ruc",
    "courseEnd": null,
    "dateAdded": "2017-06-29T19:27:24.2872093",
    "isActive": false
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`schoolClassId`|number|班级Id|
|`icon`|string|班级图标|
|`url`|string|班级链接|
|`nameCn`|string|班级中文名|
|`nameEn`|string|班级英文名|
|`postCount`|number|博文数|
|`memberCount`|number|成员数|
|`bulletinCount`|number|公告数|
|`universityId`|number|校区Id|
|`creatorBlogId`|number|创建者博客Id|
|`lastPostTime`|datetime|最后发表博文时间|
|`universityNameCn`|string|校区中文名|
|`universityNameEn`|string|校区英文名|
|`courseEnd`|datetime|结课时间|
|`dateAdded`|datetime|创建时间|
|`isActive`|boolean|是否活跃|
#### 根据Id获取班级信息
```
GET https://api.cnblogs.com/api/edu/schoolclass/{schoolClassId}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`schoolClassId`|number|1|班级Id|1|




> 返回示例

```json
{
    "schoolClassId": 1,
    "icon": "http://images2015.cnblogs.com/blog/1/201604/1-20160430154644191-2093926076.png",
    "url": "/campus/ruc/software-engineering-13",
    "nameCn": "软件工程13级",
    "nameEn": "software-engineering-13",
    "postCount": 22,
    "memberCount": 0,
    "bulletinCount": 0,
    "universityId": 1,
    "creatorBlogId": 0,
    "lastPostTime": "2016-04-11T22:48:00",
    "universityNameCn": "中国人民大学",
    "universityNameEn": "ruc",
    "courseEnd": null,
    "dateAdded": "2017-06-29T19:27:24.2872093",
    "isActive": false
}
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`schoolClassId`|number|班级Id|
|`icon`|string|班级图标|
|`url`|string|班级链接|
|`nameCn`|string|班级中文名|
|`nameEn`|string|班级英文名|
|`postCount`|number|博文数|
|`memberCount`|number|成员数|
|`bulletinCount`|number|公告数|
|`universityId`|number|校区Id|
|`creatorBlogId`|number|创建者博客Id|
|`lastPostTime`|datetime|最后发表博文时间|
|`universityNameCn`|string|校区中文名|
|`universityNameEn`|string|校区英文名|
|`courseEnd`|datetime|结课时间|
|`dateAdded`|datetime|创建时间|
|`isActive`|boolean|是否活跃|
## ZzkDocument

    
#### 找找看
```
GET https://api.cnblogs.com/api/ZzkDocuments/{category}?keyWords={keyWords}&amp;pageIndex={pageIndex}&amp;startDate={startDate}&amp;endDate={endDate}&amp;viewTimesAtLeast={viewTimesAtLeast}
```

>Query
    
|参数名|类型|必需|描述|示例|
|---------|-------|-------------|-------|---|
|`category`|string|1|搜索类别|可选参数(Blog,News,Question,Kb)|
|`keyWords`|string|1|搜索关键字|.net|
|`pageIndex`|number|1|要返回的页次,如果不提供页次,则为默认值1|1|
|`startDate`|date|1|开始时间,如果不提供日期,则显示所有搜索结果日期格式: 2015-09-09|2015-09-09|
|`endDate`|date|1|结束日期,如果不提供日期,则截止到当前日期日期格式: 2015-09-09|2015-09-09|
|`viewTimesAtLeast`|string|1|搜索浏览次数在此以上的内容|10|



> 详细说明
    
<span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">查询结果:</span><div><span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">&nbsp;如果关键字为空,则返回 StatusCode:BadRequest400.&nbsp;</span></div><div><span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">如果搜索类别不支持,则返回 StatusCode:BadRequest400.&nbsp;</span></div><div><span style="color: rgb(51, 51, 51); font-family: &quot;Segoe UI Light&quot;, Frutiger, &quot;Frutiger Linotype&quot;, &quot;Dejavu Sans&quot;, &quot;Helvetica Neue&quot;, Arial, sans-serif; font-size: 14px;">如果查询结果为空,则返回StatusCode:Ok200.但HttpContent为空。</span></div>

> 返回示例

```json
[
  {
    "Title": "sample string 1",
    "Content": "sample string 2",
    "UserName": "sample string 3",
    "UserAlias": "sample string 4",
    "PublishTime": "2017-06-25T10:03:46.4250727+08:00",
    "VoteTimes": 6,
    "ViewTimes": 7,
    "CommentTimes": 8,
    "Uri": "sample string 9",
    "Id": "sample string 10"
  },
  {
    "Title": "sample string 1",
    "Content": "sample string 2",
    "UserName": "sample string 3",
    "UserAlias": "sample string 4",
    "PublishTime": "2017-06-25T10:03:46.4250727+08:00",
    "VoteTimes": 6,
    "ViewTimes": 7,
    "CommentTimes": 8,
    "Uri": "sample string 9",
    "Id": "sample string 10"
  }
]
```
> 返回参数
    
|参数名|类型|描述|
|--|--|--|
|`Title`|string|查询内容的标题|
|`Content`|string|查询内容摘要|
|`UserName`|string|作者|
|`UserAlias`|string|博客地址|
|`PublishTime`|string|发布时间|
|`VoteTimes`|number|被推荐次数|
|`ViewTimes`|number|浏览次数|
|`CommentTimes`|number|评论次数|
|`Uri`|string|页面链接|
|`Id`|string||
