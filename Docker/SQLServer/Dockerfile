# Start with the SQL Server image
FROM mcr.microsoft.com/mssql/server:2022-CU13-ubuntu-20.04

# Set environment variables required for SQL Server
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Password12345!

# Switch to root user
USER root
RUN mkdir -p /usr/src/app

COPY *.bak /usr/src/app/backups/
COPY restore.sql /usr/src/app/
COPY entrypoint.sh /usr/src/app/

RUN chmod +x /usr/src/app/entrypoint.sh

USER mssql
EXPOSE 1433

CMD ["/usr/src/app/entrypoint.sh"]