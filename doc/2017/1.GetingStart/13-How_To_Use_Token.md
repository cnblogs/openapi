## 1.4 如何使用Token?

Token的使用非常的简单,只需要在每次在请求Api,在`Header`添加`Authorization`以及`Bearer {token}`即可。

示例如下：
`GET https://api.cnblogs.com/api/users`

请求头:

| 类型 | 参数 |
| :---: | :---: |
| Authorization | Bearer {token} |

>注意:`Bearer`和`token`之间有一个空格.









