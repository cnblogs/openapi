## 获取成员博文列表

请求地址：
`GET https://api.cnblogs.com/api/edu/answer/posts/{blogId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|blogId|number|是|博客Id|10000|




返回示例：
```
[
    {
        "id": 3,
        "title": "软件工程学习进度条",
        "url": "http://www.cnblogs.com/sunle/p/5372010.html",
        "description": "第一周 第二周 第三周 第四周 第五周 第六周 学习时间 四小时 六小时 七小时 十二小时 十五小时 十五小时 代码量 100 100 150 150 200 200 博客量 100 200 200 300 300 400 学习到的知识 随机函数 四则运算与git的配置 git的使用 统计词频 网页",
        "viewCount": 10,
        "diggCount": 0,
        "commentCount": 0,
        "author": "sun-le",
        "blogUrl": "http://www.cnblogs.com/sunle/",
        "dateAdded": "2016-04-09T16:55:00"
    }
]
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|id|博文Id|number|
|title|标题|string|
|url|链接|string|
|description|描述|string|
|viewCount|浏览数|number|
|diggCount|推荐数|number|
|commentCount|评论数|number|
|author|作者|string|
|blogUrl|博客链接|string|
|dateAdded|发布时间|datetime|








