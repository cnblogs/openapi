## 获取参与投票成员

请求地址：
`GET https://api.cnblogs.com/api/edu/vote/committed/members/{schoolClassId}/{voteId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|班级Id|1|
|voteId|number|是|投票Id|1|

返回示例：
```
[
    {
        "memberId": 1070,
        "studentNo": "1231242124",
        "realName": "李思雨",
        "displayName": "lisiyu",
        "blogId": 270178,
        "postCount": 1,
        "blogUrl": "http://www.cnblogs.com/lisiyu/",
        "avatarUrl": "/images/noavatar.png",
        "membership": 1
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
|postCount|博文数|number|
|blogUrl|博客链接|string|
|avatarUrl|头像链接|string|
|membership|身份（1.学生、2.老师、3.助教）|number|



















