# MongoStack
A web api app with image storage and retrieval


To upload an image:
```
POST /api/image/upload HTTP/1.1
Host: dteske.me:59823
Cache-Control: no-cache
Postman-Token: 934d02d0-5461-aa3b-d39a-9020b3e84b18
Content-Type: multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW
```


To get an image by name:
```
GET /api/image/MaryDarkKnightText.png HTTP/1.1
Host: dteske.me:59823
Cache-Control: no-cache
Postman-Token: 1dc3a85d-2821-1f9b-6221-aa8f825f1ba4
```

To see all images by name:
```
GET /api/image/_all HTTP/1.1
Host: dteske.me:59823
Cache-Control: no-cache
Postman-Token: a004d790-acc8-0eac-4f11-e9cd9915408f
```
