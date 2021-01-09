#!/bin/bash

apiGatewayVersion=0.1.0
grpcServiceVersion=0.1.1

docker build -t khaale/greeting-api-gateway:${apiGatewayVersion} -f ./ApiGateway/Dockerfile .
docker build -t khaale/greeting-grpc-service:${grpcServiceVersion} -f ./GrpcService/Dockerfile .
