-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        10.9.3-MariaDB - mariadb.org binary distribution
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- daep 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `daep` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `daep`;

-- 테이블 daep.cmpycodes 구조 내보내기
CREATE TABLE IF NOT EXISTS `cmpycodes` (
  `CMPYCODE` varchar(50) NOT NULL,
  `CMPYNAME` varchar(50) NOT NULL,
  `CEO` varchar(50) DEFAULT NULL,
  `ADDR` varchar(50) DEFAULT NULL,
  `CMPYTYPE` varchar(50) DEFAULT NULL,
  `ITEM` varchar(50) DEFAULT NULL,
  `TYPE` varchar(50) DEFAULT NULL,
  `WRTDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`CMPYCODE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 테이블 daep.prodcodes 구조 내보내기
CREATE TABLE IF NOT EXISTS `prodcodes` (
  `HISTDATE` varchar(8) NOT NULL,
  `PRODCODE` varchar(50) NOT NULL,
  `PRODNAME` varchar(50) NOT NULL,
  `TYPE` varchar(50) DEFAULT NULL,
  `COLOR` varchar(50) DEFAULT NULL,
  `STANDARD` varchar(50) DEFAULT NULL,
  `UNITFEE` int(11) DEFAULT NULL,
  `UNIT` varchar(50) DEFAULT NULL,
  `WRTDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`HISTDATE`,`PRODCODE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 테이블 daep.purinfos 구조 내보내기
CREATE TABLE IF NOT EXISTS `purinfos` (
  `PURDATE` varchar(8) NOT NULL,
  `CMPYCODE` varchar(50) NOT NULL,
  `RESCODE` varchar(50) NOT NULL,
  `SEQ` int(11) NOT NULL DEFAULT 0,
  `COUNT` int(11) NOT NULL DEFAULT 0,
  `AMT` int(11) NOT NULL DEFAULT 0,
  `TAG` varchar(50) DEFAULT NULL,
  `WRTDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`PURDATE`,`CMPYCODE`,`RESCODE`,`SEQ`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 함수 daep.PUR_SEQ 구조 내보내기
DELIMITER //
CREATE FUNCTION `PUR_SEQ`(vPurDate VARCHAR(8), vCmpyCode VARCHAR(50), vResCode VARCHAR(50)) RETURNS int(11)
BEGIN
	DECLARE RES INT;
	SET RES = 0;
	SELECT MAX(SEQ)+1 INTO RES
	FROM PURINFOS
	WHERE PURDATE = vPurDate
	AND CMPYCODE = vCmpyCode
	AND RESCODE = vResCode
	GROUP BY CMPYCODE, RESCODE ;
	IF RES = 0 THEN 
		SET RES = 1;
	END IF;
	RETURN RES;
END//
DELIMITER ;

-- 테이블 daep.rescodes 구조 내보내기
CREATE TABLE IF NOT EXISTS `rescodes` (
  `HISTDATE` varchar(8) NOT NULL,
  `RESCODE` varchar(50) NOT NULL,
  `RESNAME` varchar(50) NOT NULL,
  `CREATOR` varchar(50) DEFAULT NULL,
  `COLOR` varchar(50) DEFAULT NULL,
  `STANDARD` varchar(50) DEFAULT NULL,
  `UNITFEE` int(11) DEFAULT 0,
  `UNIT` varchar(50) DEFAULT NULL,
  `WRTDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`HISTDATE`,`RESCODE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 테이블 daep.revinfos 구조 내보내기
CREATE TABLE IF NOT EXISTS `revinfos` (
  `REVDATE` varchar(8) NOT NULL,
  `CMPYCODE` varchar(50) NOT NULL,
  `PRODCODE` varchar(50) NOT NULL,
  `SEQ` int(11) NOT NULL,
  `COUNT` int(11) NOT NULL DEFAULT 0,
  `AMT` int(11) NOT NULL DEFAULT 0,
  `TAG` varchar(50) DEFAULT NULL,
  `WRTDATE` datetime DEFAULT NULL,
  PRIMARY KEY (`REVDATE`,`CMPYCODE`,`PRODCODE`,`SEQ`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 내보낼 데이터가 선택되어 있지 않습니다.

-- 함수 daep.REV_SEQ 구조 내보내기
DELIMITER //
CREATE FUNCTION `REV_SEQ`(vRevDate VARCHAR(8), vCmpyCode VARCHAR(50), vProdCode VARCHAR(50)) RETURNS int(11)
BEGIN
	DECLARE RES INT;
	SET RES = 0;
	SELECT MAX(SEQ)+1 INTO RES
	FROM REVINFOS
	WHERE REVDATE = vRevDate
	AND CMPYCODE = vCmpyCode
	AND PRODCODE = vProdCode
	GROUP BY CMPYCODE, PRODCODE ;
	IF RES = 0 THEN 
		SET RES = 1;
	END IF;
	RETURN RES;
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
