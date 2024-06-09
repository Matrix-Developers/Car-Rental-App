# Car Rental App
The Car Rental App is a complete Windows Forms C# .NET CRUD application with almost market-level business logic used to manage the rental of vehicles on a Car Rental Store. As a CRUD application, it allows to create, read, update, and delete data entries from Employees, Clients, Services, Cupons, Partners, Groups of Vehicles, Vehicles, Rentals and Devolutions. To manage the data entries, a valid registered employee must log using valid credentials.

The app uses Entity Framework ORM for the Database Integration to allow better data scalability and maintenance.

Many other auxiliary libraries were also used, including: "Serilog" for logs, "Moq" for tests that require the use of a mock, "Autofac" for dependency injection and "PdfSharp" for the PDFs of the rental receips.

Finally, the application have a considerable test coverange of 126 tests, divided between Application Tests, ORM Tests and Unit Tests.

# Environment Setup
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


# Features

### Log-in Scren
To actually open the Car Rental App, you must enter a valid username and password of a registered Employee. To demonstration reasons, you can also bypass this screen using "admin" as both User and Password. 

![Login screen](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/075b4049-68bc-40b5-8a56-b4d52a10a89c)


### Dashboard
The Dashboard allows the user to view the most important information on the Car Rental App:
- In the "Vehicle" Area, its possible to visualize the ammount of registered Cars, how many are available (able to rent) and unavailable ( curently rented).
- In the "Client" Area, its possible to visualize the ammount of registered clients and how many of them are either legal or natural entities.
- In the "Rental" Area, its possible to visuazlie the ammount total ammount of car rents accomplished, how many of the open leases return today and how many return in at least 7 days.
- In the "Services" Area, its possibile to visualize the total ammount of registered rental services

![dashboard](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/d762d69d-c544-4d80-b358-fb222c65acec)

### Records Tab
This tab allows the managemenet most basic data entries related to a rental, including Employees, Clients, Services, Groups of Vehicles, Vehicles
![image](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/7c9e3157-e492-44ec-b43e-504be4117187)

![Vehicles](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/95700d67-4350-4181-b5fc-bd2dae8e770d)

You can register new entries or update and delete existing ones. For register and update, keep in mind that many of the fields are validated and will show a error message in the main screen footnote in case of error.

![Register Client](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/2c8ee273-e3a0-4609-a82e-0cea4bc35367)

![Register Service](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/7705c5dc-54dc-4267-9531-bd81c1a95204)

![Edit Vehicle](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/965c1429-5e6c-433d-8568-d76853f12c7b)

![Edit Employee](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/4cff7dfd-2bf1-419d-a532-f3e879331baf)

![Delete Employee](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/7a7c2a8f-fc08-435a-a70e-1e84d3255d12)


### Discounts Tab 
Discounts are an optional feature that allows user to get discounts when applying for a car rental. This tabs allow to manage the data entry related to the coupon and his coupons.

![image](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/f02cc02d-719b-4db5-9a8e-7a1f226725e9)
![cupouns](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/5e2bc618-c056-4e9b-91fe-c8af802f30f7)
![Register Partner](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/5eae0b76-65d7-45cd-8c08-3bc96e854553)
![Register Cupoun](https://github.com/Matrix-Developers/Locadora-de-Veiculos/assets/50923316/9fab7d29-3f6d-4416-addc-70c4e593b36b)


### Rental Tab
todo
