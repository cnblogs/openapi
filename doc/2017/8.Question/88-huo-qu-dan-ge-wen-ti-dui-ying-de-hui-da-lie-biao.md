## 获取单个问题对应的回答列表

请求地址：
`GET https://api.cnblogs.com/api/questions/{questionId}/answers`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|questionId|string|是|问题ID||


详细说明：：
```
根据问题ID返回该问题的回答列表
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

