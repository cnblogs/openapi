## 修改答案

请求地址：
`PATCH https://api.cnblogs.com/api/edu/answer/modify/{answerId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "schoolClassId": 1,
    "title": "软件工程-构建之法 团队",
    "url": "http://www.cnblogs.com/lisiyu/p/5419159.html",
    "postId": 10000,
    "remark": null
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|answerId|number|是|答案Id||
|schoolClassId|number|是|操作人班级Id||
|title|string|是|标题||
|url|string|是|链接||
|postId|number|是|博文Id||
|remark|string|是|备注||





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


