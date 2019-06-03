-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 26, 2019 at 11:08 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `arq_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `config`
--

CREATE TABLE `config` (
  `Cod` int(20) NOT NULL,
  `Latitude` double(24,24) NOT NULL,
  `Longitude` double(24,24) NOT NULL,
  `Colour` varchar(40) NOT NULL,
  `Label` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `Cod` int(20) NOT NULL,
  `Date` date NOT NULL,
  `TownHall` varchar(40) NOT NULL,
  `Parish` varchar(40) NOT NULL,
  `Place` varchar(40) NOT NULL,
  `Epoch` varchar(60) NOT NULL,
  `RawMaterial` varchar(60) NOT NULL,
  `Description` varchar(60) NOT NULL,
  `Base` varchar(40) NOT NULL,
  `Tecnhology` varchar(60) NOT NULL,
  `Length` double(12,12) NOT NULL,
  `Width` double(12,12) NOT NULL,
  `Thickness` double(12,12) NOT NULL,
  `Latitude` double(24,24) NOT NULL,
  `Longitude` double(24,24) NOT NULL,
  `Bibliography` varchar(120) NOT NULL,
  `Image` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`Cod`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
