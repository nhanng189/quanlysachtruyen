-- CREATE DATABASE

create database QuanLiSachTruyen1;

use QuanLiSachTruyen1;

create table PhieuMuon(ma int identity(1,1) constraint PhieuMuon_PK primary key(ma), maKhachHang int not null default -1,
maSach int not null default -1, maQuanLi int not null default -1, ngayMuon date not null, ngayTra date);

create table QuanLi(ma int identity(1,1) constraint QuanLi_PK primary key(ma), tenHienThi char(30) not null default '1',
matKhau char(30) not null default '1', hoTen nchar(30) not null default '1', diaChi nchar(30) not null default N'Chưa có',
email nchar(30) not null default N'Chưa có', soDienThoai char(15) not null, soCMND char(10) not null);

create table KhachHang(ma int identity(1,1) constraint KhachHang_PK primary key(ma), hoTen nchar(30) not null default '1',
diaChi nchar(30) not null default N'Chưa có', soDienThoai char(15) not null, soCMND nchar(10) not null default N'Chưa có');

create table Sach(ma int identity(1,1) constraint Sach_PK primary key(ma),ten nvarchar(100) not null default '1',
theLoaiSach int not null default -1, loaiSach int not null default -1, tacGia nchar(30) not null default N'Chưa cập nhật',
soLuongThuc int not null default 0, soLuongCon int not null default 0, giaThanh float not null, giaChoThue float not null);

create table LoaiSach(ma int identity(1,1) constraint LoaiSach_PK primary key(ma),
ten nchar(30) not null default '1', soLuong int not null default 0);

create table TheLoaiSach(ma int identity(1,1) constraint TheLoaiSach_PK primary key(ma),
ten nvarchar(30) not null default '1', soLuong int not null default 0);

alter table PhieuMuon add
constraint PhieuMuon_KhachHang_FK foreign key(maKhachHang) references KhachHang(ma),
constraint PhieuMuon_Sach_FK foreign key(maSach) references Sach(ma),
constraint PhieuMuon_QuanLi_FK foreign key(maQuanLi) references QuanLi(ma);

alter table Sach add
constraint Sach_TheLoaiSach_FK foreign key(theLoaiSach) references TheLoaiSach(ma),
constraint Sach_LoaiSach_FK foreign key(loaiSach) references LoaiSach(ma);

--INSERT DATABASE

INSERT INTO theLoaiSach VALUES
(N'Tiểu thuyết', 2),
(N'Cổ tích', 1),
(N'Trinh thám', 2),
(N'Tâm lí', 3);

INSERT INTO loaiSach VALUES
(N'Thiếu nhi', 2),
(N'Người lớn', 2),
(N'Tuổi 18', 4);

INSERT INTO sach VALUES
(N'thám tử lừng danh conan', 3, 3, N'Aoyama Gosho', 4, 4, 20000, 1000),
(N'giết con chim nhại', 1, 2, N'Harper Lee', 3, 3, 100000, 6000),
(N'tôi thấy hoa vàng trên cỏ xanh', 1, 3, N'Nguyễn Nhật Ánh', 3, 3, 80000, 5000),
(N'lỗi ở những vì sao', 4, 3, N'John Green', 2, 2, 120000, 4000),
(N'Nàng bạch tuyết và bảy chú lùn', 2, 1, N'Chưa cập nhật', 2, 2, 120000, 4000),
(N'The little prince', 4, 1, N'Antoine de Saint-Exupéry', 2, 1, 120000, 4000),
(N'5 centimet trên giây', 4, 3, N'Makoto Shinkai', 2, 2, 120000, 4000),
(N'Mật mã Da Vinci', 3, 2, N'Dan Brown', 2, 2, 120000, 4000);

INSERT INTO khachHang VALUES
(N'Ngô Thành Phát', N'169/3C Ba Đình', '092345987', '123459876');

INSERT INTO quanLi VALUES
('Admin', '1', N'Lại Quỳnh Giao', N'39/3A Đinh Tiên Hoàng', 'giaolai@gmail.com', '0919839912', '123456789'),
('Staff1', '1', N'Jack Sparrow', N'38/3A Đinh Tiên Hoàng', 'jacksparrow@gmail.com', '0908131276', '987654321');

INSERT INTO phieuMuon VALUES
(1, 6, 2, getDate(), dateAdd(month, 1, getDate()));

--TEST

SELECT * FROM sach WHERE ten LIKE '%trên%' or ten LIKE '%prince%' OR 1!=1