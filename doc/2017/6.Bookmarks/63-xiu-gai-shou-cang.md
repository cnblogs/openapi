## 修改收藏

请求地址：
`PATCH https://api.cnblogs.com/api/bookmarks/{id}`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
  "WzLinkId": 1,
  "Title": "sample string 2",
  "LinkUrl": "sample string 3",
  "Summary": "sample string 4",
  "Tags": [
    "sample string 1",
    "sample string 2"
  ]
}
```

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|id|string|是|收藏编号||



