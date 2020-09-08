/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50724
Source Host           : localhost:3306
Source Database       : db_bengkel

Target Server Type    : MYSQL
Target Server Version : 50724
File Encoding         : 65001

Date: 2020-09-08 21:10:14
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
  `harga_jual_p` int(9) DEFAULT NULL,
  `stok` int(9) DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  PRIMARY KEY (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_barang
-- ----------------------------
INSERT INTO `tb_barang` VALUES ('12312312', 'OLI YAMALUBE', '30000', '41000', '35000', '35000', '225', 'A');
INSERT INTO `tb_barang` VALUES ('B0000001', 'VELG ORI MIO Z', '90', '700000', '650000', '600000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000002', 'LAMPU REM MIO Z', '90', '350000', '300000', '250000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000003', 'BEHEL NMAX', '90', '150000', '140000', '130000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000004', 'BEHEL MIO Z ', '90', '100000', '90000', '80000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000005', 'KNALPOT ORI MIO Z', '90', '600000', '580000', '560000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000009', 'SPION MURAH', '9405', '20000', '18000', '15000', '171', 'A');
INSERT INTO `tb_barang` VALUES ('B0000010', 'SPION MAHAL', '99000', '30000', '28000', '25000', '1', 'A');
INSERT INTO `tb_barang` VALUES ('B0000011', 'TEST 11', '32333', '150', '140', '130', '125', 'A');
INSERT INTO `tb_barang` VALUES ('B0000012', 'TES 12', '90', '150', '140', '130', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000013', 'TESTING', '1017', '150', '140', '130', '1488', 'A');
INSERT INTO `tb_barang` VALUES ('B0000017', 'ASD', '90', '123', '123', '345', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000018', 'LAMPU REM X-RIDE', '90', '150000', '140000', '130000', '12', 'A');
INSERT INTO `tb_barang` VALUES ('B0000019', 'HELM KYT', '90', '150000', '140000', '130000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000020', 'HELM BOGO', '90', '175000', '170000', '165000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000021', 'HELM KIWI', '90', '20000', '15000', '12000', '48', 'A');
INSERT INTO `tb_barang` VALUES ('B0000022', 'BAUT', '7350', '15000', '4000', '8000', '120', 'A');
INSERT INTO `tb_barang` VALUES ('B0000023', 'KLEP MIO Z', '90', '200000', '180000', '170000', '0', 'A');
INSERT INTO `tb_barang` VALUES ('B0000024', 'KLEP SOUL GT', '89638', '200000', '180000', '150000', '108', 'A');
INSERT INTO `tb_barang` VALUES ('B0000025', 'TEST', '10000', '12000', '11000', '10500', '18', 'A');

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
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0001/PB//0820', '2020-08-30 10:35:55', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0002/PB//0820', '2020-08-30 10:37:18', '6', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000021', '0002/PB//0820', '2020-08-30 10:37:18', '24', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000013', '0003/PB//0820', '2020-08-30 10:38:21', '1476', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000011', '0004/PB//0820', '2020-08-30 10:38:42', '2', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000018', '0007/PB//0820', '2020-08-30 10:40:42', '12', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0010/PB//0820', '2020-08-30 10:53:21', '8', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0011/PB//0820', '2020-08-30 11:04:24', '100', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0012/PB//0820', '2020-08-30 12:41:01', '2', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0012/PB//0820', '2020-08-30 12:41:17', '10', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0013/PB//0820', '2020-08-30 12:42:12', '12', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0014/PB//0820', '2020-08-30 12:44:20', '10', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0015/PB//0820', '2020-08-30 12:44:40', '10', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0016/PB//0820', '2020-08-30 12:46:48', '24', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0016/PB//0820', '2020-08-30 12:46:48', '10', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000022', '0017/PB//0820', '2020-08-30 12:54:31', '120', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000025', 'SA', '2020-09-04 21:09:19', '18', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0001/PB//0920', '2020-09-04 21:50:29', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0002/PB//0920', '2020-09-04 22:54:22', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0003/PB//0920', '2020-09-04 22:57:07', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0004/PB//0920', '2020-09-04 22:58:12', '132', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000013', '0005/PB//0920', '2020-09-04 22:58:29', '12', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000010', '0006/PB//0920', '2020-09-07 08:24:48', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0007/PB//0920', '2020-09-07 08:26:50', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000024', '0008/PB//0920', '2020-09-07 08:28:19', '12', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0009/PB//0920', '2020-09-07 08:31:00', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0010/PB//0920', '2020-09-07 09:36:00', '10', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0010/PB//0920', '2020-09-07 09:36:00', '12', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0011/PB//0920', '2020-09-07 09:49:27', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0012/PB//0920', '2020-09-07 09:53:18', '1', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000011', '0013/PB//0920', '2020-09-07 22:32:35', '123', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0014/PB//0920', '2020-09-07 22:34:40', '10', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0014/PB//0920', '2020-09-07 22:34:40', '5', '0');
INSERT INTO `tb_barang_history` VALUES ('12312312', '0015/PB//0920', '2020-09-08 20:43:59', '10', '0');
INSERT INTO `tb_barang_history` VALUES ('B0000009', '0016/PB//0920', '2020-09-08 20:45:23', '12', '0');

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
INSERT INTO `tb_barang_satuan` VALUES ('B0000018', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000018', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000019', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000019', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000020', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000020', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000021', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000021', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000023', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000023', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000024', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000024', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000022', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000022', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000017', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000017', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000011', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000012', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000012', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000013', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000013', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000025', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('B0000025', 'LSN', '12', 'M');
INSERT INTO `tb_barang_satuan` VALUES ('B0000009', 'PCS', '1', 'D');
INSERT INTO `tb_barang_satuan` VALUES ('12312312', 'PCS', '1', 'D');

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
INSERT INTO `tb_pelanggan` VALUES ('PL000003', 'IRFAN', 'BANTAENG', '666', 'L');

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
INSERT INTO `tb_pembayaran_hutang` VALUES ('0001/PH//0920', '2020-09-08 20:02:44', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0002/PH//0920', '2020-09-08 20:03:09', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0003/PH//0920', '2020-09-08 20:03:12', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0004/PH//0920', '2020-09-08 20:03:21', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0005/PH//0920', '2020-09-08 20:03:40', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0006/PH//0920', '2020-09-08 20:04:12', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0007/PH//0920', '2020-09-08 20:04:59', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0008/PH//0920', '2020-09-08 20:05:45', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0009/PH//0920', '2020-09-08 20:06:13', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0010/PH//0920', '2020-09-08 20:07:20', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0011/PH//0920', '2020-09-08 20:10:04', '0');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0012/PH//0920', '2020-09-08 20:10:37', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0013/PH//0920', '2020-09-08 20:18:13', '0');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0014/PH//0920', '2020-09-08 20:20:11', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0015/PH//0920', '2020-09-08 20:45:45', '1');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0016/PH//0920', '2020-09-08 20:48:39', '0');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0017/PH//0920', '2020-09-08 20:50:36', '0');
INSERT INTO `tb_pembayaran_hutang` VALUES ('0018/PH//0920', '2020-09-08 20:51:07', '1');

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
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0001/PH//0920', '0010/PB//0920', '0');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0002/PH//0920', '0010/PB//0920', '0');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0003/PH//0920', '0010/PB//0920', '0');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0004/PH//0920', '0010/PB//0920', '0');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0005/PH//0920', '0010/PB//0920', '0');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0006/PH//0920', '0010/PB//0920', '0');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0007/PH//0920', '0010/PB//0920', '0');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0008/PH//0920', '0010/PB//0920', '92160');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0009/PH//0920', '0010/PB//0920', '200000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0011/PH//0920', '0009/PB//0920', '10000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0012/PH//0920', '0009/PB//0920', '10650');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0013/PH//0920', '0012/PB//0920', '600');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0013/PH//0920', '0013/PB//0920', '956960');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0014/PH//0920', '0012/PB//0920', '600');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0014/PH//0920', '0013/PB//0920', '56960');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0015/PH//0920', '0016/PB//0920', '112860');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0016/PH//0920', '0009/PB//0920', '10000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0016/PH//0920', '0012/PB//0920', '9000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0016/PH//0920', '0013/PB//0920', '3900000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0016/PH//0920', '0014/PB//0920', '300000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0017/PH//0920', '0009/PB//0920', '10000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0017/PH//0920', '0012/PB//0920', '9000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0017/PH//0920', '0013/PB//0920', '3900000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0017/PH//0920', '0014/PB//0920', '300000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0018/PH//0920', '0009/PB//0920', '10000');
INSERT INTO `tb_pembayaran_hutang_detail` VALUES ('0018/PH//0920', '0013/PB//0920', '3900000');

-- ----------------------------
-- Table structure for `tb_pembelian`
-- ----------------------------
DROP TABLE IF EXISTS `tb_pembelian`;
CREATE TABLE `tb_pembelian` (
  `kd_pembelian` varchar(32) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `kd_supplier` varchar(8) DEFAULT NULL,
  `kd_bukti` varchar(8) DEFAULT NULL,
  `sales` varchar(32) DEFAULT NULL,
  `diskon` decimal(5,2) DEFAULT NULL,
  `tanggal_jt` date DEFAULT NULL,
  `tunai` int(9) DEFAULT NULL,
  `sisa` int(9) DEFAULT NULL,
  PRIMARY KEY (`kd_pembelian`),
  KEY `kd_supplier` (`kd_supplier`),
  CONSTRAINT `tb_pembelian_ibfk_1` FOREIGN KEY (`kd_supplier`) REFERENCES `tb_supplier` (`kd_supplier`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tb_pembelian
-- ----------------------------
INSERT INTO `tb_pembelian` VALUES ('0001/PB//0820', '2020-08-30 10:35:55', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0001/PB//0920', '2020-09-04 21:50:29', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0002/PB//0820', '2020-08-30 10:37:18', 'SP000001', '', '', '1.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0002/PB//0920', '2020-09-04 22:54:22', 'SP000002', '', '', '0.00', '2020-09-04', null, null);
INSERT INTO `tb_pembelian` VALUES ('0003/PB//0820', '2020-08-30 10:38:19', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0003/PB//0920', '2020-09-04 22:57:07', 'SP000002', '', '', '0.00', '2020-09-04', null, null);
INSERT INTO `tb_pembelian` VALUES ('0004/PB//0820', '2020-08-30 10:38:42', 'SP000002', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0004/PB//0920', '2020-09-04 22:58:12', 'SP000001', '', '', '0.00', '2020-09-16', null, null);
INSERT INTO `tb_pembelian` VALUES ('0005/PB//0820', '2020-08-30 10:39:00', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0005/PB//0920', '2020-09-04 22:58:29', 'SP000002', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0006/PB//0820', '2020-08-30 10:40:02', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0006/PB//0920', '2020-09-07 08:24:48', 'SP000002', '', '', '0.00', '2020-09-07', '90', null);
INSERT INTO `tb_pembelian` VALUES ('0007/PB//0820', '2020-08-30 10:40:42', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0007/PB//0920', '2020-09-07 08:26:50', 'SP000002', '', '', '0.00', '2020-09-07', '90', null);
INSERT INTO `tb_pembelian` VALUES ('0008/PB//0820', '2020-08-30 10:42:04', 'SP000002', '', '', '105.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0008/PB//0920', '2020-09-07 08:28:19', 'SP000001', '', '', '0.00', '2020-09-07', '1000000', null);
INSERT INTO `tb_pembelian` VALUES ('0009/PB//0920', '2020-09-07 08:31:00', 'SP000002', '', '', '0.00', '2020-09-07', '100000', '0');
INSERT INTO `tb_pembelian` VALUES ('0010/PB//0820', '2020-08-30 10:53:21', 'SP000001', '', '', '10.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0010/PB//0920', '2020-09-07 09:36:00', 'SP000001', '', '', '5.00', '2020-09-07', '100000', '0');
INSERT INTO `tb_pembelian` VALUES ('0011/PB//0820', '2020-08-30 11:04:24', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0011/PB//0920', '2020-09-07 09:49:27', 'SP000002', '', '', '0.00', null, '39200', '0');
INSERT INTO `tb_pembelian` VALUES ('0012/PB//0820', '2020-08-30 12:41:01', 'SP000001', '', '', '10.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0012/PB//0920', '2020-09-07 09:53:18', 'SP000002', '', '', '0.00', '2020-09-15', '30000', '9000');
INSERT INTO `tb_pembelian` VALUES ('0013/PB//0820', '2020-08-30 12:42:12', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0013/PB//0920', '2020-09-07 22:32:35', 'SP000002', '', '', '0.00', '2020-09-07', '20000', '0');
INSERT INTO `tb_pembelian` VALUES ('0014/PB//0820', '2020-08-30 12:44:20', 'SP000001', '', '', '0.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0014/PB//0920', '2020-09-07 22:34:40', 'SP000002', '', '', '15.00', '2020-09-07', '21', '300000');
INSERT INTO `tb_pembelian` VALUES ('0015/PB//0820', '2020-08-30 12:44:40', 'SP000001', '', '', '10.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0015/PB//0920', '2020-09-08 20:43:59', 'SP000001', '', '', '0.00', null, '300000', '0');
INSERT INTO `tb_pembelian` VALUES ('0016/PB//0820', '2020-08-30 12:46:48', 'SP000002', '', '', '10.00', null, null, null);
INSERT INTO `tb_pembelian` VALUES ('0016/PB//0920', '2020-09-08 20:45:23', 'SP000001', '', '', '1.00', '2020-09-08', '0', '0');
INSERT INTO `tb_pembelian` VALUES ('0017/PB//0820', '2020-08-30 12:54:31', 'SP000001', '', '', '2.00', null, null, null);

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
INSERT INTO `tb_pembelian_detail` VALUES ('0001/PB//0820', 'B0000009', 'PCS', '1', '1', '1.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0002/PB//0820', 'B0000009', 'PCS', '6', '1000', '1.00', '6');
INSERT INTO `tb_pembelian_detail` VALUES ('0002/PB//0820', 'B0000021', 'LSN', '2', '1000', '2.00', '24');
INSERT INTO `tb_pembelian_detail` VALUES ('0003/PB//0820', 'B0000013', 'LSN', '123', '100000', '2.00', '1476');
INSERT INTO `tb_pembelian_detail` VALUES ('0004/PB//0820', 'B0000011', 'PCS', '1', '1', '1.00', '2');
INSERT INTO `tb_pembelian_detail` VALUES ('0007/PB//0820', 'B0000018', 'LSN', '1', '100000', '10.00', '12');
INSERT INTO `tb_pembelian_detail` VALUES ('0010/PB//0820', 'B0000009', 'PCS', '8', '800000', '10.00', '8');
INSERT INTO `tb_pembelian_detail` VALUES ('0011/PB//0820', 'B0000009', 'PCS', '100', '10000', '10.00', '100');
INSERT INTO `tb_pembelian_detail` VALUES ('0012/PB//0820', '12312312', 'PCS', '2', '79500', '30.00', '2');
INSERT INTO `tb_pembelian_detail` VALUES ('0012/PB//0820', 'B0000009', 'PCS', '10', '13500', '30.00', '10');
INSERT INTO `tb_pembelian_detail` VALUES ('0013/PB//0820', '12312312', 'LSN', '1', '2400000', '10.00', '12');
INSERT INTO `tb_pembelian_detail` VALUES ('0014/PB//0820', '12312312', 'PCS', '10', '100000', '10.00', '10');
INSERT INTO `tb_pembelian_detail` VALUES ('0015/PB//0820', '12312312', 'PCS', '10', '100000', '10.00', '10');
INSERT INTO `tb_pembelian_detail` VALUES ('0016/PB//0820', '12312312', 'LSN', '2', '500000', '10.00', '24');
INSERT INTO `tb_pembelian_detail` VALUES ('0016/PB//0820', 'B0000009', 'PCS', '10', '13500', '30.00', '10');
INSERT INTO `tb_pembelian_detail` VALUES ('0017/PB//0820', 'B0000022', 'LSN', '10', '100000', '10.00', '120');
INSERT INTO `tb_pembelian_detail` VALUES ('0001/PB//0920', '12312312', 'PCS', '1', '1', '1.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0002/PB//0920', '12312312', 'PCS', '1', '1', '1.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0003/PB//0920', 'B0000009', 'PCS', '1', '1', '1.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0004/PB//0920', '12312312', 'LSN', '11', '11111', '1.00', '132');
INSERT INTO `tb_pembelian_detail` VALUES ('0005/PB//0920', 'B0000013', 'LSN', '1', '12323', '1.00', '12');
INSERT INTO `tb_pembelian_detail` VALUES ('0006/PB//0920', 'B0000010', 'PCS', '1', '100000', '1.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0007/PB//0920', 'B0000009', 'PCS', '1', '99000', '1.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0008/PB//0920', 'B0000024', 'LSN', '1', '1222333', '12.00', '12');
INSERT INTO `tb_pembelian_detail` VALUES ('0009/PB//0920', '12312312', 'PCS', '1', '123112', '2.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0010/PB//0920', '12312312', 'PCS', '10', '30000', '2.00', '10');
INSERT INTO `tb_pembelian_detail` VALUES ('0010/PB//0920', 'B0000009', 'PCS', '12', '10000', '1.00', '12');
INSERT INTO `tb_pembelian_detail` VALUES ('0011/PB//0920', '12312312', 'PCS', '1', '40000', '2.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0012/PB//0920', '12312312', 'PCS', '1', '40000', '1.00', '1');
INSERT INTO `tb_pembelian_detail` VALUES ('0013/PB//0920', 'B0000011', 'PCS', '123', '33333', '3.00', '123');
INSERT INTO `tb_pembelian_detail` VALUES ('0014/PB//0920', '12312312', 'PCS', '10', '35000', '5.00', '10');
INSERT INTO `tb_pembelian_detail` VALUES ('0014/PB//0920', 'B0000009', 'PCS', '5', '10000', '10.00', '5');
INSERT INTO `tb_pembelian_detail` VALUES ('0015/PB//0920', '12312312', 'PCS', '10', '30000', '0.00', '10');
INSERT INTO `tb_pembelian_detail` VALUES ('0016/PB//0920', 'B0000009', 'PCS', '12', '10000', '5.00', '12');

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
ELSEIF (MID(NEW.kd_transaksi, 6, 2) = 'PB')
THEN
UPDATE tb_barang tb SET  tb.stok = tb.stok + NEW.stok_masuk WHERE tb.kd_barang = NEW.kd_barang;
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
DROP TRIGGER IF EXISTS `tambah ke tabel history`;
DELIMITER ;;
CREATE TRIGGER `tambah ke tabel history` AFTER INSERT ON `tb_pembelian_detail` FOR EACH ROW INSERT INTO tb_barang_history
VALUES (NEW.kd_barang, NEW.kd_pembelian, NOW(), NEW.unit, 0)
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `update harga beli baru`;
DELIMITER ;;
CREATE TRIGGER `update harga beli baru` AFTER INSERT ON `tb_pembelian_detail` FOR EACH ROW UPDATE tb_barang
SET harga_beli  = NEW.qty * NEW.harga_beli * (100 - NEW.diskon) / 100 / NEW.unit
WHERE kd_barang = NEW.kd_barang
;;
DELIMITER ;
