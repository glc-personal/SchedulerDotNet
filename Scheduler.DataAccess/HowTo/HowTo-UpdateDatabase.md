# HowTo-UpdateDatabase
## Summary
This HowTo is designated to showing how to update the database using Entity Framework (EF) 
Migrations without having to use SQL Server Management Studio (SSMS).

## Content
- Update the Model
- Update the Database Context
- Perform an Add-Migration using EF
- Update the Database using EF
- Verify the Change via SSMS

## Update the Model
The initial step to making a change to the project's database is to make the desired change
to the Model (this model is a table in the database). For example, if we want to add a
ProfilePicturePath (which is a string) to our User Model we would need to add it to our 
User Model (User.cs).

## Update the Database Context 
If we are creating any initial data within the Database Context method OnModelCreating,
then the change we made to the model needs to be represented there. For our modification
to the User model example, in this case we do have an initial user being created so the
ProfilePicturePath needs to be set here.

## Perform an Add-Migration using EF
To prepare the changes to our database we need to perform an EF migration, in this case 
we have SchedulerDotNet as our startup project but Scheduler.DataAccess is the Project
of focus so to add our migration we need to open the Package Manager Console 
(Tools > NuGet Package Manager > Package Manager Console). At the prompt (PM>) execute the 
following command:
```
Add-Migration AddUserProfilePicturePath -StartupProject SchedulerDotNet -Project Scheduler.DataAccess
```

## Update the Database using EF
Once the migration has been added (in this case we added the _AddUserProfilePicturePath_ migration) 
we can update the database. For our continued example the command would look like:
```
Update-Database -StartupProject SchedulerDotNet -Project Scheduler.DataAccess
```
Once again at the Package Manager Console prompt (PM>).

## Verify the Change via SSMS
The modifications to the table or database can be verified using the SSMS. Go to the database
of interest, then to the tables if necessary. Select the desired table or tables (in this case we 
are interested in the User table and need to see if a new column has been added for 
_ProfilePicturePath_).