## 获取当前班级投票

请求地址：
`GET https://api.cnblogs.com/api/edu/votes/current/{schoolClassId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|班级Id|1|


返回示例：
```
[
    {
        "voteId": 8,
        "title": "第一次作业情况调查",
        "description": "第一次作业已经开始，你觉得第一个编程题目如何？",
        "voteCount": 1,
        "blogUrl": "http://www.cnblogs.com/sunle/",
        "publisher": "sun-le",
        "dateAdded": "2017-09-10T18:01:46.011604"
    }
]
```
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|voteId|投票Id|number|
|title|标题|string|
|description|描述|string|
|voteCount|参与数|number|
|blogUrl|发起人博客|string|
|publisher|发起人|string|
|dateAdded|发起时间|datetime|





