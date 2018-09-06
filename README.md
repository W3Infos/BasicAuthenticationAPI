# BasicAuthenticationAPI
Basic Authentication in web api c#

1.Create a WEBAPI PROJECT as BasicAuthenticationAPI
2.Create a Web Application another project as ClientSerivece
3.Create another project for Data Access from DB as DataAccess
 
4. Create two class files in BasicAuthenticationAPI root directory
.     UserSecurity.cs
.     BasicAuthentciationAttribute.cs

paste the code from above files.

5. Create DataEntityModel in DataAcess project and give referenence to the main API project

6. Create index.html file in ClientSerivec project and paste the code from above file

# DB details: tbl1
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](200) NULL,
	[Password] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Blood] [nvarchar](50) NULL,
	[Country] [nvarchar](200) NULL,
	[CStates] [nvarchar](200) NULL,
	[City] [nvarchar](200) NULL,
	[Pincode] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[PhoneNumber] [bigint] NULL,
	[District] [nvarchar](400) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

# DB details: tbl2

CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Salary] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



#Note: Insert some sample data:

USE [mmb_db]
GO

INSERT INTO [dbo].[Users]
           ([Username]
           ,[Password]
           ,[Email]
           ,[Blood]
           ,[Country]
           ,[CStates]
           ,[City]
           ,[Pincode]
           ,[CreatedDate]
           ,[PhoneNumber]
           ,[District])
     VALUES
           ('test',
           'test',
           'test',
           'test',
           'test',
          'test',
           'test',
           'test',
           'test',
           'test',
           'test',)
GO


7. Build the project and set startup project on start for API, Web Projects and RUN and tried to login with credentials.
