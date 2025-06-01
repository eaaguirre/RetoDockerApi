# reto3-Dicker-Edinson-FIXED

## Requisitos
- .NET 8 SDK
- Docker
- Trivy

## Ejecutar localmente
```bash
dotnet run --project src/ApiReto3
```

## Pruebas
```bash
dotnet test
```

## Docker
```bash
docker build -t api-reto3-dotnet .
docker run -p 5000:80 api-reto3-dotnet
```

## Trivy
```bash
trivy image api-reto3-dotnet
```
