# Start with the SQL Server image
FROM mcr.microsoft.com/mssql/server:2022-CU13-ubuntu-20.04

# Set environment variables required for SQL Server
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Password12345!

# Create directories for backups and scripts
RUN mkdir -p /var/opt/mssql/backups /var/opt/mssql/scripts

# Copy the .bak file into the container
COPY *.bak /var/opt/mssql/backups/

# Copy the restore script into the container
COPY restore.sql /var/opt/mssql/scripts/

# Expose SQL Server's default port
EXPOSE 1433

# Start SQL Server and execute the restore script, then keep SQL Server running in the foreground
CMD /opt/mssql/bin/sqlservr & \
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $SA_PASSWORD -i /var/opt/mssql/scripts/restore.sql && \
    tail -f /dev/null