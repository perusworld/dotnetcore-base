# .NET Core Web/REST App Base #
.NET Core Web/REST app base code

## Requirements ##
1. .NET Core 1.1+
1. Bower

## Restore dependencies ##
	dotnet restore
	bower install

## Run App ##
	dotnet run --urls "http://*:3000"

## Test App ##
Open browser and goto [http://localhost:3000](http://localhost:3000)

## Test REST APIs -cURL ##
### GET ###
```bash
curl -X GET -H "Accept: application/json" -H "Cache-Control: no-cache" "http://localhost:3000/api/helloREST/peru"
```
### POST ###
```bash
curl -X POST -H "Content-Type: application/json" -H "Cache-Control: no-cache" -d '{
  "msg": "peru"
}' "http://localhost:3000/api/helloREST"
```