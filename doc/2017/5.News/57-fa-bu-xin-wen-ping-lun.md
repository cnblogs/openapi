## 发布新闻评论

请求地址：
`POST https://api.cnblogs.com/api/news/{newsId}/comments`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
  "ParentId": 1,
  "Content": "sample string 2"
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|newsId|number|是|新闻编号|528994|



