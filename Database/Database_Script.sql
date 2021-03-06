USE [master]
GO
/****** Object:  Database [TicketSelling]    Script Date: 5/23/2020 3:11:30 PM ******/
CREATE DATABASE [TicketSelling]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TicketSelling', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TicketSelling.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TicketSelling_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TicketSelling_log.ldf' , SIZE = 1344KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TicketSelling] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TicketSelling].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TicketSelling] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TicketSelling] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TicketSelling] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TicketSelling] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TicketSelling] SET ARITHABORT OFF 
GO
ALTER DATABASE [TicketSelling] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TicketSelling] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TicketSelling] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TicketSelling] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TicketSelling] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TicketSelling] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TicketSelling] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TicketSelling] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TicketSelling] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TicketSelling] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TicketSelling] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TicketSelling] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TicketSelling] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TicketSelling] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TicketSelling] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TicketSelling] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TicketSelling] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TicketSelling] SET RECOVERY FULL 
GO
ALTER DATABASE [TicketSelling] SET  MULTI_USER 
GO
ALTER DATABASE [TicketSelling] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TicketSelling] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TicketSelling] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TicketSelling] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TicketSelling] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TicketSelling', N'ON'
GO
USE [TicketSelling]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[Username] [nvarchar](50) NOT NULL,
	[Pass_Account] [nvarchar](50) NOT NULL,
	[ID_User] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAYMENT]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAYMENT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Bill]  AS ('PID'+right('00000000'+CONVERT([varchar](8),[ID]),(8))) PERSISTED NOT NULL,
	[Name] [varchar](50) NULL,
	[Bank] [varchar](50) NULL,
	[Card_Number] [nvarchar](20) NULL,
	[Card_Type] [varchar](50) NULL,
	[Date_Pay] [date] NULL,
	[ID_Ticket] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Bill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TICKET]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TICKET](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Ticket]  AS ('TKID'+right('00000000'+CONVERT([varchar](8),[ID]),(8))) PERSISTED NOT NULL,
	[Seat_Number] [int] NOT NULL,
	[Total_Price] [float] NULL,
	[ID_User] [varchar](11) NULL,
	[ID_Trip] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRIP]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRIP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Trip]  AS ('TID'+right('00000000'+CONVERT([varchar](8),[ID]),(8))) PERSISTED NOT NULL,
	[Source] [varchar](50) NOT NULL,
	[Destination] [varchar](50) NOT NULL,
	[Date_Trip] [date] NOT NULL,
	[Start_Time] [time](7) NOT NULL,
	[Arrival_Time] [time](7) NOT NULL,
	[Duration] [time](7) NOT NULL,
	[Total_Seat] [int] NOT NULL,
	[Available_Seat] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Discount] [float] NOT NULL,
	[ID_Driver] [varchar](11) NULL,
	[ID_Manager] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Trip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ARITHABORT ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_User]  AS ('UID'+right('00000000'+CONVERT([varchar](8),[ID]),(8))) PERSISTED NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Phone] [char](20) NOT NULL,
	[Address_User] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Gender_User] [char](10) NOT NULL,
	[Date_Of_Birth] [date] NOT NULL,
	[Role_User] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD FOREIGN KEY([ID_User])
