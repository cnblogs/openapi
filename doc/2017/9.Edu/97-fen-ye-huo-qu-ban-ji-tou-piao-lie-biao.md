## 分页获取班级投票列表
请求地址：
`GET https://api.cnblogs.com/api/edu/schoolclass/votes/{schoolClassId}/{pageIndex}-{pageSize}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|班级Id|1|
|pageIndex|number|是|页码|10|
|pageSize|number|是|页容量|10|


返回示例：
```
{
    "totalCount": 10,
    "votes": [
        {
            "voteId": 8,
            "title": "第一次作业情况调查",
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


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|totalCount|投票总数|number|
|votes|投票列表|array|
|votes.voteId|投票Id|number|
|votes.title|标题|string|
|votes.url|链接|string|
|votes.description|描述|string|
|votes.voteCount|参与数|number|
|votes.blogUrl|发起人博客|string|
|votes.avatarUrl|发起人头像|string|
|votes.displayName|发起人|string|
|votes.deadline|截止时间|datetime|
|votes.dateAdded|发起时间|datetime|
|votes.isFinished|是否完成|boolean|





