-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 17. Jun 2012 um 20:22
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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `tkunde`
--

INSERT INTO `tkunde` (`kuID`, `kuFirma`, `kuStrasse`, `kuPLZ`, `kuOrt`, `kuTel`, `kuFax`, `kuAnsprechpartner`, `kuEMail`) VALUES
(1, 'Testfirma', 'Teststraße 23', '12312', 'Testhausen', '12312312', '1234234', 'Schorsch', 'sch@orsch.de');

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Daten für Tabelle `tmitarbeiter`
--

INSERT INTO `tmitarbeiter` (`miID`, `roID`, `miName`, `miVorname`, `miUsername`, `miPasswort`, `miEMail`) VALUES
(1, 1, 'Admin', 'NA', 'Admin', 'admin', 'NA'),
(2, 2, 'User', 'NA', 'User', 'user', 'NA'),
(3, 2, 'Seipel', 'Günther', 'gseipel', 'passwort', 'gunther@seipel.de');

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
(3, 1, 1);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `tprojekt`
--

INSERT INTO `tprojekt` (`prID`, `kuID`, `prName`, `prBeschreibung`) VALUES
(1, 1, 'Essen gehen', 'Man isst ein Brötchen.');

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
(1, 1);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `ttaetigkeitenvorlage`
--

INSERT INTO `ttaetigkeitenvorlage` (`taID`, `taBeschreibung`) VALUES
(1, 'Essen');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

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
