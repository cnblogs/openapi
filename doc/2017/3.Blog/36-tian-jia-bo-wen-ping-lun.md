## 添加博文评论

请求地址：
`POST https://api.cnblogs.com/api/blogs/{blogApp}/posts/{postId}/comments`



请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|
|Content-Type|application/json|

请求参数示例：
```
{
    "body":"Coding changes the world"
}
```
请求参数说明:

|参数名|类型|说明|示例|
|:---:|:---:|:---:|:---:|
|blogApp|string|博客名||
|postId|string|博客编号||



