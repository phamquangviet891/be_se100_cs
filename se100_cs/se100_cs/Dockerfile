# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "se100_cs.csproj" --disable-parallel
RUN dotnet publish "se100_cs.csproj" -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "se100_cs.dll"]

#docker build -t 20522153/se100:1.0.7 .
#docker push 20522153/se100:1.0.7

#docker run -d -p 5000:80 20522153/se100:1.0.8