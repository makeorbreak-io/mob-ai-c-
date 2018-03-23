FROM mob-ai-csharp:latest

RUN mkdir /robot/
ADD mob-ai-csharp/multipaint /robot/mob-ai-csharp/multipaint
ADD mob-ai-csharp/ /robot/mob-ai-csharp/
ADD mob-ai-csharp/lib/*.dll /robot/lib/
ADD mob-ai-csharp.sln /robot/

WORKDIR /robot/
RUN dotnet build mob-ai-csharp.sln
RUN cd /robot/mob-ai-csharp/

WORKDIR /robot/mob-ai-csharp/

ENTRYPOINT dotnet run