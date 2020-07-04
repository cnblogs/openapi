## 根据Id获取作业信息

请求地址：
`GET https://api.cnblogs.com/api/edu/homework/{homeworkId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|homeworkId|number|是|作业Id|1|

详细说明：
```
格式类型为markdown时，需要使用“convertedContent”字段来显示作业内容
```


返回示例：
```
{
    "homeworkId": 9,
    "title": "作业要求 20170907",
    "content": "&lt;p&gt;评分规则&lt;/p&gt;\n&lt;p&gt;截止时间前提交，有分。&lt;br /&gt;补交，0分; 先计为负分，一周内补交改为0分。&lt;br /&gt;晚交，倒扣; 迟于截止时间一周，倒扣本题分数。&lt;br /&gt;抄袭，倒扣本次作业分数。&lt;br /&gt;按教师和专家意见修改，在截止时间以前完成的，计入成绩。&lt;/p&gt;",
    "formatType": 1,
    "convertedContent": null,
    "description": "评分规则 截止时间前提交，有分。补交，0分; 先计为负分，一周内补交改为0分。晚交，倒扣; 迟于截止时间一周，倒扣本题分数。抄袭，倒扣本次作业分数。按教师和专家意见修改，在截止时间以前完成的，计入成绩。",
    "answerCount": 0,
    "isClosed": false,
    "publisher": "sun-le",
    "displayName": null,
    "blogUrl": "http://www.cnblogs.com/sunle/",
    "avatarUrl": null,
    "schoolClassId": 8,
    "startTime": null,
    "deadline": "2017-09-10T17:00:00",
    "isShowInHome": false,
    "isFinished": true,
    "displayTime": "2017-09-10T16:24:05.2909972"
}
```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|homeworkId|作业Id|number|
|title|标题|string|
|content|内容|string|
|formatType|格式类型（1.TinyMce、2.Markdown）|number|
|convertedContent|markdown转换内容|string|
|description|描述|string|
|answerCount|答案数|number|
|isClosed|是否关闭|boolean|
|publisher|发布者|string|
|blogUrl|发布者博客|string|
|avatarUrl|发布者头像|string|
|schoolClassId|班级Id|number|
|startTime|起始时间|datetime|
|deadline|截止时间|datetime|
|isShowInHome|是否首页显示|boolean|
|isFinished|是否完成|boolean|
|displayTime|发布时间|datetime|



