## 提问

请求地址：
`POST https://api.cnblogs.com/api/questions`

请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|
请求参数示例：
```
{
    "Title" : "WebApi 提问（标题（6～200字符））",
    "Content" :"WebApi 提问内容（20～100000字符）",
    "Tags": "sample string 3（不超过五个标签）",
    "Flags": "1",
    "UserID":1001
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|Title|string|是|问题标题||
|Content|string|是|问题内容||
|Tags|string|是|问题标签||
|Flags|number|是|发布标志|1 表示发布至首页，2表示不发布至首页|
|UserID|string|是|用户ID||

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

