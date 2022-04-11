-- --------------------------------------------------------
-- 主机:                           192.168.10.3
-- 服务器版本:                        8.0.26 - MySQL Community Server - GPL
-- 服务器操作系统:                      Linux
-- HeidiSQL 版本:                  11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 导出 hq_mana 的数据库结构
DROP DATABASE IF EXISTS `hq_mana`;
CREATE DATABASE IF NOT EXISTS `hq_mana` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `hq_mana`;

-- 导出  表 hq_mana.Constructors 结构
DROP TABLE IF EXISTS `Constructors`;
CREATE TABLE IF NOT EXISTS `Constructors` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '' COMMENT '施工单位',
  `Manager` varchar(50) NOT NULL DEFAULT '' COMMENT '负责人',
  `Contact` varchar(50) NOT NULL DEFAULT '' COMMENT '联系方式',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COMMENT='施工单位';

-- 正在导出表  hq_mana.Constructors 的数据：~4 rows (大约)
/*!40000 ALTER TABLE `Constructors` DISABLE KEYS */;
REPLACE INTO `Constructors` (`id`, `Name`, `Manager`, `Contact`) VALUES
	(1, '辽宁恒禹电力工程有限公司', '闵春雨', ''),
	(2, '海城市东马建筑工程有限公司', '郭士佩', ''),
	(3, '海城市第四建筑工程有限公司', '黄金', ''),
	(4, '辽宁农发建设工程有限公司', '翟铁', '');
/*!40000 ALTER TABLE `Constructors` ENABLE KEYS */;

