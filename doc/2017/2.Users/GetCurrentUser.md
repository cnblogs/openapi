## 获取当前登陆用户信息

请求地址：
`GET https://api.cnblogs.com/api/users`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|

返回示例：

```
{
  "UserId": "4566ea6b-f2b3",
  "SpaceUserId": 2,
  "BlogId": 3,
  "DisplayName": "sample string 4",
  "Face": "sample string 5",
  "Avatar": "sample string 6",
  "Seniority": "sample string 7",
  "BlogApp": "sample string 8"
}
```

返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|UserId|用户id|string|
|SpaceUserId|用户显示名称id|number|
|BlogId|博客id|number|
|DisplayName|显示名称|string
|Face|原图头像url|string|
|Avatar|缩略图url|string|
|Seniority|园龄|string|
|BlogApp|博客名|string|