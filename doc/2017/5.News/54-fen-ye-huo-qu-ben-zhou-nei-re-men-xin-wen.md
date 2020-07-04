## 分页获取本周内热门新闻

请求地址：
`GET https://api.cnblogs.com/api/newsitems/@hot-week?pageIndex={pageIndex}&pageSize={pageSize}`



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
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|Id|编号|number|
|Title|标题|string|
|Summary|标题|string|
|TopicId||string|
|TopicIcon||string|
|ViewCount|浏览次数|number|
|CommentCount|评论次数|number|
|DiggCount|点击次数|number|
|DateAdded|添加时间|string|