-- 导出  表 hq_mana.Limits 结构
DROP TABLE IF EXISTS `Limits`;
CREATE TABLE IF NOT EXISTS `Limits` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Users_id` int NOT NULL DEFAULT '0' COMMENT '用户编号',
  `Types_id` int NOT NULL DEFAULT '0' COMMENT '类型编号',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb3 COMMENT='权限';

-- 正在导出表  hq_mana.Limits 的数据：~11 rows (大约)
/*!40000 ALTER TABLE `Limits` DISABLE KEYS */;
REPLACE INTO `Limits` (`id`, `Users_id`, `Types_id`) VALUES
	(16, 3, 1),
	(17, 3, 6),
	(18, 1, 1),
	(19, 1, 2),
	(20, 1, 3),
	(21, 1, 4),
	(22, 1, 5),
	(23, 1, 6),
	(24, 2, 1),
	(25, 2, 2),
	(26, 2, 4);
/*!40000 ALTER TABLE `Limits` ENABLE KEYS */;

-- 导出  表 hq_mana.Logs 结构
DROP TABLE IF EXISTS `Logs`;
CREATE TABLE IF NOT EXISTS `Logs` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Users_id` int NOT NULL DEFAULT '0' COMMENT '用户编号',
  `Type` varchar(50) NOT NULL DEFAULT '' COMMENT '操作类型',
  `Detail` varchar(50) NOT NULL DEFAULT '' COMMENT '详情',
  `DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '操作时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=utf8mb3 COMMENT='操作日志';

-- 正在导出表  hq_mana.Logs 的数据：~90 rows (大约)
/*!40000 ALTER TABLE `Logs` DISABLE KEYS */;
REPLACE INTO `Logs` (`id`, `Users_id`, `Type`, `Detail`, `DateTime`) VALUES
	(1, 0, '删除', '【删除房产信息】房产名称【国网辽宁鞍山海城供电分公司八里供电所】，房产编码【5708572232】', '2022-03-25 02:41:50'),
	(2, 0, '删除', '【删除房产信息】房产名称【原国网海城农电局办公楼】，房产编码【0800029919】', '2022-03-25 02:41:54'),
	(3, 0, '删除', '【删除房产信息】房产名称【立山供电公司办公楼】，房产编码【0800032284】', '2022-03-25 02:41:57'),
	(4, 0, '导入', '【导入房产信息】导入房产数据【3】条', '2022-03-25 02:45:28'),
	(5, 0, '删除', '【删除房产信息】房产名称【国网辽宁鞍山海城供电分公司八里供电所】，房产编码【5708572232】', '2022-03-25 02:46:19'),
	(6, 0, '删除', '【删除房产信息】房产名称【原国网海城农电局办公楼】，房产编码【0800029919】', '2022-03-25 02:46:21'),
	(7, 0, '删除', '【删除房产信息】房产名称【立山供电公司办公楼】，房产编码【0800032284】', '2022-03-25 02:46:24'),
	(8, 0, '导出', '【导出房产信息】导出房产数据【4】', '2022-03-25 03:24:34'),
	(9, 1, '导出', '【导出工程信息】导出工程数据【1】条', '2022-03-28 01:03:41'),
	(10, 1, '导出', '【导出工程信息】导出工程数据【1】条', '2022-03-28 01:03:59'),
	(11, 1, '导入', '【导入工程信息】导入工程数据【0】条', '2022-03-29 02:12:16'),
	(12, 0, '登录', '【登录信息】', '2022-03-29 02:40:22'),
	(13, 0, '登录', '【登录信息】匿名', '2022-03-29 02:41:46'),
	(14, 1, '登录', '【登录信息】', '2022-03-29 02:41:59'),
	(15, 1, '登录', '【登录信息】admin', '2022-03-29 02:47:40'),
	(16, 0, '登录', '【登录信息】匿名', '2022-03-29 03:02:39'),
	(17, 1, '登录', '【登录信息】admin', '2022-03-29 03:02:46'),
	(18, 1, '登录', '【登录信息】admin', '2022-03-29 08:11:13'),
	(19, 1, '登录', '【登录信息】admin', '2022-03-29 08:13:54'),
	(20, 1, '登录', '【登录信息】admin', '2022-03-29 08:25:31'),
	(21, 1, '登录', '【登录信息】admin', '2022-03-31 00:48:50'),
	(22, 1, '登录', '【登录信息】admin', '2022-03-31 01:05:56'),
	(23, 1, '登录', '【登录信息】admin', '2022-03-31 01:11:40'),
	(24, 0, '登录', '【登录信息】匿名', '2022-03-31 01:30:25'),
	(25, 0, '登录', '【登录信息】匿名', '2022-03-31 01:32:58'),
	(26, 1, '登录', '【登录信息】admin', '2022-03-31 01:47:48'),
	(27, 0, '登录', '【登录信息】匿名', '2022-03-31 02:16:22'),
	(28, 0, '登录', '【登录信息】匿名', '2022-03-31 02:18:36'),
	(29, 0, '登录', '【登录信息】匿名', '2022-03-31 02:30:56'),
	(30, 0, '登录', '【登录信息】匿名', '2022-03-31 02:36:31'),
	(31, 0, '登录', '【登录信息】匿名', '2022-03-31 02:37:06'),
	(32, 0, '登录', '【登录信息】匿名', '2022-03-31 02:38:37'),
	(33, 0, '登录', '【登录信息】匿名', '2022-03-31 02:40:35'),
	(34, 0, '登录', '【登录信息】匿名', '2022-03-31 05:17:52'),
	(35, 0, '登录', '【登录信息】匿名', '2022-03-31 05:43:32'),
	(36, 0, '登录', '【登录信息】匿名', '2022-03-31 07:33:51'),
	(37, 0, '登录', '【登录信息】匿名', '2022-03-31 08:13:25'),
	(38, 0, '登录', '【登录信息】匿名', '2022-03-31 08:15:40'),
	(39, 0, '登录', '【登录信息】匿名', '2022-03-31 08:17:39'),
	(40, 0, '登录', '【登录信息】匿名', '2022-04-01 06:47:19'),
	(41, 0, '登录', '【登录信息】匿名', '2022-04-01 06:51:43'),
	(42, 0, '登录', '【登录信息】匿名', '2022-04-01 07:52:47'),
	(43, 0, '登录', '【登录信息】匿名', '2022-04-01 07:53:56'),
	(44, 0, '登录', '【登录信息】匿名', '2022-04-01 07:55:34'),
	(45, 0, '登录', '【登录信息】匿名', '2022-04-01 07:56:47'),
	(46, 0, '登录', '【登录信息】匿名', '2022-04-01 07:59:05'),
	(47, 0, '登录', '【登录信息】匿名', '2022-04-01 08:00:07'),
	(48, 0, '登录', '【登录信息】匿名', '2022-04-01 08:01:24'),
	(49, 0, '登录', '【登录信息】匿名', '2022-04-01 08:06:47'),
	(50, 1, '登录', '【登录信息】admin', '2022-04-06 01:49:38'),
	(51, 0, '登录', '【登录信息】匿名', '2022-04-06 01:51:10'),
	(52, 1, '登录', '【登录信息】admin', '2022-04-06 02:00:05'),
	(53, 0, '登录', '【登录信息】匿名', '2022-04-06 02:18:47'),
	(54, 0, '登录', '【登录信息】匿名', '2022-04-06 02:40:31'),
	(55, 0, '登录', '【登录信息】匿名', '2022-04-06 02:49:56'),
	(56, 0, '登录', '【登录信息】匿名', '2022-04-06 02:50:59'),
	(57, 0, '登录', '【登录信息】匿名', '2022-04-06 02:58:45'),
	(58, 0, '登录', '【登录信息】匿名', '2022-04-06 03:00:02'),
	(59, 0, '登录', '【登录信息】匿名', '2022-04-06 03:00:57'),
	(60, 0, '登录', '【登录信息】匿名', '2022-04-06 03:03:38'),
	(61, 0, '登录', '【登录信息】匿名', '2022-04-06 03:06:12'),
	(62, 0, '登录', '【登录信息】匿名', '2022-04-06 03:17:54'),
	(63, 0, '登录', '【登录信息】匿名', '2022-04-06 03:21:49'),
	(64, 0, '登录', '【登录信息】匿名', '2022-04-06 03:23:40'),
	(65, 0, '登录', '【登录信息】匿名', '2022-04-06 03:31:19'),
	(66, 0, '登录', '【登录信息】匿名', '2022-04-06 03:33:45'),
	(67, 0, '登录', '【登录信息】匿名', '2022-04-06 06:37:50'),
	(68, 1, '登录', '【登录信息】admin', '2022-04-06 06:51:42'),
	(69, 0, '登录', '【登录信息】匿名', '2022-04-07 01:40:02'),
	(70, 0, '登录', '【登录信息】匿名', '2022-04-07 02:35:46'),
	(71, 0, '导出', '【导出工程信息】导出工程数据【1】条', '2022-04-07 02:36:14'),
	(72, 0, '登录', '【登录信息】匿名', '2022-04-07 02:51:04'),
	(73, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 02:51:34'),
	(74, 0, '登录', '【登录信息】匿名', '2022-04-07 02:52:48'),
	(75, 0, '登录', '【登录信息】匿名', '2022-04-07 02:55:33'),
	(76, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 02:55:47'),
	(77, 0, '登录', '【登录信息】匿名', '2022-04-07 05:33:02'),
	(78, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 05:33:16'),
	(79, 0, '登录', '【登录信息】匿名', '2022-04-07 05:35:32'),
	(80, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 05:35:39'),
	(81, 0, '登录', '【登录信息】匿名', '2022-04-07 05:46:12'),
	(82, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 05:46:19'),
	(83, 0, '登录', '【登录信息】匿名', '2022-04-07 05:50:34'),
	(84, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 05:50:43'),
	(85, 0, '登录', '【登录信息】匿名', '2022-04-07 05:51:50'),
	(86, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 05:51:56'),
	(87, 0, '登录', '【登录信息】匿名', '2022-04-07 05:53:16'),
	(88, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 05:53:33'),
	(89, 0, '登录', '【登录信息】匿名', '2022-04-07 05:55:27'),
	(90, 0, '导出', '【导出房产信息】导出房产数据【4】条', '2022-04-07 05:55:32');
/*!40000 ALTER TABLE `Logs` ENABLE KEYS */;

-- 导出  表 hq_mana.Models 结构
DROP TABLE IF EXISTS `Models`;
CREATE TABLE IF NOT EXISTS `Models` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '',
  `Types` varchar(50) NOT NULL DEFAULT '',
  `Columns` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=108 DEFAULT CHARSET=utf8mb3 COMMENT='模版';

-- 正在导出表  hq_mana.Models 的数据：~107 rows (大约)
/*!40000 ALTER TABLE `Models` DISABLE KEYS */;
REPLACE INTO `Models` (`id`, `Name`, `Types`, `Columns`) VALUES
	(1, '111', '房产资源', '序号'),
	(2, '111', '房产资源', '房产名称'),
	(3, '111', '房产资源', '房产编号'),
	(4, '111', '房产资源', '房产地址'),
	(5, '111', '房产资源', '建筑年代'),
	(6, '111', '房产资源', '建筑层数'),
	(7, '111', '房产资源', '建筑结构'),
	(8, '111', '房产资源', '建筑面积'),
	(9, '111', '房产资源', '建筑用途'),
	(10, '111', '房产资源', '资产原值'),
	(11, '111', '房产资源', '资产编码'),
	(12, '111', '房产资源', '设备编码'),
	(13, '111', '房产资源', '地区'),
	(14, '132', '工程项目', '序号'),
	(15, '132', '工程项目', '工程名称'),
	(16, '132', '工程项目', '工程类型'),
	(17, '132', '工程项目', '工程内容'),
	(18, '132', '工程项目', '计划金额'),
	(19, '132', '工程项目', '可研批复'),
	(20, '132', '工程项目', '初始批复'),
	(21, '132', '工程项目', '计划文号'),
	(22, '132', '工程项目', '开工时间'),
	(23, '132', '工程项目', '竣工时间'),
	(24, '132', '工程项目', '中标单位'),
	(25, '132', '工程项目', '形象进度'),
	(26, '132', '工程项目', '收集整理'),
	(27, '132', '工程项目', '立卷检查'),
	(28, '132', '工程项目', '验收合格'),
	(29, '132', '工程项目', '合同金额'),
	(30, '132', '工程项目', '实际发生额'),
	(31, '132', '工程项目', '付款金额'),
	(32, '132', '工程项目', '欠款金额'),
	(33, '132', '工程项目', '质保金支付时间'),
	(34, '123', '主界面', '房产名称'),
	(35, '123', '主界面', '房产编号'),
	(36, '123', '主界面', '建筑年代'),
	(37, '123', '主界面', '建筑层数'),
	(38, '123', '主界面', '建筑结构'),
	(39, '123', '主界面', '建筑用途'),
	(40, '123', '主界面', '资产原值'),
	(41, '123', '主界面', '资产编码'),
	(42, '123', '主界面', '设备编码'),
	(43, '123', '主界面', '地区'),
	(44, '123', '主界面', '工程名称'),
	(45, '123', '主界面', '工程类型'),
	(46, '123', '主界面', '工程内容'),
	(47, '123', '主界面', '计划金额'),
	(48, '123', '主界面', '可研批复'),
	(49, '123', '主界面', '初始批复'),
	(50, '123', '主界面', '计划文号'),
	(51, '123', '主界面', '开工时间'),
	(52, '123', '主界面', '竣工时间'),
	(53, '123', '主界面', '中标单位'),
	(54, '123', '主界面', '形象进度'),
	(55, '123', '主界面', '合同金额'),
	(56, '123', '主界面', '实际发生额'),
	(57, '123', '主界面', '支付金额'),
	(58, '123', '主界面', '欠款金额'),
	(59, '123', '主界面', '质保金支付时间'),
	(60, '123', '主界面', '施工单位'),
	(61, '123', '主界面', '负责人'),
	(62, '123', '主界面', '联系方式'),
	(63, '123', '主界面', '分包金额'),
	(64, '123', '主界面', '支付金额1'),
	(65, '123', '主界面', '欠款金额1'),
	(66, '123', '主界面', '管理费'),
	(67, '123', '主界面', '是否挂账'),
	(68, '123', '主界面', '收集整理'),
	(69, '123', '主界面', '立卷检查'),
	(70, '123', '主界面', '验收合格'),
	(71, '3213', '主界面', '房产名称'),
	(72, '3213', '主界面', '房产编号'),
	(73, '3213', '主界面', '建筑年代'),
	(74, '3213', '主界面', '建筑层数'),
	(75, '3213', '主界面', '建筑结构'),
	(76, '3213', '主界面', '建筑用途'),
	(77, '3213', '主界面', '资产原值'),
	(78, '3213', '主界面', '资产编码'),
	(79, '3213', '主界面', '设备编码'),
	(80, '3213', '主界面', '地区'),
	(81, '3213', '主界面', '工程名称'),
	(82, '3213', '主界面', '工程类型'),
	(83, '3213', '主界面', '工程内容'),
	(84, '3213', '主界面', '计划金额'),
	(85, '3213', '主界面', '可研批复'),
	(86, '3213', '主界面', '初始批复'),
	(87, '3213', '主界面', '计划文号'),
	(88, '3213', '主界面', '开工时间'),
	(89, '3213', '主界面', '竣工时间'),
	(90, '3213', '主界面', '中标单位'),
	(91, '3213', '主界面', '形象进度'),
	(92, '3213', '主界面', '合同金额'),
	(93, '3213', '主界面', '实际发生额'),
	(94, '3213', '主界面', '支付金额'),
	(95, '3213', '主界面', '欠款金额'),
	(96, '3213', '主界面', '质保金支付时间'),
	(97, '3213', '主界面', '施工单位'),
	(98, '3213', '主界面', '负责人'),
	(99, '3213', '主界面', '联系方式'),
	(100, '3213', '主界面', '分包金额'),
	(101, '3213', '主界面', '支付金额1'),
	(102, '3213', '主界面', '欠款金额1'),
	(103, '3213', '主界面', '管理费'),
	(104, '3213', '主界面', '是否挂账'),
	(105, '3213', '主界面', '收集整理'),
	(106, '3213', '主界面', '立卷检查'),
	(107, '3213', '主界面', '验收合格');
/*!40000 ALTER TABLE `Models` ENABLE KEYS */;

-- 导出  表 hq_mana.Partitions 结构
DROP TABLE IF EXISTS `Partitions`;
CREATE TABLE IF NOT EXISTS `Partitions` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Projects_id` int NOT NULL DEFAULT '0' COMMENT '项目编码',
  `Constructors_id` int NOT NULL DEFAULT '0' COMMENT '施工单位编码',
  `Amount` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '分包金额',
  `Amount_Pay` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '付款金额',
  `Amount_Arrear` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '欠款金额',
  `Management` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '管理费',
  `Account` tinyint(1) NOT NULL DEFAULT '0' COMMENT '是否挂账',
  `Users_id` int NOT NULL DEFAULT '0' COMMENT '用户编号',
  `DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '操作时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3 COMMENT='分包信息';

-- 正在导出表  hq_mana.Partitions 的数据：~1 rows (大约)
/*!40000 ALTER TABLE `Partitions` DISABLE KEYS */;
REPLACE INTO `Partitions` (`id`, `Projects_id`, `Constructors_id`, `Amount`, `Amount_Pay`, `Amount_Arrear`, `Management`, `Account`, `Users_id`, `DateTime`) VALUES
	(1, 3, 1, 10000.00, 0.00, 0.00, 1.00, 0, 0, '2022-03-25 09:35:21');
/*!40000 ALTER TABLE `Partitions` ENABLE KEYS */;

-- 导出  表 hq_mana.Premises 结构
DROP TABLE IF EXISTS `Premises`;
CREATE TABLE IF NOT EXISTS `Premises` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '' COMMENT '房产名称',
  `Code` varchar(50) NOT NULL DEFAULT '' COMMENT '房产编号',
  `Address` varchar(50) NOT NULL DEFAULT '' COMMENT '房产地址',
  `Date` varchar(50) NOT NULL DEFAULT '' COMMENT '建筑年代',
  `Levels` varchar(50) NOT NULL DEFAULT '' COMMENT '建筑层数',
  `Structure` varchar(50) NOT NULL DEFAULT '' COMMENT '建筑结构',
  `Dimension` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '建筑面积',
  `Purpose` varchar(50) NOT NULL DEFAULT '' COMMENT '建筑用途',
  `Assets_Amount` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '资产原值',
  `Assets_Code` varchar(50) NOT NULL DEFAULT '' COMMENT '资产编码',
  `Device_Code` varchar(50) NOT NULL DEFAULT '' COMMENT '设备编码',
  `Region` varchar(50) NOT NULL DEFAULT '' COMMENT '地区',
  `Users_id` int NOT NULL DEFAULT '0' COMMENT '用户编号',
  `DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '操作时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3 COMMENT='房产资源';

