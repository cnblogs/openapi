## 根据新闻Id分页获取新闻评论

请求地址：
`GET https://api.cnblogs.com/api/news/{newsId}/[ { "commentID": 287365, "contentID": 528922, "commentContent": "单纯想象一下就觉得很疯狂啊。", "userGuid": "e14bccfd-3ed8-df11-ac81-842b2b196315", "userId": 168112, "userName": "Firen", "faceUrl": "https://pic.cnblogs.com/face/168112/20151104135814.png", "floor": 1, "dateAdded": "2015-09-11T17:02:49.653", "agreeCount": 0, "antiCount": 0, "parentCommentID": 0, "parentComment": null }, { "commentID": 287370, "contentID": 528922, "commentContent": "霍金可以试一下", "userGuid": "68a4f62b-cdfd-df11-ac81-842b2b196315", "userId": 224049, "userName": "`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|newsId|string|是|新闻id||
|pageIndex|number|是|页码||
|pageSize|number|是|页容量||


返回示例：
```
[
    {
        "commentID": 287365,
        "contentID": 528922,
        "commentContent": "单纯想象一下就觉得很疯狂啊。",
        "userGuid": "e14bccfd-3ed8-df11-ac81-842b2b196315",
        "userId": 168112,
        "userName": "Firen",
        "faceUrl": "https://pic.cnblogs.com/face/168112/20151104135814.png",
        "floor": 1,
        "dateAdded": "2015-09-11T17:02:49.653",
        "agreeCount": 0,
        "antiCount": 0,
        "parentCommentID": 0,
        "parentComment": null
    }
]

```
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|commentID|评论编号|number|
|contentID|内容编号|number|
|commentContent|评论内容|string|
|userGuid|用户编号|string|
|userId|用户编号|number|
|userName|用户名	|string|
|faceUrl|头像地址|string|
|floor||number|
|dateAdded|添加时间|string|
|agreeCount|赞同人数|number|
|antiCount|反对人数|number|
|parentCommentID||number|
|parentComment||string|
