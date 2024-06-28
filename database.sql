CREATE TABLE categories (
    id INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(255)
);

CREATE TABLE tariffs (
    id INT AUTO_INCREMENT PRIMARY KEY,
    tariff_name VARCHAR(255),
    number_of_days INT
);

CREATE TABLE prices (
    id INT AUTO_INCREMENT PRIMARY KEY,
    price INT,
    category_id INT,
    tariff_id INT,
    FOREIGN KEY (category_id) REFERENCES categories(id),
    FOREIGN KEY (tariff_id) REFERENCES tariffs(id)
);

CREATE TABLE visitors (
    id INT AUTO_INCREMENT PRIMARY KEY,
    last_name VARCHAR(255),
    first_name VARCHAR(255),
    middle_name VARCHAR(255),
    birth_date DATE,
    login VARCHAR(255),
    password VARCHAR(255)
);

CREATE TABLE subscriptions (
    id INT AUTO_INCREMENT PRIMARY KEY,
    start_date DATE,
    end_date DATE,
    status VARCHAR(255),
    visitor_id INT,
    price_id INT,
    FOREIGN KEY (visitor_id) REFERENCES visitors(id),
    FOREIGN KEY (price_id) REFERENCES prices(id)
);

CREATE TABLE sessions (
    id INT AUTO_INCREMENT PRIMARY KEY,
    starting_time TIME
);

CREATE TABLE visits (
    id INT AUTO_INCREMENT PRIMARY KEY,
    visit_date DATE,
    session_id INT,
    subscription_id INT,
    FOREIGN KEY (subscription_id) REFERENCES subscriptions(id),
    FOREIGN KEY (session_id) REFERENCES sessions(id)
);


INSERT INTO categories (id, category_name) VALUES
(1, 'Дети от 6 до 13 лет'),
(2, 'Взрослые с 14 лет'),
(3, 'Льготный'),
(4, 'Взрослый + ребенок до 5 лет');

INSERT INTO tariffs (id, tariff_name, number_of_days) VALUES
(1, 'Разовый', 1),
(2, '10 сеансов', 10),
(3, '15 сеансов', 15),
(4, '20 сеансов', 20),
(5, 'Безлимит', 30);

INSERT INTO prices (id, price, category_id, tariff_id) VALUES
(1, 170, 1, 1),
(2, 200, 4, 1),
(3, 200, 2, 1),
(4, 150, 3, 1),
(5, 1600, 1, 2),
(6, 1900, 2, 2),
(7, 1900, 4, 2),
(8, 1400, 3, 2),
(9, 2200, 1, 3),
(10, 2700, 2, 3),
(11, 2700, 4, 3),
(12, 1950, 3, 3),
(13, 2700, 1, 4),
(14, 3400, 2, 4),
(15, 2500, 3, 4),
(16, 3400, 4, 4),
(17, 2200, 1, 5),
(18, 2200, 2, 5),
(19, 2200, 3, 5),
(20, 2200, 4, 5);

INSERT INTO visitors (id, last_name, first_name, middle_name, birth_date, login, password) VALUES
(1, 'Митина', 'Алина', 'Витальевна', '2006-06-12', 'Masha', '12345'),
(2, 'Романова', 'Карина', 'Альбертовна', '1998-07-13', 'Eva', '1357'),
(3, 'Петров', 'Константин', 'Александрович', '1988-07-16', 'Kris', '1234'),
(4, 'Новоселов', 'Михаил', 'Андреевич', '1990-09-23', 'Tayra', '9876');

INSERT INTO subscriptions (id, start_date, end_date, status, visitor_id, price_id) VALUES
(1, '2019-03-02', '2019-04-02', 'не действует', 1, 5),
(2, '2019-05-25', '2019-06-25', 'действует', 1, 5),
(3, '2019-05-09', '2019-05-09', 'не действует', 2, 2),
(4, '2019-05-11', '2019-06-11', 'действует', 2, 10),
(5, '2019-05-13', '2019-05-13', 'не действует', 3, 4),
(6, '2019-05-14', '2019-06-14', 'не действует', 3, 8),
(7, '2019-05-20', '2019-06-20', 'действует', 4, 20);

INSERT INTO sessions (id, starting_time) VALUES
(1, '10:00:00'),
(2, '11:00:00'),
(3, '12:00:00'),
(4, '14:00:00'),
(5, '15:00:00'),
(6, '16:00:00'),
(7, '17:00:00'),
(8, '18:00:00'),
(9, '19:00:00');

INSERT INTO visits (id, visit_date, session_id, subscription_id) VALUES
(1, '2019-03-02', 2, 1),
(2, '2019-03-03', 3, 1),
(3, '2019-03-05', 3, 1),
(4, '2019-03-07', 6, 1),
(5, '2019-03-09', 2, 1),
(6, '2019-05-25', 1, 2),
(7, '2019-05-26', 2, 2),
(8, '2019-05-27', 2, 2),
(9, '2019-05-09', 3, 3),
(10, '2019-05-11', 7, 4),
(11, '2019-05-12', 8, 4),
(12, '2019-05-14', 6, 4),
(13, '2019-05-13', 4, 5),
(14, '2019-05-14', 1, 6),
(15, '2019-05-15', 4, 6),
(16, '2019-05-16', 1, 6),
(17, '2019-05-18', 4, 6),
(18, '2019-05-19', 2, 6),
(19, '2019-05-20', 2, 6),
(20, '2019-05-22', 3, 6),
(21, '2019-05-23', 2, 6),
(22, '2019-05-24', 2, 6),
(23, '2019-05-27', 2, 6),
(24, '2019-05-21', 2, 7),
(25, '2019-05-22', 6, 7),
(26, '2019-05-23', 7, 7),
(27, '2019-05-24', 8, 7);

