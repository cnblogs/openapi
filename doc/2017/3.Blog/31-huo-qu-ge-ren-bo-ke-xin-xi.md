## 获取个人博客信息

请求地址：
`GET https://api.cnblogs.com/api/blogs/{blogApp}`



请求参数头：


|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|


请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|blogApp|string|是|博客名|hellocnblogs|




返回示例：
```
{
    "blogId": 40823,
    "title": "it新闻",
    "subtitle": "提供最新IT资讯",
    "postCount": 33,
    "pageSize": 10,
    "enableScript": false
}
```
返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|blogId|博客id|number|
|title|标题|string|
|subtitle|子标题|string|
|postCount|博客数量|number|
|pageSize|页内容|number|
|enableScript|是否加密|boolean|