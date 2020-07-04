## 按园子昵称添加成员

请求地址：
`POST https://api.cnblogs.com/api/edu/member/register/displayName`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|
请求参数示例：
```
{
    "schoolClassId": 1,
    "displayName": "test",
    "realName": "测试",
    "role": 1,
    "studentNo": "1513933002"
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|操作人班级Id||
|displayName|string|是|园子昵称||
|realName|string|是|真实姓名||
|role|number|是|身份（1.学生、2.老师、3.助教）||
|studentNo|string|是|学号||

详细说明：
```
返回值“isWarning”为true时，则对应“message”字段中的内容
```

返回示例：
```
{
    "isSuccess": false,
    "isWarning": true,
    "isError": false,
    "message": "您输入的园子昵称有误！"
}
```


