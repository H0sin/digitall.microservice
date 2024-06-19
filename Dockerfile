FROM mcr.microsoft.com/mssql/server:2019-latest

# Copy restore script into container
COPY restore_script.sql /docker-entrypoint-initdb.d/

# Grant permissions for the restore script to execute
USER root
RUN chown -R mssql:mssql /docker-entrypoint-initdb.d/restore_script.sql
USER mssql
