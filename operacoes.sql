-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23-Set-2020 às 17:26
-- Versão do servidor: 10.4.13-MariaDB
-- versão do PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `controle operações ativos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `operacoes`
--

CREATE TABLE `operacoes` (
  `idOperacao` int(11) NOT NULL,
  `Ativo` varchar(6) CHARACTER SET utf8 NOT NULL,
  `Quantidade` int(11) NOT NULL,
  `Valor` double(15,2) NOT NULL,
  `Data` varchar(10) NOT NULL,
  `statusOperacao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `operacoes`
--

INSERT INTO `operacoes` (`idOperacao`, `Ativo`, `Quantidade`, `Valor`, `Data`, `statusOperacao`) VALUES
(1, 'EGIE3', 200, 4579.00, '01/09/2020', NULL),
(2, 'TAEE11', 300, 6900.00, '12/05/2020', NULL),
(3, 'HGLG11', 214, 20525.00, '02/08/2020', NULL),
(6, 'WEGE3', 100, 34500.00, '07/09/2020', NULL),
(8, 'PETR4', 300, 16578.23, '12/09/2020', NULL),
(9, 'ITSA4', 12000, 60000.12, '12/09/2020', NULL),
(10, 'ITSA4', -2000, -9568.45, '14/09/2020', NULL),
(12, 'EGIE3', 200, 15000.00, '19/09/2020', NULL),
(13, 'PETR4', 200, 2545.25, '23/09/2020', NULL),
(14, 'PETR4', -200, -2645.25, '23/09/2020', NULL),
(15, 'ITSA4', 100, 2800.00, '23/09/2020', NULL);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `operacoes`
--
ALTER TABLE `operacoes`
  ADD PRIMARY KEY (`idOperacao`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `operacoes`
--
ALTER TABLE `operacoes`
  MODIFY `idOperacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
