
CREATE DATABASE IF NOT EXISTS `BookWise`;
USE `BookWise`;

CREATE TABLE IF NOT EXISTS `books` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `isbn_no` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `category` varchar(255) DEFAULT NULL,
  `available_books` int(11) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id`)
);


CREATE TABLE IF NOT EXISTS `book_transactions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `book_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `borrow_date` datetime NOT NULL,
  `return_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK__Books` (`book_id`),
  KEY `FK__Users` (`user_id`),
  CONSTRAINT `FK__Books` FOREIGN KEY (`book_id`) REFERENCES `books` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK__Users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ;

CREATE TABLE IF NOT EXISTS `rules` (
  `max_books_per_user` int(11) NOT NULL DEFAULT 2,
  `max_days_to_return` int(11) NOT NULL DEFAULT 14,
  `fine_per_day` decimal(20,2) NOT NULL DEFAULT 5.00
) ;

INSERT INTO `rules` (`max_books_per_user`, `max_days_to_return`, `fine_per_day`) VALUES
	(2, 14, 5.00);

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `role` varchar(50) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`),
  UNIQUE KEY `nic` (`nic`),
  UNIQUE KEY `email` (`email`)
);

INSERT INTO `users` (`id`, `first_name`, `last_name`, `role`, `nic`, `phone`, `address`, `email`, `password`, `created_at`) VALUES
	(123456, 'Admin', 'Admin', 'admin', '123456789', NULL, NULL, 'admin@gmaill.com', '$2a$11$ntUgp6eHfEuy1Tdz.otyi.jlzxLfHgEqEQJWg5Mje2Ywc2QRST9ES', '2025-11-07 16:23:28');
