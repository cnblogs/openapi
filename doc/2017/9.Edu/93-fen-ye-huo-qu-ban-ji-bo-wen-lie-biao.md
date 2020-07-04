## 分页获取班级博文列表
请求地址：
`GET https://api.cnblogs.com/api/edu/schoolclass/posts/{filter}/{schoolClassId}/{pageIndex}-{pageSize}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|filter|string|是|筛选条件|tutor|
|schoolClassId|number|是|班级Id|1|
|pageIndex|number|是|页码|1|
|pageSize|number|是|页容量|10|

详细说明：
```
筛选条件包含：no_comment（零回复）、tutor（老师/助教）、student（学生）、all（所有）
```

返回示例：
```
{
    "totalCount": 10,
    "blogPosts": [
        {
            "title": "结对编程之黄金分割",
            "url": "http://www.cnblogs.com/QuanQingli/p/5372570.html",
            "description": "结对编程之队友信息 队友：彭扬阳。博客地址http://www.cnblogs.com/zxyoyo/ 结对项目：黄金分割游戏。题目地址http://www.cnblogs.com/qingxu/p/5316897.html 结对编程之队友介绍 这次编程能很有幸和彭同学一组，彭同学平时是一个觉得沉默",
            "viewCount": 45,
            "diggCount": 0,
            "commentCount": 3,
            "author": "正能量制造机",
            "displayName": "正能量制造机(李全清)",
            "blogId": 269776,
            "blogUrl": "http://www.cnblogs.com/QuanQingli/",
            "avatarUrl": "/images/noavatar.png",
            "dateAdded": "2016-04-09T20:36:00"
        }
    ]
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|totalCount|博文总数|number|
|blogPosts|博文列表|array|
|blogPosts.title|标题|string|
|blogPosts.url|链接|string|
|blogPosts.description|描述|string|
|blogPosts.viewCount|浏览数|number|
|blogPosts.diggCount|推荐数|number|
|blogPosts.commentCount|评论数|number|
|blogPosts.author|作者|string|
|blogPosts.displayName|显示名|string|
|blogPosts.blogId|博客Id|number|
|blogPosts.blogUrl|博客链接|string|
|blogPosts.avatarUrl|作者头像|string|
|blogPosts.dateAdded|发表日期|datetime|



