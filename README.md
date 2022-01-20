# CampSleepaway
School project.
A project (Console app) that uses Entity Framework. The app should simulate a camp with campers, cabins, counselors and next of kin. The project should also account for history. 

To run the project, make sure to change the connection string so that it has your server name. The connection string is in the persistence project, in the DataContext class. 

<h1>Solution:</h1> 
Design pattern: Clean architecture. 
The solution is devided into 4 different projects: 

<h3>1- Domain: Class library</h3>
This project contains only the models. 

<h3>2- Persistence: Class library</h3>
This project has a dependency on Domain. The project contains EFCore PKG. 
Here is the connection to the database using DataContext class. There is also a Seed class to seed the DB with some data. 
Also in this project, Repository pattern is implemented to simplify handling data. 

<h3>3- Application: Class library</h3>
This project has a dependency on Persistence. 
Here is the business logic. All use cases are included in this project as Handlers. 
Those handlers takes arguments like ID etc. and returns a string. This string can then be shown to the user. 

<h3>4- Presentation: Console application</h3>
This project has a dependency on Application. 
Here we have a menu system that shows the options to the user and allow to choose only using the up and down arrows. 
In the menu system, when the user choose an option. A call is made to the Application project and a string is returned from application to show to the user. 

