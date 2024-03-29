﻿CREATE DATABASE QUANLYPHONGKHACHSAN

USE QUANLYPHONGKHACHSAN
CREATE TABLE KHACH
(
MAKH NVARCHAR(50),
TENKH NVARCHAR(50),
DIACHIKH NVARCHAR(50),
SOCMND INT,
PRIMARY KEY(MAKH)
)
CREATE TABLE PHONG
(
SOPHONG NVARCHAR(50),
LOAIPHONG NVARCHAR(50),
TENPHONG NVARCHAR(50),
DONGIA INT,
PRIMARY KEY(SOPHONG)
)
CREATE TABLE CHITIETTHUEPHONG
(
SOPHONG INT,
MAKH NVARCHAR(50),
NGAYDEN DATETIME,
NGAYDI DATETIME,
TIENDATCOC FLOAT,
PRIMARY KEY(SOPHONG)
)
CREATE TABLE HOADON
(
SOHD NVARCHAR(50),
NGAYHD DATETIME,
MAKH NVARCHAR(50),
PRIMARY KEY (SOHD)
)
CREATE TABLE CHITIETHOADON
(
SOHD NVARCHAR(50),
SOPHONG  NVARCHAR(50),
SONGAY INt,
DONGIA Float,
SOTIENTRA FLOAT,
PRIMARY KEY (SOHD)
)

INSERT INTO KHACH
VALUES ('MK1',N'Lương Quang khoa',N'số 1 trần phú','2558465')
INSERT INTO KHACH
VALUES ('MK2',N'Phan Thi My Dung',N'số 2 trần phú','2552332')
INSERT INTO KHACH
VALUES ('MK3',N'Nguyen Quang Đai',N'số 3 trần phú','25562')





INSERT INTO PHONG
VALUES ('101','Phòng Standard(STD)','Single bed room(SGL)','100000')
INSERT INTO PHONG
VALUES ('102','Phòng Superior(SUP)','Twin bed room(TWN)','250000')
INSERT INTO PHONG
VALUES ('103','Double bed room (DBL)','Phòng Deluxe(DLX)','300000')


INSERT INTO CHITIETTHUEPHONG
VALUES ('001','MK1','2020-7-13','2020-7-15','5000000')
INSERT INTO CHITIETTHUEPHONG
VALUES ('002','MK2','2020-7-14','2020-7-17','5500000')
INSERT INTO CHITIETTHUEPHONG
VALUES ('003','MK3','2020-7-15','2020-7-22','6000000')



INSERT INTO HOADON
VALUES ('HD1','2020-7-13','MK1')
INSERT INTO HOADON
VALUES ('HD2','2020-7-14','MK2')
INSERT INTO HOADON
VALUES ('HD3','2020-7-15','MK3')

INSERT INTO CHITIETHOADON
VALUES ('HD1','101','1','100000','100000')
INSERT INTO CHITIETHOADON
VALUES ('HD2','102','10','250000','25000000')
INSERT INTO CHITIETHOADON
VALUES ('HD3','103','7','100000','700000')

SELECT *
FROM KHACH

SELECT *
FROM PHONG

SELECT *
FROM HOADON

SELECT *
FROM CHITIETHOADON

SELECT *
FROM CHITIETTHUEPHONG



