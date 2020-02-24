FROM  cakebuild/cake:2.1-sdk-mono
COPY . /app
WORKDIR  /app
 
RUN ["chmod", "+x", "./build.sh"]

ENTRYPOINT ["./build.sh"]