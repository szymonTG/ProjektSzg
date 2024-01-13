# Simple Library Management App 
###student's project for .NET Core lab.  
App shows books in possesion of the Library, User views (access restricted to e.g. Employees view) and Admin views (all pages available).

Used packages:  

    AspNetCore.Identity 6.0.0  
    AspNetCore.EntityFrameworkCore 6.0.0  

Database sample data creation code:

```
/*
Users:
admin@biblioteka.pl
tomasz@wypozyczalnia.pl

were created manually on the webpage

*/

USE [aspnet-ProjektSzg-0F7FEDC0-A163-4F11-B105-A76D223F9936]
GO

INSERT INTO [dbo].[AspNetRoles]
           ([Id]
           ,[Name]
           ,[NormalizedName]
           ,[ConcurrencyStamp])
     VALUES
           (1
           ,'Admin'
           ,'ADMIN'
           ,NULL)
		   ,(2
           ,'User'
           ,'USER'
           ,NULL)
GO


INSERT INTO [dbo].[AspNetUserRoles]
           ([UserId]
           ,[RoleId])
     VALUES
           ('8d40190d-7ab9-4dee-8a00-9b31aa981109'
           ,1), ('a83c5573-dca4-4ce4-b9bf-6457fb56d2fa'
           ,2)
GO

INSERT INTO [dbo].[TableUsers]
           ([firstName]
           ,[surname]
           ,[telNumber])
     VALUES
           ('Tomasz'
           ,'Przykładowy'
           ,1894566789)
		   ,('Piotr'
           ,'Przypadkowy'
           ,1894599889)
GO

INSERT INTO [dbo].[TableEmployees]
           ([employeeName]
           ,[employeeSurname]
           ,[telNumber])
     VALUES
           ('Simon'
           ,'Von Admin'
           ,789123456)
		   ,('Tomasz'
           ,'Sampliński'
           ,789123457)
		   
GO


INSERT INTO [dbo].[TableBooks]
           ([title]
           ,[author]
           ,[isbn])
     VALUES
           ('Sample Book Vol.1'
           ,'Sample Author'
           ,'1234567891235')
		   ,('Sample Book Vol.2'
           ,'Sample Author'
           ,'1234567891236')
		   ,('Sample Book Vol.3'
           ,'Sample Author & Friends'
           ,'1234567891237')
GO



INSERT INTO [dbo].[TableBookRentals]
           ([startDate]
           ,[endDate]
           ,[userId]
           ,[UsersuserId]
           ,[bookId]
           ,[BooksbookId])
     VALUES
           (GETDATE()-5
           ,NULL
           ,3
           ,3
           ,1
           ,1),
		   (GETDATE()-4
           ,GETDATE()-1
           ,4
           ,4
           ,2
           ,2)
GO


```
