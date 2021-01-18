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
-- Table structure for table `DMSdata`
--

CREATE TABLE `DMSdata` (
  `ID` int(11) NOT NULL,
  `UserID` varchar(20) DEFAULT NULL,
  `GroupID` varchar(20) DEFAULT NULL,
  `FileName` varchar(100) DEFAULT NULL,
  `Date` datetime DEFAULT NULL,
  `PDFCode` varchar(20) DEFAULT NULL,
  `Process` int(5) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `DMSdata`
--

INSERT INTO `DMSdata` (`ID`, `UserID`, `GroupID`, `FileName`, `Date`, `PDFCode`, `Process`) VALUES
(1, '1', '2699428', 'file', '2020-11-16 06:19:23', '12699428', 1),
(2, '1', '6713205', 'file', '2020-11-16 06:37:40', '16713205', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `DMSdata`
--
ALTER TABLE `DMSdata`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `DMSdata`
--
ALTER TABLE `DMSdata`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
