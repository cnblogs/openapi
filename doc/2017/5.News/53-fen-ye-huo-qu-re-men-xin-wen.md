## 分页获取热门新闻

请求地址：
`GET https://api.cnblogs.com/api/newsitems/@hot?startDate={startDate}&endDate={endDate}&pageIndex={pageIndex}&pageSize={pageSize}`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|startDate|string|是|开始时间||
|endDate|string|是|结束时间||
|pageIndex|string|是|页码||
|pageSize|string|是|页容量||


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