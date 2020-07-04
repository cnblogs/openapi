## 分页获取班级公告列表
请求地址：
`GET https://api.cnblogs.com/api/edu/schoolclass/bulletins/{schoolClassId}/{pageIndex}-{pageSize}`

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
    "bulletins": [
        {
            "bulletinId": 10,
            "content": "沈航软件工程13级默认班级公告",
            "publisher": "sun-le",
            "blogUrl": "http://www.cnblogs.com/sunle/",
            "dateAdded": "2017-09-06T11:38:35.9192169"
        }
    ]
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|totalCount|公告总数|number|
|bulletins|公告列表|array|
|bulletins.bulletinId|公告Id|number|
|bulletins.content|内容|string|
|bulletins.publisher|发布者|string|
|bulletins.blogUrl|发布者博客|string|
|bulletins.dateAdded|发布时间|datetime|



