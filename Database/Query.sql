--Create procedure
CREATE PROC USP_Login
@userName NVARCHAR (100), @passWord NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.ACCOUNT WHERE Username = @userName COLLATE SQL_Latin1_General_CP1_CS_AS AND Pass_Account = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS
END

CREATE PROC USP_showName
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.Last_Name, U.First_Name FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END

CREATE PROC USP_getName
@idUser NVARCHAR (100)
AS
BEGIN
	SELECT First_Name, Last_Name FROM dbo.USERS WHERE ID_User = @idUser
END


CREATE PROC USP_getRole
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.Role_User FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END

CREATE PROC USP_getID
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.ID_User FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END

CREATE PROC USP_loadTrip
@source NVARCHAR(100), @destination NVARCHAR (100), @date DATE
AS
BEGIN
	SELECT* FROM trip WHERE Source = @source AND Destination = @destination AND Date_Trip = @date
END

CREATE PROC USP_getSeat
@idTrip NVARCHAR (100)
AS
BEGIN

	SELECT Total_Seat FROM dbo.TRIP WHERE ID_Trip = @idTrip
END

CREATE PROC USP_getListSeat
@idTrip NVARCHAR (100)
AS
BEGIN
	SELECT TK.Seat_Number
	FROM dbo.TRIP AS T, dbo.TICKET AS TK
	WHERE T.ID_Trip = TK.ID_Trip 
	AND TK.ID_Trip = @idTrip

END

CREATE PROC USP_loadTripUser
@idTrip NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.TRIP WHERE ID_Trip = @idTrip
END

CREATE PROC USP_InsertTicket
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

CREATE PROC USP_InsertPayment
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

ALTER TABLE dbo.PAYMENT ALTER COLUMN Card_Number NVARCHAR(20)

CREATE PROC USP_maxIdTicket
AS
BEGIN
DECLARE @maxID INT
SET @maxID = (SELECT max (id) FROM dbo.TICKET)
SELECT ID_Ticket FROM dbo.TICKET WHERE id = @maxID
END

CREATE PROC USP_updateSeat
@idTrip NVARCHAR (100)
AS
BEGIN
	UPDATE dbo.TRIP SET Available_Seat = (Available_Seat - 1) WHERE ID_Trip = @idTrip
END

CREATE PROC USP_LoadTicket
@idTicket NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.TICKET WHERE ID_Ticket = @idTicket COLLATE SQL_Latin1_General_CP1_CS_AS
END


CREATE PROC USP_UpdateAccount
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

---------------------------------------
--Queries--

--1.Count the number of tickets that were sold in a particular month in a particular year
DECLARE @Month INT
DECLARE @Year INT 
SET @Month = 5
SET @Year = 2020   -- Could be change 
SELECT COUNT(*) AS 'Number of Tickets'
FROM dbo.PAYMENT 
WHERE MONTH(Date_Pay) = @Month AND YEAR(Date_Pay) = @Year

--2.Average revenue in each month of a particular year
DECLARE @Year INT
SET @Year = 2020 
SELECT MONTH(P.Date_Pay) AS 'Month', CAST(AVG(CAST(T.Total_Price AS FLOAT)) AS DECIMAL(10,3)) AS 'Avarage Revenue'
FROM dbo.TICKET AS T, dbo.PAYMENT AS P
WHERE YEAR (P.Date_Pay) = @Year
AND T.ID_Ticket = P.ID_Ticket
GROUP BY MONTH(P.Date_Pay)


--3.Find all the trips have booked in each month of a particular year and order to descending times of booking

DECLARE @Year INT
SET @Year = 2020 
SELECT MONTH(P.Date_Pay) AS 'Month', T.ID_Trip, COUNT(*) AS 'Times'
FROM dbo.TRIP AS T, dbo.TICKET AS TK, dbo.PAYMENT AS P
WHERE YEAR(P.Date_Pay) = @Year 
AND T.ID_Trip = TK.ID_Trip
AND TK.ID_Ticket = P.ID_Ticket
GROUP BY MONTH(P.Date_Pay), T.ID_Trip
ORDER BY (COUNT(*)) DESC

--4.Find ID of users that booked at least 10 trips in a month

SELECT tk.ID_User, datename(MONTH,T.Date_Trip) as month, COUNT(*) as number
FROM TRIP T, TICKET tk
WHERE tk.ID_Trip = T.ID_Trip
GROUP BY tk.ID_User, datename(MONTH,T.Date_Trip)
HAVING COUNT(*)>=10;

--5.Find ID of users, name of source place that they have booked most recently, number of them, and the same for the destination.
--Source--
SELECT tk.ID_User, T.Source, COUNT(*)
    FROM TICKET tk, TRIP T
    WHERE tk.ID_Trip = T.ID_Trip	
    GROUP BY tk.ID_User, T.Source
    ORDER BY tk.ID_User
--Destination
SELECT tk.ID_User, T.Destination, COUNT(*)
    FROM TICKET tk, TRIP T
    WHERE tk.ID_Trip = T.ID_Trip
    GROUP BY tk.ID_User, T.Destination
    ORDER BY tk.ID_User


--6.Find all trips from one place to another on a date with a total duration of less than 12 hours. Search only for trips that have one-stop. Needed information will be given by the customers.
SELECT  T1.Source,
   	 	T2.Source,
   		T1.Destination,
   		T2.Destination,
   	 DATEPART(HOUR,T1.Duration)*60+DATEPART(HOUR,T2.Duration)*60+DATEPART(MINUTE,T1.Duration)+DATEPART(MINUTE,T2.Duration) as DURATION
FROM TRIP T1, TRIP T2
WHERE
    T1.Date_Trip = T2.Date_Trip
	AND T1.Destination = T2.Source
	AND (DATEPART(HOUR,T1.Duration)*60+DATEPART(HOUR,T2.Duration)*60+ DATEPART(MINUTE,T1.Duration)+DATEPART(MINUTE,T2.Duration)) < 12*60

--7.Find the driver who drives the most trips in a month
SELECT TOP 1 U.ID_User, U.First_Name, U.Last_Name, COUNT(*)
FROM TRIP T, USERS U
WHERE T.ID_Driver = U.ID_User
GROUP BY U.ID_User, U.First_Name, U.Last_Name
ORDER BY COUNT(*) DESC

--8. Change PassWord
CREATE PROC USP_UpdateAccount
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