## 发起投票

请求地址：
`POST https://api.cnblogs.com/api/edu/vote/publish`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "schoolClassId": 1,
    "title": "职业规划",
    "content": "毕业后想从事什么方向?",
    "picture": null,
    "voteMode": 3,
    "privacy": 1,
    "deadline": "2017-09-10 17:00",
    "voteOptions": [
        "web前端开发",
        "后端开发",
        "软件测试"
    ]
}
```



请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|操作人班级Id||
|title|string|是|标题||
|content|string|是|内容||
|picture|string|是|图片链接||
|voteMode|number|是|模式（1.单选、2.多选、3.排名）||
|privacy|number|是|隐私（1.公开、2.匿名）||
|deadline|datetime|是|截止时间||
|voteOptions|array|是|投票选项||


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


