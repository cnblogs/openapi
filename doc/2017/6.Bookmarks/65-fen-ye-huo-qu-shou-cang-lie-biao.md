## 分页获取收藏列表

请求地址：
`GET https://api.cnblogs.com/api/Bookmarks?pageIndex={pageIndex}&pageSize={pageSize}`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|pageIndex|number|是|页码|1|
|pageSize|number|是|页容量|10|








返回示例：
```
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
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|WzLinkId|收藏编号|string|
|Title	|标题|string|
|LinkUrl|收藏链接|string|
|Summary|收藏标题|string|
|Tags|标签|string|
|DateAdded|添加时间|string|
|FromCNBlogs|是否来自博客园|string|