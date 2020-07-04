## 发布闪存评论

请求地址：
`POST https://api.cnblogs.com/api/statuses/{statusId}/comments`

请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
  "ReplyTo": 1,
  "ParentCommentId": 2,
  "Content": "sample string 3"
}
```



请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|statusId|string|是|闪存编号||
|ReplyTo|string|是|||
|ParentCommentId|string|是|||
|Content|string|是|内容||


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

