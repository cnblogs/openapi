## 修改公告

请求地址：
`PATCH https://api.cnblogs.com/api/edu/bulletin/modify/{bulletinId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "schoolClassId": 8,
    "content": "请大家将开题报告以markdown的方式发到别人的博客上"
}```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|bulletinId|number|是|公告Id||
|schoolClassId|number|是|操作人班级Id||
|content|string|是|内容||


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


