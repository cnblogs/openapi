## 找找看接口

请求地址：
`GET https://api.cnblogs.com/api/ZzkDocuments/{category}?keyWords={keyWords}&pageIndex={pageIndex}&startDate={startDate}&endDate={endDate}&viewTimesAtLeast={viewTimesAtLeast}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|

请求参数说明:

|参数名|类型|说明|示例|
|:---:|:---:|:---:|:---:|
|category|string|搜索类别|可选参数(Blog,News,Question,Kb)|
|keyWords|string|搜索关键字|.net|
|pageIndex|number|要返回的页次,如果不提供页次,则为默认值1|1|
|startDate|date|开始时间,如果不提供日期,则显示所有搜索结果日期格式: 2015-09-09|2015-09-09|
|endDate|date|结束日期,如果不提供日期,则截止到当前日期日期格式: 2015-09-09|2015-09-09|
|viewTimesAtLeast|string|搜索浏览次数在此以上的内容|10|

返回示例:

```
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

返回参数说明:

|参数名|描述|类型|
|:---:|:---:|:---:|
|Title|查询内容的标题|string|
|Content|查询内容摘要|string|
|UserName|作者|string
|UserAlias|博客地址|string
|PublishTime|发布时间|string
|VoteTimes|被推荐次数|number
|ViewTimes|浏览次数|number
|CommentTimes|评论次数|number
|Uri|页面链接|string
|Id|博客id|string

