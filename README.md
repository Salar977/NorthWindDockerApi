# Northwind Docker API

## Overview

This project is a web API for managing the Northwind database, running inside a Docker container with SQL Server and Nginx for reverse proxying.
The API is built using ASP.NET Core, MS SQLServer 2022, Nginx and Docker.

## Features

- **Web API**: Exposes endpoints to interact with the Northwind database.
- **SQL Server**: Stores data in the Northwind database inside a Docker container.
- **Nginx**: Acts as a reverse proxy, routing requests to the API and serving static content.


## Requirements

- .NET 9
- MS SQLServer 2022
- Nginx
- Docker
- Docker Compose

## Getting Started

1. Clone this repository:
   ```bash
   git clone https://github.com/Salar977/NorthWindDockerApi.git
   cd NorthWindDockerApi
2. Build the Docker Containers
   ```bash
    docker-compose up -d
3. Access the API
   
   Once the containers are running, the API can be accessed at the following URLs:
   ```bash
   Nginx Page: http://localhost/
   Health endpoint: http://localhost/health/
   Customers endpoint: http://localhost/customers/
   Customer by id: http://localhost/customers/<customerId>
