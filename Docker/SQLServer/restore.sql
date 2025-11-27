RESTORE DATABASE NorthwindDb
FROM DISK = '/usr/src/app/backups/NORTHWIND.bak'
WITH MOVE 'Northwind' TO '/var/opt/mssql/data/Northwind.mdf',
     MOVE 'Northwind_log' TO '/var/opt/mssql/data/Northwind.ldf',
     REPLACE;
GO