-- 正在导出表  hq_mana.Premises 的数据：~4 rows (大约)
/*!40000 ALTER TABLE `Premises` DISABLE KEYS */;
REPLACE INTO `Premises` (`id`, `Name`, `Code`, `Address`, `Date`, `Levels`, `Structure`, `Dimension`, `Purpose`, `Assets_Amount`, `Assets_Code`, `Device_Code`, `Region`, `Users_id`, `DateTime`) VALUES
	(1, '变电运检二工区办公楼', '0800032807', '', '1999', '4层', '钢混', 12714.00, '办公用房', 2851939.91, '270100000039', '022100000000016342', '铁东', 0, '2022-03-25 09:36:15'),
	(3, '国网辽宁鞍山海城供电分公司八里供电所', '5708572232', '', '2018', '2层', '钢混', 525.00, '乡镇供电所', 2260771.38, '270100001038', '022100000000546997', '海城', 0, '2022-03-25 09:36:16'),
	(4, '原国网海城农电局办公楼', '0800029919', '', '1987', '5层', '砖混', 2394.00, '办公用房', 1778063.12, '270100000592', '022200000000018172', '海城', 0, '2022-03-25 09:36:17'),
	(5, '立山供电公司办公楼', '0800032284', '', '1994', '5层', '砖混', 3399.00, '办公用房', 3583940.53, '270100000224', '022100000000016320', '立山', 0, '2022-03-25 09:36:18');
