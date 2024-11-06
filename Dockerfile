# Use the official .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

# Copy the remaining files and build the application
COPY . ./
RUN dotnet restore
RUN dotnet dev-certs https
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet tool restore
RUN dotnet ef database update

# Expose the port your application runs on
EXPOSE 9000 9001

# Run the application
ENTRYPOINT ["dotnet", "run"]