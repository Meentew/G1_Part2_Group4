-- ============================================
-- database.sql
-- Group Project #1 - Backend Software Development
-- n-Tier Login Application Database
-- ============================================

-- 1. สร้าง Database (ถ้ายังไม่มี)
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'LoginAppDB')
BEGIN
    CREATE DATABASE LoginAppDB;
END
GO

USE LoginAppDB;
GO

-- 2. ลบตารางเดิมถ้ามี (เผื่อรันซ้ำตอน dev)
IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
    DROP TABLE dbo.Users;
GO

-- 3. สร้างตาราง Users
CREATE TABLE Users (
    UserID      VARCHAR(50)  NOT NULL PRIMARY KEY,
    Password    VARCHAR(100) NOT NULL,
    FullName    NVARCHAR(100) NOT NULL,
    RoleName    VARCHAR(20)  NOT NULL
);
GO

-- 4. Insert ข้อมูลตัวอย่าง (อย่างน้อย 5 records, มี 2 roles: Admin, User)
INSERT INTO Users (UserID, Password, FullName, RoleName) VALUES
('admin Jackie',   '1234',     N'ณัฏฐนันท์  พาณิชวัฒนากูล ', 'Admin'),
('guest Anya', 'Anya',  N'อาเนีย ฟอเจอร์',    'User'),
('guest beam',    'beamkung', N'ธีรวัฒน์ ภาสพงษ์ไพศาล', 'User'),
('admin Paimon', 'Paimon',  N'ไพม่อน',       'Admin'),
('guest Ichigo', 'Ichigo', N'คุโรซากิ อิจิโกะ',   'User');
GO

-- 5. ตรวจสอบข้อมูล
SELECT * FROM Users;
GO
