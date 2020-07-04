## 答案打分

请求地址：
`PATCH https://api.cnblogs.com/api/edu/answer/marking/{answerId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "schoolClassId": 1,
    "score": 9.2
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|answerId|number|是|答案Id||
|schoolClassId|number|是|操作人班级Id||
|score|number|是|分数||






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


