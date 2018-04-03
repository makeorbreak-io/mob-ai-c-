FROM mob-ai-csharp:latest

RUN mkdir /robot/
ADD mob-ai-csharp.csproj /robot/
ADD multipaint /robot/multipaint
ADD Bot.cs /robot/Bot.cs

WORKDIR /robot/
RUN dotnet build --configuration Release

ENTRYPOINT ["dotnet", "bin/Release/netcoreapp2.0/Bot.dll"]
