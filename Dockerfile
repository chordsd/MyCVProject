# Use the official .NET SDK image as the build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything and publish the release
COPY . .
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image as the runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Define the entry point for the application
ENTRYPOINT ["dotnet", "MyCVProject.dll"]
