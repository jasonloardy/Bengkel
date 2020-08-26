/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50724
Source Host           : localhost:3306
Source Database       : db_bengkel

Target Server Type    : MYSQL
Target Server Version : 50724
File Encoding         : 65001

Date: 2020-08-26 14:16:49
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tb_barang`
-- ----------------------------
DROP TABLE IF EXISTS `tb_barang`;
CREATE TABLE `tb_barang` (
  `kd_barang` varchar(16) NOT NULL,
  `nama_barang` varchar(64) DEFAULT NULL,
  `harga_beli` int(9) DEFAULT NULL,
  `harga_jual_u` int(9) DEFAULT NULL,
  `harga_jual_l` int(9) DEFAULT NULL,
  `harga_jual_b` int(9) DEFAULT NULL,
  `stok` int(9) DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_barang
-- ----------------------------
INSERT INTO `tb_barang` VALUES ('1234', 'OLI YAMALUBE', '30000', '40000', '35000', '32000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000001', 'VELG ORI MIO Z', '500000', '700000', '650000', '600000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000002', 'LAMPU REM MIO Z', '200000', '350000', '300000', '250000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000003', 'BEHEL NMAX', '100000', '150000', '140000', '130000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000004', 'BEHEL MIO Z ', '50000', '100000', '90000', '80000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000005', 'KNALPOT ORI MIO Z', '500000', '600000', '580000', '560000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000009', 'SPION MURAH', '10000', '20000', '18000', '15000', '5', 'A');
INSERT INTO `tb_barang` VALUES ('B0000010', 'SPION MAHAL', '20000', '30000', '28000', '25000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000011', 'TEST 11', '2', '22', '2', '2', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000012', 'TES 12', '2', '2', '2', '2', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000013', 'TESTING', '2', '2', '2', '2', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000017', 'ASD', '123', '321', '123', '321', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000018', 'LAMPU REM X-RIDE', '100000', '150000', '140000', '130000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000019', 'HELM KYT', '100000', '150000', '140000', '130000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000020', 'HELM BOGO', '125000', '175000', '170000', '165000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000021', 'HELM KIWI', '10000', '20000', '15000', '12000', '24', 'A');
INSERT INTO `tb_barang` VALUES ('B0000022', 'BAUT', '2000', '5000', '4000', '3000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000023', 'KLEP MIO Z', '100000', '200000', '180000', '170000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000024', 'KLEP SOUL GT', '110000', '200000', '180000', '150000', '96', 'A');

-- ----------------------------
-- Table structure for `tb_barang_history`
-- ----------------------------
DROP TABLE IF EXISTS `tb_barang_history`;
CREATE TABLE `tb_barang_history` (
  `kd_barang` varchar(16) DEFAULT NULL,
  `kd_transaksi` varchar(32) DEFAULT NULL,
  `tanggal` datetime DEFAULT NULL,
  `stok_masuk` int(9) DEFAULT NULL,
  `stok_keluar` int(9) DEFAULT NULL,
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `tb_barang_history_ibfk_1` FOREIGN KEY (`kd_barang`) REFERENCES `tb_barang` (`kd_barang`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_barang_history
-- ----------------------------
INSERT INTO `tb_barang_history` VALUES ('B0000024', 'SA', '2020-08-24 23:43:03', '100', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000024', 'SS', '2020-08-24 23:43:42', '0', '4');
INSERT INTO `tb_barang_history` VALUES ('B0000009', 'SS', '2020-08-26 09:21:55', '5', '0');

-- ----------------------------
-- Table structure for `tb_barang_satuan`
-- ----------------------------
DROP TABLE IF EXISTS `tb_barang_satuan`;
CREATE TABLE `tb_barang_satuan` (
  `kd_barang` varchar(16) DEFAULT NULL,
  `kd_satuan` varchar(8) DEFAULT NULL,
  `isi` int(9) DEFAULT NULL,
  `jenis_satuan` char(1) DEFAULT NULL,
  KEY `kd_satuan` (`kd_satuan`),
  CONSTRAINT `tb_barang_satuan_ibfk_1` FOREIGN KEY (`kd_satuan`) REFERENCES `tb_satuan` (`kd_satuan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_barang_satuan
