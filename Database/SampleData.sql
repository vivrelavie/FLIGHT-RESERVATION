USE `AirplaneTicketingSystem2024`;

-- Insert data into Airport table
INSERT INTO Airport (AirportCode, AirportFullName, AirportLocation) VALUES
('ATL', 'Hartsfield-Jackson Atlanta International Airport', 'Atlanta, GA'),
('LAX', 'Los Angeles International Airport', 'Los Angeles, CA'),
('MIA', 'Manila International Airport', 'Manila, PH'),
('DFW', 'Dallas/Fort Worth International Airport', 'Dallas, TX'),
('DEN', 'Denver International Airport', 'Denver, CO'),
('JFK', 'John F. Kennedy International Airport', 'New York, NY'),
('SFO', 'San Francisco International Airport', 'San Francisco, CA'),
('SEA', 'Seattle-Tacoma International Airport', 'Seattle, WA'),
('MIA', 'Miami International Airport', 'Miami, FL'),
('BOS', 'Logan International Airport', 'Boston, MA');


-- Insert data into Flights table
INSERT INTO Flights (AirplaneNumber, DepartureDate, ArrivalDate, DepartureAirportID, ArrivalAirportID, SeatsRemaining, SeatingCapacity) VALUES
('AA101', '2024-12-01 08:00:00', '2024-12-01 11:00:00', 1, 2, 150, 180),
('AA102', '2024-12-02 14:00:00', '2024-12-02 17:00:00', 2, 1, 160, 180),
('DL201', '2024-12-03 09:30:00', '2024-12-03 12:30:00', 3, 4, 170, 200),
('DL202', '2024-12-04 13:00:00', '2024-12-04 16:00:00', 4, 3, 165, 200),
('UA301', '2024-12-05 10:00:00', '2024-12-05 14:00:00', 5, 6, 180, 200),
('UA302', '2024-12-06 15:30:00', '2024-12-06 19:30:00', 6, 5, 175, 200), 
('SW401', '2024-12-07 11:00:00', '2024-12-07 13:30:00', 7, 8, 90, 120),
('SW402', '2024-12-08 16:00:00', '2024-12-08 18:30:00', 8, 7, 95, 120), 
('BA501', '2024-12-09 06:00:00', '2024-12-09 10:00:00', 9, 10, 80, 100),
('BA502', '2024-12-10 18:00:00', '2024-12-10 22:00:00', 10, 9, 85, 100),
('AF601', '2024-12-11 07:00:00', '2024-12-11 12:00:00', 1, 5, 140, 160),
('AF602', '2024-12-12 14:30:00', '2024-12-12 19:30:00', 5, 1, 135, 160), 
('LH701', '2024-12-13 10:00:00', '2024-12-13 15:00:00', 2, 7, 100, 120),
('LH702', '2024-12-14 16:00:00', '2024-12-14 21:00:00', 7, 2, 105, 120),
('EK801', '2024-12-15 09:00:00', '2024-12-15 14:00:00', 3, 8, 160, 180),
('EK802', '2024-12-16 13:30:00', '2024-12-16 18:30:00', 8, 3, 155, 180),
('QF901', '2024-12-17 08:30:00', '2024-12-17 11:30:00', 4, 9, 120, 150),
('QF902', '2024-12-18 17:00:00', '2024-12-18 20:00:00', 9, 4, 115, 150), 
('NH1001', '2024-12-19 06:00:00', '2024-12-19 11:00:00', 6, 10, 200, 220),
('NH1002', '2024-12-20 19:00:00', '2024-12-20 23:59:00', 10, 6, 190, 220),
('VS1101', '2024-12-21 07:45:00', '2024-12-21 11:45:00', 1, 6, 130, 150),
('VS1102', '2024-12-22 15:30:00', '2024-12-22 19:30:00', 6, 1, 125, 150),
('CX1201', '2024-12-23 09:15:00', '2024-12-23 12:15:00', 2, 8, 110, 130),
('CX1202', '2024-12-24 18:00:00', '2024-12-24 21:00:00', 8, 2, 105, 130), 
('SQ1301', '2024-12-25 08:00:00', '2024-12-25 12:00:00', 3, 10, 145, 160),
('SQ1302', '2024-12-26 17:00:00', '2024-12-26 21:00:00', 10, 3, 140, 160),
('QR1401', '2024-12-27 07:30:00', '2024-12-27 11:00:00', 4, 7, 170, 200),
('QR1402', '2024-12-28 14:45:00', '2024-12-28 18:15:00', 7, 4, 165, 200),
('JL1501', '2024-12-29 05:45:00', '2024-12-29 09:45:00', 5, 9, 180, 220),
('JL1502', '2024-12-30 20:00:00', '2024-12-30 23:59:00', 9, 5, 175, 220),



-- Insert data into Accounts table
INSERT INTO Accounts (FirstName, LastName, Email, Password) VALUES


-- Insert data into Transactions table
INSERT INTO Transactions (AccountID, BookingDate, ReferenceNo) VALUES


-- Insert data into Passengers table
INSERT INTO Passengers (TransactionID, Type, FirstName, LastName, Age, Birthdate) VALUES


-- Insert data into TicketDetails table
INSERT INTO TicketDetails (TransactionID, FlightID, NumberOfTickets, Children, Infant, Food, Baggage, TransferServices, TotalPrice) VALUES


-- Insert data into Payment table
INSERT INTO Payment (TransactionID, ModeOfPayment, ReferenceNo) VALUES
