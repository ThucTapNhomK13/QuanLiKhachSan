create database QuanLiKhachSan

use QuanLiKhachSan


create table Phong
(
maphong varchar(5) primary key,
tinhtrang varchar(10),
gia int,
loaiphong int,
makhachhang int

)

create table KhachHang
(
makhachhang int identity(1,1) primary key,	
hoten nvarchar(30),
gioitinh nvarchar(5),
sdt nvarchar(12),
socmnd varchar(12) ,
maphong varchar(10),
ngaydangki datetime,
ngaytra datetime, 
tratruoc int,
)

create table DichVuSuDung
(
makhachhang varchar(12),
madichvu int,
soluong int,
)

create table DichVu
(
madichvu int identity(1,1) primary key,
tendichvu nvarchar(30),
gia int,
)

create table Dangnhap
(
tendangnhap varchar(20),
matkhau varchar(20)
)

create table Hoadon
(
mahoadon int identity(1,1) primary key,
ngaythanhtoan datetime,
sotientratruoc int,
sotienthanhtoan int,
manhanvien varchar(5),
trangthai varchar(20), -- thanh toán - chưa thanh toán
makhachhang int,	
)


create table LoaiPhong
(
maloaiphong int ,
tenloaiphpng nvarchar(10),
trangbi nvarchar(30),
soluong int,
tinhtrang varchar(10)
)

-- Loai Phong
insert LoaiPhong values ('1' , ' Vip 1' , N'Giường đôi ' , '1' ,N'mới')
insert LoaiPhong values ('1' , ' Vip 1' , N'Điều hòa ' , '1' ,N'mới')
insert LoaiPhong values ('1' , ' Vip 1' , N'Bình nóng lạnh ' , '1' ,N'mới')
insert LoaiPhong values ('1' , ' Vip 1' , N'Bàn ghế đơn ' , '1' ,N'mới')
insert LoaiPhong values ('1' , ' Vip 1' , N'Rèm cửa ' , '1' ,N'mới')
insert LoaiPhong values ('2' , ' Vip 2' , N'Giường đôi ' , '1' ,N'mới')
insert LoaiPhong values ('2' , ' Vip 2' , N'Điều hòa  ' , '1' ,N'mới')
insert LoaiPhong values ('2' , ' Vip 2' , N'Bình nóng lạnh ' , '1' ,N'mới')
insert LoaiPhong values ('2' , ' Vip 2' , N'Bàn ghế đơn ' , '1' ,N'mới')
insert LoaiPhong values ('2' , ' Vip 2' , N'Tủ lạnh' , '1' ,N'mới')

-- Phong


insert Phong values ('101' ,'No' , '300000' , '002' , '')
insert Phong values ('102' ,'Yes' , '300000' , '002' , '1')
insert Phong values ('103' ,'Yes' , '200000' , '001' , '2')
insert Phong values ('104' ,'Yes' , '200000' , '001' , '3')
insert Phong values ('105' ,'No' , '200000' , '001' , '')
insert Phong values ('106' ,'No' , '300000' , '002' , '')
insert Phong values ('107' ,'No' , '200000' , '001' , '')
insert Phong values ('108' ,'No' , '200000' , '001' , '')
insert Phong values ('201' ,'No' , '300000' , '002' , '')
insert Phong values ('202' ,'Yes' , '300000' , '002' , '4')
insert Phong values ('203' ,'No' , '200000' , '001' , '')
insert Phong values ('204' ,'No' , '200000' , '001' , '')
insert Phong values ('205' ,'No' , '300000' , '002' , '')
insert Phong values ('206' ,'No' , '200000' , '001' , '')
insert Phong values ('207' ,'No' , '200000' , '001' , '')
insert Phong values ('208' ,'No' , '200000' , '001' , '')
insert Phong values ('301' ,'No' , '200000' , '001' , '')
insert Phong values ('302' ,'No' , '200000' , '001' , '')
insert Phong values ('303' ,'No' , '200000' , '001' , '')
insert Phong values ('304' ,'No' , '200000' , '001' , '')
insert Phong values ('305' ,'No' , '200000' , '001' , '')
insert Phong values ('306' ,'No' , '200000' , '001' , '')
insert Phong values ('307' ,'No' , '200000' , '001' , '')
insert Phong values ('308' ,'No' , '200000' , '001' , '')
insert Phong values ('401' ,'No' , '200000' , '001' , '')
insert Phong values ('402' ,'No' , '200000' , '001' , '')
insert Phong values ('403' ,'No' , '200000' , '001' , '')
insert Phong values ('404' ,'No' , '200000' , '001' , '')
insert Phong values ('405' ,'No' , '200000' , '001' , '')

-- KhachHang

insert KhachHang values (N'Vũ Lê Minh' , N'Nam' , '0936285633' , '031881808' , '102' , '5/14/2017' , '5/29/2017','1000000')
insert KhachHang values (N'Nguyễn Miên Anh' , N'Nữ' , '09632562' , '023652698' , '103' , '5/15/2017' , '6/29/2017','1500000')
insert KhachHang values (N'Vũ Hùng Cường' , N'Nam' , '01283143547' , '85467913' , '104' , '5/16/2017' , '6/10/2017','2000000')
insert KhachHang values (N'Nguyễn Tuấn Anh' , N'Nam' , '01216416268' , '032562563' , '202' , '5/13/2017' , '6/2/2017','1000000')

-- DichVu

insert DichVu values (N'Bữa sáng' , '50000')
insert DichVu values (N'Bữa trưa' , '100000')
insert DichVu values (N'Bữa tối' , '100000')
insert DichVu values (N'Dọn phòng' , '50000')
insert DichVu values (N'Nước' , '20000')
insert DichVu values (N'Đồ ăn nhẹ' , '80000')

-- DichVuSuDung

insert DichVuSuDung values ('1' ,'1','2')
insert DichVuSuDung values ('1' ,'2','2')
insert DichVuSuDung values ('2' ,'1','2')
insert DichVuSuDung values ('2' ,'4','1')
insert DichVuSuDung values ('2' ,'3','2')
insert DichVuSuDung values ('3' ,'1','2')
insert DichVuSuDung values ('4' ,'1','3')
insert DichVuSuDung values ('4' ,'2','2')
insert DichVuSuDung values ('4' ,'5','1')

-- HoaDon

insert HoaDon values ('5/16/2017','2000000','1000000','14150',N'Đã thanh toán','4')