## 重发公告

请求地址：
`POST https://api.cnblogs.com/api/edu/bulletin/republish/{schoolClassId}/{bulletinId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|bulletinId|number|是|公告Id||
|schoolClassId|number|是|操作人班级Id||



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