/*!40000 ALTER TABLE `Premises` ENABLE KEYS */;

-- 导出  表 hq_mana.Projects 结构
DROP TABLE IF EXISTS `Projects`;
CREATE TABLE IF NOT EXISTS `Projects` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Premises_id` int NOT NULL DEFAULT '0',
  `Name` varchar(50) NOT NULL DEFAULT '' COMMENT '工程名称',
  `Types_id` int NOT NULL DEFAULT '0' COMMENT '工程类型',
  `Detail` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '工程内容',
  `Amount` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '计划金额',
  `Developing_Reply` varchar(50) NOT NULL DEFAULT '' COMMENT '可研批复',
  `Initial_Reply` varchar(50) NOT NULL DEFAULT '' COMMENT '初始批复',
  `Plan_Code` varchar(50) NOT NULL DEFAULT '' COMMENT '计划文号',
  `Begin_Date` date NOT NULL DEFAULT '1900-01-01' COMMENT '开工时间',
  `End_Date` date NOT NULL DEFAULT '1900-01-01' COMMENT '竣工时间',
  `Tenders_id` int NOT NULL DEFAULT '0' COMMENT '中标单位',
  `Progress` varchar(50) NOT NULL DEFAULT '' COMMENT '形象进度',
  `Collect_Tag` varchar(50) NOT NULL DEFAULT '' COMMENT '收集整理',
  `Check_Tag` varchar(50) NOT NULL DEFAULT '' COMMENT '立卷检查',
  `Grade_Tag` varchar(50) NOT NULL DEFAULT '' COMMENT '验收合格',
  `Amount_Order` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '合同金额',
  `Amount_Reality` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '实际发生金额',
  `Amount_Pay` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '支付金额',
  `Amount_Arrear` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '欠款金额',
  `Warranty` date NOT NULL DEFAULT '1900-01-01' COMMENT '质保金支付时间',
  `Users_id` int NOT NULL DEFAULT '0' COMMENT '用户编号',
  `DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '操作时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COMMENT='工程项目';

