## 获取未提交答案成员

请求地址：
`GET https://api.cnblogs.com/api/edu/answer/uncommitted/{schoolClassId}/{homeworkId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|班级Id|1|
|homeworkId|number|是|作业Id|1|



返回示例：
```
[
    {
        "memberId": 59,
        "studentNo": "1513012005",
        "realName": "彭瑶",
        "displayName": "彭瑶",
        "blogId": 268394,
        "score": null,
        "rank": 0,
        "postCount": 0,
        "blogUrl": "http://www.cnblogs.com/pytlr520/",
        "avatarUrl": "/images/noavatar.png",
        "membership": 1,
        "dateAdded": "2017-08-31T17:35:11.9273282"
    }
]
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|memberId|成员Id|number|
|studentNo|学号|string|
|realName|真实姓名|string|
|displayName|园子昵称|string|
|blogId|博客Id|number|
|score|总分数|number|
|rank|优秀学生排名（1～10）|number|
|postCount|博文数|number|
|blogUrl|博客链接|string|
|avatarUrl|头像链接|string|
|membership|身份（1.学生、2.老师、3.助教）|number|
|dateAdded|创建时间|datetime|





