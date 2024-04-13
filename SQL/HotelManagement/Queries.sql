-- ¬ыбираем все номера, которые доступны (availability = 1) и не забронированы на сегодн€шнюю дату
SELECT *
FROM dbo.Rooms
WHERE availability = 1
AND room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE check_in_date <= GETDATE()
    AND check_out_date >= GETDATE()
);

-- ¬ыбираем всех клиентов, у которых фамили€ начинаетс€ с буквы "S"
SELECT *
FROM dbo.Customers
WHERE last_name LIKE 'S%';

-- ¬ыбираем все бронировани€ дл€ клиента, чье им€ или электронный адрес совпадает с указанным
SELECT *
FROM dbo.Bookings
WHERE customer_id IN (
    SELECT customer_id
    FROM dbo.Customers
    WHERE first_name = '»м€' OR email = 'email@example.com'
);

-- ¬ыбираем все бронировани€ дл€ конкретного номера (замените @room_id на идентификатор номера)
SELECT *
FROM dbo.Bookings
WHERE room_id = 1;

-- ¬ыбираем все номера, которые не забронированы на указанную дату
SELECT *
FROM dbo.Rooms
WHERE room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE check_in_date <= '2024-04-15' AND check_out_date >= '2024-04-15'
);
