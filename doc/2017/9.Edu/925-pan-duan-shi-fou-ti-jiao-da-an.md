## 判断是否题交答案

请求地址：
`GET https://api.cnblogs.com/api/edu/answer/iscommitted/{memberId}/{homeworkId}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|memberId|number|是|成员Id|1|
|homeworkId|number|是|作业Id|1|



返回示例：
```
true
```




