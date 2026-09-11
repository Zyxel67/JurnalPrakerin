-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 22, 2026 at 11:51 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Table structure for table `gurupembimbing`
--

CREATE TABLE `gurupembimbing` (
  `Id_Gr` int(50) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Telepon` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `gurupembimbing`
--

INSERT INTO `gurupembimbing` (`Id_Gr`, `Nama`, `Telepon`) VALUES
(2, '22', '2222');

-- --------------------------------------------------------

--
-- Table structure for table `jurnal_siswa`
--

CREATE TABLE `jurnal_siswa` (
  `id_laporan` int(11) NOT NULL,
  `Ids` varchar(50) NOT NULL,
  `tanggal` date NOT NULL,
  `kegiatan` varchar(100) NOT NULL,
  `deskripsi` text NOT NULL,
  `status` enum('Menunggu','Disetujui','Revisi') NOT NULL DEFAULT 'Menunggu',
  `dokumentasi` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `jurnal_siswa`
--

INSERT INTO `jurnal_siswa` (`id_laporan`, `Ids`, `tanggal`, `kegiatan`, `deskripsi`, `status`, `dokumentasi`) VALUES
(1, '33', '2026-08-22', '2332', '2323', 'Menunggu', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `perusahaan`
--

CREATE TABLE `perusahaan` (
  `Id_Pt` int(50) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Telepon` int(50) NOT NULL,
  `Nama_Pembimbing` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `perusahaan`
--

INSERT INTO `perusahaan` (`Id_Pt`, `Nama`, `Alamat`, `Telepon`, `Nama_Pembimbing`) VALUES
(2, '121212', '', 12121212, 'sdaswswawaw'),
(3, '22', '', 22, '22');

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `Ids` int(50) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Telepon` int(50) NOT NULL,
  `Jurusan` varchar(20) DEFAULT NULL,
  `Kelas` varchar(20) DEFAULT NULL,
  `Id_Pt` int(20) DEFAULT NULL,
  `Id_Gr` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`Ids`, `Nama`, `Telepon`, `Jurusan`, `Kelas`, `Id_Pt`, `Id_Gr`) VALUES
(33, '33', 33, NULL, NULL, 2, 2),
(1222, '21', 0, NULL, NULL, NULL, NULL),
(21121221, '1122', 1122, NULL, NULL, NULL, NULL),
(2147483647, '23232332', 23233232, 'RPL', '12', 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UID` int(24) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `hak` enum('Admin','Guru','Siswa','Pt') NOT NULL,
  `Ids` varchar(50) DEFAULT NULL,
  `Id_Gr` varchar(50) DEFAULT NULL,
  `Id_Pt` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UID`, `Nama`, `Password`, `Email`, `hak`, `Ids`, `Id_Gr`, `Id_Pt`) VALUES
(1, 'Gibran', '8a30407962eeb19b309b78ddf587aea18ab55232', 'TUTUNG', 'Admin', '', '', ''),
(2, 'lol', 'daad5285c5ce44e7d78003fa9f809dc779aace50', 'Tata', '', '', '', ''),
(16, '11', '17ba0791499db908433b80f37c5fbc89b870084b', '11', 'Admin', '', '', ''),
(21, '232323', '3dea7842bdaae3726936a53c2bcae02a3b4d33fd', '232323', 'Guru', NULL, '32323232323', NULL),
(24, '1122', '00fd4b4549a1094aae926ef62e9dbd3cdcc2e456', '1122', 'Siswa', '21121221', NULL, NULL),
(27, '23232332', '85bc3e20d48a3b60b448889d14c344616647e586', '23232323', 'Siswa', '12121212766767', NULL, NULL),
(28, '22', '12c6fc06c99a462375eeb3f43dfd832b08ca9e17', '22', 'Pt', NULL, NULL, '3'),
(29, '33', 'b6692ea5df920cad691c20319a6fffd7a4a766b8', '33', 'Siswa', '33', NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gurupembimbing`
--
ALTER TABLE `gurupembimbing`
  ADD PRIMARY KEY (`Id_Gr`);

--
-- Indexes for table `jurnal_siswa`
--
ALTER TABLE `jurnal_siswa`
  ADD PRIMARY KEY (`id_laporan`);

--
-- Indexes for table `perusahaan`
--
ALTER TABLE `perusahaan`
  ADD PRIMARY KEY (`Id_Pt`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`Ids`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `jurnal_siswa`
--
ALTER TABLE `jurnal_siswa`
  MODIFY `id_laporan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `perusahaan`
--
ALTER TABLE `perusahaan`
  MODIFY `Id_Pt` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `UID` int(24) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
