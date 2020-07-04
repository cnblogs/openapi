## 获取成员投票项

请求地址：
`GET https://api.cnblogs.com/api/edu/vote/committed/options/{memberId}/{voteId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|memberId|number|是|成员Id|1|
|voteId|number|是|投票Id|1|

返回示例：
```
"一般，我会写好的"
```













