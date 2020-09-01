# TestTask

For the start project you must execute the following commands to connect the necessary libraries at Package Manager Console in Visual Studio 2019:
1) install-package microsoft.entityframeworkcore.sqlserver;
2) install-package microsoft.entityframeworkcore.design;
3) install-package microsoft.entityframeworkcore.tools; 
4) install-package swashbuckle.aspnetcore;

After these command you must create or use existing database.
For the creating use next commands:
  1) add-migration <name>
  2) update-database
  3) also you must change connection string in appsettings.json
For the using of existing db just change connection string in appsettings.json
