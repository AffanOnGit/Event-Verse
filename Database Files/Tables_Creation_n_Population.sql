CREATE DATABASE Event_Verse_DB;
USE Event_Verse_DB;

--location table:
CREATE TABLE Location
(
    locationID INT IDENTITY PRIMARY KEY,
    -- Unique identifier for each location
    city VARCHAR(100) NOT NULL,
    -- City of the user
    state VARCHAR(100) NOT NULL,
    -- State or province
    country VARCHAR(100) NOT NULL,
    -- Country
    zipCode VARCHAR(20)
    -- Zip or postal code
);

--user table.
CREATE TABLE Users
(
    ID VARCHAR(255) NOT NULL PRIMARY KEY,
    -- Unique ID entered by the user
    name VARCHAR(255) NOT NULL,
    -- User's name
    email VARCHAR(255) NOT NULL UNIQUE,
    -- User's email, must be unique
    contact# VARCHAR(15),
    -- User's contact number
    age INT,
    -- User's age
    gender VARCHAR(10),
    -- User's gender
    password VARCHAR(255) NOT NULL,
    -- User's password
    dateOfRegistration DATE NOT NULL DEFAULT GETDATE(),
    -- Auto-generated registration date
    userType VARCHAR(50) NOT NULL   ,
    -- Type of user (e.g., Admin, Attendee, Vendor)
    locationID INT NOT NULL,
    FOREIGN KEY (locationID) REFERENCES Location(locationID),

    approved BIT NOT NULL DEFAULT 0
    -- 0 = Not approved, 1 = Approved
);

--organizer table.
CREATE TABLE organizer
(
    organizerID VARCHAR(255) NOT NULL PRIMARY KEY,
    -- Inherits user ID as primary key
    organizationName VARCHAR(255) NOT NULL,
    -- Name of the organization
    FOREIGN KEY (organizerID) REFERENCES users(ID)
    -- Ensures organizerID is a valid user
);

--events table:
CREATE TABLE Events
(
    eventID INT NOT NULL IDENTITY PRIMARY KEY,
    -- Unique identifier for each event
    organizerID VARCHAR(255) NOT NULL,
    -- Organizer who created the event
    eventName VARCHAR(255) NOT NULL,
    -- Name of the event
    eventStartDate DATETIME NOT NULL,
    -- Date and time of the event
    eventEndDate DATETIME NOT NULL,
    -- Date and time of the event
    eventLocation VARCHAR(255) NOT NULL,
    -- Event location
    eventDescription TEXT,
    -- Event description
    FOREIGN KEY (organizerID) REFERENCES organizer(organizerID),
    -- Links event to its organizer
    approved BIT NOT NULL DEFAULT 0
    -- 0 = Not approved, 1 = Approved
);


--tickets table;
CREATE TABLE Tickets
(
    ticketID INT NOT NULL IDENTITY PRIMARY KEY,
    -- Unique identifier for each ticket
    eventID INT NOT NULL,
    -- Links the ticket to a specific event
    category VARCHAR(50) NOT NULL,
    -- Ticket category (e.g., VIP, General)
    price DECIMAL(10, 2) NOT NULL,
    -- Ticket price
    available BIT NOT NULL,
    -- Availability status (1 = available, 0 = sold out)
    FOREIGN KEY (eventID) REFERENCES Events(eventID)
    -- Ensures the event exists
);

--admin table:
CREATE TABLE Admin
(
    adminID VARCHAR(255) NOT NULL PRIMARY KEY,
    FOREIGN KEY (adminID) REFERENCES users(ID)
);

--complaint table:
CREATE TABLE Complaints
(
    complaintID INT NOT NULL IDENTITY PRIMARY KEY,
    -- Unique identifier for complaints
    userID VARCHAR(255) NOT NULL,
    feedback VARCHAR(255) NOT NULL,
    FOREIGN KEY (userID) REFERENCES Users(ID)
    -- Organizer reference
);

--attendee table
CREATE TABLE Attendee
(
    attendeeID VARCHAR(255) NOT NULL PRIMARY KEY,
    -- Inherits user ID as primary key
    eventPreference VARCHAR(255) NOT NULL,
    -- Name of the organization
    FOREIGN KEY (attendeeID) REFERENCES users(ID)
);

