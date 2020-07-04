## 分页获取班级作业列表
请求地址：
`GET https://api.cnblogs.com/api/edu/schoolclass/homeworks/{withoutPostponed}/{schoolClassId}/{pageIndex}-{pageSize}`

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


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|totalCount|作业总数|number|
|homeworks|作业列表|array|
|homeworks.homeworkId|作业Id|number|
|homeworks.title|标题|string|
|homeworks.url|链接|string|
|homeworks.description|描述|string|
|homeworks.answerCount|答案数|number|
|homeworks.isClosed|是否关闭|boolean|
|homeworks.displayName|发布人|string|
|homeworks.blogUrl|发布人博客|string|
|homeworks.avatarUrl|发布人头像|string|
|homeworks.startTime|起始时间|datetime|
|homeworks.deadline|截止时间|datetime|
|homeworks.isFinished|是否完成|boolean|
|homeworks.displayTime|发布时间|datetime|



