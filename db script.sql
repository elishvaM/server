USE [master]
GO
/****** Object:  Database [ElishevaM_HadasB_ListsTrip]    Script Date: 13/07/2023 17:44:01 ******/
CREATE DATABASE [ElishevaM_HadasB_ListsTrip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'trips_lists', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\trips_lists.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'trips_lists_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\trips_lists_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ElishevaM_HadasB_ListsTrip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET ARITHABORT OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET RECOVERY FULL 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET  MULTI_USER 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET QUERY_STORE = OFF
GO
USE [ElishevaM_HadasB_ListsTrip]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ElishevaM_HadasB_ListsTrip]
GO
/****** Object:  User [ADCLASS\Domain Users]    Script Date: 13/07/2023 17:44:02 ******/
CREATE USER [ADCLASS\Domain Users] FOR LOGIN [ADCLASS\Domain Users]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Land] [nvarchar](20) NOT NULL,
	[City] [nvarchar](20) NOT NULL,
	[Street] [nvarchar](20) NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attraction]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attraction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Desc] [nvarchar](50) NOT NULL,
	[Img] [nvarchar](50) NOT NULL,
	[WebsiteAddress] [nvarchar](max) NOT NULL,
	[CountryId] [int] NOT NULL,
	[IsConfirm] [bit] NOT NULL,
	[TypeId] [int] NOT NULL,
	[AddressId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[PersonStateId] [int] NOT NULL,
 CONSTRAINT [PK_attraction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attraction_type]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attraction_type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_attraction_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttractionList]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttractionList](
	[Id] [int] NOT NULL,
	[TripListId] [int] NOT NULL,
	[AttractionId] [int] NOT NULL,
	[ExitDate] [datetime] NOT NULL,
	[IsBasic] [bit] NOT NULL,
	[RemainderDate] [datetime] NOT NULL,
 CONSTRAINT [PK_attraction_list] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttractionListProduct]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttractionListProduct](
	[Id] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[AttractionListId] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_attraction_list_product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[Id] [int] NOT NULL,
	[Desc] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[ComplainCount] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Continent]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Like]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Like](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AttractionListId] [int] NOT NULL,
	[Rank] [int] NOT NULL,
	[CommentId] [int] NOT NULL,
 CONSTRAINT [PK_like] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpeningHours]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpeningHours](
	[AttractionId] [int] NOT NULL,
	[Day] [int] NOT NULL,
	[OpeningHour] [datetime] NULL,
	[ClosingHour] [datetime] NULL,
	[IsOpening] [bit] NOT NULL,
 CONSTRAINT [PK_OpeningHours] PRIMARY KEY CLUSTERED 
(
	[AttractionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonState]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonState](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_PersonState] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDuplicated] [bit] NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[StorageTypeId] [int] NOT NULL,
	[IsNeedAssurants] [bit] NOT NULL,
	[Img] [nvarchar](50) NOT NULL,
	[IsImgConfirm] [bit] NOT NULL,
	[IsConfirm] [bit] NOT NULL,
	[UserId] [int] NULL,
	[Name] [nvarchar](50) NOT NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [PK_Product_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_product_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AttractionName] [nvarchar](30) NOT NULL,
	[AddressId] [int] NOT NULL,
	[UserId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavedAttraction]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavedAttraction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[AttractionId] [int] NOT NULL,
 CONSTRAINT [PK_SavedAttraction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusProduct]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StorageType]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StorageType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_storage_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TripList]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TripList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Name] [int] NULL,
	[AddingDate] [datetime] NOT NULL,
	[BackingDate] [datetime] NOT NULL,
	[TravelingDate] [datetime] NOT NULL,
 CONSTRAINT [PK_destination_country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DateBorn] [datetime] NOT NULL,
	[UserTypeId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 13/07/2023 17:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_user_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([Id], [Land], [City], [Street], [Number]) VALUES (1, N'ישראל', N'תל אביב', N'מכבים', 2)
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[Attraction] ON 

INSERT [dbo].[Attraction] ([Id], [Name], [Desc], [Img], [WebsiteAddress], [CountryId], [IsConfirm], [TypeId], [AddressId], [Status], [PersonStateId]) VALUES (1, N'לונה פארק', N'מהנה וחוויתי לכל המשפחה', N'222', N'lina.com.il', 1, 1, 3, 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Attraction] OFF
GO
SET IDENTITY_INSERT [dbo].[Attraction_type] ON 

INSERT [dbo].[Attraction_type] ([Id], [Type]) VALUES (1, N'יבש')
INSERT [dbo].[Attraction_type] ([Id], [Type]) VALUES (2, N'רטוב')
INSERT [dbo].[Attraction_type] ([Id], [Type]) VALUES (3, N'אקסטרים')
SET IDENTITY_INSERT [dbo].[Attraction_type] OFF
GO
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([Id], [Name]) VALUES (1, N'אירופה')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (2, N'אסיה')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (3, N'אמריקה')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (4, N'אפריקה')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (5, N'אוסטרליה')
SET IDENTITY_INSERT [dbo].[Continent] OFF
GO
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name], [ContinentId]) VALUES (1, N'ישראל', 1)
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
INSERT [dbo].[OpeningHours] ([AttractionId], [Day], [OpeningHour], [ClosingHour], [IsOpening]) VALUES (1, 1, CAST(N'2023-02-02T00:00:00.000' AS DateTime), CAST(N'2023-02-02T00:00:00.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[PersonState] ON 

INSERT [dbo].[PersonState] ([Id], [State]) VALUES (1, N'ילדים')
INSERT [dbo].[PersonState] ([Id], [State]) VALUES (2, N'נוער')
INSERT [dbo].[PersonState] ([Id], [State]) VALUES (3, N'הכל')
SET IDENTITY_INSERT [dbo].[PersonState] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [Email], [DateBorn], [UserTypeId], [Status]) VALUES (4, N'הדס', N'0556795633', N'7777', N'hadas@gmail.com', CAST(N'2023-03-20T00:00:00.153' AS DateTime), 2, 0)
INSERT [dbo].[User] ([Id], [Name], [Phone], [Password], [Email], [DateBorn], [UserTypeId], [Status]) VALUES (5, N'אלישבע', N'0533156394', N'eli123', N'elishevaMoshe1@gmail.com', CAST(N'2003-10-20T08:34:26.887' AS DateTime), 2, 0)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
INSERT [dbo].[UserType] ([Id], [Type]) VALUES (1, N'משתמש')
INSERT [dbo].[UserType] ([Id], [Type]) VALUES (2, N'מנהל')
GO
/****** Object:  Index [IX_user_type]    Script Date: 13/07/2023 17:44:02 ******/
CREATE NONCLUSTERED INDEX [IX_user_type] ON [dbo].[UserType]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Attraction]  WITH CHECK ADD  CONSTRAINT [FK_Attraction_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Attraction] CHECK CONSTRAINT [FK_Attraction_Address]
GO
ALTER TABLE [dbo].[Attraction]  WITH CHECK ADD  CONSTRAINT [FK_Attraction_Attraction_type] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Attraction_type] ([Id])
GO
ALTER TABLE [dbo].[Attraction] CHECK CONSTRAINT [FK_Attraction_Attraction_type]
GO
ALTER TABLE [dbo].[Attraction]  WITH CHECK ADD  CONSTRAINT [FK_Attraction_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Attraction] CHECK CONSTRAINT [FK_Attraction_Country]
GO
ALTER TABLE [dbo].[Attraction]  WITH CHECK ADD  CONSTRAINT [FK_Attraction_OpeningHours] FOREIGN KEY([Id])
REFERENCES [dbo].[OpeningHours] ([AttractionId])
GO
ALTER TABLE [dbo].[Attraction] CHECK CONSTRAINT [FK_Attraction_OpeningHours]
GO
ALTER TABLE [dbo].[Attraction]  WITH CHECK ADD  CONSTRAINT [FK_Attraction_PersonState] FOREIGN KEY([PersonStateId])
REFERENCES [dbo].[PersonState] ([Id])
GO
ALTER TABLE [dbo].[Attraction] CHECK CONSTRAINT [FK_Attraction_PersonState]
GO
ALTER TABLE [dbo].[AttractionList]  WITH CHECK ADD  CONSTRAINT [FK_attraction_list_attraction] FOREIGN KEY([AttractionId])
REFERENCES [dbo].[Attraction] ([Id])
GO
ALTER TABLE [dbo].[AttractionList] CHECK CONSTRAINT [FK_attraction_list_attraction]
GO
ALTER TABLE [dbo].[AttractionList]  WITH CHECK ADD  CONSTRAINT [FK_AttractionList_TripList] FOREIGN KEY([TripListId])
REFERENCES [dbo].[TripList] ([Id])
GO
ALTER TABLE [dbo].[AttractionList] CHECK CONSTRAINT [FK_AttractionList_TripList]
GO
ALTER TABLE [dbo].[AttractionListProduct]  WITH CHECK ADD  CONSTRAINT [FK_AttractionListProduct_AttractionList] FOREIGN KEY([AttractionListId])
REFERENCES [dbo].[AttractionList] ([Id])
GO
ALTER TABLE [dbo].[AttractionListProduct] CHECK CONSTRAINT [FK_AttractionListProduct_AttractionList]
GO
ALTER TABLE [dbo].[AttractionListProduct]  WITH CHECK ADD  CONSTRAINT [FK_AttractionListProduct_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[AttractionListProduct] CHECK CONSTRAINT [FK_AttractionListProduct_Product]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_User]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continent] ([Id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Like]  WITH CHECK ADD  CONSTRAINT [FK_Like_AttractionList] FOREIGN KEY([AttractionListId])
REFERENCES [dbo].[AttractionList] ([Id])
GO
ALTER TABLE [dbo].[Like] CHECK CONSTRAINT [FK_Like_AttractionList]
GO
ALTER TABLE [dbo].[Like]  WITH CHECK ADD  CONSTRAINT [FK_Like_Comment] FOREIGN KEY([CommentId])
REFERENCES [dbo].[Comment] ([Id])
GO
ALTER TABLE [dbo].[Like] CHECK CONSTRAINT [FK_Like_Comment]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_product_product_type] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductType] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_product_product_type]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_StatusProduct] FOREIGN KEY([StatusId])
REFERENCES [dbo].[StatusProduct] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_StatusProduct]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_product_storage_type] FOREIGN KEY([StorageTypeId])
REFERENCES [dbo].[StorageType] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_product_storage_type]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Address]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_User]
GO
ALTER TABLE [dbo].[SavedAttraction]  WITH CHECK ADD  CONSTRAINT [FK_SavedAttraction_Attraction] FOREIGN KEY([AttractionId])
REFERENCES [dbo].[Attraction] ([Id])
GO
ALTER TABLE [dbo].[SavedAttraction] CHECK CONSTRAINT [FK_SavedAttraction_Attraction]
GO
ALTER TABLE [dbo].[SavedAttraction]  WITH CHECK ADD  CONSTRAINT [FK_SavedAttraction_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[SavedAttraction] CHECK CONSTRAINT [FK_SavedAttraction_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_customer_user_type] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[UserType] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_customer_user_type]
GO
USE [master]
GO
ALTER DATABASE [ElishevaM_HadasB_ListsTrip] SET  READ_WRITE 
GO
