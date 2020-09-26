/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50724
Source Host           : localhost:3306
Source Database       : db_bengkel

Target Server Type    : MYSQL
Target Server Version : 50724
File Encoding         : 65001

Date: 2020-09-26 11:33:21
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
  `stok` int(9) DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_barang
-- ----------------------------
INSERT INTO `tb_barang` VALUES ('B0000001', 'TEST', '1000', '120', 'A');

-- ----------------------------
-- Table structure for `tb_barang_history`
-- ----------------------------
DROP TABLE IF EXISTS `tb_barang_history`;
CREATE TABLE `tb_barang_history` (
  `kd_barang` varchar(16) DEFAULT NULL,
  `kd_transaksi` varchar(32) DEFAULT NULL,
  `tanggal` datetime DEFAULT NULL,
  `harga_beli` int(9) DEFAULT NULL,
  `stok_masuk` int(9) DEFAULT NULL,
  `stok_keluar` int(9) DEFAULT NULL,
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `tb_barang_history_ibfk_1` FOREIGN KEY (`kd_barang`) REFERENCES `tb_barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_barang_history
-- ----------------------------
INSERT INTO `tb_barang_history` VALUES ('B0000001', 'SA', '2020-09-26 10:10:23', '500', '100', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000001', '0001/PJ//0920', '2020-09-26 10:23:27', '0', '0', '100');
INSERT INTO `tb_barang_history` VALUES ('B0000001', '0002/PJ//0920', '2020-09-26 10:27:43', '0', '0', '12');
INSERT INTO `tb_barang_history` VALUES ('B0000001', '0003/PJ//0920', '2020-09-26 10:34:39', '0', '0', '1');
INSERT INTO `tb_barang_history` VALUES ('B0000001', '0001/PB//0920', '2020-09-26 10:35:36', '1000', '120', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000001', '0002/PB//0920', '2020-09-26 10:39:57', '500', '13', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000001', '0002/PB//0920', '2020-09-26 10:39:58', '1000', '200', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000001', '0004/PJ//0920', '2020-09-26 11:31:56', '0', '0', '200');

-- ----------------------------
-- Table structure for `tb_barang_satuan`
-- ----------------------------
DROP TABLE IF EXISTS `tb_barang_satuan`;
CREATE TABLE `tb_barang_satuan` (
  `kd_barang` varchar(16) DEFAULT NULL,
  `kd_satuan` varchar(8) DEFAULT NULL,
  `isi` int(9) DEFAULT NULL,
  `jenis_satuan` char(1) DEFAULT NULL,
  `harga_jual_u` int(9) DEFAULT NULL,
  `harga_jual_l` int(9) DEFAULT NULL,
  `harga_jual_p` int(9) DEFAULT NULL,
  KEY `kd_satuan` (`kd_satuan`),
  CONSTRAINT `tb_barang_satuan_ibfk_1` FOREIGN KEY (`kd_satuan`) REFERENCES `tb_satuan` (`kd_satuan`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_barang_satuan
-- ----------------------------
INSERT INTO `tb_barang_satuan` VALUES ('B0000001', 'PCS', '1', 'D', '2500', '2000', '1500');
INSERT INTO `tb_barang_satuan` VALUES ('B0000001', 'BKS', '100', 'M', '150000', '130000', '110000');
INSERT INTO `tb_barang_satuan` VALUES ('B0000001', 'LSN', '12', 'M', '25000', '20000', '15000');

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
INSERT INTO `tb_pelanggan` VALUES ('PL000001', 'UMUM', 'UMUM', 'umum', 'P');

-- ----------------------------
-- Table structure for `tb_pembayaran_hutang`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembayaran_hutang`;
CREATE TABLE `tb_pembayaran_hutang` (
  `kd_pembayaran_hutang` varchar(32) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_pembayaran_hutang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembayaran_hutang
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_pembayaran_hutang_detail`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembayaran_hutang_detail`;
CREATE TABLE `tb_pembayaran_hutang_detail` (
  `kd_pembayaran_hutang` varchar(32) DEFAULT NULL,
  `kd_pembelian` varchar(32) DEFAULT NULL,
  `bayar` int(9) DEFAULT NULL,
  KEY `kd_pembelian` (`kd_pembelian`),
  KEY `tb_pembayaran_hutang_detail_ibfk_2` (`kd_pembayaran_hutang`),
  CONSTRAINT `tb_pembayaran_hutang_detail_ibfk_1` FOREIGN KEY (`kd_pembelian`) REFERENCES `tb_pembelian` (`kd_pembelian`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembayaran_hutang_detail
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_pembayaran_piutang`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembayaran_piutang`;
CREATE TABLE `tb_pembayaran_piutang` (
  `kd_pembayaran_piutang` varchar(32) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_pembayaran_piutang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembayaran_piutang
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_pembayaran_piutang_detail`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembayaran_piutang_detail`;
CREATE TABLE `tb_pembayaran_piutang_detail` (
  `kd_pembayaran_piutang` varchar(32) DEFAULT NULL,
  `kd_penjualan` varchar(32) DEFAULT NULL,
  `bayar` int(9) DEFAULT NULL,
  KEY `kd_pembelian` (`kd_penjualan`),
  KEY `tb_pembayaran_hutang_detail_ibfk_2` (`kd_pembayaran_piutang`),
  CONSTRAINT `tb_pembayaran_piutang_detail_ibfk_1` FOREIGN KEY (`kd_penjualan`) REFERENCES `tb_penjualan` (`kd_penjualan`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembayaran_piutang_detail
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_pembelian`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembelian`;
CREATE TABLE `tb_pembelian` (
  `kd_pembelian` varchar(32) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `kd_supplier` varchar(8) DEFAULT NULL,
  `kd_bukti` varchar(32) DEFAULT NULL,
  `sales` varchar(32) DEFAULT NULL,
  `diskon` decimal(5,2) DEFAULT NULL,
  `tanggal_jt` date DEFAULT NULL,
  `tunai` int(9) DEFAULT NULL,
  `sisa` int(9) DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_pembelian`),
  KEY `kd_supplier` (`kd_supplier`),
  CONSTRAINT `tb_pembelian_ibfk_1` FOREIGN KEY (`kd_supplier`) REFERENCES `tb_supplier` (`kd_supplier`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembelian
-- ----------------------------
INSERT INTO `tb_pembelian` VALUES ('0001/PB//0920', '2020-09-26 10:35:36', 'SP000001', '', '', '0.00', '2020-09-26', '0', '120000', '1');
INSERT INTO `tb_pembelian` VALUES ('0002/PB//0920', '2020-09-26 10:39:57', 'SP000001', '', '', '0.00', '2020-09-26', '0', '206500', '1');

-- ----------------------------
-- Table structure for `tb_pembelian_detail`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembelian_detail`;
CREATE TABLE `tb_pembelian_detail` (
  `kd_pembelian` varchar(32) DEFAULT NULL,
  `kd_barang` varchar(16) DEFAULT NULL,
  `kd_satuan` varchar(8) DEFAULT NULL,
  `qty` int(9) DEFAULT NULL,
  `harga_beli` int(9) DEFAULT NULL,
  `diskon` decimal(5,2) DEFAULT NULL,
  `unit` int(9) DEFAULT NULL,
  KEY `kd_barang` (`kd_barang`),
  KEY `kd_pembelian` (`kd_pembelian`),
  CONSTRAINT `tb_pembelian_detail_ibfk_1` FOREIGN KEY (`kd_barang`) REFERENCES `tb_barang` (`kd_barang`) ON UPDATE CASCADE,
  CONSTRAINT `tb_pembelian_detail_ibfk_2` FOREIGN KEY (`kd_pembelian`) REFERENCES `tb_pembelian` (`kd_pembelian`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembelian_detail
-- ----------------------------
INSERT INTO `tb_pembelian_detail` VALUES ('0001/PB//0920', 'B0000001', 'PCS', '120', '1000', '0.00', '120');
INSERT INTO `tb_pembelian_detail` VALUES ('0002/PB//0920', 'B0000001', 'PCS', '13', '500', '0.00', '13');
INSERT INTO `tb_pembelian_detail` VALUES ('0002/PB//0920', 'B0000001', 'BKS', '2', '100000', '0.00', '200');

-- ----------------------------
-- Table structure for `tb_pending`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pending`;
CREATE TABLE `tb_pending` (
  `kd_pending` varchar(10) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `kd_pelanggan` varchar(8) DEFAULT NULL,
  `diskon` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`kd_pending`),
  KEY `kd_pelanggan` (`kd_pelanggan`),
  CONSTRAINT `tb_pending_ibfk_1` FOREIGN KEY (`kd_pelanggan`) REFERENCES `tb_pelanggan` (`kd_pelanggan`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pending
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_pending_detail`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pending_detail`;
CREATE TABLE `tb_pending_detail` (
  `kd_pending` varchar(10) DEFAULT NULL,
  `kd_barang` varchar(16) DEFAULT NULL,
  `nama_barang` varchar(64) DEFAULT NULL,
  `kd_satuan` varchar(8) DEFAULT NULL,
  `qty` int(9) DEFAULT NULL,
  `harga_jual` int(9) DEFAULT NULL,
  `diskon` decimal(5,0) DEFAULT NULL,
  `unit` int(9) DEFAULT NULL,
  `harga_beli` int(9) DEFAULT NULL,
  KEY `kd_barang` (`kd_barang`),
  KEY `kd_pending` (`kd_pending`),
  CONSTRAINT `tb_pending_detail_ibfk_2` FOREIGN KEY (`kd_barang`) REFERENCES `tb_barang` (`kd_barang`) ON UPDATE CASCADE,
  CONSTRAINT `tb_pending_detail_ibfk_3` FOREIGN KEY (`kd_pending`) REFERENCES `tb_pending` (`kd_pending`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pending_detail
-- ----------------------------

-- ----------------------------
-- Table structure for `tb_penjualan`
-- ----------------------------
DROP TABLE IF EXISTS `tb_penjualan`;
CREATE TABLE `tb_penjualan` (
  `kd_penjualan` varchar(32) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `kd_pelanggan` varchar(8) DEFAULT NULL,
  `diskon` decimal(5,2) DEFAULT NULL,
  `bayar` int(9) DEFAULT NULL,
  `sisa` int(9) DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_penjualan`),
  KEY `kd_pelanggan` (`kd_pelanggan`),
  CONSTRAINT `tb_penjualan_ibfk_1` FOREIGN KEY (`kd_pelanggan`) REFERENCES `tb_pelanggan` (`kd_pelanggan`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_penjualan
-- ----------------------------
INSERT INTO `tb_penjualan` VALUES ('0001/PJ//0920', '2020-09-26 10:23:27', 'PL000001', '0.00', '0', '148500', '1');
INSERT INTO `tb_penjualan` VALUES ('0002/PJ//0920', '2020-09-26 10:27:43', 'PL000001', '0.00', '0', '10000', '1');
INSERT INTO `tb_penjualan` VALUES ('0003/PJ//0920', '2020-09-26 10:34:39', 'PL000001', '0.00', '0', '1000', '1');
INSERT INTO `tb_penjualan` VALUES ('0004/PJ//0920', '2020-09-26 11:31:56', 'PL000001', '0.00', '0', '220000', '1');

-- ----------------------------
-- Table structure for `tb_penjualan_detail`
-- ----------------------------
DROP TABLE IF EXISTS `tb_penjualan_detail`;
CREATE TABLE `tb_penjualan_detail` (
  `kd_penjualan` varchar(32) DEFAULT NULL,
  `kd_barang` varchar(16) DEFAULT NULL,
  `nama_barang` varchar(64) DEFAULT NULL,
  `kd_satuan` varchar(8) DEFAULT NULL,
  `qty` int(9) DEFAULT NULL,
  `harga_jual` int(9) DEFAULT NULL,
  `diskon` decimal(5,0) DEFAULT NULL,
  `unit` int(9) DEFAULT NULL,
  `harga_beli` int(9) DEFAULT NULL,
  KEY `kd_pending` (`kd_penjualan`),
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `tb_penjualan_detail_ibfk_2` FOREIGN KEY (`kd_barang`) REFERENCES `tb_barang` (`kd_barang`) ON UPDATE CASCADE,
  CONSTRAINT `tb_penjualan_detail_ibfk_3` FOREIGN KEY (`kd_penjualan`) REFERENCES `tb_penjualan` (`kd_penjualan`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_penjualan_detail
-- ----------------------------
INSERT INTO `tb_penjualan_detail` VALUES ('0001/PJ//0920', 'B0000001', 'TEST', 'BKS', '1', '150000', '1', '100', '50000');
INSERT INTO `tb_penjualan_detail` VALUES ('0002/PJ//0920', 'B0000001', 'TEST', 'LSN', '1', '10000', '0', '12', '6000');
INSERT INTO `tb_penjualan_detail` VALUES ('0003/PJ//0920', 'B0000001', 'TEST', 'PCS', '1', '1000', '0', '1', '500');
INSERT INTO `tb_penjualan_detail` VALUES ('0004/PJ//0920', 'B0000001', 'TEST', 'BKS', '2', '110000', '0', '200', '100000');

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
INSERT INTO `tb_satuan` VALUES ('BKS', 'BUNGKUS');
INSERT INTO `tb_satuan` VALUES ('LSN', 'LUSIN');
INSERT INTO `tb_satuan` VALUES ('PCS', 'PICES');

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
INSERT INTO `tb_supplier` VALUES ('SP000001', 'ANUGERAH', 'ANUGERAH', '123');

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
INSERT INTO `tb_user` VALUES ('admin', 'admin', 'admin', 'A', 'A');
DROP TRIGGER IF EXISTS `sesuaikan stok`;
DELIMITER ;;
CREATE TRIGGER `sesuaikan stok` AFTER INSERT ON `tb_barang_history` FOR EACH ROW IF (NEW.stok_masuk <> 0) THEN
UPDATE tb_barang SET stok = stok + NEW.stok_masuk WHERE kd_barang = NEW.kd_barang;
ELSEIF (NEW.stok_keluar <> 0) THEN
UPDATE tb_barang SET stok = stok - NEW.stok_keluar WHERE kd_barang = NEW.kd_barang;
END IF
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `pembatalan`;
DELIMITER ;;
CREATE TRIGGER `pembatalan` AFTER UPDATE ON `tb_pembayaran_hutang` FOR EACH ROW IF (NEW.status = '0') THEN
UPDATE tb_pembelian tb
JOIN tb_pembayaran_hutang_detail tphd
ON tb.kd_pembelian = tphd.kd_pembelian
SET tb.sisa = tb.sisa + tphd.bayar
WHERE tphd.kd_pembayaran_hutang = NEW.kd_pembayaran_hutang;
END IF
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `kurangi sisa hutang`;
DELIMITER ;;
CREATE TRIGGER `kurangi sisa hutang` AFTER INSERT ON `tb_pembayaran_hutang_detail` FOR EACH ROW UPDATE tb_pembelian
SET sisa = sisa - NEW.bayar
WHERE kd_pembelian = NEW.kd_pembelian
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `pembatalan_copy`;
DELIMITER ;;
CREATE TRIGGER `pembatalan_copy` AFTER UPDATE ON `tb_pembayaran_piutang` FOR EACH ROW IF (NEW.status = '0') THEN
UPDATE tb_penjualan tb
JOIN tb_pembayaran_piutang_detail tphd
ON tb.kd_penjualan = tphd.kd_penjualan
SET tb.sisa = tb.sisa + tphd.bayar
WHERE tphd.kd_pembayaran_piutang = NEW.kd_pembayaran_piutang;
END IF
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `kurangi sisa hutang_copy`;
DELIMITER ;;
CREATE TRIGGER `kurangi sisa hutang_copy` AFTER INSERT ON `tb_pembayaran_piutang_detail` FOR EACH ROW UPDATE tb_penjualan
SET sisa = sisa - NEW.bayar
WHERE kd_penjualan = NEW.kd_penjualan
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `pembatalan pembelian`;
DELIMITER ;;
CREATE TRIGGER `pembatalan pembelian` AFTER UPDATE ON `tb_pembelian` FOR EACH ROW IF (NEW.status = '0') THEN

INSERT INTO tb_barang_history
SELECT kd_barang, kd_pembelian, NOW(), 0, 0, unit
FROM tb_pembelian_detail
WHERE kd_pembelian = NEW.kd_pembelian;

UPDATE tb_barang tb
JOIN tb_pembelian_detail tpd ON tb.kd_barang = tpd.kd_barang
SET tb.harga_beli = (SELECT harga_beli
                                    FROM tb_barang_history tbh
                                    LEFT JOIN tb_pembelian tp ON tbh.kd_transaksi = tp.kd_pembelian
                                    WHERE kd_barang = tb.kd_barang AND (status = '1' or status IS NULL) AND MID(kd_transaksi, 6, 2) = 'PB'
                                    ORDER BY tbh.tanggal DESC
                                    LIMIT 1)
WHERE tpd.kd_pembelian = NEW.kd_pembelian;

END IF
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `update harga beli baru`;
DELIMITER ;;
CREATE TRIGGER `update harga beli baru` AFTER INSERT ON `tb_pembelian_detail` FOR EACH ROW UPDATE tb_barang
SET harga_beli  = NEW.qty * NEW.harga_beli * (100 - NEW.diskon) / 100 / NEW.unit
WHERE kd_barang = NEW.kd_barang
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `tambah ke tabel history`;
DELIMITER ;;
CREATE TRIGGER `tambah ke tabel history` AFTER INSERT ON `tb_pembelian_detail` FOR EACH ROW INSERT INTO tb_barang_history
VALUES (NEW.kd_barang, NEW.kd_pembelian, NOW(),
NEW.qty*NEW.harga_beli*(100-NEW.diskon)/100/NEW.unit*(100-(SELECT diskon FROM tb_pembelian WHERE kd_pembelian = NEW.kd_pembelian))/100,
NEW.unit, 0)
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `pembatalan penjualan`;
DELIMITER ;;
CREATE TRIGGER `pembatalan penjualan` AFTER UPDATE ON `tb_penjualan` FOR EACH ROW IF (NEW.status = '0') THEN

INSERT INTO tb_barang_history
SELECT kd_barang, kd_penjualan, NOW(), 0, unit, 0
FROM tb_penjualan_detail
WHERE kd_penjualan = NEW.kd_penjualan;

END IF
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `tambah tabel history`;
DELIMITER ;;
CREATE TRIGGER `tambah tabel history` AFTER INSERT ON `tb_penjualan_detail` FOR EACH ROW INSERT INTO tb_barang_history
VALUES (NEW.kd_barang, NEW.kd_penjualan, NOW(), 0, 0, NEW.unit)
;;
DELIMITER ;
