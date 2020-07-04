## 获取投票选项记录

请求地址：
`GET https://api.cnblogs.com/api/edu/vote/record/{schoolClassId}/{voteOptionId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|班级Id|1|
|voteOptionId|number|是|投票选项Id|19|


返回示例：
```
{
    "voteOption": "一般，我会写好的",
    "recordCount": 1,
    "votedMembers": [
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
}
```
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|voteOption|投票选项|string|
|recordCount|投票数|number|
|votedMembers|投票人列表|array|
|votedMembers.memberId|成员Id|number|
|votedMembers.studentNo|学号|string|
|votedMembers.realName|真实姓名|string|
|votedMembers.displayName|园子昵称|string|
|votedMembers.blogId|博客Id|number|
|votedMembers.postCount|博文数|number|
|votedMembers.blogUrl|博客链接|string|
|votedMembers.avatarUrl|头像链接|string|
|votedMembers.membership|身份（1.学生、2.老师、3.助教）|number|


