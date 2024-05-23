USE HotelManagement;

-- ������� ��� ��������� ������ ��� ������������ �������.
SELECT *
FROM dbo.Rooms
WHERE availability = 1
AND room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE GETDATE() BETWEEN check_in_date AND check_out_date
);

--������� ���� ��������, ��� ������� ���������� � ����� "S".
SELECT *
FROM dbo.Customers
WHERE last_name LIKE 'S%';

-- ������� ��� ������������ ��� ������������� ������� (�� ����� ��� ������������ ������).
SELECT *
FROM dbo.Bookings
WHERE customer_id IN (
    SELECT customer_id
    FROM dbo.Customers
    WHERE first_name = N'����' OR email = 'ivanov@example.com'
);

-- ������� ��� ������������ ��� ������������� ������.
SELECT b.*
FROM dbo.Bookings b
JOIN dbo.Rooms r ON b.room_id = r.room_id
WHERE r.room_number = 101;

-- ������� ��� ������, ������� �� ������������� �� ������������ ����.
SELECT *
FROM dbo.Rooms
WHERE room_id NOT IN (
    SELECT room_id
    FROM dbo.Bookings
    WHERE '2024-04-15' BETWEEN check_in_date AND check_out_date
);
