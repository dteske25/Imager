FROM microsoft/dotnet:1.1-sdk-msbuild
COPY . /app
WORKDIR /app
 
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
 
EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT Production
ENV MongoConnectionString "mongodb://dteske.me"
 
ENTRYPOINT ["dotnet", "run"]