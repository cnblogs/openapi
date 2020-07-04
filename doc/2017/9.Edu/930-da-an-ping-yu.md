## 答案评语

请求地址：
`PATCH https://api.cnblogs.com/api/edu/answer/suggest/{answerId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "schoolClassId": 1,
    "suggestion": "部分探讨的内容深度还要加强。"
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|answerId|number|是|答案Id||
|schoolClassId|number|是|操作人班级Id||
|suggestion|string|是|评语||


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


