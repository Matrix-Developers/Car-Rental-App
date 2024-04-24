# locadora-de-veiculos
Aplicativo C# de locação de automóveis.

# Setup
- Requires .NET Framework version 4.8 installed.
	- If not installed automatically, [get the official installation here](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks?cid=getdotnetsdk)
- Needs to have a working SQL Server Express LocalDB intance running. By default we use the "MSSQLLocalDb" instance
	- To verify if a intance of LocalDB exists, use the  command:
	`SqlLocalDb info`
	- To run an existing instance of LocalDB, use the  command:
	`SqlLocalDb start NameOfTheDesiredDB`
	- If the commands above are not recognized as an internal or external command, [follow this tutorial to install LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16)
- Connect your Visual Studio IDE to a running SQL Server Express LocalDB instance using the "Server Explorer" tab
- Finally, its necessary to update the Entity Framework's migrations
	- On the Visual Studio's "Package Manager Console", run the following command to create a new migration:
	`add-migration devmigration`
	- Update the database scheme with the following command:
	`update-database`