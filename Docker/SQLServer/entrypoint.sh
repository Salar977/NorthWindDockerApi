#!/bin/bash
set -e

# Start SQL Server in background
/opt/mssql/bin/sqlservr &

# Wait until SQL Server responds
echo "Waiting for SQL Server to start..."
until /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "$SA_PASSWORD" -Q "SELECT 1" > /dev/null 2>&1
do
  echo "SQL Server not ready yet, retrying in 2s..."
  sleep 2
done

echo "SQL Server is ready, running restore script..."
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "$SA_PASSWORD" -i /usr/src/app/restore.sql

# Keep SQL Server in foreground
wait
