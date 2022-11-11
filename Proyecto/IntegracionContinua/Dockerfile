#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
ARG source			   
WORKDIR /app
EXPOSE 80
EXPOSE 443		  

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Servicios.API/Servicios.API.csproj", "Servicios.API/"]
COPY ["Transversal.DT/Transversal.DT.csproj", "Transversal.DT/"]
COPY ["Negocio.BM/Negocio.BM.csproj", "Negocio.BM/"]
COPY ["AccesoDatos.DA/AccesoDatos.DA.csproj", "AccesoDatos.DA/"]
RUN dotnet restore "Servicios.API/Servicios.API.csproj"
COPY . .
WORKDIR "/src/Servicios.API"
RUN dotnet build "Servicios.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Servicios.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Servicios.API.dll"]