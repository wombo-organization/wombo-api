# Build e Teste

O projeto pode ser rodado de forma nativa com os comandos do .NET Core CLI:
```
dotnet run -p ./src/Wombo.Api
```

O projeto também é compatível com docker. Sendo assim é possível criar uma imagem e rodá-la em um container utilizando os comandos abaixo:
```
docker build -f ./src/Wombo.Api/Dockerfile -t wombo/api .
```
```
docker run -d -p 5000:80 --name wombo-api wombo/api
```