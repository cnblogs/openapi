## 获取班级成员列表
请求地址：
`GET https://api.cnblogs.com/api/edu/schoolclass/members/{schoolClassId}?filter={filter}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|班级Id|1|
|filter|number|是|页码|10|
|pageSize|string|否|筛选条件（昵称、姓名、学号）|happylb|


返回示例：
```
[
    {
        "memberId": 60,
        "studentNo": "1513933002",
        "realName": "胡玲碧",
        "displayName": "happylb",
        "blogId": 262939,
        "score": 138,
        "rank": 0,
        "postCount": 0,
        "blogUrl": "http://www.cnblogs.com/happylb/",
        "avatarUrl": "/images/noavatar.png",
        "membership": 1,
        "dateAdded": "2017-08-31T17:35:11.9467634"
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
|score|总得分|number|
|rank|优秀学生排名（1～10）|number|
|postCount|博文数|number|
|blogUrl|博客链接|string|
|avatarUrl|头像链接|string|
|membership|身份（1.学生、2.老师、3.助教）|number|
|dateAdded|创建时间|datetime|






