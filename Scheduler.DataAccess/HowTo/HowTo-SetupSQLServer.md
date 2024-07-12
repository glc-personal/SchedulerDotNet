# HowTo-SetupSQLServer

## Summary
This HowTo goes through how to setup SQL Server for this project which is necessary for 
development purposes on another computer, for starting from scratch, etc.

## Content
- Install SQL Server
- Install SQL Server Management Studio (SSMS)
- Configure SQL Server
- Update Connection String
- Initialize the Database

## Install SQL Server
To install SQL Server (Express is good enough), click on the following [link](https://go.microsoft.com/fwlink/p/?linkid=2216019&clcid=0x409&culture=en-us&country=us).
Once this is download double click on the item in the downloads folder. SQL Server installation wizard will appear, select the installation type as **Basic**.
Then accept the License Terms, keep the install location as the default (*C:\Program Files\Microsoft SQL Server*), then click *Install*. Once the installation is complete, keep
all defaults for Connection String (it should be *Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;*), SQL Server Install Log Folder, 
Installation Media Folder, and Installation Resources Folder.

## Install SQL Server Management Studio (SSMS)
To install SQL Server Management Studio (SSMS), click on the following [link](https://aka.ms/ssmsfullsetup). To start the install, double click on the SSMS setup wizard in the 
downloads folder. Keep the install location as default (*C:\Program Files (x86)\Microsoft SQL Server Management Studio 20*). Click the *Install* button. Allow changes to the 
device if necessary. After the install the setup for the SSMS will be complete. Open SSMS by searching for it in the Windows search bar and on the login screen when it 
opens check the *Trust server certificate* box.

## Configure SQL Server
To configure the SQL Server you must open the SQL Server Configuration Manager (this can be done by searching for the SQL Server Configuration Manager from the Windows
search bar). You can ensure that the SQL Server (SQLEXPRESS) instance is running by checking out the SQL Server Services option on the left hand side of the the UI.
If it is running you should see the Name *SQL Server (SQLEXPRESS)* with a state of *Running*, otherwise it would say *Stopped*. Enable TCP/IP for the SQL Server instance by going to the 
SQL Server Network Configuration option on the left hand side of the UI. From there double click on *Protocols for SQLEXPRESS* (this should be seen on the right hand side 
of the UI. If the TCP/IP protocol has a status of *Disabled*, right-click on the TCP/IP protocol and select *Enable*, confirm that this is what you want to do. Now the 
TCP/IP must be configured, to do this right click on the TCP/IP protocol and go to the *IP Address* tab, set the TCP Port to 1433 under the IPAll section (scroll all the way down).
Enable all the ports (IP1, IP2, etc), then apply the changes and confirm you want to make these changes. Once this is complete the SQL Server Service must be restarted.
To do this go to the left pane and click on SQL Server Services, right clicj on SQL Server (SQLEXPRESS) and select to restart it, this should take a few seconds.

## Update Connection String 
In the projects *appsettings.json* ensure that the *DefaultConnection* is set to 
```
"Server={LOCAL_SERVER_NAME}\\SQLEXPRESS;Database=SchedulerDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
```
where *LOCAL_SERVER_NAME* is the name of the local server. If you are unsure what this is, open SSMS and on the login window you will see the Server Name with the 
server instance (in this project we are using SQLEXPRESS). So for example, if you see for Server Name DESKTOP-6BL7COI\SQLEXPRESS, the LOCAL_SERVER_NAME for the 
connection string would be the DESKTOP-6BL7COI.

## Initialize the Database
If starting from scratch, follow the HowTo-InitializeDatabase file, otherwise we can use the projects existing migrations to setup our database on a new computer
if necessary. This can be done via the *Update-Database* command in the Package Manger Console (*Tools* > *NuGet Package Manager* > *Package Manager Console*).
We need to tell it what our startup project is and the project which containts the database context (our repositories), so our command would look like:
```
PM> Update-Database -StartupProject SchedulerDotNet -Project Scheduler.DataAccess
```
To verify that the database was setup, go to SSMS, and in the Object Explorer, under Databases, you should see SchedulerDB, our projects database.