REFERENCES [dbo].[USERS] ([ID_User])
GO
ALTER TABLE [dbo].[PAYMENT]  WITH CHECK ADD FOREIGN KEY([ID_Ticket])
REFERENCES [dbo].[TICKET] ([ID_Ticket])
GO
ALTER TABLE [dbo].[TICKET]  WITH CHECK ADD FOREIGN KEY([ID_Trip])
REFERENCES [dbo].[TRIP] ([ID_Trip])
GO
ALTER TABLE [dbo].[TICKET]  WITH CHECK ADD FOREIGN KEY([ID_User])
REFERENCES [dbo].[USERS] ([ID_User])
GO
ALTER TABLE [dbo].[TRIP]  WITH CHECK ADD FOREIGN KEY([ID_Driver])
REFERENCES [dbo].[USERS] ([ID_User])
GO
ALTER TABLE [dbo].[TRIP]  WITH CHECK ADD FOREIGN KEY([ID_Manager])
REFERENCES [dbo].[USERS] ([ID_User])
GO
/****** Object:  StoredProcedure [dbo].[USP_getID]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_getID]
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.ID_User FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getListSeat]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_getListSeat]
@idTrip NVARCHAR (100)
AS
BEGIN
	SELECT TK.Seat_Number
	FROM dbo.TRIP AS T, dbo.TICKET AS TK
	WHERE T.ID_Trip = TK.ID_Trip 
	AND TK.ID_Trip = @idTrip

END
GO
/****** Object:  StoredProcedure [dbo].[USP_getName]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_getName]
@idUser NVARCHAR (100)
AS
BEGIN
	SELECT First_Name, Last_Name FROM dbo.USERS WHERE ID_User = @idUser
END

GO
/****** Object:  StoredProcedure [dbo].[USP_getRole]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_getRole]
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.Role_User FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getSeat]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_getSeat]
@idTrip NVARCHAR (100)
AS
BEGIN

	SELECT Total_Seat FROM dbo.TRIP WHERE ID_Trip = @idTrip
END

GO
/****** Object:  StoredProcedure [dbo].[USP_InsertPayment]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertPayment]
@Name NVARCHAR (100), @Bank NVARCHAR (100), @CardNum NVARCHAR(100),
@CardType NVARCHAR (100), @idTicket NVARCHAR (100)
AS
BEGIN
INSERT dbo.PAYMENT
        ( Name ,
          Bank ,
          Card_Number ,
          Card_Type ,
          Date_Pay ,
          ID_Ticket
        )
VALUES  ( @Name , -- Name - varchar(50)
          @Bank , -- Bank - varchar(50)
          @CardNum , -- Card_Number - int
          @CardType , -- Card_Type - varchar(50)
          GETDATE() , -- Date_Pay - date
          @idTicket  -- ID_Ticket - varchar(12)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertTicket]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertTicket]
@seatNumber INT, @totalPrice FLOAT, @idUser NVARCHAR(100), @idTrip NVARCHAR(100)
AS
BEGIN
INSERT dbo.TICKET
        ( Seat_Number ,
          Total_Price ,
          ID_User ,
          ID_Trip
        )
VALUES  ( @seatNumber , -- Seat_Number - int
          @totalPrice , -- Total_Price - bigint
          @idUser , -- ID_User - varchar(11)
          @idTrip  -- ID_Trip - varchar(11)
        )
END

GO
/****** Object:  StoredProcedure [dbo].[USP_LoadTicket]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_LoadTicket]
@idTicket NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.TICKET WHERE ID_Ticket = @idTicket COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO
/****** Object:  StoredProcedure [dbo].[USP_loadTrip]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_loadTrip]
@source NVARCHAR(100), @destination NVARCHAR (100), @date DATE
AS
BEGIN
	SELECT* FROM trip WHERE Source = @source AND Destination = @destination AND Date_Trip = @date
END

GO
/****** Object:  StoredProcedure [dbo].[USP_loadTripUser]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_loadTripUser]
@idTrip NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.TRIP WHERE ID_Trip = @idTrip
END

GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@userName NVARCHAR (100), @passWord NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.ACCOUNT WHERE Username = @userName COLLATE SQL_Latin1_General_CP1_CS_AS AND Pass_Account = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO
/****** Object:  StoredProcedure [dbo].[USP_maxIdTicket]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_maxIdTicket]
AS
BEGIN
DECLARE @maxID INT
SET @maxID = (SELECT max (id) FROM dbo.TICKET)
SELECT ID_Ticket FROM dbo.TICKET WHERE id = @maxID
END
GO
/****** Object:  StoredProcedure [dbo].[USP_showName]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_showName]
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.Last_Name, U.First_Name FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
@idUser NVARCHAR (100), @passWord NVARCHAR (100), @newPassWord NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT

	SELECT @isRightPass = COUNT(*)
	FROM dbo.ACCOUNT
	WHERE ID_User = @idUser AND Pass_Account = @passWord

	IF (@isRightPass = 1) 
	BEGIN
		UPDATE dbo.ACCOUNT SET Pass_Account = @newPassWord WHERE ID_User = @idUser
	END
        
END
GO
/****** Object:  StoredProcedure [dbo].[USP_updateSeat]    Script Date: 5/23/2020 3:11:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_updateSeat]
@idTrip NVARCHAR (100)
AS
BEGIN
	UPDATE dbo.TRIP SET Available_Seat = (Available_Seat - 1) WHERE ID_Trip = @idTrip
END


GO
USE [master]
GO
ALTER DATABASE [TicketSelling] SET  READ_WRITE 
GO
