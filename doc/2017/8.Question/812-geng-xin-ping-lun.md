## 更新评论

请求地址：
`PATCH https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}/comments/{commentId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|
请求参数示例：
```
{
    "Content" :"Robert Comment From Question Api",
    "PostUserID":1111
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|questionId|number|是|问题id||
|answerId|number|是|问题id||
|commentId|number|是|评论Id||
|Content|string|是|||
|PostUserID|number|是|提交者ID||

详细说明：
```
更新评论
```

返回示例：
```
{
  "Content": "sample string 1",
  "ParentCommentId": 2
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

