# Build e Teste

Rodar o projeto via .NET Core CLI:

```bash
dotnet run -p ./src/Wombo.Api
```

Rodar projeto via Docker:

```bash
docker build -f ./src/Wombo.Api/Dockerfile -t wombo/wombo.api .
docker run -d -p 5000:80 --name wombo-api wombo/wombo.api
```
