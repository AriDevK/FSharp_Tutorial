FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FSharp_Tutorial/FSharp_Tutorial.fsproj", "FSharp_Tutorial/"]
RUN dotnet restore "FSharp_Tutorial/FSharp_Tutorial.fsproj"
COPY . .
WORKDIR "/src/FSharp_Tutorial"
RUN dotnet build "FSharp_Tutorial.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FSharp_Tutorial.fsproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FSharp_Tutorial.dll"]
