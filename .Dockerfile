FROM microsoft/dotnet:latest
COPY . /app
WORKDIR  /app
 
ENTRYPOINT ./build.sh