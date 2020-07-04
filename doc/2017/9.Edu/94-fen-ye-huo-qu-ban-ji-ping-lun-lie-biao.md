## 分页获取班级评论列表
请求地址：
`GET https://api.cnblogs.com/api/edu/schoolclass/comments/{schoolClassId}/{pageIndex}-{pageSize}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|number|是|班级Id|1|
|pageIndex|number|是|页码|10|
|pageSize|number|是|页容量|10|

返回示例：
```
{
    "totalCount": 10,
    "comments": [
        {
            "title": "Re:结对编程--黄金分割点游戏",
            "url": "http://www.cnblogs.com/sunle/p/5368754.html#3413603",
            "sourceUrl": "http://www.cnblogs.com/sunle/p/5368754.html",
            "formattedBody": "请按规范模式贴代码，必要时给出解释",
            "commenterName": "郑蕊",
            "commenterUrl": "http://www.cnblogs.com/zhengrui0452/",
            "commenterAvatar": "/images/noavatar.png",
            "dateAdded": "2016-04-20T20:19:17"
        }
    ]
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|totalCount|评论总数|number|
|comments|评论列表|array|
|comments.title|标题|string|
|comments.url|链接|string|
|comments.sourceUrl|博文链接|string|
|comments.formattedBody|评论内容|string|
|comments.commenterName|评论人|string|
|comments.commenterUrl|评论人博客|string|
|comments.commenterAvatar|评论人头像|string|
|comments.dateAdded|评论时间|datetime|



