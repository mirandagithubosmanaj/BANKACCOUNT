CREATE DATABASE PROJEKTII;

USE PROJEKTII;

create table [UserRoles] (
	Id int primary key
	RoleID int primary key identity(1,1),
	RoleName varchar unique
)

create table [User] (
	Id int primary key
	USER_ID int primary key identity(1,1),
	Username varchar(255) unique,
	Password INT CHECK (Password >= 0000 AND Password <= 9999),
	Account_Number int unique,
	Balance float,
	UserRoles int foreign key references UserRoles(RoleID)
)

create table [Transfer] (
	Id int primary key
	Sender_Account int foreign key references User(Account_Number),
	Receiver_Account int foreign key references User(Account_Number),
	Amount float,
	Transfer_Date datetime default GETDATE()
)

create table [Deposits] (
	USER_ID int foreign key references User(USER_ID),
	Amount float,
	Transfer_Date datetime default GETDATE()
)

create table [Withdraws] (
	USER_ID int foreign key references User(USER_ID),
	Amount float,
	Transfer_Date datetime default GETDATE()
)

