FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

COPY . ./
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet restore && dotnet tool restore && dotnet ef database update

EXPOSE 9000 9001

ENTRYPOINT ["dotnet", "run"]
