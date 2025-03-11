FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY LibraryAutomation.Base/*.csproj ./LibraryAutomation.Base/
COPY LibraryAutomation.CLI/*.csproj ./LibraryAutomation.CLI/
COPY *.sln ./
RUN dotnet restore

COPY LibraryAutomation.Base/. ./LibraryAutomation.Base/
COPY LibraryAutomation.CLI/. ./LibraryAutomation.CLI/

RUN dotnet publish LibraryAutomation.CLI -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "LibraryAutomation.CLI.dll"]