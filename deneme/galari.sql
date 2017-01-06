-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Oca 2017, 16:02:04
-- Sunucu sürümü: 10.1.19-MariaDB
-- PHP Sürümü: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `test`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `galari`
--

CREATE TABLE `galari` (
  `id` int(11) NOT NULL,
  `marka` varchar(20) NOT NULL,
  `model` varchar(20) NOT NULL,
  `renk` varchar(20) NOT NULL,
  `yil` int(11) NOT NULL,
  `satimtarih` date NOT NULL,
  `teslimtarih` date NOT NULL,
  `gün` int(11) NOT NULL,
  `m_ad` varchar(20) NOT NULL,
  `m_soyad` varchar(20) NOT NULL,
  `m_adres` varchar(100) NOT NULL,
  `m_no` int(11) NOT NULL,
  `m_tc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `galari`
--

INSERT INTO `galari` (`id`, `marka`, `model`, `renk`, `yil`, `satimtarih`, `teslimtarih`, `gün`, `m_ad`, `m_soyad`, `m_adres`, `m_no`, `m_tc`) VALUES
(1, 'bmw', '530', 'beyaz', 2016, '2017-01-03', '2017-01-11', 0, '', '', '', 0, 0),
(3, 'audi', 'a7', 'k?rm?z?', 2000, '2017-01-16', '2017-01-20', 0, '', '', '', 0, 0);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `galari`
--
ALTER TABLE `galari`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `galari`
--
ALTER TABLE `galari`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
