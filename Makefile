all: prod

prod:
	dotnet run

dev:
	ASPNETCORE_ENVIRONMENT=Development dotnet run

reset_db:
	dotnet ef database drop -f
	dotnet ef database update

docker_build:
	docker build . -t swsec-aspnet

docker_run:
	docker run --rm -p 9000:9000 -p 9001:9001 --name test_dotnet swsec-aspnet:latest
	
