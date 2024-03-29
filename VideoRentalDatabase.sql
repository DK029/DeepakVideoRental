USE [master]
GO
/****** Object:  Database [VideoRentalDatabase]    Script Date: 12/11/2019 4:05:32 PM ******/
CREATE DATABASE [VideoRentalDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRentalDatabase_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoRentalDatabase_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalDatabase.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoRentalDatabase] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRentalDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRentalDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRentalDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRentalDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRentalDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRentalDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRentalDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRentalDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRentalDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRentalDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRentalDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRentalDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRentalDatabase] SET QUERY_STORE = OFF
GO
USE [VideoRentalDatabase]
GO
/****** Object:  Table [dbo].[BookRecord]    Script Date: 12/11/2019 4:05:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookRecord](
	[RentUniqID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[VideoId] [int] NULL,
	[VideoIssueDate] [varchar](50) NULL,
	[VideoReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[RentUniqID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/11/2019 4:05:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerUniqId] [int] IDENTITY(1,1) NOT NULL,
	[FrstName] [varchar](50) NULL,
	[LstName] [varchar](50) NULL,
	[PhoneNo] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerUniqId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video]    Script Date: 12/11/2019 4:05:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video](
	[VideoUniqID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Ratting] [varchar](50) NULL,
	[Year] [int] NULL,
	[Copies] [int] NULL,
	[Cost] [int] NULL,
	[Plot] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[VideoUniqID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [VideoRentalDatabase] SET  READ_WRITE 
GO
