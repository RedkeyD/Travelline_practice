USE HotelManagement;

-- Ќайдите все доступные номера дл€ бронировани€ сегодн€.
SELECT *
FROM dbo.Rooms
WHERE availability = 1
AND room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE GETDATE() BETWEEN check_in_date AND check_out_date
);

--Ќайдите всех клиентов, чьи фамилии начинаютс€ с буквы "S".
SELECT *
FROM dbo.Customers
WHERE last_name LIKE 'S%';

-- Ќайдите все бронировани€ дл€ определенного клиента (по имени или электронному адресу).
SELECT *
FROM dbo.Bookings
WHERE customer_id IN (
    SELECT customer_id
    FROM dbo.Customers
    WHERE first_name = N'»ван' OR email = 'ivanov@example.com'
);

-- Ќайдите все бронировани€ дл€ определенного номера.
SELECT b.*
FROM dbo.Bookings b
JOIN dbo.Rooms r ON b.room_id = r.room_id
WHERE r.room_number = 101;

-- Ќайдите все номера, которые не забронированы на определенную дату.
SELECT *
FROM dbo.Rooms
WHERE room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE '2024-04-15' BETWEEN check_in_date AND check_out_date
);
