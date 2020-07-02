#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SJT - Sua Jornada na Tecnologia/SJT - Sua Jornada na Tecnologia.csproj", "SJT - Sua Jornada na Tecnologia/"]
RUN dotnet restore "SJT - Sua Jornada na Tecnologia/SJT - Sua Jornada na Tecnologia.csproj"
COPY . .
WORKDIR "/src/SJT - Sua Jornada na Tecnologia"
RUN dotnet build "SJT - Sua Jornada na Tecnologia.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SJT - Sua Jornada na Tecnologia.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SJT - Sua Jornada na Tecnologia.dll"]