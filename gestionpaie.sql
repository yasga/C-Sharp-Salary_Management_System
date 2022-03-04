-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 07 jan. 2022 à 23:09
-- Version du serveur : 10.4.21-MariaDB
-- Version de PHP : 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestionpaie`
--

-- --------------------------------------------------------

--
-- Structure de la table `autonumber`
--

CREATE TABLE `autonumber` (
  `id` int(11) NOT NULL,
  `autoname` varchar(30) NOT NULL,
  `strnum` int(11) NOT NULL,
  `increment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `autonumber`
--

INSERT INTO `autonumber` (`id`, `autoname`, `strnum`, `increment`) VALUES
(1, 'trans', 29, 1);

-- --------------------------------------------------------

--
-- Structure de la table `employee`
--

CREATE TABLE `employee` (
  `emp_code` varchar(30) NOT NULL,
  `emp_fname` varchar(60) DEFAULT NULL,
  `emp_lname` varchar(60) DEFAULT NULL,
  `emp_mname` varchar(60) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` int(20) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `birth_place` varchar(100) DEFAULT NULL,
  `emp_sex` varchar(10) DEFAULT NULL,
  `emp_age` int(10) DEFAULT NULL,
  `emerg_contct` int(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `employee`
--

INSERT INTO `employee` (`emp_code`, `emp_fname`, `emp_lname`, `emp_mname`, `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`, `emerg_contct`) VALUES
('am29', 'Anas', 'Mounir', '-', 'Maarif , Casablanca', 654546735, 'Célibataire', '1989-07-07', 'Rabat', 'Mâle', 44, 654546735),
('bm17', 'bensouda', 'mounir', '-', 'Yaacoub el mansour, Casablanca', 654879321, 'Marrié(e)', '1999-05-23', 'Kénitra', 'Mâle', 23, 654879321),
('by6', 'Brahim', 'Youness', 'bennis', 'Oulfa, Casablanca', 654457892, 'Marrié(e)', '1988-08-23', 'Tetouan', 'Mâle', 43, 654457892),
('cg4', 'malak', 'ghizlane', 'idrissi', 'Marrakesh', 698471213, 'Marrié(e)', '1987-02-13', 'oujda', 'Femelle', 26, 698471213),
('ea9', 'el fenni', 'asmae', '-', 'lamiaa , Safi', 639857410, 'Célibataire', '2022-01-07', 'Safi', 'Femelle', 21, 639857410),
('jf30', 'jassour', 'fatima ezzaha', '-', 'Abdelmoumen, Casablanca', 621471213, 'Célibataire', '1987-02-13', 'Casablanca', 'Femelle', 26, 621471213),
('jha28', 'jorfi', 'hatim', '-', 'Tanger', 632971958, 'Célibataire', '1990-09-28', 'Tanger', 'Mâle', 34, 632971958),
('jl4', 'jourghi', 'latifa', '-', 'sidi maarouf, Casablanca', 617483647, 'Célibataire', '1988-05-23', 'Casablanca', 'Femelle', 25, 617483647),
('ka2', 'karam', 'ahmad', '-', 'Ain chok , Casablanca', 606321357, 'Marrié(e)', '1991-03-22', 'Salé', 'Mâle', 32, 606321357),
('nc9', 'nizar', 'camelia', '-', '2 , rue al mowahadin , rabat', 798582514, 'Célibataire', '1989-06-15', 'Rabat', 'Femelle', 36, 798582514),
('zso12', 'gma', 'yass', '-', '2, rue nichakra rahal ,Casablanca', 621881090, 'Célibataire', '2000-03-08', 'Casablanca', 'Mâle', 28, 621881090);

-- --------------------------------------------------------

--
-- Structure de la table `employee_workinfo`
--

CREATE TABLE `employee_workinfo` (
  `id` int(10) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `d_rate` int(30) DEFAULT NULL,
  `p_method` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `w_status` varchar(60) DEFAULT NULL,
  `d_hired` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `employee_workinfo`
--

INSERT INTO `employee_workinfo` (`id`, `emp_code`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`) VALUES
(0, 'jha28', 240, 'Mensuel', 'permanant', 'Active', '2013-08-07'),
(5, 'cg4', 265, 'Mensuel', 'régulier', 'Active', '2012-12-11'),
(6, 'jl4', 255, 'Hebdomadaire', 'permanant', 'Active', '2013-08-21'),
(11, 'zso12', 270, 'Mensuel', 'régulier', 'Active', '2000-08-10'),
(13, 'jf30', 345, 'Hebdomadaire', 'permanant', 'Active', '2012-12-11'),
(15, 'am29', 250, 'Mensuel', 'régulier', 'Active', '2010-07-20'),
(17, 'by6', 290, 'Mensuel', 'régulier', 'Active', '2010-08-23'),
(26, 'bm17', 310, 'Mensuel', 'permanant', 'Active', '2020-08-21'),
(27, 'ea9', 325, 'Mensuel', 'permanant', 'Active', '2022-01-01'),
(28, 'nc9', 290, 'Mensuel', 'permanant', 'Active', '2020-02-29'),
(29, 'ka2', 340, 'Mensuel', 'permanant', 'Active', '2020-02-08');

-- --------------------------------------------------------

--
-- Structure de la table `other_deduction`
--

