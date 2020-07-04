## 删除评论

请求地址：
`DELETE https://api.cnblogs.com/api/questions/{questionId}/answers/{answerId}/comments/{commentId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|questionId|string|是|问题id||
|answerId|string|是|回答id||
|commentId|string|是|评论id||


详细说明：
```
根据问题ID，回答ID， 以及评论ID 来删除评论，只能删除自己的评论。
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

