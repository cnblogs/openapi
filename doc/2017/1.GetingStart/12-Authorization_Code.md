## authorization\_code示例

---

`authorization_code`比起`client_credentials`要稍微复杂一些。`authorization_cdoe`获取token主要分两步走：

1. [获取授权码]()
2. [获取token]()

> `authorization_code`授权只要针对调用需要用户登录的api时需要。如果你调用接口的时候,如果返回`403`的时候,很可能需要使用`authorization_code`获取的`token`.

### 1.1 获取授权码

请求地址：  
`GET https://oauth.cnblogs.com/connect/authorize`  
请求参数:

| 参数名 | 类型 | 说明 | 示例 |
| :---: | :---: | :---: | :---: |
| client\_id | string | 授权Id | BDB525D7-13C9-440E-AF03-6ADF87ACC8D6 |
| scope | string | 默认 | openid profile CnBlogsApi offline\_access |
| response\_type | string | 默认 | code id\_token |
| redirect\_uri | string | 默认 | [https://oauth.cnblogs.com/auth/callback](https://oauth.cnblogs.com/auth/callback) |
| state | string | 随机字符串 | q12w2aj8627hd7 |
| nonce | string | 随机字符串 | u17j3g73hh3hg3jh3 |

返回示例:

```
https://oauth.cnblogs.com/auth/callback#code=c38fee53637dea2967f123e1c92184d854b03db03dcd87323ea60675b8125b2e&id_token=eyJhbGciOiJSUzI1NiIsImtpZCI6IjlFMjcyMkFGM0IzRTFDNzU5RTI3NEFBRDI5NDFBNzg1MDlCMDc2RDAiLCJ0eXAiOiJKV1QiLCJ4NXQiOiJuaWNpcnpzLUhIV2VKMHF0S1VHbmhRbXdkdEEifQ.eyJuYmYiOjE1MDU4MTM0NjEsImV4cCI6MTUwNTgxMzc2MSwiaXNzIjoiaHR0cHM6Ly9vYXV0aC5jbmJsb2dzLmNvbSIsImF1ZCI6IkZBQTgxRTJFLTM5ODItNDgzMC04RjMyLTYyOUUyNjk1RDBFRSIsIm5vbmNlIjoieHl6IiwiaWF0IjoxNTA1ODEzNDYxLCJjX2hhc2giOiJTbUZ3bUZUeGFuSDhqa3U3VW5XeGxRIiwic3ViIjoiMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDAwMDAwMDAwIiwiYXV0aF90aW1lIjoxNTA1ODEzNDYxLCJpZHAiOiJjbmJsb2dzX29hdXRoIiwiYW1yIjpbImF1dGhvcml6YXRpb25fY29kZSJdfQ.AurcP3x4OPjmc-koA0wZI3VDNB4zFb74lYwbga0YbwZG4GORgoRwjD3LNDbHxRFaXNsteTNbypS3TA7Mef4Wf-VmpwABa15SEcV5zDLW6UHvTvEllJor_1O4PvW6Ze95D1PARobZ6zF2gJosEXYKarZUcT1NFhUMD4btJBn5Ww9vMdCdm_dGFx3Sz4n2fn1WSTIM_WELu3HFGUu-7YCX9UFy3Bwsx8VNXP0ajG76S85kL1cDI8I9jJGj6ifxutOSrhFMGgTw-e1QMa8F3mGJAGPJma_dGTNPQJX15xG-masmvAC02739sRLPubtHJ-8Yx22xCBLGbyPOJ0sw1XHQBQ&scope=openid%20profile%20CnBlogsApi&state=abc
```

说明：

`获取授权码`接口调试，需要在浏览器中测试,发送get请求，需要用户登录。用户登录成功后,登录成功后需要自己授权截取链接中`code`参数。为下一步做准备。

>注意:`code`的有效时间是10分钟,并且一个`code`只能换取一次`token`.

### 1.2 获取token

请求地址:

`POST https://oauth.cnblogs.com/connect/token`

请求头:

| 类型 | 参数 |
| :---: | :---: |
| Content-Type | application/x-www-form-urlencoded |

请求主体:

|参数名|类型|说明|示例|
|:---:|:---:|:---:|:---:|
| client\_id | string | 授权Id | BDB525D7-13C9-440E-AF03-6ADF87ACC8D6 |
| client\_secret | string | 授权秘钥 | fcppsSlXNqtoWMnQMKYduT49E5I6rAaxfXAHotTQjibXedaJ92sTCUrJEdFYYrnOS |
| grant\_type | string | 授权方案 | authorization_code |
|code|string|授权码|c38fee53637dea2967f123e1c92184d854b03db03dcd87323ea60675b8125b2e|
|redirect_uri|string|回调地址（默认）|https://oauth.cnblogs.com/auth/callback

返回示例:

```
{
    "id_token":"oS8PzTN9WnR7qZrelHriLMaC0MvsHEWKzgfLX9uH_HCj0VZZjkyQlFTHTBUrCW0J5U6mW2Pgzd0Gjt0vZcZbPQG4fAuUuPINpY9g_nr",
    "access_token": "oS8PzTN9WnR7qZrelHriLMaC0MvsHEWKzgfLX9uH_HCj0VZZjkyQlFTHTBUrCW0J5U6mW2Pgzd0Gjt0vZcZbPQG4fAuUuPINpY9g_nr",
    "expires_in": 86400,
    "token_type": "Bearer",
    "refresh_token": "oS8PzTN9WnR7qZrelHriLMaC0MvsHEWKzgfLX9uH_HCj0VZZjkyQlFTHTBUrCW0J5U6mW2Pgzd0Gjt0vZcZbPQG4fAuUuPINpY9g_nr"
}
```

参数说明:

| 参数 | 说明 |
| :---: | :---: |
| id_token | 用户信息令牌 |
| access_token | 访问令牌 |
| expires_in | 令牌有效时间 |
| token_type | 令牌类型 |
|refresh_token| refresh_token|

### 1.3 refresh_token

在一些使用场景中,token到期,用户就需要重新登录的时候,`refresh_token`可以很好的解决这个问题。可以使用`refresh_token`去换取`token`.

请求地址:

`POST https://oauth.cnblogs.com/connect/token`

请求头:

| 类型 | 参数 |
| :---: | :---: |
| Content-Type | application/x-www-form-urlencoded |

请求主体:

|参数名|类型|说明|示例|
|:---:|:---:|:---:|:---:|
| client_id | string | 授权Id | BDB525D7-13C9-440E-AF03-6ADF87ACC8D6 |
| client_secret | string | 授权秘钥 | fcppsSlXNqtoWMnQMKYduT49E5I6rAaxfXAHotTQjibXedaJ92sTCUrJEdFYYrnOS |
| grant_type | string | 授权方案 | refresh_token |
|refresh_token|string|授权码||
|redirect_uri|string|回调地址（默认）|https://oauth.cnblogs.com/auth/callback

返回示例:

```
{
    "id_token":"oS8PzTN9WnR7qZrelHriLMaC0MvsHEWKzgfLX9uH_HCj0VZZjkyQlFTHTBUrCW0J5U6mW2Pgzd0Gjt0vZcZbPQG4fAuUuPINpY9g_nr",
    "access_token": "oS8PzTN9WnR7qZrelHriLMaC0MvsHEWKzgfLX9uH_HCj0VZZjkyQlFTHTBUrCW0J5U6mW2Pgzd0Gjt0vZcZbPQG4fAuUuPINpY9g_nr",
    "expires_in": 86400,
    "token_type": "Bearer",
    "refresh_token":"oS8PzTN9WnR7qZrelHriLMaC0MvsHEWKzgfLX9uH_HCj0VZZjkyQlFTHTBUrCW0J5U6mW2Pgzd0Gjt0vZcZbPQG4fAuUuPINpY9g_nr" "oS8PzTN9WnR7qZrelHriLMaC0MvsHEWKzgfLX9uH_HCj0VZZjkyQlFTHTBUrCW0J5U6mW2Pgzd0Gjt0vZcZbPQG4fAuUuPINpY9g_nr"
}
```

参数说明:

| 参数 | 说明 |
| :---: | :---: |
| id_token | 用户信息令牌 |
| access_token | 访问令牌 |
| expires_in | 令牌有效时间 |
| token_type | 令牌类型 |
|refresh_token| refresh_token|


