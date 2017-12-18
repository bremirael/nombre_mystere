-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 18 déc. 2017 à 22:30
-- Version du serveur :  5.7.19
-- Version de PHP :  7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `nombre_mystere`
--

-- --------------------------------------------------------

--
-- Structure de la table `joueur`
--

DROP TABLE IF EXISTS `joueur`;
CREATE TABLE IF NOT EXISTS `joueur` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `nom` varchar(160) NOT NULL,
  `login` varchar(160) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `login` (`login`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `joueur`
--

INSERT INTO `joueur` (`id`, `nom`, `login`) VALUES
(1, 'pedral', 'totoro'),
(2, 'Rosa', 'Lecat'),
(3, 'Nyan le', 'Than'),
(4, 'Leonardo', 'Da Vinci Code'),
(5, 'Jean Paul', 'Deux'),
(6, 'kev', 'adams'),
(7, 'Louis', 'Le psy faux'),
(8, 'anakin', 'skywalker');

-- --------------------------------------------------------

--
-- Structure de la table `partie`
--

DROP TABLE IF EXISTS `partie`;
CREATE TABLE IF NOT EXISTS `partie` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `partie_jouees` int(5) NOT NULL,
  `score` int(5) NOT NULL,
  `nb_coups` int(5) NOT NULL,
  `id_joueur` int(5) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `partie`
--

INSERT INTO `partie` (`id`, `partie_jouees`, `score`, `nb_coups`, `id_joueur`) VALUES
(1, 1, 97, 3, 1),
(2, 0, 0, 0, 2),
(3, 0, 0, 0, 3),
(4, 0, 0, 0, 4),
(5, 0, 0, 0, 5),
(6, 1, 98, 0, 6),
(7, 0, 0, 0, 7),
(8, 1, 99, 0, 8);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
