USE [master]
GO
/****** Object:  Database [MyDiaryDB]    Script Date: 11/24/2022 6:55:37 PM ******/
CREATE DATABASE [MyDiaryDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyDiaryDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyDiaryDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyDiaryDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MyDiaryDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MyDiaryDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyDiaryDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyDiaryDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyDiaryDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyDiaryDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyDiaryDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyDiaryDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyDiaryDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyDiaryDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyDiaryDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyDiaryDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyDiaryDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyDiaryDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyDiaryDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyDiaryDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyDiaryDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyDiaryDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyDiaryDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyDiaryDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyDiaryDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyDiaryDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyDiaryDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyDiaryDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyDiaryDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyDiaryDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MyDiaryDB] SET  MULTI_USER 
GO
ALTER DATABASE [MyDiaryDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyDiaryDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyDiaryDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyDiaryDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyDiaryDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MyDiaryDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyDiaryDB', N'ON'
GO
ALTER DATABASE [MyDiaryDB] SET QUERY_STORE = OFF
GO
USE [MyDiaryDB]
GO
/****** Object:  Table [dbo].[Diary]    Script Date: 11/24/2022 6:55:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diary](
	[DiaryId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Contents] [nvarchar](max) NOT NULL,
	[Date] [date] NOT NULL,
	[UserId] [int] NOT NULL,
	[Favorite] [bit] NULL,
 CONSTRAINT [PK_Diary] PRIMARY KEY CLUSTERED 
(
	[DiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/24/2022 6:55:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Gender] [bit] NOT NULL,
	[Dob] [date] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](12) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Diary] ON 

INSERT [dbo].[Diary] ([DiaryId], [Title], [Contents], [Date], [UserId], [Favorite]) VALUES (3, N'Test Tiep', N'test', CAST(N'2022-10-28' AS Date), 2, 0)
INSERT [dbo].[Diary] ([DiaryId], [Title], [Contents], [Date], [UserId], [Favorite]) VALUES (4, N'123123', N'123123123', CAST(N'2022-10-28' AS Date), 2, 0)
INSERT [dbo].[Diary] ([DiaryId], [Title], [Contents], [Date], [UserId], [Favorite]) VALUES (5, N'kien ngu', N'133123njonjiuonk', CAST(N'2002-11-11' AS Date), 1, 0)
INSERT [dbo].[Diary] ([DiaryId], [Title], [Contents], [Date], [UserId], [Favorite]) VALUES (17, N'Test', N'test cai add', CAST(N'2022-11-07' AS Date), 1, 0)
INSERT [dbo].[Diary] ([DiaryId], [Title], [Contents], [Date], [UserId], [Favorite]) VALUES (23, N'123123123', N'23123123123', CAST(N'2022-11-07' AS Date), 12, 1)
INSERT [dbo].[Diary] ([DiaryId], [Title], [Contents], [Date], [UserId], [Favorite]) VALUES (25, N'test', N'13123123ff', CAST(N'2022-11-15' AS Date), 1, 0)
INSERT [dbo].[Diary] ([DiaryId], [Title], [Contents], [Date], [UserId], [Favorite]) VALUES (26, N'test1', N'gbrdgbfdgbgdbdb', CAST(N'2022-11-15' AS Date), 1, 0)
SET IDENTITY_INSERT [dbo].[Diary] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (1, N'admin', N'123', N'admin', N'admin', 1, CAST(N'2002-11-11' AS Date), N'Ha Noiiiiii', N'admin@gmail.com', N'0858089828', N'C:\Users\Msi\Downloads\11.jpg')
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (2, N'nghia', N'123', N'Nghia', N'Luong', 1, CAST(N'2002-11-11' AS Date), N'Ha Noi', N'nghia@gmail.com', N'123123123', NULL)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (4, N'nghia2', N'123', N'Nghia', N'Luong', 0, CAST(N'2002-11-11' AS Date), N'Ha Noi', N'nghia2@gmail.com', N'123123123', NULL)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (6, N'mai', N'123', N'Mai', N'Pham', 0, CAST(N'2002-05-19' AS Date), N'Hanoi', N'mai@gmail.com', N'123123123', N'C:\Users\Msi\Downloads\uefa.jpg')
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (7, N'ronaldo', N'123', N'Ronaldo', N'Cristiano', 1, CAST(N'1999-01-01' AS Date), N'BoDaoNha', N'ronaldo@gmail.com', N'123123123', NULL)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (8, N'messi', N'1234', N'Messi', N'Lionel', 1, CAST(N'1977-05-05' AS Date), N'Argen', N'messi@gmail.com', N'0888888888', NULL)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (9, N'admin1', N'123', N'123123', N'123', 1, CAST(N'2022-11-07' AS Date), N'123', N'123', N'23123', NULL)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (11, N'addd', N'123123', N'Luong ', N'Nghia', 0, CAST(N'2022-11-07' AS Date), N'ha Noi', N'123123123@gmail.com', N'123123123', NULL)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (12, N'admin123', N'123123', N'123', N'123', 0, CAST(N'2022-11-07' AS Date), N'123123', N'123123@gmail.com', N'123123123', NULL)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [FirstName], [LastName], [Gender], [Dob], [Address], [Email], [Phone], [Image]) VALUES (13, N'abc', N'123', N'abc', N'abc', 0, CAST(N'2022-11-01' AS Date), N'ha noi', N'gmai@gmail.com', N'09888888888', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Diary]  WITH CHECK ADD  CONSTRAINT [FK_Diary_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Diary] CHECK CONSTRAINT [FK_Diary_Users]
GO
USE [master]
GO
ALTER DATABASE [MyDiaryDB] SET  READ_WRITE 
GO
