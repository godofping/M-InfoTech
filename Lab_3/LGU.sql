/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.4.6-MariaDB : Database - mit_pos
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`mit_pos` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `mit_pos`;

/*Table structure for table `tbl_customer` */

DROP TABLE IF EXISTS `tbl_customer`;

CREATE TABLE `tbl_customer` (
  `CustomerID` int(6) NOT NULL AUTO_INCREMENT,
  `LastName` varchar(30) DEFAULT NULL,
  `FirstName` varchar(30) DEFAULT NULL,
  `MiddleInnitial` varchar(1) DEFAULT NULL,
  `Age` int(3) DEFAULT NULL,
  `Address` varchar(60) DEFAULT NULL,
  `Tribe` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_customer` */

insert  into `tbl_customer`(`CustomerID`,`LastName`,`FirstName`,`MiddleInnitial`,`Age`,`Address`,`Tribe`) values (1,'Ancheta','Vince Leu French','L',22,'Secret','Dako Pitoy'),(2,'Roncesvalles','Rex Louise','P',21,'Secret Again','Tama Tama Lang'),(3,'Masukat','Rasol','N',22,'Secret Again n Again','Gamay Pitoy'),(4,'Brood','Mama','R',20,'Hotdog Eater','Dire'),(5,'Luna','Moon Fang','H',22,'Moon Light','Dire');

/*Table structure for table `tbl_order` */

DROP TABLE IF EXISTS `tbl_order`;

CREATE TABLE `tbl_order` (
  `OrderID` int(6) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(6) DEFAULT NULL,
  `Date` varchar(30) DEFAULT NULL,
  `AmountPaid` decimal(10,0) DEFAULT NULL,
  `AmouuntReceived` decimal(10,0) DEFAULT NULL,
  `ChangeAmount` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `ggg` (`CustomerID`),
  CONSTRAINT `ggg` FOREIGN KEY (`CustomerID`) REFERENCES `tbl_customer` (`CustomerID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_order` */

insert  into `tbl_order`(`OrderID`,`CustomerID`,`Date`,`AmountPaid`,`AmouuntReceived`,`ChangeAmount`) values (1,3,'9/1/2019','200','500','300');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
