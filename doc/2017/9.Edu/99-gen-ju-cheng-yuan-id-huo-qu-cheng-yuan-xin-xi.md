## 根据成员Id获取成员信息
请求地址：
`GET https://api.cnblogs.com/api/edu/member/{memberId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|memberId|number|是|成员Id|1|

返回示例：
```
{
    "memberId": 1,
    "studentNo": "1513933002",
    "realName": "胡玲碧",
    "displayName": "happylb",
    "schoolClassId": 8,
    "membership": 1
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|memberId|成员Id|number|
|studentNo|学号|string|
|realName|真实姓名|string|
|displayName|园子昵称|string|
|schoolClassId|班级Id|number|
|membership|身份（1.学生、2.老师、3.助教）|number|









