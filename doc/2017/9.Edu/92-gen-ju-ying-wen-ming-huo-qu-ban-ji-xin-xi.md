## 根据英文名获取班级信息
请求地址：
`GET https://api.cnblogs.com/api/edu/schoolclass/{universityNameEn}/{classNameEn}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|universityNameEn|string|是|校区英文名|ruc|
|classNameEn|string|是|班级英文名|software-engineering-13|

返回示例：
```
{
    "schoolClassId": 1,
    "icon": "http://images2015.cnblogs.com/blog/1/201604/1-20160430154644191-2093926076.png",
    "url": "/campus/ruc/software-engineering-13",
    "nameCn": "软件工程13级",
    "nameEn": "software-engineering-13",
    "postCount": 22,
    "memberCount": 0,
    "bulletinCount": 0,
    "universityId": 1,
    "creatorBlogId": 0,
    "lastPostTime": "2016-04-11T22:48:00",
    "universityNameCn": "中国人民大学",
    "universityNameEn": "ruc",
    "courseEnd": null,
    "dateAdded": "2017-06-29T19:27:24.2872093",
    "isActive": false
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|schoolClassId|班级Id|number|
|icon|班级图标|string|
|url|班级链接|string|
|nameCn|班级中文名|string|
|nameEn|班级英文名|string|
|postCount|博文数|number|
|memberCount|成员数|number|
|bulletinCount|公告数|number|
|universityId|校区Id|number|
|creatorBlogId|创建者博客Id|number|
|lastPostTime|最后发表博文时间|datetime|
|universityNameCn|校区中文名|string|
|universityNameEn|校区英文名|string|
|courseEnd|结课时间|datetime|
|dateAdded|创建时间|datetime|
|isActive|是否活跃|boolean|


