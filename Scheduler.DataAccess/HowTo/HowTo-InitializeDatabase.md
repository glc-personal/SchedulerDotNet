# HowTo-InitializeDatabase

## Summary
This HowTo covers the way to initialize the database which is necessary for starting development
on a different computer, if the Entity Framework (EF) migrations is deleted (this can be done on
purpose to start the database from scatch), or truly from scratch.

## Content
- Access the Project Manager Console
- Initialize the Database
- Update the Database

## Access the Project Manager Console
To access the project manager console, navigate via *Tools* > *NuGet Package Manager* >
*Package Manager Console*.

## Initialize the Database
To initialize the database (assuming that the repositories for each model have already been created,
these repository classes will be tables in the database, how to create a reposity is in the 
_HowTo-CreateRepository_. If this is the case the database can be initialized via an
_Add-Migration_ command in the Packacge Manager Console. For this project, we will need to specify
what the startup project is and what project has the repositories. For example our command would look
like:
```
PM> Add-Migration InitialCreate -StartupProject SchedulerDotNet -Project Scheduler.DataAccess
```
The _InitialCreate_ labels our migration and **PM>** is the Package Manager Console prompt. 
This migration is local and does not affect the actual database.
To do this we need to update the database which is covered in the next section.

## Update the Database
To actually modify the database a _Update-Database_ command must be executed, once again the startup
project and project where the repositories are must be specified, so for our project, this would look like:
```
PM> Update-Database -StartupProject SchedulerDotNet -Project Scheduler.DataAccess
```