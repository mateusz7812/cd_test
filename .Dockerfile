FROM  andrewlock/docker-dotnet-mono:latest
COPY . /app
WORKDIR  /app
 
RUN ["chmod", "+x", "./build.sh"]

ENTRYPOINT ["./build.sh"]