--attending table (links the attendee with the event
CREATE TABLE Attending
(
    attendingID INT NOT NULL IDENTITY PRIMARY KEY,
    -- Unique identifier for each attendance record
    attendeeID VARCHAR(255) NOT NULL,
    -- Attendee ID
    eventID INT NOT NULL,
    -- Event ID
    bookedTicket BIT NOT NULL DEFAULT 0,
    -- Indicates if the attendee has bought the ticket (0 = False, 1 = True)
    downloadE_Ticket BIT NOT NULL DEFAULT 0,
    -- Indicates if the attendee has downloaded the e-ticket (0 = False, 1 = True)
    FOREIGN KEY (attendeeID) REFERENCES Attendee(attendeeID),
    -- Links to the Attendee table
    FOREIGN KEY (eventID) REFERENCES Events(eventID)
    -- Links to the Events table
);

--event feedback table:
CREATE TABLE EventFeedback
(
    feedbackID INT NOT NULL IDENTITY PRIMARY KEY,
    -- Unique identifier for each feedback entry
    attendeeID VARCHAR(255) NOT NULL,
    -- Attendee providing the feedback
    eventID INT NOT NULL,
    -- Event the feedback is related to
    eventName VARCHAR(255) NOT NULL,
    -- Name of the event
    feedbackText TEXT NOT NULL,
    -- Feedback provided by the attendee
    rating INT CHECK (rating BETWEEN 1 AND 5),
    -- Rating for the event (1 to 5)
    feedbackDate DATETIME NOT NULL DEFAULT GETDATE(),
    -- Date and time of the feedback
    FOREIGN KEY (attendeeID) REFERENCES Attendee(attendeeID),
    -- Ensures valid attendee
    FOREIGN KEY (eventID) REFERENCES Events(eventID)
    -- Ensures feedback is tied to a valid event
);

--vendor table:
CREATE TABLE Vendor
(
    vendorID VARCHAR(255) NOT NULL PRIMARY KEY,
    -- Unique identifier for the vendor
    vendorName VARCHAR(255) NOT NULL,
    -- Vendor's name
    vendorCategory VARCHAR(100) NOT NULL
    -- Vendor's category (e.g., Catering, Security, etc.)
);

--event vendor table:
CREATE TABLE EventVendor
(
    eventVendorID INT NOT NULL IDENTITY PRIMARY KEY,
    -- Unique identifier for each event-vendor relationship
    eventID INT NOT NULL,
    -- Event linked to the vendor
    vendorID VARCHAR(255) NOT NULL,
    -- Vendor providing the service
    serviceDescription TEXT,
    -- Description of the service provided
    FOREIGN KEY (eventID) REFERENCES Events(eventID),
    -- Ensures event exists
    FOREIGN KEY (vendorID) REFERENCES Vendor(vendorID)
    -- Ensures vendor exists
);




--inserting into Users table:
--Admin (ADM)
INSERT INTO Users
    (ID, name, email, contact#, age, gender, password, userType, locationID, approved)
VALUES
    ('ADM001', 'root', 'root@eventverse.come', '000-000', 35, 'Male', 'root123', 'Admin', 1, 1);
-- Organizers (ORG)
INSERT INTO Users
    (ID, name, email, contact#, age, gender, password, userType, locationID, approved)
VALUES
    ('ORG001', 'John Doe', 'john.doe@eventverse.com', '555-1234', 35, 'Male', 'password123', 'Organizer', 1, 1),
    ('ORG002', 'Jane Smith', 'jane.smith@eventverse.com', '555-5678', 42, 'Female', 'password456', 'Organizer', 2, 0),
    ('ORG003', 'Michael Johnson', 'michael.johnson@eventverse.com', '555-8765', 29, 'Male', 'password789', 'Organizer', 3, 1),
    ('ORG004', 'Emily Davis', 'emily.davis@eventverse.com', '555-2345', 36, 'Female', 'password101', 'Organizer', 4, 0),
    ('ORG005', 'Chris Lee', 'chris.lee@eventverse.com', '555-3456', 40, 'Male', 'password202', 'Organizer', 5, 1),
    ('ORG006', 'Sophia Miller', 'sophia.miller@eventverse.com', '555-4567', 32, 'Female', 'password303', 'Organizer', 6, 1),
    ('ORG007', 'David Wilson', 'david.wilson@eventverse.com', '555-5679', 37, 'Male', 'password404', 'Organizer', 7, 0),
    ('ORG008', 'Olivia Moore', 'olivia.moore@eventverse.com', '555-6780', 41, 'Female', 'password505', 'Organizer', 8, 1),
    ('ORG009', 'James Brown', 'james.brown@eventverse.com', '555-7891', 33, 'Male', 'password606', 'Organizer', 9, 0),
    ('ORG010', 'Ava Harris', 'ava.harris@eventverse.com', '555-8902', 34, 'Female', 'password707', 'Organizer', 10, 1);
-- Attendees (ATT)
INSERT INTO Users
    (ID, name, email, contact#, age, gender, password, userType, locationID, approved)
VALUES
    ('ATT001', 'Lucas Martin', 'lucas.martin@attendee.com', '555-9981', 28, 'Male', 'attendee123', 'Attendee', 1, 1),
    ('ATT002', 'Mia Taylor', 'mia.taylor@attendee.com', '555-7768', 22, 'Female', 'attendee456', 'Attendee', 2, 0),
    ('ATT003', 'Ethan Anderson', 'ethan.anderson@attendee.com', '555-6657', 30, 'Male', 'attendee789', 'Attendee', 3, 1),
    ('ATT004', 'Charlotte Thomas', 'charlotte.thomas@attendee.com', '555-8891', 25, 'Female', 'attendee101', 'Attendee', 4, 1),
    ('ATT005', 'Oliver Jackson', 'oliver.jackson@attendee.com', '555-9101', 38, 'Male', 'attendee202', 'Attendee', 5, 0),
    ('ATT006', 'Amelia White', 'amelia.white@attendee.com', '555-1122', 29, 'Female', 'attendee303', 'Attendee', 6, 1),
    ('ATT007', 'Aiden Harris', 'aiden.harris@attendee.com', '555-2233', 35, 'Male', 'attendee404', 'Attendee', 7, 1),
    ('ATT008', 'Ella Robinson', 'ella.robinson@attendee.com', '555-3344', 26, 'Female', 'attendee505', 'Attendee', 8, 0),
    ('ATT009', 'Henry Clark', 'henry.clark@attendee.com', '555-4455', 31, 'Male', 'attendee606', 'Attendee', 9, 1),
    ('ATT010', 'Grace Lewis', 'grace.lewis@attendee.com', '555-5566', 40, 'Female', 'attendee707', 'Attendee', 10, 1),

    ('ATT011', 'Jack King', 'jack.king@attendee.com', '555-6677', 27, 'Male', 'attendee808', 'Attendee', 11, 1),
    ('ATT012', 'Lily Lee', 'lily.lee@attendee.com', '555-7788', 23, 'Female', 'attendee909', 'Attendee', 12, 1),
    ('ATT013', 'Benjamin Walker', 'benjamin.walker@attendee.com', '555-8899', 34, 'Male', 'attendee111', 'Attendee', 13, 1),
    ('ATT014', 'Chloe Young', 'chloe.young@attendee.com', '555-9900', 29, 'Female', 'attendee212', 'Attendee', 14, 0),
    ('ATT015', 'Jacob Scott', 'jacob.scott@attendee.com', '555-1001', 25, 'Male', 'attendee313', 'Attendee', 15, 0),
    ('ATT016', 'Zoe King', 'zoe.king@attendee.com', '555-2002', 28, 'Female', 'attendee414', 'Attendee', 16, 1),
    ('ATT017', 'Lucas Wright', 'lucas.wright@attendee.com', '555-3003', 31, 'Male', 'attendee515', 'Attendee', 17, 1),
    ('ATT018', 'Nora Adams', 'nora.adams@attendee.com', '555-4004', 30, 'Female', 'attendee616', 'Attendee', 18, 1),
    ('ATT019', 'Matthew Hall', 'matthew.hall@attendee.com', '555-5005', 32, 'Male', 'attendee717', 'Attendee', 19, 1),
    ('ATT020', 'Sophia Carter', 'sophia.carter@attendee.com', '555-6006', 27, 'Female', 'attendee818', 'Attendee', 20, 1),

    ('ATT021', 'Sebastian Moore', 'sebastian.moore@attendee.com', '555-7007', 26, 'Male', 'attendee919', 'Attendee', 21, 0),
    ('ATT022', 'Evelyn Perez', 'evelyn.perez@attendee.com', '555-8008', 39, 'Female', 'attendee020', 'Attendee', 22, 1),
    ('ATT023', 'Samuel Rodriguez', 'samuel.rodriguez@attendee.com', '555-9009', 36, 'Male', 'attendee121', 'Attendee', 23, 0),
    ('ATT024', 'Maya Nelson', 'maya.nelson@attendee.com', '555-1010', 24, 'Female', 'attendee222', 'Attendee', 24, 1),
    ('ATT025', 'David Martin', 'david.martin@attendee.com', '555-1123', 35, 'Male', 'attendee323', 'Attendee', 25, 0),
    ('ATT026', 'Lila Lewis', 'lila.lewis@attendee.com', '555-2134', 30, 'Female', 'attendee424', 'Attendee', 26, 1),
    ('ATT027', 'David Johnson', 'david.johnson@attendee.com', '555-3245', 37, 'Male', 'attendee525', 'Attendee', 27, 0),
    ('ATT028', 'Ella Smith', 'ella.smith@attendee.com', '555-4356', 28, 'Female', 'attendee626', 'Attendee', 28, 1),
    ('ATT029', 'Logan Brown', 'logan.brown@attendee.com', '555-5467', 33, 'Male', 'attendee727', 'Attendee', 29, 0),
    ('ATT030', 'Amelia Jones', 'amelia.jones@attendee.com', '555-6578', 30, 'Female', 'attendee828', 'Attendee', 30, 1),

    ('ATT031', 'Gabriel White', 'gabriel.white@attendee.com', '555-7689', 32, 'Male', 'attendee929', 'Attendee', 31, 1),
    ('ATT032', 'Isabella Scott', 'isabella.scott@attendee.com', '555-8790', 34, 'Female', 'attendee030', 'Attendee', 32, 0),
    ('ATT033', 'William Harris', 'william.harris@attendee.com', '555-9801', 30, 'Male', 'attendee131', 'Attendee', 33, 1),
    ('ATT034', 'Charlotte Clark', 'charlotte.clark@attendee.com', '555-0912', 27, 'Female', 'attendee232', 'Attendee', 34, 1),
    ('ATT035', 'Joshua Taylor', 'joshua.taylor@attendee.com', '555-2023', 31, 'Male', 'attendee333', 'Attendee', 35, 0),
    ('ATT036', 'Victoria Moore', 'victoria.moore@attendee.com', '555-3134', 29, 'Female', 'attendee434', 'Attendee', 36, 1),
    ('ATT037', 'Daniel White', 'daniel.white@attendee.com', '555-4245', 34, 'Male', 'attendee535', 'Attendee', 37, 0),
    ('ATT038', 'Hannah Davis', 'hannah.davis@attendee.com', '555-5356', 33, 'Female', 'attendee636', 'Attendee', 38, 1),
    ('ATT039', 'John Lee', 'john.lee@attendee.com', '555-6467', 30, 'Male', 'attendee737', 'Attendee', 39, 0),
    ('ATT040', 'Grace Taylor', 'grace.taylor@attendee.com', '555-7578', 28, 'Female', 'attendee838', 'Attendee', 40, 1),

    ('ATT041', 'Michael Williams', 'michael.williams@attendee.com', '555-8689', 29, 'Male', 'attendee939', 'Attendee', 41, 1),
    ('ATT042', 'Lily Miller', 'lily.miller@attendee.com', '555-9790', 32, 'Female', 'attendee040', 'Attendee', 42, 0),
    ('ATT043', 'Leo Martinez', 'leo.martinez@attendee.com', '555-0801', 35, 'Male', 'attendee141', 'Attendee', 43, 0),
    ('ATT044', 'Maya Wilson', 'maya.wilson@attendee.com', '555-1912', 28, 'Female', 'attendee242', 'Attendee', 44, 1),
    ('ATT045', 'Oscar Thompson', 'oscar.thompson@attendee.com', '555-2923', 31, 'Male', 'attendee343', 'Attendee', 45, 1),
    ('ATT046', 'Chloe Green', 'chloe.green@attendee.com', '555-3034', 33, 'Female', 'attendee444', 'Attendee', 46, 0),
    ('ATT047', 'Sebastian White', 'sebastian.white@attendee.com', '555-4145', 32, 'Male', 'attendee545', 'Attendee', 47, 1),
    ('ATT048', 'Megan Young', 'megan.young@attendee.com', '555-5256', 30, 'Female', 'attendee646', 'Attendee', 48, 0),
    ('ATT049', 'Aiden Clark', 'aiden.clark@attendee.com', '555-6367', 29, 'Male', 'attendee747', 'Attendee', 49, 1),
    ('ATT050', 'Lola Martinez', 'lola.martinez@attendee.com', '555-7478', 25, 'Female', 'attendee848', 'Attendee', 50, 1);
-- Vendors (VEN)
INSERT INTO Users
    (ID, name, email, contact#, age, gender, password, userType, locationID, approved)
VALUES
    ('VEN001', 'Alice Green', 'alice.green@vendor.com', '555-1234', 30, 'Female', 'vendor123', 'Vendor', 1, 1),
    ('VEN002', 'Bob White', 'bob.white@vendor.com', '555-5678', 45, 'Male', 'vendor456', 'Vendor', 2, 1),
    ('VEN003', 'Charlie Black', 'charlie.black@vendor.com', '555-8765', 38, 'Male', 'vendor789', 'Vendor', 3, 1),
    ('VEN004', 'Diana Blue', 'diana.blue@vendor.com', '555-2345', 29, 'Female', 'vendor101', 'Vendor', 4, 1),
    ('VEN005', 'Evan Brown', 'evan.brown@vendor.com', '555-3456', 50, 'Male', 'vendor202', 'Vendor', 5, 1);

SELECT *
FROM Users;

--Inserting into location table:
INSERT INTO Location
    (city, state, country, zipCode)
VALUES
    ('New York', 'New York', 'USA', '10001'),
    ('Los Angeles', 'California', 'USA', '90001'),
    ('London', 'England', 'UK', 'E1 6AN'),
    ('Berlin', 'Berlin', 'Germany', '10115'),
    ('Paris', 'Ile-de-France', 'France', '75001'),
    ('Toronto', 'Ontario', 'Canada', 'M5A 1A1'),
    ('Sydney', 'New South Wales', 'Australia', '2000'),
    ('Dubai', 'Dubai', 'UAE', '00001'),
    ('Tokyo', 'Tokyo', 'Japan', '100-0001'),
    ('Mumbai', 'Maharashtra', 'India', '400001'),
    ('Austin', 'Texas', 'USA', '73301'),
    ('Vancouver', 'British Columbia', 'Canada', 'V5K 0A1'),
    ('Rome', 'Lazio', 'Italy', '00100'),
    ('Madrid', 'Madrid', 'Spain', '28001'),
    ('S�o Paulo', 'S�o Paulo', 'Brazil', '01000-000'),
    ('Moscow', 'Moscow', 'Russia', '101000'),
    ('Seoul', 'Seoul', 'South Korea', '04500'),
    ('Hong Kong', 'Hong Kong', 'China', '00000'),
    ('Lagos', 'Lagos', 'Nigeria', '101245'),
    ('Cairo', 'Cairo', 'Egypt', '11511'),
    ('Mexico City', 'CDMX', 'Mexico', '01000'),
    ('Buenos Aires', 'Buenos Aires', 'Argentina', 'C1406'),
    ('Stockholm', 'Stockholm', 'Sweden', '11157'),
    ('Amsterdam', 'North Holland', 'Netherlands', '1012AB'),
    ('Cape Town', 'Western Cape', 'South Africa', '8001'),
    ('Jakarta', 'Jakarta', 'Indonesia', '10110'),
    ('Rio de Janeiro', 'Rio de Janeiro', 'Brazil', '20000-000'),
    ('Istanbul', 'Istanbul', 'Turkey', '34000'),
    ('Kuala Lumpur', 'Kuala Lumpur', 'Malaysia', '50000'),
    ('Lagos', 'Lagos', 'Nigeria', '10001'),
    ('Lisbon', 'Lisbon', 'Portugal', '1100-234'),
    ('Athens', 'Attica', 'Greece', '10552'),
    ('Paris', '�le-de-France', 'France', '75012'),
    ('Singapore', 'Singapore', 'Singapore', '188994'),
    ('Bangkok', 'Bangkok', 'Thailand', '10100'),
    ('Miami', 'Florida', 'USA', '33101'),
    ('Barcelona', 'Catalonia', 'Spain', '08001'),
    ('New Delhi', 'Delhi', 'India', '110001'),
    ('Kolkata', 'West Bengal', 'India', '700001'),
    ('Madrid', 'Madrid', 'Spain', '28035'),
    ('Lima', 'Lima', 'Peru', '15001'),
    ('Berlin', 'Berlin', 'Germany', '10365'),
    ('Manila', 'Metro Manila', 'Philippines', '1000'),
    ('Sydney', 'New South Wales', 'Australia', '2008'),
    ('Durban', 'KwaZulu-Natal', 'South Africa', '4000'),
    ('Shanghai', 'Shanghai', 'China', '200000'),
    ('Jakarta', 'DKI Jakarta', 'Indonesia', '11110'),
    ('Tunis', 'Tunis', 'Tunisia', '1000'),
    ('Addis Ababa', 'Addis Ababa', 'Ethiopia', '1000'),
    ('Santiago', 'Santiago', 'Chile', '8320000'),
    ('Lima', 'Lima', 'Peru', '15073'),
    ('Chennai', 'Tamil Nadu', 'India', '600001'),
    ('Warsaw', 'Mazowieckie', 'Poland', '00-175'),
    ('Seville', 'Andalusia', 'Spain', '41001'),
    ('Copenhagen', 'Capital Region', 'Denmark', '1000'),
    ('Bucharest', 'Bucharest', 'Romania', '030167'),
    ('Oslo', 'Oslo', 'Norway', '0154'),
    ('Helsinki', 'Uusimaa', 'Finland', '00100'),
    ('Budapest', 'Budapest', 'Hungary', '1051');

SELECT *
FROM Location;

--Inserting into Attendee Table:
INSERT INTO Attendee
    (attendeeID, eventPreference)
VALUES
    ('ATT001', 'Music'),
    ('ATT002', 'Tech'),
    ('ATT003', 'Art'),
    ('ATT004', 'Food'),
    ('ATT005', 'Sports'),
    ('ATT006', 'Theater'),
    ('ATT007', 'Film'),
    ('ATT008', 'Books'),
    ('ATT009', 'Fashion'),
    ('ATT010', 'Gaming'),
    ('ATT011', 'Music'),
    ('ATT012', 'Tech'),
    ('ATT013', 'Art'),
    ('ATT014', 'Food'),
    ('ATT015', 'Sports'),
    ('ATT016', 'Theater'),
    ('ATT017', 'Film'),
    ('ATT018', 'Books'),
    ('ATT019', 'Fashion'),
    ('ATT020', 'Gaming'),
    ('ATT021', 'Music'),
    ('ATT022', 'Tech'),
    ('ATT023', 'Art'),
    ('ATT024', 'Food'),
    ('ATT025', 'Sports'),
    ('ATT026', 'Theater'),
    ('ATT027', 'Film'),
    ('ATT028', 'Books'),
    ('ATT029', 'Fashion'),
    ('ATT030', 'Gaming'),
    ('ATT031', 'Music'),
    ('ATT032', 'Tech'),
    ('ATT033', 'Art'),
    ('ATT034', 'Food'),
    ('ATT035', 'Sports'),
    ('ATT036', 'Theater'),
    ('ATT037', 'Film'),
    ('ATT038', 'Books'),
    ('ATT039', 'Fashion'),
    ('ATT040', 'Gaming'),
    ('ATT041', 'Music'),
    ('ATT042', 'Tech'),
    ('ATT043', 'Art'),
    ('ATT044', 'Food'),
    ('ATT045', 'Sports'),
    ('ATT046', 'Theater'),
    ('ATT047', 'Film'),
    ('ATT048', 'Books'),
    ('ATT049', 'Fashion'),
    ('ATT050', 'Gaming');

SELECT *
FROM Attendee;

--Inserting into Organizer Table:
INSERT INTO Organizer
    (organizerID, organizationName)
VALUES
    ('ORG001', 'Tech Innovators Inc.'),
    ('ORG002', 'Creative Minds Ltd.'),
    ('ORG003', 'Event Masters Co.'),
    ('ORG004', 'Global Gatherings LLC'),
    ('ORG005', 'Premier Events Group'),
    ('ORG006', 'Elite Event Planners'),
    ('ORG007', 'Dynamic Events Solutions'),
    ('ORG008', 'Visionary Events'),
    ('ORG009', 'NextGen Conferences'),
    ('ORG010', 'Ultimate Event Planners');

SELECT *
FROM Organizer;

-- Inserting into Vendor Table
INSERT INTO Vendor
    (vendorID, vendorName, vendorCategory)
VALUES
    ('VEN001', 'Alice Green', 'Catering'),
    ('VEN002', 'Bob White', 'Security'),
    ('VEN003', 'Charlie Black', 'Audio-visual'),
    ('VEN004', 'Diana Blue', 'Decoration'),
    ('VEN005', 'Evan Brown', 'Logistics'),
    ('VEN006', 'Fiona Red', 'Catering'),
    ('VEN007', 'George Yellow', 'Security'),
    ('VEN008', 'Hannah Purple', 'Audio-visual'),
    ('VEN009', 'Ian Orange', 'Decoration'),
    ('VEN010', 'Jack Pink', 'Logistics');
SELECT *
FROM Vendor;

--Inserting into Events Table:
INSERT INTO Events
    (organizerID, eventName, eventStartDate, eventEndDate, eventLocation, eventDescription, approved)
VALUES
    ('ORG001', 'Tech Conference 2023', '2023-11-01 09:00:00', '2023-11-01 17:00:00', 'New York Convention Center', 'A conference for tech enthusiasts.', 1),
    ('ORG002', 'Art Expo 2023', '2023-11-05 10:00:00', '2023-11-05 18:00:00', 'Los Angeles Art Gallery', 'An exhibition showcasing modern art.', 1),
    ('ORG003', 'Food Festival 2023', '2023-11-10 11:00:00', '2023-11-10 20:00:00', 'Chicago Food Plaza', 'A festival featuring gourmet food.', 1),
    ('ORG004', 'Music Fest 2023', '2023-11-15 12:00:00', '2023-11-15 22:00:00', 'San Francisco Music Park', 'A festival with live music performances.', 1),
    ('ORG005', 'Sports Meet 2023', '2023-11-20 09:00:00', '2023-11-20 17:00:00', 'Houston Sports Arena', 'A meet for sports enthusiasts.', 1),
    ('ORG006', 'Theater Play 2023', '2023-11-25 19:00:00', '2023-11-25 21:00:00', 'Boston Theater', 'A play performed by local artists.', 1),
    ('ORG007', 'Film Festival 2023', '2023-11-30 18:00:00', '2023-11-30 23:00:00', 'Miami Film Center', 'A festival showcasing independent films.', 1),
    ('ORG008', 'Book Fair 2023', '2023-12-05 10:00:00', '2023-12-05 18:00:00', 'Seattle Book Plaza', 'A fair for book lovers.', 1),
    ('ORG009', 'Fashion Show 2023', '2023-12-10 19:00:00', '2023-12-10 21:00:00', 'Las Vegas Fashion Hall', 'A show featuring the latest fashion trends.', 1),
    ('ORG010', 'Gaming Convention 2023', '2023-12-15 09:00:00', '2023-12-15 17:00:00', 'Dallas Gaming Arena', 'A convention for gaming enthusiasts.', 1),
    ('ORG001', 'Tech Expo 2023', '2023-12-20 09:00:00', '2023-12-20 17:00:00', 'New York Convention Center', 'An expo for tech innovations.', 1),
    ('ORG002', 'Art Fair 2023', '2023-12-25 10:00:00', '2023-12-25 18:00:00', 'Los Angeles Art Gallery', 'A fair showcasing various art forms.', 1),
    ('ORG003', 'Gourmet Food Fest 2023', '2023-12-30 11:00:00', '2023-12-30 20:00:00', 'Chicago Food Plaza', 'A festival featuring gourmet food.', 1),
    ('ORG004', 'Live Music Fest 2023', '2024-01-05 12:00:00', '2024-01-05 22:00:00', 'San Francisco Music Park', 'A festival with live music performances.', 1),
    ('ORG005', 'Sports Gala 2023', '2024-01-10 09:00:00', '2024-01-10 17:00:00', 'Houston Sports Arena', 'A gala for sports enthusiasts.', 1),
    ('ORG006', 'Drama Play 2023', '2024-01-15 19:00:00', '2024-01-15 21:00:00', 'Boston Theater', 'A play performed by local artists.', 1),
    ('ORG007', 'Indie Film Fest 2023', '2024-01-20 18:00:00', '2024-01-20 23:00:00', 'Miami Film Center', 'A festival showcasing independent films.', 1),
    ('ORG008', 'Literature Fair 2023', '2024-01-25 10:00:00', '2024-01-25 18:00:00', 'Seattle Book Plaza', 'A fair for literature lovers.', 1),
    ('ORG009', 'Fashion Gala 2023', '2024-01-30 19:00:00', '2024-01-30 21:00:00', 'Las Vegas Fashion Hall', 'A gala featuring the latest fashion trends.', 1),
    ('ORG010', 'E-Sports Convention 2023', '2024-02-05 09:00:00', '2024-02-05 17:00:00', 'Dallas Gaming Arena', 'A convention for e-sports enthusiasts.', 1),
    ('ORG001', 'Tech Summit 2023', '2024-02-10 09:00:00', '2024-02-10 17:00:00', 'New York Convention Center', 'A summit for tech professionals.', 1),
    ('ORG002', 'Art Symposium 2023', '2024-02-15 10:00:00', '2024-02-15 18:00:00', 'Los Angeles Art Gallery', 'A symposium on modern art.', 1),
    ('ORG003', 'Food Carnival 2023', '2024-02-20 11:00:00', '2024-02-20 20:00:00', 'Chicago Food Plaza', 'A carnival featuring gourmet food.', 1),
    ('ORG004', 'Music Extravaganza 2023', '2024-02-25 12:00:00', '2024-02-25 22:00:00', 'San Francisco Music Park', 'An extravaganza with live music performances.', 1),
    ('ORG005', 'Sports Extravaganza 2023', '2024-03-01 09:00:00', '2024-03-01 17:00:00', 'Houston Sports Arena', 'An extravaganza for sports enthusiasts.', 1),
    ('ORG006', 'Theater Extravaganza 2023', '2024-03-05 19:00:00', '2024-03-05 21:00:00', 'Boston Theater', 'An extravaganza performed by local artists.', 1),
    ('ORG007', 'Film Extravaganza 2023', '2024-03-10 18:00:00', '2024-03-10 23:00:00', 'Miami Film Center', 'An extravaganza showcasing independent films.', 1),
    ('ORG008', 'Book Extravaganza 2023', '2024-03-15 10:00:00', '2024-03-15 18:00:00', 'Seattle Book Plaza', 'An extravaganza for book lovers.', 1),
    ('ORG009', 'Fashion Extravaganza 2023', '2024-03-20 19:00:00', '2024-03-20 21:00:00', 'Las Vegas Fashion Hall', 'An extravaganza featuring the latest fashion trends.', 1),
    ('ORG010', 'Gaming Extravaganza 2023', '2024-03-25 09:00:00', '2024-03-25 17:00:00', 'Dallas Gaming Arena', 'An extravaganza for gaming enthusiasts.', 1),
    ('ORG001', 'Tech Symposium 2023', '2024-03-30 09:00:00', '2024-03-30 17:00:00', 'New York Convention Center', 'A symposium for tech professionals.', 1),
    ('ORG002', 'Art Carnival 2023', '2024-04-05 10:00:00', '2024-04-05 18:00:00', 'Los Angeles Art Gallery', 'A carnival showcasing various art forms.', 1),
    ('ORG003', 'Gourmet Food Extravaganza 2023', '2024-04-10 11:00:00', '2024-04-10 20:00:00', 'Chicago Food Plaza', 'An extravaganza featuring gourmet food.', 1),
    ('ORG004', 'Live Music Extravaganza 2023', '2024-04-15 12:00:00', '2024-04-15 22:00:00', 'San Francisco Music Park', 'An extravaganza with live music performances.', 1),
    ('ORG005', 'Sports Symposium 2023', '2024-04-20 09:00:00', '2024-04-20 17:00:00', 'Houston Sports Arena', 'A symposium for sports enthusiasts.', 1),
    ('ORG006', 'Drama Extravaganza 2023', '2024-04-25 19:00:00', '2024-04-25 21:00:00', 'Boston Theater', 'An extravaganza performed by local artists.', 1),
    ('ORG007', 'Indie Film Extravaganza 2023', '2024-04-30 18:00:00', '2024-04-30 23:00:00', 'Miami Film Center', 'An extravaganza showcasing independent films.', 1),
    ('ORG008', 'Literature Extravaganza 2023', '2024-05-05 10:00:00', '2024-05-05 18:00:00', 'Seattle Book Plaza', 'An extravaganza for literature lovers.', 1),
    ('ORG009', 'Fashion Symposium 2023', '2024-05-10 19:00:00', '2024-05-10 21:00:00', 'Las Vegas Fashion Hall', 'A symposium featuring the latest fashion trends.', 1),
    ('ORG010', 'E-Sports Extravaganza 2023', '2024-05-15 09:00:00', '2024-05-15 17:00:00', 'Dallas Gaming Arena', 'An extravaganza for e-sports enthusiasts.', 1),
    ('ORG001', 'Tech Carnival 2023', '2024-05-20 09:00:00', '2024-05-20 17:00:00', 'New York Convention Center', 'A carnival for tech enthusiasts.', 1),
    ('ORG002', 'Art Extravaganza 2023', '2024-05-25 10:00:00', '2024-05-25 18:00:00', 'Los Angeles Art Gallery', 'An extravaganza showcasing modern art.', 1),
    ('ORG003', 'Food Symposium 2023', '2024-05-30 11:00:00', '2024-05-30 20:00:00', 'Chicago Food Plaza', 'A symposium featuring gourmet food.', 1),
    ('ORG004', 'Music Symposium 2023', '2024-06-05 12:00:00', '2024-06-05 22:00:00', 'San Francisco Music Park', 'A symposium with live music performances.', 1),
    ('ORG005', 'Sports Carnival 2023', '2024-06-10 09:00:00', '2024-06-10 17:00:00', 'Houston Sports Arena', 'A carnival for sports enthusiasts.', 1);

SELECT *
FROM Events;

--Inserting into Tickets Table:
INSERT INTO Tickets
    (eventID, category, price, available)
VALUES
    (1, 'VIP', 150.00, 1),
    (1, 'General', 50.00, 1),
    (2, 'VIP', 150.00, 1),
    (2, 'General', 50.00, 1),
    (3, 'VIP', 150.00, 1),
    (3, 'General', 50.00, 1),
    (4, 'VIP', 150.00, 1),
    (4, 'General', 50.00, 1),
    (5, 'VIP', 150.00, 1),
    (5, 'General', 50.00, 1),
    (6, 'VIP', 150.00, 1),
    (6, 'General', 50.00, 1),
    (7, 'VIP', 150.00, 1),
    (7, 'General', 50.00, 1),
    (8, 'VIP', 150.00, 1),
    (8, 'General', 50.00, 1),
    (9, 'VIP', 150.00, 1),
    (9, 'General', 50.00, 1),
    (10, 'VIP', 150.00, 1),
    (10, 'General', 50.00, 1),
    (11, 'VIP', 150.00, 1),
    (11, 'General', 50.00, 1),
    (12, 'VIP', 150.00, 1),
    (12, 'General', 50.00, 1),
    (13, 'VIP', 150.00, 1),
    (13, 'General', 50.00, 1),
    (14, 'VIP', 150.00, 1),
    (14, 'General', 50.00, 1),
    (15, 'VIP', 150.00, 1),
    (15, 'General', 50.00, 1),
    (16, 'VIP', 150.00, 1),
    (16, 'General', 50.00, 1),
    (17, 'VIP', 150.00, 1),
    (17, 'General', 50.00, 1),
    (18, 'VIP', 150.00, 1),
    (18, 'General', 50.00, 1),
    (19, 'VIP', 150.00, 1),
    (19, 'General', 50.00, 1),
    (20, 'VIP', 150.00, 1),
    (20, 'General', 50.00, 1),
    (21, 'VIP', 150.00, 1),
    (21, 'General', 50.00, 1),
    (22, 'VIP', 150.00, 1),
    (22, 'General', 50.00, 1),
    (23, 'VIP', 150.00, 1),
    (23, 'General', 50.00, 1),
    (24, 'VIP', 150.00, 1),
    (24, 'General', 50.00, 1),
    (25, 'VIP', 150.00, 1),
    (25, 'General', 50.00, 1);
SELECT *
FROM Tickets;

-- Inserting into Attending Table
INSERT INTO Attending
    (attendeeID, eventID, bookedTicket, downloadE_Ticket)
VALUES
    ('ATT001', 1, 1, 1),
    ('ATT002', 2, 1, 1),
    ('ATT003', 3, 1, 1),
    ('ATT004', 4, 1, 1),
    ('ATT005', 5, 1, 1),
    ('ATT006', 6, 1, 1),
    ('ATT007', 7, 1, 1),
    ('ATT008', 8, 1, 1),
    ('ATT009', 9, 1, 1),
    ('ATT010', 10, 1, 1),
    ('ATT011', 11, 1, 1),
    ('ATT012', 12, 1, 1),
    ('ATT013', 13, 1, 1),
    ('ATT014', 14, 1, 1),
    ('ATT015', 15, 1, 1),
    ('ATT016', 16, 1, 1),
    ('ATT017', 17, 1, 1),
    ('ATT018', 18, 1, 1),
    ('ATT019', 19, 1, 1),
    ('ATT020', 20, 1, 1),
    ('ATT021', 21, 1, 1),
    ('ATT022', 22, 1, 1),
    ('ATT023', 23, 1, 1),
    ('ATT024', 24, 1, 1),
    ('ATT025', 25, 1, 1),
    ('ATT026', 1, 1, 1),
    ('ATT027', 2, 1, 1),
    ('ATT028', 3, 1, 1),
    ('ATT029', 4, 1, 1),
    ('ATT030', 5, 1, 1),
    ('ATT031', 6, 1, 1),
    ('ATT032', 7, 1, 1),
    ('ATT033', 8, 1, 1),
    ('ATT034', 9, 1, 1),
    ('ATT035', 10, 1, 1),
    ('ATT036', 11, 1, 1),
    ('ATT037', 12, 1, 1),
    ('ATT038', 13, 1, 1),
    ('ATT039', 14, 1, 1),
    ('ATT040', 15, 1, 1),
    ('ATT041', 16, 1, 1),
    ('ATT042', 17, 1, 1),
    ('ATT043', 18, 1, 1),
    ('ATT044', 19, 1, 1),
    ('ATT045', 20, 1, 1),
    ('ATT046', 21, 1, 1),
    ('ATT047', 22, 1, 1),
    ('ATT048', 23, 1, 1),
    ('ATT049', 24, 1, 1),
    ('ATT050', 25, 1, 1);

SELECT *
FROM Attending;



-- Inserting into EventVendor Table
INSERT INTO EventVendor
    (eventID, vendorID, serviceDescription)
VALUES
    (1, 'VEN001', 'Catering services for the event.'),
    (2, 'VEN002', 'Security services for the event.'),
    (3, 'VEN003', 'Audio-visual services for the event.'),
    (4, 'VEN004', 'Decoration services for the event.'),
    (5, 'VEN005', 'Logistics and transportation services for the event.'),
    (6, 'VEN001', 'Catering services for the event.'),
    (7, 'VEN002', 'Security services for the event.'),
    (8, 'VEN003', 'Audio-visual services for the event.'),
    (9, 'VEN004', 'Decoration services for the event.'),
    (10, 'VEN005', 'Logistics and transportation services for the event.'),
    (11, 'VEN001', 'Catering services for the event.'),
    (12, 'VEN002', 'Security services for the event.'),
    (13, 'VEN003', 'Audio-visual services for the event.'),
    (14, 'VEN004', 'Decoration services for the event.'),
    (15, 'VEN005', 'Logistics and transportation services for the event.'),
    (16, 'VEN001', 'Catering services for the event.'),
    (17, 'VEN002', 'Security services for the event.'),
    (18, 'VEN003', 'Audio-visual services for the event.'),
    (19, 'VEN004', 'Decoration services for the event.'),
    (20, 'VEN005', 'Logistics and transportation services for the event.'),
    (21, 'VEN001', 'Catering services for the event.'),
    (22, 'VEN002', 'Security services for the event.'),
    (23, 'VEN003', 'Audio-visual services for the event.'),
    (24, 'VEN004', 'Decoration services for the event.'),
    (25, 'VEN005', 'Logistics and transportation services for the event.');

SELECT *
FROM EventVendor;


--INserting into EventFeedback table:
INSERT INTO EventFeedback
    (attendeeID, eventID, eventName, feedbackText, rating)
VALUES
    ('ATT001', 1, 'Tech Conference 2023', 'Great event with insightful sessions.', 5),
    ('ATT002', 2, 'Art Expo 2023', 'Amazing artwork and well-organized.', 4),
    ('ATT003', 3, 'Food Festival 2023', 'Delicious food and great atmosphere.', 5),
    ('ATT004', 4, 'Music Fest 2023', 'Fantastic performances and good crowd.', 4),
    ('ATT005', 5, 'Sports Meet 2023', 'Well-organized and exciting events.', 5),
    ('ATT006', 6, 'Theater Play 2023', 'Excellent play and great acting.', 4),
    ('ATT007', 7, 'Film Festival 2023', 'Impressive selection of films.', 5),
    ('ATT008', 8, 'Book Fair 2023', 'Wide variety of books and authors.', 4),
    ('ATT009', 9, 'Fashion Show 2023', 'Stylish and trendy fashion show.', 5),
    ('ATT010', 10, 'Gaming Convention 2023', 'Exciting games and great experience.', 5),
    ('ATT011', 11, 'Tech Expo 2023', 'Innovative tech displays and demos.', 4),
    ('ATT012', 12, 'Art Fair 2023', 'Beautiful art pieces and friendly artists.', 5),
    ('ATT013', 13, 'Gourmet Food Fest 2023', 'Delicious gourmet food and drinks.', 5),
    ('ATT014', 14, 'Live Music Fest 2023', 'Energetic performances and good vibes.', 4),
    ('ATT015', 15, 'Sports Gala 2023', 'Exciting sports events and activities.', 5),
    ('ATT016', 16, 'Drama Play 2023', 'Captivating drama and excellent acting.', 4),
    ('ATT017', 17, 'Indie Film Fest 2023', 'Great selection of indie films.', 5),
    ('ATT018', 18, 'Literature Fair 2023', 'Interesting literature and discussions.', 4),
    ('ATT019', 19, 'Fashion Gala 2023', 'Elegant and stylish fashion show.', 5),
    ('ATT020', 20, 'E-Sports Convention 2023', 'Thrilling e-sports competitions.', 5),
    ('ATT021', 21, 'Tech Summit 2023', 'Informative sessions and networking opportunities.', 4),
    ('ATT022', 22, 'Art Symposium 2023', 'Inspiring talks and beautiful art.', 5),
    ('ATT023', 23, 'Food Carnival 2023', 'Fun atmosphere and delicious food.', 5),
    ('ATT024', 24, 'Music Extravaganza 2023', 'Great music and lively crowd.', 4),
    ('ATT025', 25, 'Sports Extravaganza 2023', 'Exciting sports events and activities.', 5);

SELECT *
FROM EventFeedback;



-- Inserting into Complaints Table
INSERT INTO Complaints (userID, feedback)
VALUES
('ATT001', 'The event was not well organized.'),
('ATT002', 'The venue was too crowded.'),
('ATT003', 'The event started late.'),
('ATT004', 'The food quality was poor.'),
('ATT005', 'The sound system was not clear.'),
('ATT006', 'The seating arrangement was uncomfortable.'),
('ATT007', 'The event schedule was not followed.'),
('ATT008', 'The staff was not helpful.'),
('ATT009', 'The parking area was too far.'),
('ATT010', 'The event was too expensive.');

SELECT * FROM Complaints;






--AUDIT TRAIL TRIGGERS FOR Event-Verse-DB:

-- Audit table for Users
CREATE TABLE UsersAudit
(
    auditID INT NOT NULL IDENTITY PRIMARY KEY,
    -- Unique identifier for each audit entry
    userID VARCHAR(255) NOT NULL,
    -- ID of the user being audited
    operationType VARCHAR(50) NOT NULL,
    -- Type of operation (INSERT, UPDATE, DELETE)
    operationDate DATETIME NOT NULL DEFAULT GETDATE(),
    -- Date and time of the operation
    oldName VARCHAR(255),
    -- Old name (for UPDATE and DELETE)
    newName VARCHAR(255),
    -- New name (for INSERT and UPDATE)
    oldEmail VARCHAR(255),
    -- Old email (for UPDATE and DELETE)
    newEmail VARCHAR(255),
    -- New email (for INSERT and UPDATE)
    oldContact VARCHAR(50),
    -- Old contact (for UPDATE and DELETE)
    newContact VARCHAR(50),
    -- New contact (for INSERT and UPDATE)
    oldAge INT,
    -- Old age (for UPDATE and DELETE)
    newAge INT,
    -- New age (for INSERT and UPDATE)
    oldGender VARCHAR(10),
    -- Old gender (for UPDATE and DELETE)
    newGender VARCHAR(10),
    -- New gender (for INSERT and UPDATE)
    oldPassword VARCHAR(255),
    -- Old password (for UPDATE and DELETE)
    newPassword VARCHAR(255),
    -- New password (for INSERT and UPDATE)
    oldUserType VARCHAR(50),
    -- Old user type (for UPDATE and DELETE)
    newUserType VARCHAR(50),
    -- New user type (for INSERT and UPDATE)
    oldLocationID INT,
    -- Old location ID (for UPDATE and DELETE)
    newLocationID INT,
    -- New location ID (for INSERT and UPDATE)
    oldApproved BIT,
    -- Old approved status (for UPDATE and DELETE)
    newApproved BIT
    -- New approved status (for INSERT and UPDATE)
);
-- Trigger for INSERT on Users
GO
CREATE TRIGGER 
trgUsersInsert
ON Users
AFTER INSERT
AS
BEGIN
    INSERT INTO UsersAudit
        (
        userID, operationType, newName, newEmail, newContact, newAge, newGender, newPassword, newUserType, newLocationID, newApproved
        )
    SELECT
        ID, 'INSERT', name, email, contact#, age, gender, password, userType, locationID, approved
    FROM
        inserted;
END;
GO
-- Trigger for UPDATE on Users
GO
CREATE TRIGGER trgUsersUpdate
ON Users
AFTER UPDATE
AS
BEGIN
    INSERT INTO UsersAudit (
        userID, operationType, operationDate, oldName, newName, oldEmail, newEmail, oldContact, newContact, oldAge, newAge, oldGender, newGender, oldPassword, newPassword, oldUserType, newUserType, oldLocationID, newLocationID, oldApproved, newApproved
    )
    SELECT
        d.ID, 'UPDATE', GETDATE(), d.name, i.name, d.email, i.email, d.contact#, i.contact#, d.age, i.age, d.gender, i.gender, d.password, i.password, d.userType, i.userType, d.locationID, i.locationID, d.approved, i.approved
    FROM
        deleted d
    INNER JOIN
        inserted i ON d.ID = i.ID;
END;
GO
-- Trigger for DELETE on Users
GO
CREATE TRIGGER trgUsersDelete
ON Users
AFTER DELETE
AS
BEGIN
    INSERT INTO UsersAudit (
        userID, operationType, oldName, oldEmail, oldContact, oldAge, oldGender, oldPassword, oldUserType, oldLocationID, oldApproved
    )
    SELECT
        ID, 'DELETE', name, email, contact#, age, gender, password, userType, locationID, approved
    FROM
        deleted;
END;
GO

-- Audit table for Events
CREATE TABLE EventsAudit (
    auditID INT NOT NULL IDENTITY PRIMARY KEY,
    eventID INT NOT NULL,
    operationType VARCHAR(50) NOT NULL,
    operationDate DATETIME NOT NULL DEFAULT GETDATE(),
    oldEventName VARCHAR(255),
    newEventName VARCHAR(255),
    oldEventStartDate DATETIME,
    newEventStartDate DATETIME,
    oldEventEndDate DATETIME,
    newEventEndDate DATETIME,
    oldEventLocation VARCHAR(255),
    newEventLocation VARCHAR(255),
    oldEventDescription TEXT,
    newEventDescription TEXT,
    oldApproved BIT,
    newApproved BIT
);
-- Trigger for INSERT on Events
GO
CREATE TRIGGER 
trgEventsInsert
ON Events
AFTER INSERT
AS
BEGIN
    INSERT INTO EventsAudit (
        eventID, operationType, newEventName, newEventStartDate, newEventEndDate, newEventLocation, newEventDescription, newApproved
    )
    SELECT
        eventID, 'INSERT', eventName, eventStartDate, eventEndDate, eventLocation, eventDescription, approved
    FROM
        inserted;
END;
GO

-- Trigger for UPDATE on Events
GO
CREATE TRIGGER trgEventsUpdate
ON Events
AFTER UPDATE
AS
BEGIN
    INSERT INTO EventsAudit (
        eventID, operationType, operationDate, oldEventName, newEventName, oldEventStartDate, newEventStartDate, oldEventEndDate, newEventEndDate, oldEventLocation, newEventLocation, oldEventDescription, newEventDescription, oldApproved, newApproved
    )
    SELECT
        d.eventID, 'UPDATE', GETDATE(), d.eventName, i.eventName, d.eventStartDate, i.eventStartDate, d.eventEndDate, i.eventEndDate, d.eventLocation, i.eventLocation, d.eventDescription, i.eventDescription, d.approved, i.approved
    FROM
        deleted d
    INNER JOIN
        inserted i ON d.eventID = i.eventID;
END;
GO

-- Trigger for DELETE on Events
GO
CREATE TRIGGER trgEventsDelete
ON Events
AFTER DELETE
AS
BEGIN
    INSERT INTO EventsAudit (
        eventID, operationType, oldEventName, oldEventStartDate, oldEventEndDate, oldEventLocation, oldEventDescription, oldApproved
    )
    SELECT
        eventID, 'DELETE', eventName, eventStartDate, eventEndDate, eventLocation, eventDescription, approved
    FROM
        deleted;
END;
GO