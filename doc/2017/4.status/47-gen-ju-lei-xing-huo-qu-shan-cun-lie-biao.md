## 根据类型获取闪存列表

请求地址：
`GET https://api.cnblogs.com/api/statuses/@{type}?pageIndex={pageIndex}&pageSize={pageSize}&tag={tag}`

请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|type|string|是|类型||
|pageIndex|string|是|页码||
|pageSize|string|是|页容量||
|tag|string|是|标签||


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

