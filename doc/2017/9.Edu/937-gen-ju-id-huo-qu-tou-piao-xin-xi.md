## 根据Id获取投票信息

请求地址：
`GET https://api.cnblogs.com/api/edu/vote/{voteId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|voteId|number|是|投票Id|1|



返回示例：
```
{
    "voteId": 8,
    "title": "第一次作业情况调查",
    "content": "第一次作业已经开始，你觉得第一个编程题目如何？",
    "description": "第一次作业已经开始，你觉得第一个编程题目如何？",
    "picture": null,
    "voteMode": 1,
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
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|voteId|投票Id|number|
|title|标题|string|
|content|内容|string|
|description|描述|string|
|picture|图片链接|string|
|voteMode|模式（1.单选、2.多选、3.排名）|number|
|privacy|隐私（1.公开、2.匿名）|number|
|voteCount|参与数|number|
|blogUrl|发起人博客|string|
|publisher|发起人|string|
|publisherId|发起人Id|number|
|schoolClassId|班级Id|number|
|deadline|截止时间|datetime|
|dateAdded|发起时间|datetime|
|sFinished|是否完成|boolean|






