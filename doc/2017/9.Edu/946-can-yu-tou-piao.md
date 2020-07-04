## 参与投票

请求地址：
`POST https://api.cnblogs.com/api/edu/vote/commit/{voteId}/{isRankMode}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "schoolClassId": 1,
    "voteOptionIds": [ 3,5 ]
}
```



请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|voteId|number|是|投票Id||
|isRankMode|number|是|是否排名模式||
|schoolClassId|number|是|操作人班级Id||
|voteOptionIds|array|是|投票选项Id||


详细说明：
```
返回值“isWarning”为true时，则对应“message”字段中的内容

```

返回示例：
```
{
    "isSuccess": true,
    "isWarning": false,
    "isError": false,
    "message": null
}
```


