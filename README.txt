DeliveryTrackingAPI is used to track packages.
This is a .NET core application that was built with Visual Syudio 2019 and relies on IIS.
The solution file contains just one project that can be opened in Visual Syudio 2019 and run with IIS express.
Once running, Postman or any similar application can be used to query the endpoints.

Endpoints are:
 - "/api/package/" [get]
    gets all packages
 - "/api/package/{id}" [get]
    gets a package with a given id
 - "/api/package/" [post]
    creates package with a given name as string body
 - "/api/package/{id}" [put]
    updates a package status with values 1, 2, 3, 4 as body
	repersenting PICKED_UP, IN_TRANSIT, WAREHOUSE, DELIVERED respectively
 - "/api/packagestatus/{id}" [get]
    gets all package status for specified package
 - "/api/status" [get]
    get all statuses PICKED_UP, IN_TRANSIT, WAREHOUSE, DELIVERED
 - "/api/status/{id}" [get]
    get status with a given id

The appsettings.json file in the project folder contains the database configuration.
This needs to be changed to reflect the appropriate database.
The database that it relies on can be created using the query below.
Change USE [master] and FILENAME to reflect your environment accordingly.

USE [master]
GO

CREATE DATABASE [DeliveryTrackerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeliveryTrackerDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DeliveryTrackerDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DeliveryTrackerDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DeliveryTrackerDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO


CREATE TABLE [dbo].[Statuses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](60) NOT NULL,
	[MultiplePerPackage] [bit] NOT NULL,
 CONSTRAINT [PK_Statuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO [dbo].[Statuses] ([Name] ,[MultiplePerPackage]) VALUES ('PICKED_UP', 0);
INSERT INTO [dbo].[Statuses] ([Name] ,[MultiplePerPackage]) VALUES ('IN_TRANSIT', 1);
INSERT INTO [dbo].[Statuses] ([Name] ,[MultiplePerPackage]) VALUES ('WAREHOUSE', 1);
INSERT INTO [dbo].[Statuses] ([Name] ,[MultiplePerPackage]) VALUES ('DELIVERED', 0);


CREATE TABLE[dbo].[Packages](
	[Id][int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar] (60) NOT NULL,
CONSTRAINT[PK_Packages] PRIMARY KEY CLUSTERED
(
  [Id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

INSERT INTO [dbo].[Packages] ([Name]) VALUES ('Mr. Anyanwu''s Package');
INSERT INTO [dbo].[Packages] ([Name]) VALUES ('Wedding photos for Madam Njide');
INSERT INTO [dbo].[Packages] ([Name]) VALUES ('Remi''s Stuff...');
INSERT INTO [dbo].[Packages] ([Name]) VALUES ('Aunty Temi''s wedding cake');


CREATE TABLE [dbo].[PackageStatuses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PackageId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
	CONSTRAINT [PK_PackageStatuses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
