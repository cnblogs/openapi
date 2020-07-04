## 获取投票选项

请求地址：
`GET https://api.cnblogs.com/api/edu/vote/options/{voteId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|voteId|number|是|投票Id|1|



返回示例：
```
[
    {
        "voteOptionId": 18,
        "voteOption": "很容易，已经写好"
    },
    {
        "voteOptionId": 19,
        "voteOption": "一般，我会写好的"
    },
    {
        "voteOptionId": 20,
        "voteOption": "较难，我需要帮助才能写好"
    }
]
```
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|voteOptionId|投票选项Id	|number|
|voteOption|投票选项|string|


