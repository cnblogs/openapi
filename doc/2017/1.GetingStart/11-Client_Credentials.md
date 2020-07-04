## client\_credentials示例

接口地址:  
`POST  https://oauth.cnblogs.com/connect/token`

请求头:

| 类型 | 参数 |
| :---: | :---: |
| Content-Type | application/x-www-form-urlencoded |

请求主体:

| 参数名 | 类型 | 说明 | 示例 |
| :---: | :---: | :---: | :---: |
| client\_id | string | 授权Id | BDB525D7-13C9-440E-AF03-6ADF87ACC8D6 |
| client\_secret | string | 授权秘钥 | fcppsSlXNqtoWMnQMKYduT49E5I6rAaxfXAHotTQjibXedaJ92sTCUrJEdFYYrnOS |
| grant\_type | string | 授权方案 | client\_credentials |

返回示例:

```
{
    "access_token": "cppsSlXNqtoWMnQMKYduT49E5I6rAaxfXAHotTQjibXedaJ92sTCUrJEdFYYrn",
    "expires_in": 86400,
    "token_type": "Bearer"
}
```

参数说明:

| 参数 | 说明 |
| :---: | :---: |
| access\_token | 访问令牌 |
| expires\_in | 令牌有效时间 |
| token\_type | 令牌类型 |

