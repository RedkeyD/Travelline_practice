SELECT *
FROM dbo.Rooms
WHERE availability = 1
AND room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE check_in_date <= GETDATE()
    AND check_out_date >= GETDATE()
);

SELECT *
FROM dbo.Customers
WHERE last_name LIKE 'S%';

SELECT *
FROM dbo.Bookings
WHERE customer_id IN (
    SELECT customer_id
    FROM dbo.Customers
    WHERE first_name = 'Èìÿ' OR email = 'email@example.com'
);

SELECT *
FROM dbo.Bookings
WHERE room_id = 1;

SELECT *
FROM dbo.Rooms
WHERE room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE check_in_date <= '2024-04-15' AND check_out_date >= '2024-04-15'
);
