# TIN4483 - Xây dựng ứng dụng với .NET Framework
Phần mềm
1. Visual Studio 2022
2. Postman - https://www.postman.com/
3. GET https://dev.husc.edu.vn/tin4483/api
POST https://dev.husc.edu.vn/tin4483/api/login
BODY TYPE x-www-form-urlencode: username/password
Response { r:1, m:'token-value' }
POST https://dev.husc.edu.vn/tin4483/api/userinfo
HEADER : token lấy từ bước đăng nhập
POST https://dev.husc.edu.vn/tin4483/api/register
BODY TYPE x-www-form-urlencode: username[/password/fullname/email]
POST https://dev.husc.edu.vn/tin4483/api/userupdate
HEADER : token lấy từ bước đăng nhập
BODY TYPE x-www-form-urlencode: [password/fullname/email]

