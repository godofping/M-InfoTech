/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.4.6-MariaDB : Database - hris_skwd19
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`hris_skwd19` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `hris_skwd19`;

/*Table structure for table `tbl_employee` */

DROP TABLE IF EXISTS `tbl_employee`;

CREATE TABLE `tbl_employee` (
  `employeenumber` int(6) NOT NULL AUTO_INCREMENT,
  `employeeID` int(6) DEFAULT NULL,
  `surename` varchar(30) DEFAULT NULL,
  `firstname` varchar(30) DEFAULT NULL,
  `middlename` varchar(30) DEFAULT NULL,
  `extname` year(4) DEFAULT NULL,
  `birthdate` date DEFAULT NULL,
  `positionID` int(6) DEFAULT NULL,
  `employeesalarygradeID` int(6) DEFAULT NULL,
  `dateofservices1` date DEFAULT NULL,
  `lenghtofsevices` int(6) DEFAULT NULL,
  `positionlevel` int(6) DEFAULT NULL,
  `dateoflastpromoted` date DEFAULT NULL,
  `employeestatuusID` int(6) DEFAULT NULL,
  PRIMARY KEY (`employeenumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_employee` */

/*Table structure for table `tbl_employeeposition` */

DROP TABLE IF EXISTS `tbl_employeeposition`;

CREATE TABLE `tbl_employeeposition` (
  `positionID` int(6) NOT NULL AUTO_INCREMENT,
  `positioncodename` varchar(30) DEFAULT NULL,
  `positiondescription` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`positionID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_employeeposition` */

/*Table structure for table `tbl_employeesalarygrade` */

DROP TABLE IF EXISTS `tbl_employeesalarygrade`;

CREATE TABLE `tbl_employeesalarygrade` (
  `employeesalarygradeID` int(6) NOT NULL AUTO_INCREMENT,
  `salarygradecode` varchar(30) DEFAULT NULL,
  `salarygradeamount` int(6) DEFAULT NULL,
  PRIMARY KEY (`employeesalarygradeID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_employeesalarygrade` */

insert  into `tbl_employeesalarygrade`(`employeesalarygradeID`,`salarygradecode`,`salarygradeamount`) values (1,'Salary Grade1',NULL),(2,'Salary Grade2',NULL),(3,'Salary Grade3',NULL);

/*Table structure for table `tbl_employeestatus` */

DROP TABLE IF EXISTS `tbl_employeestatus`;

CREATE TABLE `tbl_employeestatus` (
  `employeestatusID` int(6) NOT NULL AUTO_INCREMENT,
  `statscode` varchar(30) DEFAULT NULL,
  `statusdescription` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`employeestatusID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_employeestatus` */

insert  into `tbl_employeestatus`(`employeestatusID`,`statscode`,`statusdescription`) values (1,'JO','Job Order'),(2,'CA','Casual'),(3,'RE','Regular');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
