FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["GeometryLib.Console/GeometryLib.Console.csproj", "GeometryLib.Console/"]
RUN dotnet restore "GeometryLib.Console/GeometryLib.Console.csproj"
COPY . .
WORKDIR "/src/GeometryLib.Console"
RUN dotnet build "GeometryLib.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GeometryLib.Console.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GeometryLib.Console.dll"]
