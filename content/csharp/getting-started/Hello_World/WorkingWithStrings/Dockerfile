﻿FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WorkingWithStrings/WorkingWithStrings.csproj", "WorkingWithStrings/"]
RUN dotnet restore "WorkingWithStrings/WorkingWithStrings.csproj"
COPY . .
WORKDIR "/src/WorkingWithStrings"
RUN dotnet build "WorkingWithStrings.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WorkingWithStrings.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WorkingWithStrings.dll"]