-- 正在导出表  hq_mana.Projects 的数据：~1 rows (大约)
/*!40000 ALTER TABLE `Projects` DISABLE KEYS */;
REPLACE INTO `Projects` (`id`, `Premises_id`, `Name`, `Types_id`, `Detail`, `Amount`, `Developing_Reply`, `Initial_Reply`, `Plan_Code`, `Begin_Date`, `End_Date`, `Tenders_id`, `Progress`, `Collect_Tag`, `Check_Tag`, `Grade_Tag`, `Amount_Order`, `Amount_Reality`, `Amount_Pay`, `Amount_Arrear`, `Warranty`, `Users_id`, `DateTime`) VALUES
	(3, 1, '国网辽宁鞍山车辆运输服务部综合楼装饰装修分系统4层、5层停车场改造', 1, '该项目主要内容及工程量：根据使用单位需求利用现有停车场改为办公用房使用，并对该房间内进行重新装修，装修面积2752㎡。砌筑墙体130.8m³（200厚轻集料混凝土砌块）；地面铺砖2350㎡；橡胶板地面226平方米；重新刮大白、刷乳胶漆508㎡；室内墙砖铺贴546㎡；安装铝板吊顶2350㎡；安装内门65樘；喷淋支管（上喷改下喷）126米；喷淋头180个；感烟探测器38个；灯具130套；散热器更换65组；安装暖气罩215㎡；窗台板18.55㎡；更衣柜40米；肯德基门6㎡；楼内线路整体改造；增设电暖气40组等。', 0.00, '', '', '', '2022-04-22', '1990-01-01', 1, '', '未完成', '未完成', '未完成', 0.00, 0.00, 0.00, 0.00, '2022-03-22', 0, '2022-03-25 09:37:45');
