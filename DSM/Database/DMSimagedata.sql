-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: fdb30.awardspace.net
-- Generation Time: Dec 03, 2020 at 09:52 AM
-- Server version: 5.7.20-log
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `3532067_data`
--

-- --------------------------------------------------------

--
-- Table structure for table `DMSimagedata`
--

CREATE TABLE `DMSimagedata` (
  `ID` int(11) NOT NULL,
  `UserID` int(20) DEFAULT NULL,
  `GroupID` int(20) DEFAULT NULL,
  `ImageID` int(20) DEFAULT NULL,
  `ImageOrder` int(5) DEFAULT NULL,
  `FileName` text,
  `Date` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `DMSimagedata`
--

INSERT INTO `DMSimagedata` (`ID`, `UserID`, `GroupID`, `ImageID`, `ImageOrder`, `FileName`, `Date`) VALUES
(4, 1, 2699428, 3393826, 2, 'upload/1269942833938265908.jpg', '2020-11-16 06:13:22'),
(3, 1, 2699428, 6438754, 1, 'upload/1269942864387545275.jpg', '2020-11-16 06:12:09'),
(5, 1, 2699428, 9590341, 3, 'upload/1269942895903413858.jpg', '2020-11-16 06:15:47'),
(6, 1, 2699428, 442383, 4, 'upload/126994284423834221.jpg', '2020-11-16 06:16:52'),
(7, 1, 2699428, 758524, 5, 'upload/126994287585246598.jpg', '2020-11-16 06:19:23'),
(8, 1, 2699428, 5753255, 6, '126994285753255.jpg', '2020-11-16 06:24:39'),
(9, 1, 6713205, 7625824, 1, '167132057625824.jpg', '2020-11-16 06:37:40'),
(10, 1, 6713205, 8278679, 2, '167132058278679.jpg', '2020-11-16 06:37:52'),
(11, 1, 6713205, 815294, 3, '16713205815294.jpg', '2020-11-16 06:38:09');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `DMSimagedata`
--
ALTER TABLE `DMSimagedata`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `DMSimagedata`
--
ALTER TABLE `DMSimagedata`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
