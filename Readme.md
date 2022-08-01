protoc ./proto/users.proto --js_out=import_style=commonjs:generated --grpc-web_out=import_style=commonjs,mode=grpcwebtext:generated


protoc ./proto/users.proto --grpc-web_out=import_style=typescript,mode=grpcwebtext:generated![image](https://user-images.githubusercontent.com/3081487/182104330-f6526f5f-9e6e-40d4-a5b5-79e1b0959b30.png)
