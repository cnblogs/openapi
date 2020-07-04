## 分页获取精华区博文列表

请求地址：
`GET https://api.cnblogs.com/api/blogposts/@picked?pageIndex={pageIndex}&pageSize={pageSize}`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|pageIndex|string|是|页码|1|
|pageSize|string|是|页容量|10|




返回示例：
```
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
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|Id|编号|string|
|Title|标题|string|
|Url|博文链接|string|
|Description|摘要|string|
|Author|作者|string|
|BlogApp|博客名|string|
|Avatar|头像|string|
|PostDate|发布时间|string|
|ViewCount|浏览次数|number|
|CommentCount|评论次数|number|
|DiggCount|点击次数|number|