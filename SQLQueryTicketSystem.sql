USE [master]
GO
/****** Object:  Database [Ticket system]    Script Date: 27.12.2021 15:07:32 ******/
CREATE DATABASE [Ticket system]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ticket system', FILENAME = N'D:\SQL SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ticket system.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ticket system_log', FILENAME = N'D:\SQL SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ticket system_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ticket system] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ticket system].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ticket system] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ticket system] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ticket system] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ticket system] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ticket system] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ticket system] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ticket system] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ticket system] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ticket system] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ticket system] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ticket system] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ticket system] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ticket system] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ticket system] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ticket system] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ticket system] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ticket system] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ticket system] SET TRUSTWORTHY ON 
GO
ALTER DATABASE [Ticket system] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ticket system] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ticket system] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ticket system] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ticket system] SET RECOVERY FULL 
GO
ALTER DATABASE [Ticket system] SET  MULTI_USER 
GO
ALTER DATABASE [Ticket system] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ticket system] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ticket system] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ticket system] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ticket system] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ticket system', N'ON'
GO
ALTER DATABASE [Ticket system] SET QUERY_STORE = OFF
GO
USE [Ticket system]
GO
/****** Object:  Table [dbo].[Access]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Access](
	[IDAccess] [int] IDENTITY(1,1) NOT NULL,
	[Rights] [varchar](100) NOT NULL,
	[IDAuth] [int] NOT NULL,
	[Author] [varchar](200) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Access] PRIMARY KEY CLUSTERED 
(
	[IDAccess] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authorization]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authorization](
	[IDAuth] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[IDRole] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[IDUser] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IDAuth] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriesEvents]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriesEvents](
	[IDCategory] [int] IDENTITY(1,1) NOT NULL,
	[Category] [varchar](300) NOT NULL,
 CONSTRAINT [PK_CategoriesEvents] PRIMARY KEY CLUSTERED 
(
	[IDCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[IDEvents] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](500) NOT NULL,
	[IDCategory] [int] NOT NULL,
	[NumbersOfVisitors] [int] NOT NULL,
	[IDOrganisation] [int] NOT NULL,
	[Status] [varchar](100) NOT NULL,
	[IDAccess] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[IDEvents] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logging]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logging](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Action] [varchar](max) NOT NULL,
	[Who] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Logging] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization](
	[IDOrganization] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](300) NOT NULL,
	[PhoneNumber] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[IDOrganization] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Place]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Place](
	[IDPlace] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](300) NOT NULL,
	[City] [varchar](100) NOT NULL,
	[Address] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Place] PRIMARY KEY CLUSTERED 
(
	[IDPlace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IDRole] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](40) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IDRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDTicket] [uniqueidentifier] NOT NULL,
	[NameOrganisation] [varchar](300) NOT NULL,
	[EmailBuyer] [varchar](100) NOT NULL,
	[IDEvent] [int] NOT NULL,
	[IDPlace] [int] NOT NULL,
	[IDType] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeTicket]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeTicket](
	[IDType] [int] NOT NULL,
	[Cost] [decimal](18, 2) NOT NULL,
	[Title] [varchar](400) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_TypeTicket] PRIMARY KEY CLUSTERED 
(
	[IDType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 27.12.2021 15:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IDUser] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[Surname] [varchar](100) NOT NULL,
	[Patronymic] [varchar](100) NOT NULL,
	[DateBirth] [datetime] NOT NULL,
	[Sex] [char](1) NOT NULL,
 CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Access]  WITH CHECK ADD  CONSTRAINT [FK_Access_AuthorizationUser] FOREIGN KEY([IDAuth])
REFERENCES [dbo].[Authorization] ([IDAuth])
GO
ALTER TABLE [dbo].[Access] CHECK CONSTRAINT [FK_Access_AuthorizationUser]
GO
ALTER TABLE [dbo].[Authorization]  WITH CHECK ADD  CONSTRAINT [FK_AuthorizationUser_Users] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Authorization] CHECK CONSTRAINT [FK_AuthorizationUser_Users]
GO
ALTER TABLE [dbo].[Authorization]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Roles] ([IDRole])
GO
ALTER TABLE [dbo].[Authorization] CHECK CONSTRAINT [FK_Users_Roles]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Access] FOREIGN KEY([IDAccess])
REFERENCES [dbo].[Access] ([IDAccess])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Access]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_CategoriesEvents] FOREIGN KEY([IDCategory])
REFERENCES [dbo].[CategoriesEvents] ([IDCategory])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_CategoriesEvents]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Organization] FOREIGN KEY([IDOrganisation])
REFERENCES [dbo].[Organization] ([IDOrganization])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Organization]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Events] FOREIGN KEY([IDEvent])
REFERENCES [dbo].[Events] ([IDEvents])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Events]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Place] FOREIGN KEY([IDPlace])
REFERENCES [dbo].[Place] ([IDPlace])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Place]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_TypeTicket1] FOREIGN KEY([IDType])
REFERENCES [dbo].[TypeTicket] ([IDType])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_TypeTicket1]
GO
USE [master]
GO
ALTER DATABASE [Ticket system] SET  READ_WRITE 
GO
