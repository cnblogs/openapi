## 编辑作业

请求地址：
`PATCH https://api.cnblogs.com/api/edu/homework/edit/{homeworkId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "operatorInfo": {
        "schoolClassId": 1,
        "blogId": 269831
    },
    "title": "作业要求 20170907",
    "startTime": "2017-09-10 12:00",
    "deadline": "2017-09-12 17:00",
    "content": "<p>评分规则</p><p>截止时间前提交，有分。<br />补交，0分; 先计为负分，一周内补交改为0分。<br />晚交，倒扣; 迟于截止时间一周，倒扣本题分数。<br />抄袭，倒扣本次作业分数。<br />按教师和专家意见修改，在截止时间以前完成的，计入成绩。</p>",
    "formatType": 1,
    "IsShowInHome": true
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|homeworkId|number|是|作业Id||
|operatorInfo|object|是|操作人信息||
|operatorInfo.schoolClassId|number|是|操作人班级Id||
|operatorInfo.blogId|number|是|操作人博客Id||
|title|string|是|标题||
|startTime|datetime|是|起始时间||
|deadline|datetime|是|截止时间||
|content|string|是|内容||
|formatType|number|是|格式类型（1.TinyMce、2.Markdown）||
|IsShowInHome|boolean|是|是否首页显示||





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


