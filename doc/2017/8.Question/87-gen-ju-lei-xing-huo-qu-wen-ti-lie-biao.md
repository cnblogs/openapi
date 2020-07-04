## 根据类型获取问题列表

请求地址：
`GET https://api.cnblogs.com/api/questions/@{type}?pageIndex={pageIndex}&pageSize={pageSize}`

请求参数头：

|参数名|参数值|
|:---:|:---:|
|Authorization|Bearer {token}|

请求参数说明：

|参数名|类型|必须|描述|示例 e.g.|
|:---:|:---:|:---:|:---:|:---:|
|type|string|是|列表类型|高分问题，已解决，新回答等|
|pageIndex|number|是|页码|默认为 1|
|pageSize|number|是|页面容量|默认为 25|
|spaceUserId|number|是|用户ID|默认为 0|

详细说明：：
```
根据列表类型，获取相对应的问题列表，主要有下面几种类型：
问题首页列表:                                type = "unsolved"
高分问题列表:                                type = "highscore"
零回答问题列表:                             type = "noanswer"
已解决问题列表:                             type = "solved"
某个用户提问的问题列表:               type = "myquestion" 
某个用户未解决的问题列表:            type = "myunsolved" 
某个用户回答的问题列表:               type = "myanswer" 
某个用户回答被采纳的问题列表:     type = "mybestanswer" 


```


返回参数说明：

|参数名|描述|类型|
|:---:|:---:|:---:|
|Version||string|
|Content||string|
|StatusCode||string|
|ReasonPhrase||string|
|Headers||string|
|RequestMessage||string|
|IsSuccessStatusCode||string|