-- ----------------------------
INSERT INTO `tb_barang_satuan` VALUES ('B0000010', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000011', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000011', 'PCS', '2', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000012', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000012', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000017', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000017', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000013', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000013', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000018', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000018', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000019', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000019', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000020', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000020', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000021', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000021', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000022', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000022', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000023', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000023', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000024', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000024', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000009', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('1234', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('1234', 'LSN', '12', 'M');

-- ----------------------------
-- Table structure for `tb_pelanggan`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pelanggan`;
CREATE TABLE `tb_pelanggan` (
  `kd_pelanggan` varchar(8) NOT NULL,
  `nama` varchar(64) DEFAULT NULL,
  `alamat` varchar(64) DEFAULT NULL,
  `no_telepon` varchar(64) DEFAULT NULL,
  `kategori` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_pelanggan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pelanggan
-- ----------------------------
INSERT INTO `tb_pelanggan` VALUES ('PL000001', 'JASON', 'BARONANG', '12345678901', 'L');
INSERT INTO `tb_pelanggan` VALUES ('PL000002', 'ERIKA', 'SERIGALA', '123819823', 'B');

-- ----------------------------
-- Table structure for `tb_pembelian`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembelian`;
CREATE TABLE `tb_pembelian` (
  `kd_pembelian` varchar(32) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `kd_supplier` varchar(8) DEFAULT NULL,
  `kd_bukti` varchar(8) DEFAULT NULL,
  `diskon` decimal(3,2) DEFAULT NULL,
  PRIMARY KEY (`kd_pembelian`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembelian
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_satuan`
-- ----------------------------
DROP TABLE IF EXISTS `tb_satuan`;
CREATE TABLE `tb_satuan` (
  `kd_satuan` varchar(8) NOT NULL,
  `nama_satuan` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`kd_satuan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_satuan
-- ----------------------------
INSERT INTO `tb_satuan` VALUES ('LSN', 'LUSIN');
INSERT INTO `tb_satuan` VALUES ('PCS', 'PIECES');

-- ----------------------------
-- Table structure for `tb_supplier`
-- ----------------------------
DROP TABLE IF EXISTS `tb_supplier`;
CREATE TABLE `tb_supplier` (
  `kd_supplier` varchar(8) NOT NULL,
  `nama` varchar(64) DEFAULT NULL,
  `alamat` varchar(64) DEFAULT NULL,
  `no_telepon` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`kd_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_supplier
-- ----------------------------
INSERT INTO `tb_supplier` VALUES ('SP000001', 'TESTING', 'JASON', '123');
INSERT INTO `tb_supplier` VALUES ('SP000002', 'ASD', 'DSA', '123');

-- ----------------------------
-- Table structure for `tb_user`
-- ----------------------------
DROP TABLE IF EXISTS `tb_user`;
CREATE TABLE `tb_user` (
  `username` varchar(8) NOT NULL,
  `password` varchar(32) DEFAULT NULL,
  `nama` varchar(32) DEFAULT NULL,
  `level` char(1) DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_user
-- ----------------------------
INSERT INTO `tb_user` VALUES ('admin', 'admin', 'ADMIN', 'A', 'A');
INSERT INTO `tb_user` VALUES ('kasir', 'kasir', 'IWAN', 'K', 'A');
INSERT INTO `tb_user` VALUES ('kasir2', 'kasir2', 'NURUL', 'K', 'N');
INSERT INTO `tb_user` VALUES ('userku', 'passku', 'NAMA KU', 'A', 'N');
DROP TRIGGER IF EXISTS `sesuaikan stok`;
DELIMITER ;;
CREATE TRIGGER `sesuaikan stok` AFTER INSERT ON `tb_barang_history` FOR EACH ROW IF (NEW.kd_transaksi = 'SA')
THEN
UPDATE tb_barang tb SET  tb.stok = NEW.stok_masuk WHERE tb.kd_barang = NEW.kd_barang;
ELSEIF (NEW.kd_transaksi = 'SS' AND NEW.stok_masuk <> 0)
THEN
UPDATE tb_barang tb SET  tb.stok = tb.stok + NEW.stok_masuk WHERE tb.kd_barang = NEW.kd_barang;
ELSEIF (NEW.kd_transaksi = 'SS' AND NEW.stok_keluar <> 0)
THEN
UPDATE tb_barang tb SET  tb.stok = tb.stok - NEW.stok_keluar WHERE tb.kd_barang = NEW.kd_barang;
END IF
;;
DELIMITER ;
