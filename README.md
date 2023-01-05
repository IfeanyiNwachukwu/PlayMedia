# PlayMedia
A simple API service utilizing  a CQRS and Microservices approach.

Create Docker Network  =   docker network create --attachable -d bridge myDockerNetwork
View docker networks =  docker network ls

Deploy Mongo Db as a container
docker run -it -d --name mongo-container -p 27017:27017 --network myDockerNetwork --restart always -v mongodb_data_container:/data/db mongo:latest

Deploy Microsoft Sql Server
 docker run -d --name sql-container --network myDockerNetwork --restart always -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$tr0ngS@P@ssw0rd02' -e 'MSSQL_PID=Express' -p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu

** docker-compose up -d

Create a file via Command Line =  type NUL > fileName.fileExtension
