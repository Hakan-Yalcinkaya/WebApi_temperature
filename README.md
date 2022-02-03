"Cmd" üzerinden uygulamanın olduğu dizine giriş yaptıktan sonra.
 -- docker build . -t webapi 
 komutu execute ettikten sonra image oluşmuş olacaktır.
 Daha sonrasında containerımızı oluşturmak için
 -- docker run -d -p 3080:80 --name webapi webapi
 komutunu çalıştırırız. webapi isimli containerımız oluşur.
 http://localhost:3080/ adresinden servise ulaşabiliriz.
