## 获取用户班级列表
请求地址：
`GET https://api.cnblogs.com/api/edu/member/schoolclasses`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|




返回示例：
```
[
    {
        "schoolClassId": 1,
        "url": "/campus/ruc/software-engineering-13",
        "nameCn": "软件工程13级",
        "universityNameCn": "中国人民大学",
        "courseEnd": null
    }
]
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|schoolClassId|班级Id|number|
|url|班级链接|string|
|nameCn|班级中文名|string|
|universityNameCn|校区中文名|string|
|courseEnd|结课时间|datetime|










