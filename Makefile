all: dev

prod:
	dotnet run

dev:
	ASPNETCORE_ENVIRONMENT=Development dotnet run

reset_db:
	dotnet ef database drop -f
	dotnet ef database update
