FROM microsoft/dotnet:latest
COPY . /app
WORKDIR  /app
 
ENTRYPOINT sudo ./build.sh