USE HotelManagement;

-- Disable foreign key constraints
ALTER TABLE dbo.Bookings NOCHECK CONSTRAINT FK_bookings_id_customer;
ALTER TABLE dbo.Bookings NOCHECK CONSTRAINT FK_bookings_id_room;
ALTER TABLE dbo.RoomToFacilities NOCHECK CONSTRAINT FK_roomToFacilities_id_room;
ALTER TABLE dbo.RoomToFacilities NOCHECK CONSTRAINT FK_roomToFacilities_id_facilities;

-- Truncate tables
TRUNCATE TABLE dbo.RoomToFacilities;
TRUNCATE TABLE dbo.Bookings;
TRUNCATE TABLE dbo.Customers;
TRUNCATE TABLE dbo.Facilities;
TRUNCATE TABLE dbo.Rooms;

-- Re-enable foreign key constraints
ALTER TABLE dbo.Bookings CHECK CONSTRAINT FK_bookings_id_customer;
ALTER TABLE dbo.Bookings CHECK CONSTRAINT FK_bookings_id_room;
ALTER TABLE dbo.RoomToFacilities CHECK CONSTRAINT FK_roomToFacilities_id_room;
ALTER TABLE dbo.RoomToFacilities CHECK CONSTRAINT FK_roomToFacilities_id_facilities;


