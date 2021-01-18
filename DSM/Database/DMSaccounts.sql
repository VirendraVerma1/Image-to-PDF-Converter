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
-- Table structure for table `DMSaccounts`
--

CREATE TABLE `DMSaccounts` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Date` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `DMSaccounts`
--

INSERT INTO `DMSaccounts` (`ID`, `Name`, `Date`) VALUES
(1, '7786343', '2020-11-16 17:24:45'),
(2, '3244340', '2020-11-16 17:30:59');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `DMSaccounts`
--
ALTER TABLE `DMSaccounts`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `DMSaccounts`
--
ALTER TABLE `DMSaccounts`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
