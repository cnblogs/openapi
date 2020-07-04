## 获取当前班级作业

请求地址：
`GET https://api.cnblogs.com/api/edu/homeworks/current/{schoolClassId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|schoolClassId|string|是|班级Id|1|




返回示例：
```
[
    {
        "homeworkId": 10,
        "title": "使用markdown编辑器",
        "description": "使用markdown编辑器",
        "answerCount": 0,
        "publisher": "sun-le",
        "blogUrl": "http://www.cnblogs.com/sunle/",
        "displayTime": "2017-09-11T12:06:36.478281"
    }
]
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|homeworkId|作业Id|number|
|title|标题|string|
|description|描述|string|
|answerCount|答案数|number|
|publisher|发布者|string|
|blogUrl|发布者博客|string|
|displayTime|发布时间|datetime|



