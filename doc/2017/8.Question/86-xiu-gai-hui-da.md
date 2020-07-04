## 修改回答

请求地址：
`PATCH https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|
请求参数示例：
```
{
    "Answer":"XXx",
    "UserID": 1001
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|questionId|string|是|问题ID||
|answerId|string|是|回答ID||
|Answer|string|是|回答内容||
|UserID|string|是|用户ID||


详细说明：
```
修改回答
```

返回示例：
```
{
  "Answer": "sample string 1"
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|Version||string|
|Content||string|
|StatusCode||string|
|ReasonPhrase||string|
|Headers||string|
|RequestMessage||string|
|IsSuccessStatusCode||string|