/*!40000 ALTER TABLE `Projects` ENABLE KEYS */;

-- 导出  表 hq_mana.Settlements 结构
DROP TABLE IF EXISTS `Settlements`;
CREATE TABLE IF NOT EXISTS `Settlements` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Projects_id` int NOT NULL DEFAULT '0' COMMENT '项目编码',
  `Partitions` tinyint(1) NOT NULL DEFAULT '0' COMMENT '是否分包',
  `Amount` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '支付金额',
  `DateTime` datetime NOT NULL DEFAULT '1900-01-01 00:00:00' COMMENT '支付时间',
  `Users_id` int NOT NULL DEFAULT '0' COMMENT '用户编号',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COMMENT='结算信息';

-- 正在导出表  hq_mana.Settlements 的数据：~1 rows (大约)
/*!40000 ALTER TABLE `Settlements` DISABLE KEYS */;
REPLACE INTO `Settlements` (`id`, `Projects_id`, `Partitions`, `Amount`, `DateTime`, `Users_id`) VALUES
	(3, 3, 0, 0.00, '2022-03-22 00:00:00', 0);
/*!40000 ALTER TABLE `Settlements` ENABLE KEYS */;

-- 导出  表 hq_mana.Tenders 结构
DROP TABLE IF EXISTS `Tenders`;
CREATE TABLE IF NOT EXISTS `Tenders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '' COMMENT '中标单位',
  `Manager` varchar(50) NOT NULL DEFAULT '' COMMENT '负责人',
  `Contact` varchar(50) NOT NULL DEFAULT '' COMMENT '联系方式',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COMMENT='中标单位';

