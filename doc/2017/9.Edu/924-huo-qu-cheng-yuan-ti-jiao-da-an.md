## 获取成员提交答案

请求地址：
`GET https://api.cnblogs.com/api/edu/{memberId}/{homeworkId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|memberId|number|是|成员Id|1|
|homeworkId|number|是|作业Id|1|



返回示例：
```
{
    "answerId": 2,
    "title": "软件工程-构建之法 团队",
    "url": "http://www.cnblogs.com/lisiyu/p/5419159.html",
    "remark": null,
    "score": null,
    "entryId": 23,
    "suggestion": null,
    "dateAdded": "2017-09-02T19:07:16.1649235"
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|answerId|答案Id|number|
|title|标题|string|
|url|链接|string|
|remark|学生备注|string|
|score|分数|number|
|entryId|博文Id|number|
|suggestion|老师建议|string|
|dateAdded|提交时间|datetime|