CREATE TABLE `other_deduction` (
  `KEY` int(11) NOT NULL,
  `trans_id` varchar(30) NOT NULL,
  `emp_code` varchar(10) DEFAULT NULL,
  `deduct1` varchar(60) DEFAULT NULL,
  `ded_amount1` int(30) DEFAULT NULL,
  `deduct2` varchar(60) DEFAULT NULL,
  `ded_amount2` int(30) DEFAULT NULL,
  `deduct3` varchar(60) DEFAULT NULL,
  `ded_amount3` int(30) DEFAULT NULL,
  `deduct4` varchar(60) DEFAULT NULL,
  `ded_amount4` int(30) DEFAULT NULL,
  `total_ded` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `other_deduction`
--

INSERT INTO `other_deduction` (`KEY`, `trans_id`, `emp_code`, `deduct1`, `ded_amount1`, `deduct2`, `ded_amount2`, `deduct3`, `ded_amount3`, `deduct4`, `ded_amount4`, `total_ded`) VALUES
(13, 'trans18', 'am29', '', 0, '', 0, '', 0, '', 0, 700),
(14, 'trans19', 'zso12', '', 0, '', 0, '', 0, '', 0, 0),
(15, 'trans20', 'ea9', '', 0, '', 0, '', 0, '', 0, 100),
(16, 'trans21', 'bm17', '', 0, '', 0, '', 0, '', 0, 20),
(17, 'trans22', 'by6', '', 0, '', 0, '', 0, '', 0, 30),
(18, 'trans23', 'cg4', '', 0, '', 0, '', 0, '', 0, 0),
(19, 'trans24', 'jha28', '', 0, '', 0, '', 0, '', 0, 30),
(20, 'trans25', 'jl4', '', 0, '', 0, '', 0, '', 0, 20),
(21, 'trans26', 'nc9', '', 0, '', 0, '', 0, '', 0, 620),
(22, 'trans27', 'ka2', '', 0, '', 0, '', 0, '', 0, 120),
(23, 'trans28', 'jf30', '', 0, '', 0, '', 0, '', 0, 120);

-- --------------------------------------------------------

--
-- Structure de la table `payroll`
--

CREATE TABLE `payroll` (
  `KEY` int(11) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `num_days` int(30) DEFAULT NULL,
  `r_wage` int(30) DEFAULT NULL,
  `overtime` int(30) DEFAULT NULL,
  `hol_pay` int(30) DEFAULT NULL,
  `gross_sal` int(30) DEFAULT NULL,
  `cash_ad` int(30) DEFAULT NULL,
  `bread_vale` int(30) DEFAULT NULL,
  `philhealth` int(30) DEFAULT NULL,
  `pag-ibig` int(30) DEFAULT NULL,
  `net_income` int(30) DEFAULT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `dateissued` date NOT NULL,
  `trans_id` varchar(30) NOT NULL DEFAULT '0',
  `user_id` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `payroll`
--

INSERT INTO `payroll` (`KEY`, `emp_code`, `num_days`, `r_wage`, `overtime`, `hol_pay`, `gross_sal`, `cash_ad`, `bread_vale`, `philhealth`, `pag-ibig`, `net_income`, `remarks`, `dateissued`, `trans_id`, `user_id`) VALUES
(15, 'zso12', 23, 6210, 270, 1080, 7560, 0, 0, 0, 0, 7560, 'Bon profil / tous les retards et les abcenses sont justifiés .', '2022-01-01', 'trans19', NULL),
(16, 'ea9', 26, 8450, 81, 975, 9506, 100, 0, 0, 0, 9406, 'Enregisté', '2022-01-02', 'trans20', NULL),
(17, 'bm17', 25, 7750, 232, 0, 7982, 20, 0, 0, 0, 7962, 'Enregisté', '2022-01-03', 'trans21', NULL),
(18, 'by6', 21, 6090, 145, 290, 6525, 0, 0, 0, 30, 6495, 'Enregisté', '2022-01-03', 'trans22', NULL),
(19, 'cg4', 23, 6095, 198, 265, 6558, 0, 0, 0, 0, 6558, 'Enregisté', '2022-01-05', 'trans23', NULL),
(20, 'jha28', 24, 5760, 150, 0, 5910, 10, 0, 10, 10, 5880, 'Enregisté', '2022-01-05', 'trans24', NULL),
(21, 'jl4', 19, 4845, 31, 0, 4876, 20, 0, 0, 0, 4856, 'Enregisté', '2022-01-07', 'trans25', NULL),
(22, 'nc9', 23, 6670, 181, 1160, 8011, 500, 0, 120, 0, 7391, 'Enregisté', '2022-01-07', 'trans26', NULL),
(23, 'ka2', 21, 7140, 255, 3400, 10795, 0, 0, 120, 0, 10675, 'Enregisté', '2022-01-07', 'trans27', NULL),
(24, 'jf30', 21, 7245, 172, 3105, 10522, 0, 0, 120, 0, 10402, 'Enregisté', '2022-01-07', 'trans28', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `user_id` int(30) NOT NULL,
  `name` text DEFAULT NULL,
  `username` varchar(60) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`user_id`, `name`, `username`, `pass`, `type`) VALUES
(1, 'admin', 'admin', '123', 'Administrateur'),
(2, 'yas gma', 'yg', '1234', 'Personnel');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `autonumber`
--
ALTER TABLE `autonumber`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_code`),
  ADD UNIQUE KEY `emp_code` (`emp_code`);

--
-- Index pour la table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `emp_code_2` (`emp_code`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Index pour la table `other_deduction`
--
ALTER TABLE `other_deduction`
  ADD PRIMARY KEY (`KEY`);

--
-- Index pour la table `payroll`
--
ALTER TABLE `payroll`
  ADD PRIMARY KEY (`KEY`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `trans_id` (`trans_id`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `autonumber`
--
ALTER TABLE `autonumber`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT pour la table `other_deduction`
--
ALTER TABLE `other_deduction`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT pour la table `payroll`
--
ALTER TABLE `payroll`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
