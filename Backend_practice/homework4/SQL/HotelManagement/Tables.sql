use HotelManagement

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rooms')
	CREATE TABLE dbo.Rooms(
	 room_id INT IDENTITY(1,1) NOT NULL,
	 room_number INT NOT NULL,
	 room_type NVARCHAR(50) NOT NULL,
	 price_per_night MONEY NOT NULL,
	 availability BIT NOT NULL,
	 CONSTRAINT PK_rooms_id_room PRIMARY KEY(room_id)
	)

IF NOT EXISTS ( SELECT * FROM sysobjects WHERE name ='Customers')
	CREATE TABLE dbo.Customers(
	 customer_id INT IDENTITY(1,1) NOT NULL,
	 first_name NVARCHAR(50) NOT NULL,
	 last_name NVARCHAR(50) NOT NULL,
	 email NVARCHAR(50) NOT NULL,
     phone_number NVARCHAR(50) NOT NULL,
	 CONSTRAINT PK_customers_id_customer PRIMARY KEY(customer_id)
	)

IF NOT EXISTS ( SELECT * FROM sys.objects WHERE name ='Bookings')
	CREATE TABLE dbo.Bookings(
	 booking_id INT IDENTITY(1,1) NOT NULL,
	 customer_id INT NOT NULL,
	 room_id INT NOT NULL,
	 check_in_date DATE NOT NULL,
     check_out_date DATE NOT NULL,
	 CONSTRAINT PK_bookings_id_booking PRIMARY KEY(booking_id),
	 CONSTRAINT FK_bookings_id_customer
		FOREIGN KEY (customer_id) REFERENCES dbo.Customers (customer_id),
	 CONSTRAINT FK_bookings_id_room
		FOREIGN KEY (room_id) REFERENCES dbo.Rooms (room_id)
	)
IF NOT EXISTS ( SELECT * FROM sysobjects WHERE name ='Facilities')
	CREATE TABLE dbo.Facilities(
	 facility_id INT IDENTITY(1,1) NOT NULL,
	 facility_name NVARCHAR(200) NOT NULL,
	 CONSTRAINT PK_facilities_id_facility PRIMARY KEY(facility_id)
	)
IF NOT EXISTS ( SELECT * FROM sysobjects WHERE name ='RoomToFacilities')
	CREATE TABLE dbo.RoomToFacilities(
	 room_id INT NOT NULL,
	 facility_id INT NOT NULL,
	 CONSTRAINT PK_roomToFacilities_id_roomToFacilities PRIMARY KEY(room_id, facility_id),
	 CONSTRAINT FK_roomToFacilities_id_room
		FOREIGN KEY (room_id) REFERENCES dbo.Rooms(room_id),
	 CONSTRAINT FK_roomToFacilities_id_facilities
		FOREIGN KEY (facility_id) REFERENCES dbo.Facilities(facility_id)
	)