-- 正在导出表  hq_mana.Tenders 的数据：~3 rows (大约)
/*!40000 ALTER TABLE `Tenders` DISABLE KEYS */;
REPLACE INTO `Tenders` (`id`, `Name`, `Manager`, `Contact`) VALUES
	(1, '鞍山电力实业有限公司', '', ''),
	(2, '海城市东马建筑工程有限公司', '', ''),
	(3, '海城市第四建筑工程有限公司', '', '');
/*!40000 ALTER TABLE `Tenders` ENABLE KEYS */;

-- 导出  表 hq_mana.Types 结构
DROP TABLE IF EXISTS `Types`;
CREATE TABLE IF NOT EXISTS `Types` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '' COMMENT '类型名称',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3 COMMENT='工程类型';

-- 正在导出表  hq_mana.Types 的数据：~6 rows (大约)
/*!40000 ALTER TABLE `Types` DISABLE KEYS */;
REPLACE INTO `Types` (`id`, `Name`) VALUES
	(1, '小型基建'),
	(2, '国网大修'),
	(3, '国网技改'),
	(4, '房屋修缮（省大修）'),
	(5, '日常零星维修'),
	(6, '维保');
/*!40000 ALTER TABLE `Types` ENABLE KEYS */;

-- 导出  表 hq_mana.Users 结构
DROP TABLE IF EXISTS `Users`;
CREATE TABLE IF NOT EXISTS `Users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '' COMMENT '用户名',
  `Password` varchar(50) NOT NULL DEFAULT '' COMMENT '密码',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COMMENT='用户';

-- 正在导出表  hq_mana.Users 的数据：~3 rows (大约)
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
REPLACE INTO `Users` (`id`, `Name`, `Password`) VALUES
	(1, 'admin', '123'),
	(2, '长得帅', '123'),
	(3, '长得美', '123');
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;

-- 导出  触发器 hq_mana.Settlements_after_delete 结构
DROP TRIGGER IF EXISTS `Settlements_after_delete`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `Settlements_after_delete` AFTER DELETE ON `Settlements` FOR EACH ROW BEGIN
	IF OLD.Partitions = 0 THEN
		UPDATE Projects SET Amount_Pay = Amount_Pay -  OLD.Amount, Amount_Arrear = Amount_Arrear + OLD.Amount WHERE Projects.id = OLD.Projects_id;
	ELSE
		UPDATE PARTITIONS SET Amount_Pay = Amount_Pay - OLD.Amount, Amount_Arrear = Amount_Arrear + OLD.Amount WHERE PARTITIONS.Projects_id = OLD.Projects_id;
	END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- 导出  触发器 hq_mana.Settlements_after_insert 结构
DROP TRIGGER IF EXISTS `Settlements_after_insert`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `Settlements_after_insert` AFTER INSERT ON `Settlements` FOR EACH ROW BEGIN
	IF NEW.Partitions = 0 THEN
		UPDATE Projects SET Amount_Pay = Amount_Pay + NEW.Amount, Amount_Arrear = Amount_Arrear - NEW.Amount WHERE Projects.id = NEW.Projects_id;
	ELSE
		UPDATE PARTITIONS SET Amount_Pay = Amount_Pay + NEW.Amount, Amount_Arrear = Amount_Arrear - NEW.Amount WHERE PARTITIONS.Projects_id = NEW.Projects_id;
	END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- 导出  触发器 hq_mana.Settlements_after_update 结构
DROP TRIGGER IF EXISTS `Settlements_after_update`;
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `Settlements_after_update` AFTER UPDATE ON `Settlements` FOR EACH ROW BEGIN
	IF NEW.Partitions = 0 THEN
		UPDATE Projects SET Amount_Pay = Amount_Pay - OLD.Amount + NEW.Amount, Amount_Arrear = Amount_Arrear + OLD.Amount - NEW.Amount WHERE Projects.id = NEW.Projects_id;
	ELSE
		UPDATE PARTITIONS SET Amount_Pay = Amount_Pay - OLD.Amount + NEW.Amount, Amount_Arrear = Amount_Arrear + OLD.Amount - NEW.Amount WHERE PARTITIONS.Projects_id = NEW.Projects_id;
	END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
