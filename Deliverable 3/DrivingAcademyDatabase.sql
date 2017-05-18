use dte7_DrivingAcademyDatabase

--Create the tables needed for the database--

--Client Types--
create table clientTypes(
	name varchar(12) NOT NULL,
	cost money,
	thours int,
	PRIMARY KEY(name),
	--Check Statements--
	check(name like 'New' or name like 'Experienced')
)

--Clients--
create table clients(
	username varchar(20) NOT NULL,
	pWord varchar(16),
	fName varchar(32),
	sName varchar(32),
	email varchar(30),
	phone varchar(20),
	typeName varchar(12),
	PRIMARY KEY(username),
	FOREIGN KEY(typeName) references clientTypes,
	--Check Statements--
	check(email like '%_@__%.__%')
)

--Instructors--
create table instructors(
	username varchar(20) NOT NULL,
	pWord varchar(16),
	fName varchar(32),
	sName varchar(32),
	email varchar(30),
	phone varchar(20),
	PRIMARY KEY(username),
	--Check Statements--
	check(email like '%_@__%.__%')
)

--Cars--
create table cars(
	licence_no varchar(10) NOT NULL,
	make varchar(16),
	spare int,
	PRIMARY KEY(licence_no)
)

--Timeslots--
create table timeslots(
	slot_id int NOT NULL,
	slotTime varchar(10) NOT NULL,
	slotDate varchar(10) NOT NULL,
	PRIMARY KEY(slot_id, slotTime, slotDate)
)

--Appointments--
create table appointments(
	appointment_id int NOT NULL,
	notes varchar(max),
	slot_id int NOT NULL,
	slotDate varchar(10) NOT NULL,
	slotTime varchar(10) NOT NULL,
	client_id varchar(20),
	car_id varchar(10),
	instructor_id varchar(20),
	confirmed int,
	PRIMARY KEY(appointment_id),
	FOREIGN KEY(client_id) REFERENCES clients,
	FOREIGN KEY(car_id) REFERENCES cars,
	FOREIGN KEY(slot_id, slotTime, slotDate) REFERENCES timeslots,
	FOREIGN KEY(instructor_id) REFERENCES instructors
)

--Documents--
create table documents(
	document_id int NOT NULL,
	givenDate date,
	givenTime time,
	link varchar(50),
	docType varchar(10),
	client_id varchar(20),
	PRIMARY KEY(document_id),
	FOREIGN KEY(client_id) references clients
)

--Admin Staff--
create table adminStaff(
	username varchar(20) NOT NULL,
	pWord varchar(16),
	fName varchar(32),
	sName varchar(32),
	email varchar(30),
	PRIMARY KEY(username),
	--Check Statements--
	check(email like '%_@__%.__%')
)

--Drop tables for when needed (Must drop from the top)--
drop table adminStaff
drop table documents
drop table appointments
drop table timeslots
drop table cars
drop table instructors
drop table clients
drop table clientTypes

--Populate the appropriate tables--

--Client types (New and Experienced)--
insert into clientTypes values('Experienced', 100.00, 2)
insert into clientTypes values('New', 50, 5)

--Cars (5 cars, differing makes and models)--
insert into cars values('JKH458','Mazda',0)
insert into cars values('LEF835','Nissan',0)
insert into cars values('THR456','Holden',0)
insert into cars values('HJI906','Ford',0)
insert into cars values('DGE345','Fiat',0)

--Instructors (4 instructors)--
insert into instructors values('dte7','abc123','Dylan','Exton','gfhd@gmail.com','025641542')
insert into instructors values('gdt45','def456','John','Smith','js@hotmail.com','0245846124')
insert into instructors values('fte7','ghi789','Fredrick','Johnbanks','fdjohn@live.co.nz','032459451')
insert into instructors values('faet78','qwerty','Gerald', 'Freeminister','freemins@gmail.com','02747474747')

--Admin Staff (2 admins and 1 manager)--
insert into adminStaff values('adminStaff1','password1','Gerald','Springer','g.springer@live.com')
insert into adminStaff values('adminStaff2','password2','Harry','Terry','hartar@gmail.com')
insert into adminStaff values('managerMan','password3','Taylor','Bertus','taybert@hotmail.com')

--Select Statements--
select * from clients
select * from cars
select * from instructors
select * from documents
select * from timeslots order by slotDate ASC
select * from appointments where confirmed = 1
select * from clientTypes
select * from adminStaff

SELECT slotTime, appointment_id from appointments where instructor_id like 'q' and slotDate like '2017-01-01' and client_id is null and confirmed = 1