## 获取投票统计

请求地址：
`GET https://api.cnblogs.com/api/edu/vote/stats/{voteId}/{isRankMode}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|voteId|number|是|投票Id|1|
|isRankMode|boolean|是|是否排名模式|true|

详细说明：
```
排名模式无需“recordCount”字段，非排名模式无需“ranking”字段
```

返回示例：
```
[
    {
        "voteOptionId": 23,
        "voteOption": "No.3 软件测试",
        "recordCount": 0,
        "ranking": 3
    },
    {
        "voteOptionId": 21,
        "voteOption": "No.2 web前端开发",
        "recordCount": 0,
        "ranking": 2
    },
    {
        "voteOptionId": 22,
        "voteOption": "No.1 后端开发",
        "recordCount": 0,
        "ranking": 1
    }
]
```
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|voteOptionId|投票选项Id|number|
|voteOption|投票选项|string|
|recordCount|投票数|number|
|ranking|排名|number|



