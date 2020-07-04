## 关闭作业

请求地址：
`PATCH https://api.cnblogs.com/api/edu/homework/close/{schoolClassId}/{homeworkId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


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


