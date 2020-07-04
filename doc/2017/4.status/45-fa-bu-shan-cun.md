## 发布闪存

请求地址：
`POST https://api.cnblogs.com/api/statuses`

请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
  "Content": "sample string 1",
  "IsPrivate": true
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|Content|string|是|内容||
|IsPrivate|string|是|是否私有||

返回示例：
```
{
  "Content": "sample string 1",
  "IsPrivate": true
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

