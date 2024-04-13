use HotelManagement

-- Insert data into Rooms table
INSERT INTO dbo.Rooms (room_id, room_number, room_type, price_per_night, availability)
VALUES 
(1, 101, 'Single', 50.00, 1),
(2, 102, 'Single', 50.00, 0),
(3, 201, 'Double', 80.00, 1),
(4, 202, 'Double', 80.00, 1),
(5, 301, 'Suite', 120.00, 0);

-- Insert data into Customers table
INSERT INTO dbo.Customers (customer_id, first_name, last_name, email, phone_number)
VALUES 
(1, 'John', 'Doe', 'john.doe@example.com', '123-456-7890'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '987-654-3210'),
(3, 'Michael', 'Johnson', 'michael.johnson@example.com', '555-123-4567');

-- Insert data into Bookings table
INSERT INTO dbo.Bookings (booking_id, customer_id, room_id, check_in_date, check_out_date)
VALUES 
(1, 1, 1, '2024-04-15', '2024-04-18'),
(2, 2, 3, '2024-05-01', '2024-05-05'),
(3, 3, 4, '2024-06-10', '2024-06-15');

-- Insert data into Facilities table
INSERT INTO dbo.Facilities (facility_id, facility_name)
VALUES 
(1, 'Wi-Fi'),
(2, 'Кондиционер'),
(3, 'Мини-бар');

-- Insert data into RoomToFacilities table
INSERT INTO dbo.RoomToFacilities (room_id, facility_id)
VALUES 
(1, 1),
(3, 1),
(3, 2),
(4, 1),
(4, 3);
