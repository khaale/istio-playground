#!/bin/bash

helm install api-gateway ./helm/api-gateway/ --namespace greeting
helm install grpc-service ./helm/grpc-service/ --namespace greeting
