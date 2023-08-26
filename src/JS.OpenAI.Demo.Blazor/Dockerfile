#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY ../Demo.db ./

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/JS.OpenAI.Demo.Blazor/JS.OpenAI.Demo.Blazor.csproj", "src/JS.OpenAI.Demo.Blazor/"]
COPY ["src/JS.OpenAI.Demo.Application/JS.OpenAI.Demo.Application.csproj", "src/JS.OpenAI.Demo.Application/"]
COPY ["src/JS.OpenAI.Demo.Domain/JS.OpenAI.Demo.Domain.csproj", "src/JS.OpenAI.Demo.Domain/"]
COPY ["src/JS.OpenAI.Demo.Domain.Shared/JS.OpenAI.Demo.Domain.Shared.csproj", "src/JS.OpenAI.Demo.Domain.Shared/"]
COPY ["src/JS.OpenAI.Demo.Application.Contracts/JS.OpenAI.Demo.Application.Contracts.csproj", "src/JS.OpenAI.Demo.Application.Contracts/"]
COPY ["src/JS.OpenAI.Demo.HttpApi/JS.OpenAI.Demo.HttpApi.csproj", "src/JS.OpenAI.Demo.HttpApi/"]
COPY ["src/JS.OpenAI.Demo.EntityFrameworkCore/JS.OpenAI.Demo.EntityFrameworkCore.csproj", "src/JS.OpenAI.Demo.EntityFrameworkCore/"]
RUN dotnet restore "src/JS.OpenAI.Demo.Blazor/JS.OpenAI.Demo.Blazor.csproj"
COPY . .
WORKDIR "/src/src/JS.OpenAI.Demo.Blazor"
RUN dotnet build "JS.OpenAI.Demo.Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JS.OpenAI.Demo.Blazor.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JS.OpenAI.Demo.Blazor.dll"]