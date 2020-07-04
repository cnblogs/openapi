## 获取博文的评论列表

请求地址：
`GET https://api.cnblogs.com/api/blogs/{blogApp}/posts/{postId}/comments?pageIndex={pageIndex}&pageSize={pageSize}`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|blogApp|string|是|博客名|cnblogs|
|postId|number|是|博文编号|112233|
|pageIndex|number|是|页码|1|
|pageSize|number|是|页容量|10|




返回示例：
```
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
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|Id|编号|number|
|Body|内容|string|
|Author|作者|string|
|AuthorUrl|作者链接|string|
|FaceUrl|头像链接|string|
|Floor||string|
|DateAdded|添加时间|string|