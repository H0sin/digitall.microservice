USE master;
GO

-- Restore database from disk
RESTORE DATABASE DigitallDb
FROM DISK = '/var/opt/mssql/data/sqlserver-data.bak'
WITH MOVE 'DigitallDb' TO '/var/opt/mssql/data/DigitallDb.mdf',
MOVE 'DigitallDb_log' TO '/var/opt/mssql/data/DigitallDb_log.ldf',
REPLACE;
GO
