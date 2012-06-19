-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 19. Jun 2012 um 17:43
-- Server Version: 5.5.16
-- PHP-Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `zeiterfassung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tkunde`
--

CREATE TABLE IF NOT EXISTS `tkunde` (
  `kuID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `kuFirma` varchar(64) DEFAULT NULL,
  `kuStrasse` varchar(64) NOT NULL,
  `kuPLZ` varchar(5) NOT NULL,
  `kuOrt` varchar(64) NOT NULL,
  `kuTel` varchar(32) NOT NULL,
  `kuFax` varchar(32) DEFAULT NULL,
  `kuAnsprechpartner` varchar(64) NOT NULL,
  `kuEMail` varchar(32) NOT NULL,
  PRIMARY KEY (`kuID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Daten für Tabelle `tkunde`
--

INSERT INTO `tkunde` (`kuID`, `kuFirma`, `kuStrasse`, `kuPLZ`, `kuOrt`, `kuTel`, `kuFax`, `kuAnsprechpartner`, `kuEMail`) VALUES
(1, 'Testfirma', 'Teststraße 23', '12312', 'Testhausen', '12312312', '1234234', 'Schorsch', 'sch@orsch.de'),
(2, 'MultiCom', 'Blumenstrasse 2', '45878', 'Aachen', '454-6874554', '454-68745545', 'Diddi Schubert', 'Diddi@hotmail.mobi.co.uk'),
(3, 'Blumen AG', 'Auf der Terrasse 17', '85878', 'Hamburg', '0221-6544554', '02221-68745548', 'Oskar Lafontaine', 'Oskar@web.de'),
(4, 'Telekom GmbH', 'Bonner Talweg 1-9999', '50545', 'Bonn', '0228-523447', '0228-524654', 'Pamela Schultze', 'Pamela@Schultzens.de'),
(5, 'ICEA GmbH & Co. KG', 'Auf den Wegen 1-3', '45874', 'Münster', '0229-5478756', '0229-5465466', 'Jürgen  Schuster', 'Juergen.Schuster@office.de');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tmitarbeiter`
--

CREATE TABLE IF NOT EXISTS `tmitarbeiter` (
  `miID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `roID` int(10) unsigned NOT NULL,
  `miName` varchar(32) NOT NULL,
  `miVorname` varchar(32) DEFAULT NULL,
  `miUsername` varchar(32) NOT NULL,
  `miPasswort` varchar(32) NOT NULL,
  `miEMail` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`miID`),
  KEY `fk_miroID` (`roID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=11 ;

--
-- Daten für Tabelle `tmitarbeiter`
--

INSERT INTO `tmitarbeiter` (`miID`, `roID`, `miName`, `miVorname`, `miUsername`, `miPasswort`, `miEMail`) VALUES
(1, 1, 'Admin', 'NA', 'Admin', '83095e7ae40304e6c03c9da2f1ce2302', 'NA'),
(2, 2, 'User', 'NA', 'User', '83095e7ae40304e6c03c9da2f1ce2302', 'NA'),
(3, 2, 'Seipel', 'Günther', 'gseipel', '83095e7ae40304e6c03c9da2f1ce2302', 'gunther@seipel.de'),
(7, 2, 'Müller', 'Horst', 'Horsti', '83095e7ae40304e6c03c9da2f1ce2302', 'horst@horst.de'),
(8, 2, 'Vogt', 'Holger', 'H01gA', '83095e7ae40304e6c03c9da2f1ce2302', 'holger@office.de'),
(9, 2, 'Müller', 'Juppi', 'Jupp', '83095e7ae40304e6c03c9da2f1ce2302', 'Juppinator@webmail.to'),
(10, 1, 'Frings', 'Thorsten', 'Toddy', '83095e7ae40304e6c03c9da2f1ce2302', 'Toddy@webmail.to');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tmita_proj`
--

CREATE TABLE IF NOT EXISTS `tmita_proj` (
  `miID` int(10) unsigned NOT NULL,
  `prID` int(10) unsigned NOT NULL,
  `mpAktiv` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`miID`,`prID`),
  KEY `fk_mpprID` (`prID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `tmita_proj`
--

INSERT INTO `tmita_proj` (`miID`, `prID`, `mpAktiv`) VALUES
(3, 1, 1),
(7, 1, 1),
(8, 2, 1),
(9, 3, 0),
(10, 4, 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tprojekt`
--

CREATE TABLE IF NOT EXISTS `tprojekt` (
  `prID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `kuID` int(10) unsigned NOT NULL,
  `prName` varchar(64) NOT NULL,
  `prBeschreibung` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`prID`),
  KEY `fk_prkuID` (`kuID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Daten für Tabelle `tprojekt`
--

INSERT INTO `tprojekt` (`prID`, `kuID`, `prName`, `prBeschreibung`) VALUES
(1, 1, 'Essen gehen', 'Man isst ein Brötchen.'),
(2, 1, 'Operation Flashpoint', 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquy'),
(3, 2, 'Operation Walküre', 'Die Operation Walküre war ursprünglich ein Plan der deutschen Wehrmacht zur Unterdrückung eines möglichen Aufstandes während der'),
(4, 3, 'Project Zero', 'Project Zero, in den USA als Fatal Frame vertrieben, ist ein japanisches Survival-Horror-Adventure von Tecmo aus dem Jahr 2001, '),
(5, 4, 'Project X', 'Three seemingly anonymous high school seniors attempt to finally make a name for themselves. Their idea is innocent enough - let');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tproj_taet`
--

CREATE TABLE IF NOT EXISTS `tproj_taet` (
  `prID` int(10) unsigned NOT NULL,
  `taID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`prID`,`taID`),
  KEY `fk_pttaID` (`taID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `tproj_taet`
--

INSERT INTO `tproj_taet` (`prID`, `taID`) VALUES
(1, 1),
(3, 1),
(2, 2),
(3, 2),
(1, 3),
(4, 3),
(1, 5),
(4, 6),
(2, 7);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `trolle`
--

CREATE TABLE IF NOT EXISTS `trolle` (
  `roID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `roBezeichnung` varchar(32) NOT NULL,
  PRIMARY KEY (`roID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Daten für Tabelle `trolle`
--

INSERT INTO `trolle` (`roID`, `roBezeichnung`) VALUES
(1, 'Geschaeftsleitung'),
(2, 'Mitarbeiter');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ttaetigkeitenvorlage`
--

CREATE TABLE IF NOT EXISTS `ttaetigkeitenvorlage` (
  `taID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `taBeschreibung` varchar(50) NOT NULL,
  PRIMARY KEY (`taID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Daten für Tabelle `ttaetigkeitenvorlage`
--

INSERT INTO `ttaetigkeitenvorlage` (`taID`, `taBeschreibung`) VALUES
(1, 'Essen'),
(2, 'feißig arbeiten'),
(3, 'Konzeptentwicklung'),
(4, 'Konzeptumsetzung'),
(5, 'Ideensammlung'),
(6, 'Brain Storming'),
(7, 'Meeting'),
(8, 'Dientreise');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tzeiterfassung`
--

CREATE TABLE IF NOT EXISTS `tzeiterfassung` (
  `zeID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `miID` int(10) unsigned NOT NULL,
  `prID` int(10) unsigned NOT NULL,
  `zeTag` date NOT NULL,
  `zeTaetigkeit` varchar(50) NOT NULL,
  `zeDauer` decimal(4,2) NOT NULL,
  `zeReisekosten` decimal(6,2) DEFAULT '0.00',
  PRIMARY KEY (`zeID`),
  KEY `fk_zemiID` (`miID`),
  KEY `fk_zeprID` (`prID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Daten für Tabelle `tzeiterfassung`
--

INSERT INTO `tzeiterfassung` (`zeID`, `miID`, `prID`, `zeTag`, `zeTaetigkeit`, `zeDauer`, `zeReisekosten`) VALUES
(1, 7, 1, '2012-06-18', 'arbeiten', 1.50, 0.00),
(2, 8, 2, '2012-06-17', 'gearbeitet', 9.50, 3.00),
(3, 9, 3, '2011-05-17', 'gearbeitet', 4.50, 60.00),
(4, 10, 4, '2012-04-01', 'geschufftet', 12.15, 0.00);

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `tmitarbeiter`
--
ALTER TABLE `tmitarbeiter`
  ADD CONSTRAINT `fk_miroID` FOREIGN KEY (`roID`) REFERENCES `trolle` (`roID`);

--
-- Constraints der Tabelle `tmita_proj`
--
ALTER TABLE `tmita_proj`
  ADD CONSTRAINT `fk_mpmiID` FOREIGN KEY (`miID`) REFERENCES `tmitarbeiter` (`miID`),
  ADD CONSTRAINT `fk_mpprID` FOREIGN KEY (`prID`) REFERENCES `tprojekt` (`prID`);

--
-- Constraints der Tabelle `tprojekt`
--
ALTER TABLE `tprojekt`
  ADD CONSTRAINT `fk_prkuID` FOREIGN KEY (`kuID`) REFERENCES `tkunde` (`kuID`);

--
-- Constraints der Tabelle `tproj_taet`
--
ALTER TABLE `tproj_taet`
  ADD CONSTRAINT `fk_ptprID` FOREIGN KEY (`prID`) REFERENCES `tprojekt` (`prID`),
  ADD CONSTRAINT `fk_pttaID` FOREIGN KEY (`taID`) REFERENCES `ttaetigkeitenvorlage` (`taID`);

--
-- Constraints der Tabelle `tzeiterfassung`
--
ALTER TABLE `tzeiterfassung`
  ADD CONSTRAINT `fk_zemiID` FOREIGN KEY (`miID`) REFERENCES `tmitarbeiter` (`miID`),
  ADD CONSTRAINT `fk_zeprID` FOREIGN KEY (`prID`) REFERENCES `tprojekt` (`prID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
