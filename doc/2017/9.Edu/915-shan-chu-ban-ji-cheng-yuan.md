## 删除班级成员

请求地址：
`DELETE https://api.cnblogs.com/api/edu/member/remove/{schoolClassId}/{memberId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|



请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|memberId|number|是|成员Id||
|schoolClassId|number|是|操作人班级Id||
|blogId|number|是|操作人博客Id||


详细说明：
```
返回值“isWarning”为true时，则对应“message”字段中的内容
```

返回示例：
```
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```


