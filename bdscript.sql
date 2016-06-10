/*
Navicat SQL Server Data Transfer

Source Server         : local
Source Server Version : 120000
Source Host           : .:1433
Source Database       : BDVentasM
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 120000
File Encoding         : 65001

Date: 2016-06-09 23:39:14
*/


-- ----------------------------
-- Table structure for tb_bloqueo
-- ----------------------------
DROP TABLE [tb_bloqueo]
GO
CREATE TABLE [tb_bloqueo] (
[cod_bloqueo] int NOT NULL IDENTITY(100,1) ,
[fecha_bloqueo] smalldatetime NOT NULL ,
[cod_usuario] varchar(100) NOT NULL ,
[id_jugador] varchar(100) NOT NULL ,
[personaje] varchar(100) NULL ,
[estado] varchar(100) NOT NULL ,
[razonbloqueo] varchar(500) NOT NULL ,
[sancion] varchar(200) NOT NULL ,
[razondesbloqueo] varchar(500) NULL 
)

GO

-- ----------------------------
-- Table structure for tb_cambiodatos
-- ----------------------------
DROP TABLE [tb_cambiodatos]
GO
CREATE TABLE [tb_cambiodatos] (
[cod_cambiodatos] int NOT NULL IDENTITY(1,1) ,
[cod_usuario] varchar(100) NOT NULL ,
[idcuenta] varchar(100) NOT NULL ,
[proantiguo] varchar(50) NOT NULL ,
[pronuevo] varchar(50) NOT NULL ,
[dniantiguo] varchar(8) NULL ,
[dninuevo] varchar(8) NULL ,
[correoant] varchar(50) NOT NULL ,
[correonuevo] varchar(50) NOT NULL ,
[fecha] smalldatetime NOT NULL ,
[pagado] float(53) NOT NULL ,
[estado] varchar(20) NOT NULL DEFAULT ('NORMAL') ,
[fecha_deposito] smalldatetime NULL ,
[mtcn] varchar(20) NULL ,
[modalidad] varchar(30) NOT NULL ,
[observacion] varchar(500) NULL 
)

GO

-- ----------------------------
-- Table structure for tb_cambionombre
-- ----------------------------
DROP TABLE [tb_cambionombre]
GO
CREATE TABLE [tb_cambionombre] (
[cod_cambio] int NOT NULL IDENTITY(1,1) ,
[cod_usuario] varchar(100) NULL ,
[idAntiguo] varchar(100) NOT NULL ,
[nickAntiguo] varchar(100) NOT NULL ,
[idNuevo] varchar(100) NOT NULL ,
[nickNuevo] varchar(100) NULL ,
[cantResets] int NOT NULL ,
[fechacambio] smalldatetime NOT NULL ,
[pagado] float(53) NOT NULL ,
[estado] varchar(100) NOT NULL DEFAULT ('NORMAL') ,
[cod_raza] int NULL ,
[fecha_deposito] smalldatetime NULL ,
[mtcn] varchar(20) NULL ,
[modalidad] varchar(100) NULL 
)

GO

-- ----------------------------
-- Table structure for tb_item_detalle
-- ----------------------------
DROP TABLE [tb_item_detalle]
GO
CREATE TABLE [tb_item_detalle] (
[id] int NOT NULL IDENTITY(1,1) ,
[cod_item_padre] int NOT NULL ,
[cod_item_hijo] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[tb_item_detalle]', RESEED, 38)
GO

-- ----------------------------
-- Records of tb_item_detalle
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tb_item_detalle] ON
GO
INSERT INTO [tb_item_detalle] ([id], [cod_item_padre], [cod_item_hijo]) VALUES (N'1', N'816', N'825'), (N'2', N'816', N'825'), (N'3', N'816', N'893'), (N'4', N'816', N'907'), (N'5', N'816', N'925'), (N'6', N'816', N'943'), (N'7', N'816', N'961'), (N'8', N'816', N'711'), (N'9', N'816', N'413'), (N'10', N'816', N'414'), (N'11', N'816', N'407'), (N'12', N'816', N'408'), (N'13', N'823', N'897'), (N'14', N'823', N'913'), (N'15', N'823', N'407'), (N'16', N'817', N'892'), (N'17', N'817', N'826'), (N'18', N'817', N'407'), (N'19', N'821', N'827'), (N'20', N'821', N'827'), (N'21', N'821', N'911'), (N'22', N'821', N'929'), (N'23', N'821', N'947'), (N'24', N'821', N'965'), (N'25', N'821', N'829'), (N'26', N'821', N'714'), (N'27', N'821', N'413'), (N'28', N'821', N'414'), (N'29', N'821', N'407'), (N'30', N'821', N'408'), (N'31', N'489', N'300'), (N'35', N'489', N'100'), (N'36', N'489', N'164'), (N'37', N'926', N'945'), (N'38', N'926', N'950')
GO
GO
SET IDENTITY_INSERT [tb_item_detalle] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for tb_items
-- ----------------------------
DROP TABLE [tb_items]
GO
CREATE TABLE [tb_items] (
[cod_item] int NOT NULL IDENTITY(100,1) ,
[cod_tipoitem] int NULL ,
[descripcion] varchar(100) NOT NULL ,
[precio] float(53) NOT NULL 
)


GO
DBCC CHECKIDENT(N'[tb_items]', RESEED, 1070)
GO

-- ----------------------------
-- Records of tb_items
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tb_items] ON
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'100', N'1', N'Bronze Armor', N'1'), (N'101', N'1', N'Dragon Armor', N'1'), (N'102', N'1', N'Pad Armor', N'1'), (N'103', N'1', N'Legendary Armor', N'1'), (N'104', N'1', N'Bone Armor', N'1'), (N'105', N'1', N'Leather Armor', N'1'), (N'106', N'1', N'Scale Armor', N'1'), (N'107', N'1', N'Sphinx Armor', N'1'), (N'108', N'1', N'Brass Armor', N'1'), (N'109', N'1', N'Plate Armor', N'1'), (N'110', N'1', N'Vine Armor', N'1'), (N'111', N'1', N'Silk Armor', N'1'), (N'112', N'1', N'Wind Armor', N'1'), (N'113', N'1', N'Spirit Armor', N'1'), (N'114', N'1', N'Guardian Armor', N'1'), (N'115', N'1', N'Storm Crow Armor', N'1'), (N'116', N'1', N'Black Dragon Armor', N'1'), (N'117', N'1', N'Dark Phoenix Armor', N'1'), (N'118', N'1', N'Grand Soul Armor', N'1'), (N'119', N'1', N'Holy Spirit Armor', N'1'), (N'120', N'1', N'Thunder Hawk Armor', N'1'), (N'121', N'1', N'Great Dragon Armor', N'1'), (N'122', N'1', N'Dark Soul Armor', N'1'), (N'123', N'1', N'Hurricane Armor', N'1'), (N'124', N'1', N'Red Spirit Armor', N'1'), (N'125', N'1', N'Light Plate Armor', N'1'), (N'126', N'1', N'Adamantine Armor', N'1'), (N'127', N'1', N'Dark Steel Armor', N'1'), (N'128', N'1', N'Dark Master Armor', N'1'), (N'129', N'1', N'Dragon Knight Armor', N'1'), (N'130', N'1', N'Venom Mist Armor', N'1'), (N'131', N'1', N'Sylpid Ray Armor', N'1'), (N'132', N'1', N'Volcano Armor', N'1'), (N'133', N'1', N'Sunlight Armor', N'1'), (N'134', N'1', N'Ashcrow Armor', N'1'), (N'135', N'1', N'Eclips Armor', N'1'), (N'136', N'1', N'Iris Armor', N'1'), (N'137', N'1', N'Valiant Armor', N'1'), (N'138', N'1', N'Glorious Armor', N'1'), (N'139', N'1', N'Ancient Armor', N'1'), (N'140', N'1', N'Red Wing Armor', N'1'), (N'141', N'1', N'Violent Wind Armor', N'1'), (N'142', N'1', N'Demonic Armor', N'1'), (N'143', N'1', N'Storm Blitz Armor', N'1'), (N'144', N'1', N'Eternal Wing Armor', N'1'), (N'145', N'1', N'Titanium Armor', N'1'), (N'146', N'1', N'Brave Armor', N'1'), (N'147', N'1', N'Hades Armor', N'1'), (N'148', N'1', N'Seraphim Armor', N'1'), (N'149', N'1', N'Divine Armor', N'1'), (N'150', N'1', N'Phamtom Armor', N'1'), (N'151', N'1', N'Destroyer Armor', N'1'), (N'152', N'1', N'Royal Armor', N'1'), (N'153', N'1', N'Succubus Armor', N'1'), (N'154', N'2', N'Small Axe', N'1'), (N'155', N'2', N'Hand Axe', N'1'), (N'156', N'2', N'Double Axe', N'1'), (N'157', N'2', N'Tomahawk', N'1'), (N'158', N'2', N'Elven Axe', N'1'), (N'159', N'2', N'Battle Axe', N'1'), (N'160', N'2', N'Nikea Axe', N'1'), (N'161', N'2', N'Larkan Axe', N'1'), (N'162', N'2', N'Crescent Axe', N'1'), (N'163', N'2', N'Chaos Dragon Axe', N'1'), (N'164', N'3', N'Bronze Boots', N'3'), (N'165', N'3', N'Dragon Boots', N'3'), (N'166', N'3', N'Pad Boots', N'3'), (N'167', N'3', N'Legendary Boots', N'3'), (N'168', N'3', N'Bone Boots', N'3'), (N'169', N'3', N'Leather Boots', N'3'), (N'170', N'3', N'Scale Boots', N'3'), (N'171', N'3', N'Sphinx Boots', N'3'), (N'172', N'3', N'Brass Boots', N'3'), (N'173', N'3', N'Plate Boots', N'3'), (N'174', N'3', N'Vine Boots', N'3'), (N'175', N'3', N'Silk Boots', N'3'), (N'176', N'3', N'Wind Boots', N'3'), (N'177', N'3', N'Spirit Boots', N'3'), (N'178', N'3', N'Guardian Boots', N'3'), (N'179', N'3', N'Storm Crow Boots', N'3'), (N'180', N'3', N'Black Dragon Boots', N'3'), (N'181', N'3', N'Dark Phoenix Boots', N'3'), (N'182', N'3', N'Grand Soul Boots', N'3'), (N'183', N'3', N'Holy Spirit Boots', N'3'), (N'184', N'3', N'Thunder Hawk Boots', N'3'), (N'185', N'3', N'Great Dragon Boots', N'3'), (N'186', N'3', N'Dark Soul Boots', N'3'), (N'187', N'3', N'Hurricane Boots', N'3'), (N'188', N'3', N'Red Spirit Boots', N'3'), (N'189', N'3', N'Light Plate Boots', N'3'), (N'190', N'3', N'Adamantine Boots', N'3'), (N'191', N'3', N'Dark Steel Boots', N'3'), (N'192', N'3', N'Dark Master Boots', N'3'), (N'193', N'3', N'Dragon Knight Boots', N'3'), (N'194', N'3', N'Venom Mist Boots', N'3'), (N'195', N'3', N'Sylpid Ray Boots', N'3'), (N'196', N'3', N'Volcano Boots', N'3'), (N'197', N'3', N'Sunlight Boots', N'3'), (N'198', N'3', N'Ashcrow Boots', N'3'), (N'199', N'3', N'Eclips Boots', N'3')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'200', N'3', N'Iris Boots', N'3'), (N'201', N'3', N'Valiant Boots', N'3'), (N'202', N'3', N'Glorious Boots', N'3'), (N'203', N'3', N'Ancient Boots', N'3'), (N'204', N'3', N'Red Wing Boots', N'3'), (N'205', N'3', N'Violent Wind Boots', N'3'), (N'206', N'3', N'Demonic Boots', N'3'), (N'207', N'3', N'Storm Blitz Boots', N'3'), (N'208', N'3', N'Eternal Wing Boots', N'3'), (N'209', N'3', N'Titanium Boots', N'3'), (N'210', N'3', N'Brave Boots', N'3'), (N'211', N'3', N'Hades Boots', N'3'), (N'212', N'3', N'Seraphim Boots', N'3'), (N'213', N'3', N'Divine Boots', N'3'), (N'214', N'3', N'Phamtom Boots', N'3'), (N'215', N'3', N'Destroyer Boots', N'3'), (N'216', N'3', N'Royal Boots', N'3'), (N'217', N'3', N'Succubus Boots', N'3'), (N'218', N'4', N'Short Bow', N'1'), (N'219', N'4', N'Bow', N'1'), (N'220', N'4', N'Elven Bow', N'1'), (N'221', N'4', N'Battle Bow', N'1'), (N'222', N'4', N'Tiger Bow', N'1'), (N'223', N'4', N'Silver Bow', N'1'), (N'224', N'4', N'Chaos Nature Bow', N'1'), (N'225', N'4', N'Arrow', N'1'), (N'226', N'4', N'Celestial Bow', N'1'), (N'227', N'4', N'Arrow Viper Bow', N'1'), (N'228', N'4', N'Syilph Wind Bow', N'1'), (N'229', N'4', N'Albatross Bow', N'1'), (N'230', N'4', N'Dark Stinger Bow', N'1'), (N'231', N'5', N'Bolt', N'1'), (N'232', N'5', N'Crossbow', N'1'), (N'233', N'5', N'Golden Crossbow', N'1'), (N'234', N'5', N'Arquebus', N'1'), (N'235', N'5', N'Light Crossbow', N'1'), (N'236', N'5', N'Serpent Crossbow', N'1'), (N'237', N'5', N'Bluewing Crossbow', N'1'), (N'238', N'5', N'Aquagold Crossbow', N'1'), (N'239', N'5', N'Saint Crossbow', N'1'), (N'240', N'5', N'Divine Crossbow of Archangel', N'1'), (N'241', N'5', N'Great Reign Crossbow', N'1'), (N'242', N'6', N'Fenrir Rojo', N'1'), (N'243', N'6', N'Fenrir Azul', N'1'), (N'244', N'6', N'Fenrir Negro', N'1'), (N'245', N'6', N'Fenrir Dorado', N'1'), (N'246', N'7', N'Bronze Gloves', N'7'), (N'247', N'7', N'Dragon Gloves', N'7'), (N'248', N'7', N'Pad Gloves', N'7'), (N'249', N'7', N'Legendary Gloves', N'7'), (N'250', N'7', N'Bone Gloves', N'7'), (N'251', N'7', N'Leather Gloves', N'7'), (N'252', N'7', N'Scale Gloves', N'7'), (N'253', N'7', N'Sphinx Gloves', N'7'), (N'254', N'7', N'Brass Gloves', N'7'), (N'255', N'7', N'Plate Gloves', N'7'), (N'256', N'7', N'Vine Gloves', N'7'), (N'257', N'7', N'Silk Gloves', N'7'), (N'258', N'7', N'Wind Gloves', N'7'), (N'259', N'7', N'Spirit Gloves', N'7'), (N'260', N'7', N'Guardian Gloves', N'7'), (N'261', N'7', N'Storm Crow Gloves', N'7'), (N'262', N'7', N'Black Dragon Gloves', N'7'), (N'263', N'7', N'Dark Phoenix Gloves', N'7'), (N'264', N'7', N'Grand Soul Gloves', N'7'), (N'265', N'7', N'Holy Spirit Gloves', N'7'), (N'266', N'7', N'Thunder Hawk Gloves', N'7'), (N'267', N'7', N'Great Dragon Gloves', N'7'), (N'268', N'7', N'Dark Soul Gloves', N'7'), (N'269', N'7', N'Hurricane Gloves', N'7'), (N'270', N'7', N'Red Spirit Gloves', N'7'), (N'271', N'7', N'Light Plate Gloves', N'7'), (N'272', N'7', N'Adamantine Gloves', N'7'), (N'273', N'7', N'Dark Steel Gloves', N'7'), (N'274', N'7', N'Dark Master Gloves', N'7'), (N'275', N'7', N'Dragon Knight Gloves', N'7'), (N'276', N'7', N'Venom Mist Gloves', N'7'), (N'277', N'7', N'Sylpid Ray Gloves', N'7'), (N'278', N'7', N'Volcano Gloves', N'7'), (N'279', N'7', N'Sunlight Gloves', N'7'), (N'280', N'7', N'Ashcrow Gloves', N'7'), (N'281', N'7', N'Eclips Gloves', N'7'), (N'282', N'7', N'Iris Gloves', N'7'), (N'283', N'7', N'Valiant Gloves', N'7'), (N'284', N'7', N'Glorious Gloves', N'7'), (N'285', N'7', N'Ancient Gloves', N'7'), (N'286', N'7', N'Red Wing Gloves', N'7'), (N'287', N'7', N'Violent Wind Gloves', N'7'), (N'288', N'7', N'Demonic Gloves', N'7'), (N'289', N'7', N'Storm Blitz Gloves', N'7'), (N'290', N'7', N'Eternal Wing Gloves', N'7'), (N'291', N'7', N'Titanium Gloves', N'7'), (N'292', N'7', N'Brave Gloves', N'7'), (N'293', N'7', N'Hades Gloves', N'7'), (N'294', N'7', N'Seraphim Gloves', N'7'), (N'295', N'7', N'Divine Gloves', N'7'), (N'296', N'7', N'Phamtom Gloves', N'7'), (N'297', N'7', N'Destroyer Gloves', N'7'), (N'298', N'7', N'Royal Gloves', N'7'), (N'299', N'7', N'Succubus Gloves', N'7')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'300', N'8', N'Bronze Helm', N'8'), (N'301', N'8', N'Dragon Helm', N'8'), (N'302', N'8', N'Pad Helm', N'8'), (N'303', N'8', N'Legendary Helm', N'8'), (N'304', N'8', N'Bone Helm', N'8'), (N'305', N'8', N'Leather Helm', N'8'), (N'306', N'8', N'Scale Helm', N'8'), (N'307', N'8', N'Sphinx Helm', N'8'), (N'308', N'8', N'Brass Helm', N'8'), (N'309', N'8', N'Plate Helm', N'8'), (N'310', N'8', N'Vine Helm', N'8'), (N'311', N'8', N'Silk Helm', N'8'), (N'312', N'8', N'Wind Helm', N'8'), (N'313', N'8', N'Spirit Helm', N'8'), (N'314', N'8', N'Guardian Helm', N'8'), (N'315', N'8', N'Black Dragon Helm', N'8'), (N'316', N'8', N'Dark Phoenix Helm', N'8'), (N'317', N'8', N'Grand Soul Helm', N'8'), (N'318', N'8', N'Holy Spirit Helm', N'8'), (N'319', N'8', N'Great Dragon Helm', N'8'), (N'320', N'8', N'Dark Soul Helm', N'8'), (N'321', N'8', N'Red Spirit Helm', N'8'), (N'322', N'8', N'Light Plate Helm', N'8'), (N'323', N'8', N'Adamantine Helm', N'8'), (N'324', N'8', N'Dark Steel Helm', N'8'), (N'325', N'8', N'Dark Master Helm', N'8'), (N'326', N'8', N'Dragon Knight Helm', N'8'), (N'327', N'8', N'Venom Mist Helm', N'8'), (N'328', N'8', N'Sylphid Ray Helm', N'8'), (N'329', N'8', N'Sunlight Helm', N'8'), (N'330', N'8', N'Ashcrow Helm', N'8'), (N'331', N'8', N'Eclips Helm', N'8'), (N'332', N'8', N'Iris Helm', N'8'), (N'333', N'8', N'Glorious Helm', N'8'), (N'334', N'8', N'Ancient Helm', N'8'), (N'335', N'8', N'Red Wing Helm', N'8'), (N'336', N'8', N'Violent Wind Helm', N'8'), (N'337', N'8', N'Demonic Helm', N'8'), (N'338', N'8', N'Storm Blitz Helm', N'8'), (N'339', N'8', N'Eternal Wing Helm', N'8'), (N'340', N'8', N'Titanium Helm', N'8'), (N'341', N'8', N'Brave Helm', N'8'), (N'342', N'8', N'Hades Helm', N'8'), (N'343', N'8', N'Seraphim Helm', N'8'), (N'344', N'8', N'Divine Helm', N'8'), (N'345', N'8', N'Royal Helm', N'8'), (N'346', N'8', N'Succubus Helm', N'8'), (N'347', N'9', N'Elemental Mace', N'1'), (N'348', N'9', N'Morning Star', N'1'), (N'349', N'9', N'Flail', N'1'), (N'350', N'9', N'Great Hammer', N'1'), (N'351', N'9', N'Crystal Morning Star', N'1'), (N'352', N'9', N'Mace of the King', N'1'), (N'353', N'10', N'Bronze Pants', N'10'), (N'354', N'10', N'Dragon Pants', N'10'), (N'355', N'10', N'Pad Pants', N'10'), (N'356', N'10', N'Legendary Pants', N'10'), (N'357', N'10', N'Bone Pants', N'10'), (N'358', N'10', N'Leather Pants', N'10'), (N'359', N'10', N'Scale Pants', N'10'), (N'360', N'10', N'Sphinx Pants', N'10'), (N'361', N'10', N'Brass Pants', N'10'), (N'362', N'10', N'Plate Pants', N'10'), (N'363', N'10', N'Vine Pants', N'10'), (N'364', N'10', N'Silk Pants', N'10'), (N'365', N'10', N'Wind Pants', N'10'), (N'366', N'10', N'Spirit Pants', N'10'), (N'367', N'10', N'Guardian Pants', N'10'), (N'368', N'10', N'Storm Crow Pants', N'10'), (N'369', N'10', N'Black Dragon Pants', N'10'), (N'370', N'10', N'Dark Phoenix Pants', N'10'), (N'371', N'10', N'Grand Soul Pants', N'10'), (N'372', N'10', N'Holy Spirit Pants', N'10'), (N'373', N'10', N'Thunder Hawk Pants', N'10'), (N'374', N'10', N'Great Dragon Pants', N'10'), (N'375', N'10', N'Dark Soul Pants', N'10'), (N'376', N'10', N'Hurricane Pants', N'10'), (N'377', N'10', N'Red Spirit Pants', N'10'), (N'378', N'10', N'Light Plate Pants', N'10'), (N'379', N'10', N'Adamantine Pants', N'10'), (N'380', N'10', N'Dark Steel Pants', N'10'), (N'381', N'10', N'Dark Master Pants', N'10'), (N'382', N'10', N'Dragon Knight Pants', N'10'), (N'383', N'10', N'Venom Mist Pants', N'10'), (N'384', N'10', N'Sylpid Ray Pants', N'10'), (N'385', N'10', N'Volcano Pants', N'10'), (N'386', N'10', N'Sunlight Pants', N'10'), (N'387', N'10', N'Ashcrow Pants', N'10'), (N'388', N'10', N'Eclips Pants', N'10'), (N'389', N'10', N'Iris Pants', N'10'), (N'390', N'10', N'Valiant Pants', N'10'), (N'391', N'10', N'Glorious Pants', N'10'), (N'392', N'10', N'Ancient Pants', N'10'), (N'393', N'10', N'Red Wing Pants', N'10'), (N'394', N'10', N'Violent Wind Pants', N'10'), (N'395', N'10', N'Demonic Pants', N'10'), (N'396', N'10', N'Storm Blitz Pants', N'10'), (N'397', N'10', N'Eternal Wing Pants', N'10'), (N'398', N'10', N'Titanium Pants', N'10'), (N'399', N'10', N'Brave Pants', N'10')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'400', N'10', N'Hades Pants', N'10'), (N'401', N'10', N'Seraphim Pants', N'10'), (N'402', N'10', N'Divine Pants', N'10'), (N'403', N'10', N'Phamtom Pants', N'10'), (N'404', N'10', N'Destroyer Pants', N'10'), (N'405', N'10', N'Royal Pants', N'10'), (N'406', N'10', N'Succubus Pants', N'10'), (N'407', N'11', N'Pendant of Lightining', N'1'), (N'408', N'11', N'Pendant of Fire', N'1'), (N'409', N'11', N'Pendant of Ice', N'1'), (N'410', N'11', N'Pendant of Wind', N'1'), (N'411', N'11', N'Pendant of Water', N'1'), (N'412', N'11', N'Pendant of Ability', N'1'), (N'413', N'12', N'Ring of Ice', N'1'), (N'414', N'12', N'Ring of Poison', N'1'), (N'415', N'12', N'Ring of Transformation', N'1'), (N'416', N'12', N'Ring of Wizardry', N'1'), (N'417', N'12', N'Ring of Fire', N'1'), (N'418', N'12', N'Ring of Earth', N'1'), (N'419', N'12', N'Ring of Wind', N'1'), (N'420', N'12', N'Ring of Magic', N'1'), (N'421', N'12', N'Elite Skelleton Transformation', N'1'), (N'422', N'12', N'S3 Ring 1', N'1'), (N'423', N'12', N'S3 Ring 2', N'1'), (N'424', N'12', N'GM Transformation Ring', N'1'), (N'425', N'13', N'Ropa Bronze', N'13'), (N'426', N'13', N'Ropa Dragon', N'13'), (N'427', N'13', N'Ropa Pad', N'13'), (N'428', N'13', N'Ropa Legendary', N'13'), (N'429', N'13', N'Ropa Bone', N'13'), (N'430', N'13', N'Ropa Leather', N'13'), (N'431', N'13', N'Ropa Scale', N'13'), (N'432', N'13', N'Ropa Sphinx', N'13'), (N'433', N'13', N'Ropa Brass', N'13'), (N'434', N'13', N'Ropa Plate', N'13'), (N'435', N'13', N'Ropa Vine', N'13'), (N'436', N'13', N'Ropa Silk', N'13'), (N'437', N'13', N'Ropa Wind', N'13'), (N'438', N'13', N'Ropa Spirit', N'13'), (N'439', N'13', N'Ropa Guardian', N'13'), (N'440', N'13', N'Ropa Storm Crow', N'13'), (N'441', N'13', N'Ropa Black Dragon', N'13'), (N'442', N'13', N'Ropa Dark Phoenix', N'13'), (N'443', N'13', N'Ropa Grand Soul', N'13'), (N'444', N'13', N'Ropa Divine', N'13'), (N'445', N'13', N'Ropa Thunder Hawk', N'13'), (N'446', N'13', N'Ropa Great Dragon', N'13'), (N'447', N'13', N'Ropa Black Soul', N'13'), (N'448', N'13', N'Ropa Hurricane', N'13'), (N'449', N'13', N'Ropa Red Spirit', N'13'), (N'450', N'13', N'Ropa Light Plate', N'13'), (N'451', N'13', N'Ropa Adamantine', N'13'), (N'452', N'13', N'Ropa Dark Steel', N'13'), (N'453', N'13', N'Ropa Dark Master', N'13'), (N'454', N'13', N'Ropa Dragon Knight', N'13'), (N'455', N'13', N'Ropa Venom Mist', N'13'), (N'456', N'13', N'Ropa Sylpid Ray', N'13'), (N'457', N'13', N'Ropa Volcano', N'13'), (N'458', N'13', N'Ropa Sunlight', N'13'), (N'459', N'13', N'Ropa Ashcrow', N'13'), (N'460', N'13', N'Ropa Eclips', N'13'), (N'461', N'13', N'Ropa Iris', N'13'), (N'462', N'13', N'Ropa Valiant', N'13'), (N'463', N'13', N'Ropa Glorious', N'13'), (N'464', N'13', N'Ropa Ancient', N'13'), (N'465', N'13', N'Ropa Red Wing', N'13'), (N'466', N'13', N'Ropa Mistery', N'13'), (N'467', N'13', N'Ropa Black Rose', N'13'), (N'468', N'13', N'Ropa Aura', N'13'), (N'469', N'13', N'Ropa Lilium', N'13'), (N'470', N'13', N'Ropa Titanium', N'13'), (N'471', N'13', N'Ropa Brave', N'13'), (N'472', N'13', N'Ropa Hades', N'13'), (N'473', N'13', N'Ropa Seraphim', N'13'), (N'474', N'13', N'Ropa Faith', N'13'), (N'475', N'13', N'Ropa Phamtom', N'13'), (N'476', N'13', N'Ropa Destroyer', N'13'), (N'477', N'13', N'Ropa Paewang', N'13'), (N'478', N'13', N'Ropa Queen', N'13'), (N'479', N'14', N'Battle Scepter', N'1'), (N'480', N'14', N'Master Scepter', N'1'), (N'481', N'14', N'Master Scepter', N'1'), (N'482', N'14', N'Great Scepter', N'1'), (N'483', N'14', N'Lord Scepter', N'1'), (N'484', N'14', N'Divine Scepter of Archangel', N'1'), (N'485', N'14', N'Great Lord Scepter', N'1'), (N'486', N'14', N'Soleil Scepter', N'1'), (N'487', N'14', N'Shining Scepter', N'1'), (N'488', N'14', N'Absolute Scepter', N'1'), (N'489', N'15', N'Set Bronze', N'15'), (N'490', N'15', N'Set Dragon', N'15'), (N'491', N'15', N'Set Pad', N'15'), (N'492', N'15', N'Set Legendary', N'15'), (N'493', N'15', N'Set Bone', N'15'), (N'494', N'15', N'Set Leather', N'15'), (N'495', N'15', N'Set Scale', N'15'), (N'496', N'15', N'Set Sphinx', N'15'), (N'497', N'15', N'Set Brass', N'15'), (N'498', N'15', N'Set Plate', N'15'), (N'499', N'15', N'Set Vine', N'15')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'500', N'15', N'Set Silk', N'15'), (N'501', N'15', N'Set Wind', N'15'), (N'502', N'15', N'Set Spirit', N'15'), (N'503', N'15', N'Set Guardian', N'15'), (N'504', N'15', N'Set Storm Crow', N'15'), (N'505', N'15', N'Set Black Dragon', N'15'), (N'506', N'15', N'Set Dark Phoenix', N'15'), (N'507', N'15', N'Set Grand Soul', N'15'), (N'508', N'15', N'Set Holy Spirit', N'15'), (N'509', N'15', N'Set Thunder Hawk', N'15'), (N'510', N'15', N'Set Great Dragon', N'15'), (N'511', N'15', N'Set Dark Soul', N'15'), (N'512', N'15', N'Set Hurricane', N'15'), (N'513', N'15', N'Set Red Spirit', N'15'), (N'514', N'15', N'Set Light Plate', N'15'), (N'515', N'15', N'Set Adamantine', N'15'), (N'516', N'15', N'Set Dark Steel', N'15'), (N'517', N'15', N'Set Dark Master', N'15'), (N'518', N'15', N'Set Dragon Knight', N'15'), (N'519', N'15', N'Set Venom Mist', N'15'), (N'520', N'15', N'Set Sylpid Ray', N'15'), (N'521', N'15', N'Set Volcano', N'15'), (N'522', N'15', N'Set Sunlight', N'15'), (N'523', N'15', N'Set Ashcrow', N'15'), (N'524', N'15', N'Set Eclips', N'15'), (N'525', N'15', N'Set Iris', N'15'), (N'526', N'15', N'Set Valiant', N'15'), (N'527', N'15', N'Set Glorious', N'15'), (N'528', N'15', N'Set Ancient', N'15'), (N'529', N'15', N'Set Red Wing', N'15'), (N'530', N'15', N'Set Violent Wind', N'15'), (N'531', N'15', N'Set Demonic', N'15'), (N'532', N'15', N'Set Storm Blitz', N'15'), (N'533', N'15', N'Set Eternal Wing', N'15'), (N'534', N'15', N'Set Titanium', N'15'), (N'535', N'15', N'Set Brave', N'15'), (N'536', N'15', N'Set Hades', N'15'), (N'537', N'15', N'Set Seraphim', N'15'), (N'538', N'15', N'Set Divine', N'15'), (N'539', N'15', N'Set Phamtom', N'15'), (N'540', N'15', N'Set Destroyer', N'15'), (N'541', N'15', N'Set Royal', N'15'), (N'542', N'15', N'Set Succubus', N'15'), (N'543', N'16', N'Set Bronze 3', N'16'), (N'544', N'16', N'Set Dragon 3', N'16'), (N'545', N'16', N'Set Pad 3', N'16'), (N'546', N'16', N'Set Legendary 3', N'16'), (N'547', N'16', N'Set Bone 3', N'16'), (N'548', N'16', N'Set Leather 3', N'16'), (N'549', N'16', N'Set Scale 3', N'16'), (N'550', N'16', N'Set Sphinx 3', N'16'), (N'551', N'16', N'Set Brass 3', N'16'), (N'552', N'16', N'Set Plate 3', N'16'), (N'553', N'16', N'Set Vine 3', N'16'), (N'554', N'16', N'Set Silk 3', N'16'), (N'555', N'16', N'Set Wind 3', N'16'), (N'556', N'16', N'Set Spirit 3', N'16'), (N'557', N'16', N'Set Guardian 3', N'16'), (N'558', N'16', N'Set Storm Crow 3', N'16'), (N'559', N'16', N'Set Black Dragon 3', N'16'), (N'560', N'16', N'Set Dark Phoenix 3', N'16'), (N'561', N'16', N'Set Grand Soul 3', N'16'), (N'562', N'16', N'Set Holy Spirit 3', N'16'), (N'563', N'16', N'Set Thunder Hawk 3', N'16'), (N'564', N'16', N'Set Great Dragon 3', N'16'), (N'565', N'16', N'Set Dark Soul 3', N'16'), (N'566', N'16', N'Set Hurricane 3', N'16'), (N'567', N'16', N'Set Red Spirit 3', N'16'), (N'568', N'16', N'Set Light Plate 3', N'16'), (N'569', N'16', N'Set Adamantine 3', N'16'), (N'570', N'16', N'Set Dark Steel 3', N'16'), (N'571', N'16', N'Set Dark Master 3', N'16'), (N'572', N'16', N'Set Dragon Knight 3', N'16'), (N'573', N'16', N'Set Venom Mist 3', N'16'), (N'574', N'16', N'Set Sylpid Ray 3', N'16'), (N'575', N'16', N'Set Volcano 3', N'16'), (N'576', N'16', N'Set Sunlight 3', N'16'), (N'577', N'16', N'Set Ashcrow 3', N'16'), (N'578', N'16', N'Set Eclips 3', N'16'), (N'579', N'16', N'Set Iris 3', N'16'), (N'580', N'16', N'Set Valiant 3', N'16'), (N'581', N'16', N'Set Glorious 3', N'16'), (N'582', N'16', N'Set Ancient 3', N'16'), (N'583', N'16', N'Set Red Wing 3', N'16'), (N'584', N'16', N'Set Violent Wind 3', N'16'), (N'585', N'16', N'Set Demonic 3', N'16'), (N'586', N'16', N'Set Storm Blitz 3', N'16'), (N'587', N'16', N'Set Eternal Wing 3', N'16'), (N'588', N'16', N'Set Titanium 3', N'16'), (N'589', N'16', N'Set Brave 3', N'16'), (N'590', N'16', N'Set Hades 3', N'16'), (N'591', N'16', N'Set Seraphim 3', N'16'), (N'592', N'16', N'Set Divine 3', N'16'), (N'593', N'16', N'Set Phamtom 3', N'16'), (N'594', N'16', N'Set Destroyer 3', N'16'), (N'595', N'16', N'Set Royal 3', N'16'), (N'596', N'16', N'Set Succubus 3', N'16'), (N'597', N'17', N'Set Hyperion Bronze', N'17'), (N'598', N'17', N'Set Garuda Brass', N'17'), (N'599', N'17', N'Set Kantata Plate', N'17')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'600', N'17', N'Set Knight Leather', N'17'), (N'601', N'17', N'Set Eplete Scale', N'17'), (N'602', N'17', N'Set Hyon Dragon', N'17'), (N'603', N'17', N'Set Apollo Pad', N'17'), (N'604', N'17', N'Set Evis Bone', N'17'), (N'605', N'17', N'Set Anubis Legendary', N'17'), (N'606', N'17', N'Set Heras Sphinx', N'17'), (N'607', N'17', N'Set Seto vine', N'17'), (N'608', N'17', N'Set Gaya Silk', N'17'), (N'609', N'17', N'Set Argo Spirit', N'17'), (N'610', N'17', N'Set Odin Wind', N'17'), (N'611', N'17', N'Set Gywen Guardian', N'17'), (N'612', N'17', N'Set Gayon Strom Crow', N'17'), (N'613', N'18', N'Small Shield', N'1'), (N'614', N'18', N'Horn Shield', N'1'), (N'615', N'18', N'Kite Shield', N'1'), (N'616', N'18', N'Elven Shield', N'1'), (N'617', N'18', N'Buckler', N'1'), (N'618', N'18', N'Dragon Slayer Shield', N'1'), (N'619', N'18', N'Skull Shield', N'1'), (N'620', N'18', N'Spike Shield', N'1'), (N'621', N'18', N'Tower Shield', N'1'), (N'622', N'18', N'Plate Shield', N'1'), (N'623', N'18', N'Large Round Shield', N'1'), (N'624', N'18', N'Serpent Shield', N'1'), (N'625', N'18', N'Bronze Shield', N'1'), (N'626', N'18', N'Dragon Shield', N'1'), (N'627', N'18', N'Legendary Shield', N'1'), (N'628', N'18', N'Grand Soul Shield', N'1'), (N'629', N'18', N'Elemental Shield', N'1'), (N'630', N'18', N'Crimson Glory Shield', N'1'), (N'631', N'18', N'Salamander Shield', N'1'), (N'632', N'18', N'Frost Barrier Shield', N'1'), (N'633', N'18', N'Guardian Shield', N'1'), (N'634', N'19', N'Light Spear', N'1'), (N'635', N'19', N'Spear', N'1'), (N'636', N'19', N'Dragon Lance', N'1'), (N'637', N'19', N'Great Trident', N'1'), (N'638', N'19', N'Serpent Spear', N'1'), (N'639', N'19', N'Double Poleaxe', N'1'), (N'640', N'19', N'Halberd', N'1'), (N'641', N'19', N'Berdysh', N'1'), (N'642', N'19', N'Great Scythe', N'1'), (N'643', N'19', N'Bill of Balrog', N'1'), (N'644', N'19', N'Dragon Spear', N'1'), (N'645', N'20', N'Skull Staff', N'1'), (N'646', N'20', N'Angelic Staff', N'1'), (N'647', N'20', N'Serpent Staff', N'1'), (N'648', N'20', N'Thunder Staff', N'1'), (N'649', N'20', N'Gorgon Staff', N'1'), (N'650', N'20', N'Legendary Staff', N'1'), (N'651', N'20', N'Staff of Resurrection', N'1'), (N'652', N'20', N'Chaos Lightning Staff', N'1'), (N'653', N'20', N'Staff of Destruction', N'1'), (N'654', N'20', N'Dragon Soul Staff', N'1'), (N'655', N'20', N'Divine Staff of Archangel', N'1'), (N'656', N'20', N'Staff of Kundun', N'1'), (N'657', N'20', N'Grand Viper Staff', N'1'), (N'658', N'20', N'Platina Staff', N'1'), (N'659', N'20', N'Deadly Staff', N'1'), (N'660', N'20', N'Inberial Staff', N'1'), (N'661', N'20', N'Summon Spirit Stick', N'1'), (N'662', N'20', N'Mystery Stick', N'1'), (N'663', N'20', N'Violent Wind Stick', N'1'), (N'664', N'20', N'Red Wing Stick', N'1'), (N'665', N'20', N'Ancient Stick', N'1'), (N'666', N'20', N'Demonic Stick', N'1'), (N'667', N'20', N'Storm Blitz Stick', N'1'), (N'668', N'20', N'Eternal Wing Stick', N'1'), (N'669', N'20', N'Book of Shamut', N'1'), (N'670', N'20', N'Book of Neil', N'1'), (N'671', N'21', N'Kris', N'1'), (N'672', N'21', N'Short Sword', N'1'), (N'673', N'21', N'Rapier', N'1'), (N'674', N'21', N'Katana', N'1'), (N'675', N'21', N'Sword of Assassin', N'1'), (N'676', N'21', N'Blade', N'1'), (N'677', N'21', N'Gladius', N'1'), (N'678', N'21', N'Falchion', N'1'), (N'679', N'21', N'Serpent Sword', N'1'), (N'680', N'21', N'Sword of Salamander', N'1'), (N'681', N'21', N'Light Saber', N'1'), (N'682', N'21', N'Legendary Sword', N'1'), (N'683', N'21', N'Healical Sword', N'1'), (N'684', N'21', N'Double Blade', N'1'), (N'685', N'21', N'Lightning Sword', N'1'), (N'686', N'21', N'Giant Sword', N'1'), (N'687', N'21', N'Sword of Destruction', N'1'), (N'688', N'21', N'Dark Breaker', N'1'), (N'689', N'21', N'Thunder Sword', N'1'), (N'690', N'21', N'Divine Sword of Archangel', N'1'), (N'691', N'21', N'Knight Blade', N'1'), (N'692', N'21', N'Dark Reign Blade', N'1'), (N'693', N'21', N'Rune Blade', N'1'), (N'694', N'21', N'Crystal Sword', N'1'), (N'695', N'21', N'Bone Blade', N'1'), (N'696', N'21', N'Explosion Blade', N'1'), (N'697', N'21', N'Abs Scep Archangel', N'1'), (N'698', N'21', N'DayBreak', N'1'), (N'699', N'21', N'Sword Dancer', N'1')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'700', N'21', N'Flameberge ', N'1'), (N'701', N'21', N'Sword Breacker', N'1'), (N'702', N'21', N'Rune Bastard Sword', N'1'), (N'703', N'22', N'Wings of Elf', N'1'), (N'704', N'22', N'Wings of Heaven', N'1'), (N'705', N'22', N'Wings of Satan', N'1'), (N'706', N'22', N'Wing of Spirits', N'1'), (N'707', N'22', N'Wing of Soul', N'1'), (N'708', N'22', N'Wing of Dragon', N'1'), (N'709', N'22', N'Wing of Darkness', N'1'), (N'710', N'22', N'Cape of Lord', N'1'), (N'711', N'22', N'Wings of Storm', N'1'), (N'712', N'22', N'Wing of Eternal', N'1'), (N'713', N'22', N'Wings of Illusion', N'1'), (N'714', N'22', N'Wing of Ruin', N'1'), (N'715', N'22', N'Cape of Emperor', N'1'), (N'716', N'22', N'Wing of Curse', N'1'), (N'717', N'22', N'Wings of Despair', N'1'), (N'718', N'22', N'Wing of Dimension', N'1'), (N'719', N'15', N'Set de Anillos y Pend', N'1'), (N'720', N'9', N'Fros Mace', N'1'), (N'721', N'17', N'Set Vicious Dragon', N'17'), (N'722', N'17', N'Set Isis Legendary', N'17'), (N'723', N'17', N'Set Aruane Guardian', N'17'), (N'724', N'17', N'Set Muren Strom Crow', N'17'), (N'725', N'17', N'Set Agnis Adamantine', N'17'), (N'726', N'17', N'Set Browii Adamantine', N'17'), (N'727', N'17', N'Set Krono Red Wing', N'17'), (N'728', N'17', N'Set Semeden Red Wing', N'17'), (N'729', N'20', N'Book of Lagle', N'1'), (N'730', N'19', N'Brova Spear', N'1'), (N'731', N'4', N'Aileen Bow', N'1'), (N'732', N'18', N'Cross Shield', N'0'), (N'733', N'20', N'Chrome Staff', N'1'), (N'734', N'20', N'Raven Stick', N'1'), (N'735', N'14', N'Stryker Scepter', N'1'), (N'736', N'24', N'Set Titanium 3 Sock', N'1'), (N'737', N'24', N'Set Brave 3 Sock', N'1'), (N'738', N'24', N'Set Hades 3 Sock', N'1'), (N'739', N'24', N'Set Seraphim 3 Sock', N'1'), (N'740', N'24', N'Set Divine 3 Sock', N'1'), (N'741', N'24', N'Set Phamtom 3 Sock', N'1'), (N'742', N'24', N'Set Destroyer 3 Sock', N'1'), (N'743', N'24', N'Set Royal 3 Sock', N'1'), (N'744', N'24', N'Set Succubus 3 Sock', N'1'), (N'745', N'17', N'Set Mist Bronze', N'1'), (N'746', N'17', N'Set Anonymous Leather', N'1'), (N'747', N'17', N'Set Berserker Scale', N'1'), (N'748', N'17', N'Set Cloud Brass', N'1'), (N'749', N'17', N'Set Rave Plate', N'1'), (N'750', N'17', N'Set Barnake Pad', N'1'), (N'751', N'17', N'Set Sylion Bone', N'1'), (N'752', N'17', N'Set Minet Sphinx', N'1'), (N'753', N'17', N'Set Drake Vine', N'1'), (N'754', N'17', N'Set Fase Silk', N'1'), (N'755', N'17', N'Set Elvian Wind', N'1'), (N'756', N'17', N'Set Karis Spirit', N'1'), (N'757', N'23', N'Set Full Hyperion Bronze', N'1'), (N'758', N'23', N'Set Full Garuda Brass', N'1'), (N'759', N'23', N'Set Full Kantata Plate', N'1'), (N'760', N'23', N'Set Full Knight Leather', N'1'), (N'761', N'23', N'Set Full Eplete Scale', N'1'), (N'762', N'23', N'Set Full Hyon Dragon', N'1'), (N'763', N'23', N'Set Full Apollo Pad', N'1'), (N'764', N'23', N'Set Full Evis Bone', N'1'), (N'765', N'23', N'Set Full Anubis Legendary', N'1'), (N'766', N'23', N'Set Full Heras Sphinx', N'1'), (N'767', N'23', N'Set Full Seto vine', N'1'), (N'768', N'23', N'Set Full Gaya Silk', N'1'), (N'769', N'23', N'Set Full Argo Spirit', N'1'), (N'770', N'23', N'Set Full Odin Wind', N'1'), (N'771', N'23', N'Set Full Gywen Guardian', N'1'), (N'772', N'23', N'Set Full Gayon Strom Crow', N'1'), (N'773', N'23', N'Set Full Vicious Dragon', N'1'), (N'774', N'23', N'Set Full Isis Legendary', N'1'), (N'775', N'23', N'Set Full Aruane Guardian', N'1'), (N'776', N'23', N'Set Full Muren Strom Crow', N'1'), (N'777', N'23', N'Set Full Agnis Adamantine', N'1'), (N'778', N'23', N'Set Full Browii Adamantine', N'1'), (N'779', N'23', N'Set Full Krono Red Wing', N'1'), (N'780', N'23', N'Set Full Semeden Red Wing', N'1'), (N'781', N'23', N'Set Full Mist Bronze', N'1'), (N'782', N'23', N'Set Full Anonymous Leather', N'1'), (N'783', N'23', N'Set Full Berserker Scale', N'1'), (N'784', N'23', N'Set Full Cloud Brass', N'1'), (N'785', N'23', N'Set Full Rave Plate', N'1'), (N'786', N'23', N'Set Full Barnake Pad', N'1'), (N'787', N'23', N'Set Full Sylion Bone', N'1'), (N'788', N'23', N'Set Full Minet Sphinx', N'1'), (N'789', N'23', N'Set Full Drake Vine', N'1'), (N'790', N'23', N'Set Full Fase Silk', N'1'), (N'791', N'23', N'Set Full Elvian Wind', N'1'), (N'792', N'23', N'Set Full Karis Spirit', N'1'), (N'793', N'15', N'Set Sacred', N'15'), (N'794', N'15', N'Set Holly Storm', N'15'), (N'795', N'15', N'Set Piercing', N'15'), (N'796', N'16', N'Set Sacred 3', N'16'), (N'797', N'16', N'Set Holly Storm 3', N'16'), (N'798', N'16', N'Set Piercing 3', N'16'), (N'799', N'21', N'Sacred Glove', N'1')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'800', N'21', N'Holly Storm Glove', N'1'), (N'801', N'21', N'Piercing Blade Glove', N'1'), (N'802', N'1', N'Sacred Armor', N'1'), (N'803', N'1', N'Storm Jahad Armor', N'1'), (N'804', N'1', N'Piercing Armor', N'1'), (N'805', N'3', N'Sacred Boots', N'3'), (N'806', N'3', N'Storm Jahad Boots', N'3'), (N'807', N'3', N'Piercing Boots', N'3'), (N'808', N'8', N'Sacred Helm', N'8'), (N'809', N'8', N'Storm Jahad Helm', N'8'), (N'810', N'8', N'Piercing Helm', N'8'), (N'811', N'10', N'Sacred Pants', N'10'), (N'812', N'10', N'Storm Jahad Pants', N'10'), (N'813', N'10', N'Piercing Pants', N'10'), (N'814', N'22', N'Cape of Fighter', N'1'), (N'815', N'22', N'Cape of Overrule', N'1'), (N'816', N'25', N'Set Titanium Sk5', N'1'), (N'817', N'25', N'Set Brave Sk5', N'1'), (N'818', N'25', N'Set Hades Sk5', N'1'), (N'819', N'25', N'Set Seraphim Sk5', N'1'), (N'820', N'25', N'Set Divine Sk5', N'1'), (N'821', N'25', N'Set Phantom Sk5', N'1'), (N'822', N'25', N'Set Destroyer Sk5', N'1'), (N'823', N'25', N'Set Royal Sk5', N'1'), (N'824', N'25', N'Set Succubus Sk5', N'1'), (N'825', N'21', N'Flameberge Sk5', N'1'), (N'826', N'21', N'Sword Bracker Sk5', N'1'), (N'827', N'21', N'Rune Bastard Sword SK5', N'1'), (N'828', N'18', N'Crismon Shield Sk5', N'1'), (N'829', N'18', N'Salamander Shield Sk5', N'1'), (N'830', N'18', N'Frost Shield Sk5', N'1'), (N'831', N'18', N'Guardian Shield Sk5', N'1'), (N'832', N'18', N'Cross Shield Sk5', N'1'), (N'833', N'14', N'Absolute Scepter Sk5', N'1'), (N'834', N'20', N'Inberial Staff Sk5', N'1'), (N'835', N'20', N'Summon Spirit Stick Sk5', N'1'), (N'836', N'4', N'Dark Stinger Sk5', N'1'), (N'837', N'20', N'Deadly Staff Sk5', N'1'), (N'838', N'17', N'Set Vega Sacred', N'1'), (N'839', N'17', N'Set Chamereuui Sacred', N'1'), (N'840', N'23', N'Set Full Vega Sacred', N'1'), (N'841', N'23', N'Set Full Chamereuui Sacred', N'1'), (N'842', N'13', N'Ropa Hades Sk5', N'13'), (N'843', N'13', N'Ropa Brave Sk5', N'13'), (N'844', N'13', N'Ropa Destroyer Sk5', N'13'), (N'845', N'13', N'Ropa Paewang Sk5', N'13'), (N'846', N'13', N'Ropa Faith Sk5', N'13'), (N'847', N'13', N'Ropa Seraphim Sk5', N'13'), (N'848', N'13', N'Ropa Queen Sk5', N'13'), (N'849', N'13', N'Ropa Phantom Sk5', N'13'), (N'850', N'15', N'Set Phoenix Soul', N'15'), (N'851', N'16', N'Set Phoenix Soul 3', N'16'), (N'852', N'25', N'Set Phoenix Soul Sk5', N'1'), (N'853', N'1', N'Phoenix Soul Armor', N'1'), (N'854', N'3', N'Phoenix Soul Boots', N'3'), (N'855', N'7', N'Phoenix Soul Gloves', N'7'), (N'856', N'8', N'Phoenix Soul Helm', N'8'), (N'857', N'10', N'Phoenix Soul Pants', N'10'), (N'858', N'21', N'Phoenix Soul Star', N'1'), (N'859', N'21', N'Phoenix Soul Star Sk5', N'1'), (N'860', N'20', N'Divine Stick Archangel', N'1'), (N'861', N'20', N'Divine Stick Archangel Sk5', N'1'), (N'862', N'13', N'Ropa Titanium SK5', N'13'), (N'863', N'13', N'Ropa Soul Phoenix', N'13'), (N'864', N'13', N'Ropa Soul Phoenix SK5', N'13'), (N'865', N'12', N'Kantata Ring of Wind', N'1'), (N'866', N'12', N'Kantata Ring of Poison ', N'1'), (N'867', N'12', N'Warrior Ring of Ice', N'1'), (N'868', N'12', N'Apollo Ring of Magic', N'1'), (N'869', N'12', N'Anubis Ring of Fire', N'1'), (N'870', N'12', N'Ceto Ring of Earth', N'1'), (N'871', N'12', N'Vicious Ring of Earth', N'1'), (N'872', N'12', N'Agnis Ring of Poison', N'1'), (N'873', N'11', N'Eplete Pendant of Ligthinng ', N'1'), (N'874', N'11', N'Garuda Pendant of Fire', N'1'), (N'875', N'11', N'Apollo Pendant of Ice', N'1'), (N'876', N'11', N'Evis Pendant of Wind', N'1'), (N'877', N'11', N'Gywen Pendant of Ability', N'1'), (N'878', N'11', N'Gaion Pendant of Water', N'1'), (N'879', N'11', N'Broy Pendant of Ice ', N'1'), (N'880', N'12', N'Muren Ring of Fire', N'1'), (N'881', N'12', N'Krono Ring of Magic', N'1'), (N'882', N'1', N'Lazy Wind Armor', N'1'), (N'883', N'7', N'Lazy Wind Gloves', N'7'), (N'884', N'3', N'Lazy Wind Boots', N'3'), (N'885', N'10', N'Lazy Wind Pants', N'10'), (N'886', N'21', N'Rune Bastard Sword SK5-2', N'1'), (N'887', N'1', N'Stormwing Armor', N'1'), (N'888', N'1', N'Dark Devil Armor', N'1'), (N'889', N'1', N'Sticky Armor', N'1'), (N'890', N'1', N'Light Lord Armor', N'1'), (N'891', N'1', N'Hell Night Armor', N'1'), (N'892', N'26', N'Brave Helm SK5', N'1'), (N'893', N'26', N'Titan Helm SK5', N'1'), (N'894', N'26', N'Hades Helm SK5', N'1'), (N'895', N'26', N'Seraphim Helm SK5', N'1'), (N'896', N'26', N'Divine Helm SK5', N'1'), (N'897', N'26', N'Royal tHelm SK5', N'1'), (N'898', N'26', N'Eternal Wing Gloves SK5', N'1'), (N'899', N'26', N'Phoenix Soul Helm SK5', N'1')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'900', N'26', N'Lazy Wind Helm SK5', N'1'), (N'901', N'26', N'Stormwing Helm SK5', N'1'), (N'902', N'26', N'Dark Devil Helm SK5', N'1'), (N'903', N'26', N'Sticky Helm SK5', N'1'), (N'904', N'26', N'Light Lord Helm SK5', N'1'), (N'905', N'26', N'Ambition Helm SK5', N'1'), (N'906', N'27', N'Brave Armor SK5', N'1'), (N'907', N'27', N'Titan Armor SK5', N'1'), (N'908', N'27', N'Hades Armor SK5', N'1'), (N'909', N'27', N'Seraphim Armor SK5', N'1'), (N'910', N'27', N'Divine Armor SK5', N'1'), (N'911', N'27', N'Phantom Armor SK5', N'1'), (N'912', N'27', N'Destroy Armor SK5', N'1'), (N'913', N'27', N'Royal Armor SK5', N'1'), (N'914', N'27', N'Eternal Wing Armor SK5', N'1'), (N'915', N'27', N'Phoenix Soul Armor SK5', N'1'), (N'916', N'27', N'Lazy Wind Armor SK5', N'1'), (N'917', N'27', N'Stormwing Armor SK5', N'1'), (N'918', N'27', N'Dark Devil Armor SK5', N'1'), (N'919', N'27', N'Sticky Armor SK5', N'1'), (N'920', N'27', N'Light Lord Armor SK5', N'1'), (N'921', N'27', N'Hell Night Armor SK5', N'1'), (N'922', N'27', N'Magic Knight Armor SK5', N'1'), (N'923', N'27', N'Ambition Armor SK5', N'1'), (N'924', N'28', N'Brave Pants SK5', N'1'), (N'925', N'28', N'Titan Pants SK5', N'1'), (N'926', N'28', N'Hades Pants SK5', N'1'), (N'927', N'28', N'Seraphim Pants SK5', N'1'), (N'928', N'28', N'Divine Pants SK5', N'1'), (N'929', N'28', N'Phantom Pants SK5', N'1'), (N'930', N'28', N'Destroy Pants SK5', N'1'), (N'931', N'28', N'Royal Pants SK5', N'1'), (N'932', N'28', N'Eternal Wing Pants SK5', N'1'), (N'933', N'28', N'Phoenix Soul Pants SK5', N'1'), (N'934', N'28', N'Lazy Wind Pants SK5', N'1'), (N'935', N'28', N'Stormwing Pants SK5', N'1'), (N'936', N'28', N'Dark Devil Pants SK5', N'1'), (N'937', N'28', N'Sticky Pants SK5', N'1'), (N'938', N'28', N'Light Lord Pants SK5', N'1'), (N'939', N'28', N'Hell Night Pants SK5', N'1'), (N'940', N'28', N'Magic Knight Pants SK5', N'1'), (N'941', N'28', N'Ambition Pants SK5', N'1'), (N'942', N'29', N'Brave Gloves SK5', N'1'), (N'943', N'29', N'Titan Gloves SK5', N'1'), (N'944', N'29', N'Hades Gloves SK5', N'1'), (N'945', N'29', N'Seraphim Gloves SK5', N'1'), (N'946', N'29', N'Divine Gloves SK5', N'1'), (N'947', N'29', N'Phantom Gloves SK5', N'1'), (N'948', N'29', N'Destroy Gloves SK5', N'1'), (N'949', N'29', N'Royal Gloves SK5', N'1'), (N'950', N'29', N'Eternal Wing Gloves SK5', N'1'), (N'951', N'29', N'error', N'1'), (N'952', N'29', N'Lazy Wind Gloves SK5', N'1'), (N'953', N'29', N'Stormwing Gloves SK5', N'1'), (N'954', N'29', N'Dark Devil Gloves SK5', N'1'), (N'955', N'29', N'Sticky Gloves SK5', N'1'), (N'956', N'29', N'Light Lord Gloves SK5', N'1'), (N'957', N'29', N'Hell Night Gloves SK5', N'1'), (N'958', N'29', N'Magic Knight Gloves SK5', N'1'), (N'959', N'29', N'Ambition Gloves SK5', N'1'), (N'960', N'30', N'Brave Boots SK5', N'1'), (N'961', N'30', N'Titan Boots SK5', N'1'), (N'962', N'30', N'Hades Boots SK5', N'1'), (N'963', N'30', N'Seraphim Boots SK5', N'1'), (N'964', N'30', N'Divine Boots SK5', N'1'), (N'965', N'30', N'Phantom Boots SK5', N'1'), (N'966', N'30', N'Destroy Boots SK5', N'1'), (N'967', N'30', N'Royal Boots SK5', N'1'), (N'968', N'30', N'Eternal Wing Boots SK5', N'1'), (N'969', N'30', N'Phoenix Soul Boots SK5', N'1'), (N'970', N'30', N'Lazy Wind Boots SK5', N'1'), (N'971', N'30', N'Stormwing Boots SK5', N'1'), (N'972', N'30', N'Dark Devil Boots SK5', N'1'), (N'973', N'30', N'Sticky Boots SK5', N'1'), (N'974', N'30', N'Light Lord Boots SK5', N'1'), (N'975', N'30', N'Hell Night Boots SK5', N'1'), (N'976', N'30', N'Magic Knight Boots SK5', N'1'), (N'977', N'30', N'Ambition Boots SK5', N'1'), (N'978', N'26', N'Succubus Helm SK5', N'1'), (N'979', N'27', N'Succubus Armor SK5', N'1'), (N'980', N'28', N'Succubus Pants SK5', N'1'), (N'981', N'29', N'Succubus Gloves SK5', N'1'), (N'982', N'30', N'Succubus Boots SK5', N'1'), (N'983', N'21', N'Flameberge Sk5-2', N'1'), (N'984', N'21', N'Sword Bracker Sk5-2', N'1'), (N'985', N'21', N'Phoenix Soul Star Sk5-2', N'1'), (N'986', N'21', N'Bone Blade-2', N'1'), (N'987', N'21', N'Explosion Blade-2', N'1'), (N'988', N'21', N'DayBreak-2', N'1'), (N'989', N'21', N'Sword Dancer-2', N'1'), (N'990', N'21', N'Flameberge-2', N'1'), (N'991', N'21', N'Sword Breaker-2', N'1'), (N'992', N'21', N'Sacred Glove-2', N'1'), (N'993', N'21', N'Holly Storm Glove-2', N'1'), (N'994', N'21', N'Piercing Glove-2', N'1'), (N'995', N'21', N'Phoenix Soul Star-2', N'1'), (N'996', N'9', N'Mace of the King-2', N'1'), (N'997', N'20', N'Miracle Staff', N'1'), (N'998', N'20', N'Spite Staff', N'1'), (N'999', N'20', N'Miracle Staff SK5', N'1')
GO
GO
INSERT INTO [tb_items] ([cod_item], [cod_tipoitem], [descripcion], [precio]) VALUES (N'1000', N'20', N'Spite Staff SK5', N'1'), (N'1001', N'19', N'Magmus Peer', N'1'), (N'1002', N'19', N'Magmus Peer SK5', N'1'), (N'1003', N'18', N'Lazy Wind Shield', N'1'), (N'1004', N'18', N'Dark Devil Shield', N'1'), (N'1005', N'18', N'Light Lord Shield', N'1'), (N'1006', N'18', N'Magic Knight Shield', N'1'), (N'1007', N'18', N'Ambition Shield1', N'1'), (N'1008', N'18', N'Lazy Wind Shield SK5', N'1'), (N'1009', N'18', N'Dark Devil Shield SK5', N'1'), (N'1010', N'18', N'Light Lord Shield SK5', N'1'), (N'1011', N'18', N'Magic Knight Shield SK5', N'1'), (N'1012', N'18', N'Ambition Shield SK5', N'1'), (N'1013', N'14', N'Thunderbolt', N'1'), (N'1014', N'14', N'Thunderbolt SK5', N'1'), (N'1015', N'9', N'Horn of Steal', N'1'), (N'1016', N'9', N'Horn of Steal SK5', N'1'), (N'1017', N'5', N'Devil Crossbow', N'1'), (N'1018', N'5', N'Devil Crossbow SK5', N'1'), (N'1019', N'4', N'Angelic Bow', N'1'), (N'1020', N'4', N'Angelic Bow SK5', N'1'), (N'1021', N'21', N'Sonic Blade', N'1'), (N'1022', N'21', N'Cyclone Sword', N'1'), (N'1023', N'21', N'Asura', N'1'), (N'1024', N'21', N'Blast Break', N'1'), (N'1025', N'21', N'Sonick Blade SK5', N'1'), (N'1026', N'21', N'Cyclone Sword SK5', N'1'), (N'1027', N'21', N'Asura SK5', N'1'), (N'1028', N'21', N'Blast Break SK5', N'1'), (N'1029', N'22', N'Wings of Chaos 2.5', N'1'), (N'1030', N'22', N'Wings of Magic 2.5', N'1'), (N'1031', N'22', N'Wings of Life 2.5', N'1'), (N'1032', N'22', N'Cloak of Death 2.5', N'1'), (N'1033', N'1', N'Magic Knight Armor', N'1'), (N'1034', N'1', N'Ambition Armor', N'1'), (N'1035', N'1', N'.', N'1'), (N'1036', N'1', N'.', N'1'), (N'1037', N'1', N'.', N'1'), (N'1038', N'1', N'.', N'1'), (N'1039', N'1', N'.', N'1'), (N'1040', N'1', N'.', N'1'), (N'1041', N'1', N'.', N'1'), (N'1042', N'1', N'.', N'1'), (N'1043', N'3', N'Stormwing Boots', N'3'), (N'1044', N'3', N'Dark Devil Boots', N'3'), (N'1045', N'3', N'Sticky Boots', N'3'), (N'1046', N'3', N'Light Lord Boots', N'3'), (N'1047', N'3', N'Hell Night Boots', N'3'), (N'1048', N'3', N'Magic Knight Boots', N'3'), (N'1049', N'3', N'Ambition Boots', N'3'), (N'1050', N'7', N'Stormwing Gloves', N'7'), (N'1051', N'7', N'Dark Devil Gloves', N'7'), (N'1052', N'7', N'Sticky Gloves', N'7'), (N'1053', N'7', N'Light Lord Gloves', N'7'), (N'1054', N'7', N'Hell Night Gloves', N'7'), (N'1055', N'7', N'Magic Knight Gloves', N'7'), (N'1056', N'7', N'Ambition Gloves', N'7'), (N'1057', N'8', N'Lazy Wind Helm', N'8'), (N'1058', N'8', N'Stormwing Helm', N'8'), (N'1059', N'8', N'Dark Devil Helm', N'8'), (N'1060', N'8', N'Sticky Helm', N'8'), (N'1061', N'8', N'Light Lord Helmet', N'8'), (N'1062', N'8', N'Ambition Helm', N'8'), (N'1063', N'10', N'Stormwing Pants', N'10'), (N'1064', N'10', N'Dark Devil Pants', N'10'), (N'1065', N'10', N'Sticky Pants', N'10'), (N'1066', N'10', N'Light Lord Pants', N'10'), (N'1067', N'10', N'Hell Night Pants', N'10'), (N'1068', N'10', N'Magic Knight Pants', N'10'), (N'1069', N'10', N'Ambition Pants', N'10'), (N'1070', N'9', N'Frost Mace SK5', N'1')
GO
GO
SET IDENTITY_INSERT [tb_items] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for tb_raza
-- ----------------------------
DROP TABLE [tb_raza]
GO
CREATE TABLE [tb_raza] (
[cod_raza] int NOT NULL IDENTITY(1,1) ,
[identificador_raza] char(3) NOT NULL ,
[nombre_raza] varchar(50) NULL 
)


GO
DBCC CHECKIDENT(N'[tb_raza]', RESEED, 7)
GO

-- ----------------------------
-- Records of tb_raza
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tb_raza] ON
GO
INSERT INTO [tb_raza] ([cod_raza], [identificador_raza], [nombre_raza]) VALUES (N'1', N'BK ', N'Blade Knight'), (N'2', N'SM ', N'Soul Master'), (N'3', N'ELF', N'Fairy Elf'), (N'4', N'MG ', N'Magic Gladiator'), (N'5', N'DL ', N'Dark Lord'), (N'6', N'SUM', N'Summoner'), (N'7', N'RF ', N'Rage Fighter')
GO
GO
SET IDENTITY_INSERT [tb_raza] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for tb_tipoitem
-- ----------------------------
DROP TABLE [tb_tipoitem]
GO
CREATE TABLE [tb_tipoitem] (
[cod_tipoitem] int NOT NULL ,
[descripcion] varchar(100) NOT NULL 
)


GO

-- ----------------------------
-- Records of tb_tipoitem
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [tb_tipoitem] ([cod_tipoitem], [descripcion]) VALUES (N'1', N'Armors'), (N'2', N'Axes'), (N'3', N'Boots'), (N'4', N'Bows'), (N'5', N'Crossbows'), (N'6', N'Fenrirs'), (N'7', N'Gloves'), (N'8', N'Helms'), (N'9', N'Maces'), (N'10', N'Pants'), (N'11', N'Pendants'), (N'12', N'Rings'), (N'13', N'Ropas'), (N'14', N'Scepters'), (N'15', N'Sets'), (N'16', N'Sets 3'), (N'17', N'Sets Acc.'), (N'18', N'Shields'), (N'19', N'Spears'), (N'20', N'Staff'), (N'21', N'Swords'), (N'22', N'Wings'), (N'23', N'Sets Acc.+ Full'), (N'24', N'Sets 3 + Socket'), (N'25', N'Sets 3 + Socket 5'), (N'26', N'1.Helms Sk5'), (N'27', N'2.Armors SK5'), (N'28', N'3.Pants SK5'), (N'29', N'4.Gloves SK5'), (N'30', N'5. Boots SK5')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for tb_usuario
-- ----------------------------
DROP TABLE [tb_usuario]
GO
CREATE TABLE [tb_usuario] (
[cod_usuario] varchar(100) NOT NULL ,
[password] varchar(100) NOT NULL ,
[tipousuario] varchar(100) NOT NULL 
)


GO


-- ----------------------------
-- Table structure for tb_venta
-- ----------------------------
DROP TABLE [tb_venta]
GO
CREATE TABLE [tb_venta] (
[cod_venta] int NOT NULL IDENTITY(1000,1) ,
[cod_item] int NOT NULL ,
[serie] varchar(100) NOT NULL ,
[cod_usuario] varchar(100) NOT NULL ,
[id_jugador] varchar(100) NOT NULL ,
[nombresapellidos] varchar(100) NOT NULL ,
[fecha_venta] smalldatetime NOT NULL ,
[modalidad] varchar(100) NOT NULL ,
[fecha_deposito] smalldatetime NULL ,
[mtcn] varchar(20) NULL ,
[estado] varchar(100) NOT NULL ,
[cantidad] int NOT NULL ,
[precioventa] float(53) NOT NULL ,
[observacion] varchar(500) NOT NULL ,
[nivel] int NOT NULL DEFAULT (13) 
)


-- ----------------------------
-- Procedure structure for actualizarbloqueo
-- ----------------------------
DROP PROCEDURE [actualizarbloqueo]
GO

/*Procedure para actulizar datos de bloqueo*/

create procedure [actualizarbloqueo]	
@cod_bloqueo int,
@sancion  varchar(100),
@razonbloqueo  varchar(200)
as 
update tb_bloqueo 
set sancion=@sancion,razonbloqueo=@razonbloqueo
where cod_bloqueo=@cod_bloqueo



GO

-- ----------------------------
-- Procedure structure for actualizarCambioNombre
-- ----------------------------
DROP PROCEDURE [actualizarCambioNombre]
GO

/*procedure para actualizar el cambio de nombre*/
CREATE procedure [actualizarCambioNombre]
@cod_cambio int,
@idAntiguo varchar(100),
@idNuevo varchar(100),
@nickAntiguo varchar(100),
@nickNuevo varchar(100),
@cod_raza integer,
@cantResets int
as
UPDATE tb_cambionombre
   SET 
	idAntiguo = @idAntiguo,
	nickAntiguo= @nickAntiguo,
	idNuevo=@idNuevo,
	nickNuevo=@nickNuevo,
	cod_raza=@cod_raza,
	cantResets=@cantResets
 WHERE cod_cambio=@cod_cambio


GO

-- ----------------------------
-- Procedure structure for agregarbloqueo
-- ----------------------------
DROP PROCEDURE [agregarbloqueo]
GO



/*Procedure para bloqueo de cuentas */


/*Agregar bloqueo de cuenta*/
create procedure [agregarbloqueo]	
@fecha_bloqueo smalldatetime,
@cod_usuario  varchar(100),
@id_jugador  varchar(100),
@personaje  varchar(100),
@razonbloqueo  varchar(200),	
@sancion  varchar(100)
as insert into tb_bloqueo values(@fecha_bloqueo,
@cod_usuario,@id_jugador,@personaje,'Bloqueada',
@razonbloqueo,@sancion,null)



GO

-- ----------------------------
-- Procedure structure for agregarcambionombre
-- ----------------------------
DROP PROCEDURE [agregarcambionombre]
GO

/*Procedure para insertar una nueva 
cambio nombre*/
CREATE procedure [agregarcambionombre]
@cod_usuario  varchar(100)  ,
@idAntiguo  varchar(100)    ,
@nickAntiguo  varchar(100)    ,
@idNuevo  varchar(100)    ,
@nickNuevo  varchar(100)   ,
@cantResets  int,
@fechacambio smalldatetime,
@pagado float,
@cod_raza integer, 
@mtcn varchar(20),
@modalidad varchar(100),
@fecha_deposito smalldatetime
as
insert into tb_cambionombre (cod_usuario
           ,idAntiguo
           ,nickAntiguo
           ,idNuevo
           ,nickNuevo
           ,cantResets
           ,fechacambio
           ,pagado,cod_raza,mtcn,modalidad,fecha_deposito)values(@cod_usuario,
@idAntiguo,@nickAntiguo,@idNuevo,@nickNuevo,@cantResets,@fechacambio,@pagado,
@cod_raza,@mtcn,@modalidad,@fecha_deposito)


GO

-- ----------------------------
-- Procedure structure for agregarItem
-- ----------------------------
DROP PROCEDURE [agregarItem]
GO



/*Procedure que Agrega un Item*/
create procedure [agregarItem]
@cod_tipoitem         int,
@descripcion          varchar(100),
@precio               float
as 
insert into tb_items 
values(@cod_tipoitem,@descripcion,@precio)



GO

-- ----------------------------
-- Procedure structure for agregarUsuario
-- ----------------------------
DROP PROCEDURE [agregarUsuario]
GO


/*Procedure que agrega usuario*/
create procedure [agregarUsuario] 
@cod_usuario          varchar(100) ,
@password             varchar(100),
@tipousuario		  varchar(100)
as insert into tb_usuario 
values(@cod_usuario,@password,@tipousuario)



GO

-- ----------------------------
-- Procedure structure for anularCambioDatos
-- ----------------------------
DROP PROCEDURE [anularCambioDatos]
GO


create procedure [anularCambioDatos]
@cod_cambiodatos integer,
@observacion varchar(500)
as
update tb_cambiodatos
set estado = 'Anulado', observacion = @observacion
where cod_cambiodatos = @cod_cambiodatos



GO

-- ----------------------------
-- Procedure structure for anularCambioNombre
-- ----------------------------
DROP PROCEDURE [anularCambioNombre]
GO


create procedure [anularCambioNombre]
@cod_cambio int
as 
update tb_cambionombre
set estado = 'ANULADO'
where cod_cambio=@cod_cambio



GO

-- ----------------------------
-- Procedure structure for anularventa
-- ----------------------------
DROP PROCEDURE [anularventa]
GO



/*Anula la venta*/
create procedure [anularventa]
@cod_venta as int,
@cod_item as int,
@serie as varchar(100)
as 
update tb_venta 
set estado = 'Anulada'
where cod_venta = @cod_venta 
and cod_item = @cod_item 
and serie = @serie COLLATE SQL_Latin1_General_Cp1_CS_AS



GO

-- ----------------------------
-- Procedure structure for bloqueoxlogin
-- ----------------------------
DROP PROCEDURE [bloqueoxlogin]
GO





/*listar bloqueo x login*/
create procedure [bloqueoxlogin]
@id_jugador varchar(50)
as select 
fecha_bloqueo as 'Fecha',cod_usuario as 'Vendedor',
id_jugador as 'Login', personaje as 'Personaje',
estado as 'Estado',razonbloqueo as 'R.Bloqueo',
sancion as 'Sancion',razondesbloqueo as 'R.Desbloqueo',
cod_bloqueo as 'C.Bloqueo'
from tb_bloqueo 
where id_jugador =@id_jugador COLLATE SQL_Latin1_General_Cp1_CS_AS 
and estado = 'Bloqueada'
order by cod_bloqueo desc



GO

-- ----------------------------
-- Procedure structure for bloqueoxloginhistorico
-- ----------------------------
DROP PROCEDURE [bloqueoxloginhistorico]
GO



/*listar bloqueo x login historco*/
create procedure [bloqueoxloginhistorico]
@id_jugador varchar(50)
as select 
fecha_bloqueo as 'Fecha',cod_usuario as 'Vendedor',
id_jugador as 'Login', personaje as 'Personaje',
estado as 'Estado',razonbloqueo as 'R.Bloqueo',
sancion as 'Sancion',razondesbloqueo as 'R.Desbloqueo',
cod_bloqueo as 'C.Bloqueo'
from tb_bloqueo
where id_jugador =@id_jugador COLLATE SQL_Latin1_General_Cp1_CS_AS 
order by cod_bloqueo desc

GO

-- ----------------------------
-- Procedure structure for buscarCambioDatos
-- ----------------------------
DROP PROCEDURE [buscarCambioDatos]
GO

create procedure [buscarCambioDatos]
@idcuenta varchar(100),
@mtcn varchar(20),
@fechainicio smalldatetime,
@fechafin smalldatetime,
@tipo integer 
as 


--busqueda por idcuenta
if @idcuenta is not null and @tipo = 1
--query 
select
cod_usuario as 'Vendedor',
cod_cambiodatos as 'Codigo',
idcuenta as 'ID cuenta',
proantiguo as 'Antiguo Prop.',
pronuevo as 'Nuevo Prop.',
fecha as 'Fecha',
modalidad as 'Mod. Pago',
estado as 'Estado'
from tb_cambiodatos 
where idcuenta = @idcuenta  COLLATE SQL_Latin1_General_Cp1_CS_AS 
and estado = 'Normal'
order by fecha desc 


--busqueda por idcuenta historico
if @idcuenta is not null and @tipo = 2
--query
select
cod_usuario as 'Vendedor',
cod_cambiodatos as 'Codigo',
idcuenta as 'ID cuenta',
proantiguo as 'Antiguo Prop.',
pronuevo as 'Nuevo Prop.',
fecha as 'Fecha',
modalidad as 'Mod. Pago',
estado as 'Estado'
from tb_cambiodatos 
where idcuenta = @idcuenta  COLLATE SQL_Latin1_General_Cp1_CS_AS 
order by fecha desc 


--busqueda por mtcn
else if @mtcn is not null and @tipo = 1
--query 
select
cod_usuario as 'Vendedor',
cod_cambiodatos as 'Codigo',
idcuenta as 'ID cuenta',
proantiguo as 'Antiguo Prop.',
pronuevo as 'Nuevo Prop.',
fecha as 'Fecha',
modalidad as 'Mod. Pago',
estado as 'Estado'
from tb_cambiodatos 
where mtcn = mtcn 
and estado = 'Normal'
order by fecha desc 


--busqueda por mtcn historicpo 
else if @mtcn is not null and @tipo = 2
--query 
select
cod_usuario as 'Vendedor',
cod_cambiodatos as 'Codigo',
idcuenta as 'ID cuenta',
proantiguo as 'Antiguo Prop.',
pronuevo as 'Nuevo Prop.',
fecha as 'Fecha',
modalidad as 'Mod. Pago',
estado as 'Estado'
from tb_cambiodatos 
where mtcn = mtcn 
order by fecha desc 


--busqueda por fechas 
else if @fechainicio is not null and @tipo = 1
--query 
select
cod_usuario as 'Vendedor',
cod_cambiodatos as 'Codigo',
idcuenta as 'ID cuenta',
proantiguo as 'Antiguo Prop.',
pronuevo as 'Nuevo Prop.',
fecha as 'Fecha',
modalidad as 'Mod. Pago',
estado as 'Estado'
from tb_cambiodatos 
where fecha between @fechainicio and @fechafin 
and estado = 'Normal'
order by fecha desc 

--busqueda por fechas historico
else if @fechainicio is not null and @tipo = 2
--query 
select
cod_usuario as 'Vendedor',
cod_cambiodatos as 'Codigo',
idcuenta as 'ID cuenta',
proantiguo as 'Antiguo Prop.',
pronuevo as 'Nuevo Prop.',
fecha as 'Fecha',
modalidad as 'Mod. Pago',
estado as 'Estado'
from tb_cambiodatos  
where fecha between @fechainicio and @fechafin 
order by fecha desc 


GO

-- ----------------------------
-- Procedure structure for cambiarClave
-- ----------------------------
DROP PROCEDURE [cambiarClave]
GO
create procedure [cambiarClave]
@cod_usuario          varchar(100) ,
@password             varchar(100)
as 
update tb_usuario set password=@password
where cod_usuario=@cod_usuario
GO

-- ----------------------------
-- Procedure structure for cambiarTipo
-- ----------------------------
DROP PROCEDURE [cambiarTipo]
GO
create procedure [cambiarTipo]
@cod_usuario          varchar(100) ,
@tipousuario		  varchar(100)
as 
update tb_usuario set tipousuario=@tipousuario
where cod_usuario=@cod_usuario
GO

-- ----------------------------
-- Procedure structure for cambioitemoset
-- ----------------------------
DROP PROCEDURE [cambioitemoset]
GO



/*Procedure procedure que cambia la venta a cambiada*/
create procedure [cambioitemoset]
@cod_venta as int,
@cod_item as int,
@serie as varchar(100)
as 
update tb_venta 
set estado = 'Item o Set Cambiado'
where cod_venta = @cod_venta 
and cod_item = @cod_item 
and serie = @serie COLLATE SQL_Latin1_General_Cp1_CS_AS



GO

-- ----------------------------
-- Procedure structure for cambioxidantiguo
-- ----------------------------
DROP PROCEDURE [cambioxidantiguo]
GO

/*Procedure  que lista el 
cambio de nombre x id antiguo*/
CREATE procedure [cambioxidantiguo]
@idAntiguo  varchar(100),
@tipo int
as
if @tipo=1
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and idantiguo = @idAntiguo COLLATE SQL_Latin1_General_Cp1_CS_AS
and estado = 'NORMAL'
order by cod_cambio desc
else
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and idantiguo = @idAntiguo COLLATE SQL_Latin1_General_Cp1_CS_AS
AND estado = 'ANULADO'
order by cod_cambio desc



GO

-- ----------------------------
-- Procedure structure for cambioxidnuevo
-- ----------------------------
DROP PROCEDURE [cambioxidnuevo]
GO

/*Procedure  que lista el 
cambio de nombre x id nuevo*/
CREATE procedure [cambioxidnuevo]
@idnuevo  varchar(100),
@tipo INT
as
if @tipo = 1
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and idnuevo = @idnuevo COLLATE SQL_Latin1_General_Cp1_CS_AS
and estado = 'NORMAL'
order by cod_cambio desc
else
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and idnuevo = @idnuevo COLLATE SQL_Latin1_General_Cp1_CS_AS
and estado = 'ANULADO'
order by cod_cambio desc



GO

-- ----------------------------
-- Procedure structure for cambioxnickantiguo
-- ----------------------------
DROP PROCEDURE [cambioxnickantiguo]
GO

/*Procedure  que lista el 
cambio de nombre x nick antiguo*/
CREATE procedure [cambioxnickantiguo]
@nickantiguo varchar(100),
@tipo int
as
if @tipo = 1
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and nickantiguo = @nickantiguo COLLATE SQL_Latin1_General_Cp1_CS_AS
and estado = 'NORMAL'
order by cod_cambio desc
else
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idAntiguo,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and nickantiguo = @nickantiguo COLLATE SQL_Latin1_General_Cp1_CS_AS
and estado = 'ANULADO'
order by cod_cambio desc



GO

-- ----------------------------
-- Procedure structure for cambioxnicknuevo
-- ----------------------------
DROP PROCEDURE [cambioxnicknuevo]
GO

/*Procedure  que lista el 
cambio de nombre x id nuevo*/
CREATE procedure [cambioxnicknuevo]
@nicknuevo  varchar(100),
@tipo int
as
if @tipo = 1
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and nicknuevo = @nicknuevo COLLATE SQL_Latin1_General_Cp1_CS_AS
and estado = 'NORMAL'
order by cod_cambio desc
else
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and nicknuevo = @nicknuevo COLLATE SQL_Latin1_General_Cp1_CS_AS
and estado = 'ANULADO'
order by cod_cambio desc



GO

-- ----------------------------
-- Procedure structure for desbloquearcuenta
-- ----------------------------
DROP PROCEDURE [desbloquearcuenta]
GO



/*Procedure para desbloquear cuenta */
create procedure [desbloquearcuenta] 
@cod_bloqueo int,
@razondesbloqueo varchar(200)
as
update tb_bloqueo 
set razondesbloqueo= @razondesbloqueo, estado = 'Desbloqueada'
where cod_bloqueo = @cod_bloqueo




GO

-- ----------------------------
-- Procedure structure for devolverbloqueo
-- ----------------------------
DROP PROCEDURE [devolverbloqueo]
GO



/*listar bloqueo devuelve el bloqueo*/
create procedure [devolverbloqueo]
@cod_bloqueo int
as 
select 
fecha_bloqueo as 'Fecha',cod_usuario as 'Vendedor',
id_jugador as 'Login', personaje as 'Personaje',
estado as 'Estado',razonbloqueo as 'R.Bloqueo',
sancion as 'Sancion',razondesbloqueo as 'R.Desbloqueo',
cod_bloqueo as 'C.Bloqueo'
from tb_bloqueo
where cod_bloqueo = @cod_bloqueo order by fecha_bloqueo



GO

-- ----------------------------
-- Procedure structure for devolveritem
-- ----------------------------
DROP PROCEDURE [devolveritem]
GO


/*Procedure que retorna los datos del item
recibe el codigo como paremetro*/
create procedure [devolveritem] 
@cod_item int
as select*from tb_items where cod_item = @cod_item




GO

-- ----------------------------
-- Procedure structure for insertarCambioDatos
-- ----------------------------
DROP PROCEDURE [insertarCambioDatos]
GO

create procedure [insertarCambioDatos]
@cod_usuario varchar(100),
@idcuenta varchar(100),
@proantiguo varchar(50),
@pronuevo varchar(50),
@dniantiguo varchar(8),
@dninuevo varchar(8),
@correoant varchar(50),
@correonuevo varchar(50),
@fecha smalldatetime,
@pagado float,
@fecha_deposito smalldatetime,
@mtcn varchar(20),
@modalidad varchar(30),
@observacion varchar(500)
as
insert into tb_cambiodatos
(
cod_usuario,
idcuenta,
proantiguo,
pronuevo,
dniantiguo,
dninuevo,
correoant,
correonuevo,
fecha,
pagado,
fecha_deposito,
mtcn,
modalidad,
observacion
) 
values (
@cod_usuario,
@idcuenta,
@proantiguo,
@pronuevo,
@dniantiguo,
@dninuevo,
@correoant,
@correonuevo,
@fecha,
@pagado,
@fecha_deposito,
@mtcn,
@modalidad,
@observacion
)


GO

-- ----------------------------
-- Procedure structure for insertarVenta
-- ----------------------------
DROP PROCEDURE [insertarVenta]
GO
CREATE procedure [insertarVenta]
@cod_item  int ,
@serie  varchar(100)  ,
@cod_usuario  varchar(100) ,
@id_jugador  varchar(100),
@nombresapellidos  varchar(100),
@fecha_venta  smalldatetime  ,
@modalidad  varchar(100)   ,
@fecha_deposito  smalldatetime  ,
@mtcn  varchar(20)  ,
@estado  varchar(100)  ,
@cantidad  int  ,
@precioventa  float  ,	
@observacion  varchar(500),
@nivel int
as 
insert into tb_venta values(@cod_item,
@serie,@cod_usuario,@id_jugador,@nombresapellidos,
@fecha_venta,@modalidad,@fecha_deposito,
@mtcn,@estado,@cantidad,@precioventa,@observacion,@nivel)

GO

-- ----------------------------
-- Procedure structure for listarbloqueo
-- ----------------------------
DROP PROCEDURE [listarbloqueo]
GO



/*listar bloqueo de cuenta actuales*/
create procedure [listarbloqueo]
as select 
fecha_bloqueo as 'Fecha',cod_usuario as 'Vendedor',
id_jugador as 'Login', personaje as 'Personaje',
estado as 'Estado',razonbloqueo as 'R.Bloqueo',
sancion as 'Sancion',razondesbloqueo as 'R.Desbloqueo',
cod_bloqueo as 'C.Bloqueo'
from tb_bloqueo
where estado = 'Bloqueada'
order by cod_bloqueo desc



GO

-- ----------------------------
-- Procedure structure for listarbloqueoHistorico
-- ----------------------------
DROP PROCEDURE [listarbloqueoHistorico]
GO



/*lista todos los bloqueos*/
create procedure [listarbloqueoHistorico]
as select cod_bloqueo as 'C.Bloqueo',
fecha_bloqueo as 'Fecha',cod_usuario as 'Vendedor',
id_jugador as 'Login', personaje as 'Personaje',
estado as 'Estado',razonbloqueo as 'R.Bloqueo',
sancion as 'Sancion',razondesbloqueo as 'R.Desbloqueo'
from tb_bloqueo
order by cod_bloqueo desc



GO

-- ----------------------------
-- Procedure structure for listarCambiosNombreEntreFechas
-- ----------------------------
DROP PROCEDURE [listarCambiosNombreEntreFechas]
GO

CREATE  procedure [listarCambiosNombreEntreFechas]
@fecha1  smalldatetime,
@fecha2  smalldatetime,
@tipo int
as
if @tipo = 1
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and fechacambio between @fecha1 and @fecha2
and estado = 'NORMAL'
order by cod_cambio desc
else
select 
cn.cod_cambio,
cn.cod_usuario,
cn.modalidad,
cn.idAntiguo,
cn.nickAntiguo,
cn.idNuevo ,
cn.nickNuevo,
rz.identificador_raza,
cantResets,
fechacambio,
pagado,
fecha_deposito,
mtcn,
estado 
from tb_cambionombre cn,tb_raza rz
where rz.cod_raza = cn.cod_raza 
and fechacambio between @fecha1 and @fecha2
and estado = 'ANULADO'
order by cod_cambio desc



GO

-- ----------------------------
-- Procedure structure for listarUsuarios
-- ----------------------------
DROP PROCEDURE [listarUsuarios]
GO


/*Procedure que lista los usuarios
pero solo el  codigo y el tipo usuario*/
create procedure [listarUsuarios]
as 
select cod_usuario,tipousuario from tb_usuario



GO

-- ----------------------------
-- Procedure structure for modificaritem
-- ----------------------------
DROP PROCEDURE [modificaritem]
GO



/*Procedure que Modifica un Item*/
create procedure [modificaritem]
@cod_item             int,
@cod_tipoitem         int,
@descripcion          varchar(100),
@precio               float
as 
update  tb_items set cod_tipoitem=@cod_tipoitem,
descripcion =@descripcion,
precio = @precio where cod_item=@cod_item



GO

-- ----------------------------
-- Procedure structure for modificarventa
-- ----------------------------
DROP PROCEDURE [modificarventa]
GO
/*Modificar la venTA*/
CREATE procedure [modificarventa]
@cod_venta int,
@cod_itema int ,
@cod_itemn int ,
@seriea varchar(100),
@serien varchar(100),
@id_jugador varchar(100),
@observacion varchar(500),
@precioventa  float,
@cantidad  int,
@modalidad varchar(100),
@mtcn varchar(20),
@nom varchar(100),
@nivel int
as 
update tb_venta 
set cod_item = @cod_itemn, serie=@serien,
id_jugador=@id_jugador,observacion=@observacion,precioventa=@precioventa,
cantidad=@cantidad,modalidad=@modalidad, mtcn = @mtcn,nombresapellidos=@nom,
nivel = @nivel
where cod_venta = @cod_venta and 
cod_item = @cod_itema and serie = @seriea



GO

-- ----------------------------
-- Procedure structure for obtenerCambioDatos
-- ----------------------------
DROP PROCEDURE [obtenerCambioDatos]
GO

create procedure [obtenerCambioDatos]
@cod_cambiodatos as integer 
as 
select * from tb_cambiodatos  where cod_cambiodatos = @cod_cambiodatos


GO

-- ----------------------------
-- Procedure structure for obtenerCambioNombre
-- ----------------------------
DROP PROCEDURE [obtenerCambioNombre]
GO

CREATE procedure [obtenerCambioNombre]
@cod_cambio int
as
SELECT cod_cambio
      ,cod_usuario
      ,idAntiguo
      ,nickAntiguo
      ,idNuevo
      ,nickNuevo
      ,cod_raza
      ,cantResets
      ,fechacambio
      ,pagado
      ,estado
      ,modalidad
      ,mtcn
      ,fecha_deposito     
  FROM tb_cambionombre
where cod_cambio =@cod_cambio 


GO

-- ----------------------------
-- Procedure structure for obteneritemxventa
-- ----------------------------
DROP PROCEDURE [obteneritemxventa]
GO
CREATE procedure [obteneritemxventa]
@cod_venta as int, 
@cod_item as int,
@serie as varchar(100)
as
select v.cod_venta as 'C.Venta', v.cod_usuario as 'Vendedor',
v.id_jugador as 'Login', v.fecha_venta as 'Fecha Venta',
v.modalidad as 'Modalidad', v.precioventa as 'Pagado',
i.cod_tipoitem as 'cod_tipoitem',
v.cod_item as 'C.Item',i.descripcion as 'Item//Set',
v.estado as 'Estado',
v.serie as Serie,
v.cantidad as Cantidad,
v.nombresapellidos as 'Nombres Apellidos',
v.observacion as Observacion,
v.mtcn,
v.fecha_deposito as 'F.Deposito',
v.nivel
from tb_venta as v, tb_items as i
where v.cod_venta = @cod_venta 
and v.cod_item = @cod_item and 
v.serie = @serie
and v.cod_item = i.cod_item








GO

-- ----------------------------
-- Procedure structure for obteneritemxventamtcn
-- ----------------------------
DROP PROCEDURE [obteneritemxventamtcn]
GO

/*Procedure que devuelve el item d la venta*/
CREATE procedure [obteneritemxventamtcn]
@cod_venta as int, 
@cod_item as int,
@serie as varchar(100)
as
select v.cod_venta as 'C.Venta', v.cod_usuario as 'Vendedor',
v.id_jugador as 'Login', v.fecha_venta as 'Fecha Venta',
v.modalidad as 'Modalidad', v.precioventa as 'Pagado',
i.cod_tipoitem as 'cod_tipoitem',
v.cod_item as 'C.Item',i.descripcion as 'Item//Set',
v.estado as 'Estado',
v.serie as Serie,
v.cantidad as Cantidad,
v.nombresapellidos as 'Nombres Apellidos',
v.observacion as Observacion,
v.fecha_deposito as 'F.Deposito',
v.mtcn as Mtcn
from tb_venta as v, tb_items as i
where v.cod_venta = @cod_venta 
and v.cod_item = @cod_item and 
v.serie = @serie
and v.cod_item = i.cod_item


GO

-- ----------------------------
-- Procedure structure for SP_ITEM_HIJO_AGREGAR
-- ----------------------------
DROP PROCEDURE [SP_ITEM_HIJO_AGREGAR]
GO

--procedure para agregar un item hijo
create procedure [SP_ITEM_HIJO_AGREGAR]
@itempadre int,
@itemhijo int
as
insert into tb_item_detalle (cod_item_padre,cod_item_hijo) values (@itempadre,@itemhijo);


GO

-- ----------------------------
-- Procedure structure for SP_ITEM_HIJO_ELIMINAR
-- ----------------------------
DROP PROCEDURE [SP_ITEM_HIJO_ELIMINAR]
GO
create procedure [SP_ITEM_HIJO_ELIMINAR]
@id int
as
delete from tb_item_detalle  where id = @id
GO

-- ----------------------------
-- Procedure structure for SP_ITEM_OBTENER_HIJOS
-- ----------------------------
DROP PROCEDURE [SP_ITEM_OBTENER_HIJOS]
GO
create procedure [SP_ITEM_OBTENER_HIJOS]
@codItem         int
as 
select id.id,id.cod_item_hijo as cod_item,i.cod_tipoitem,i.descripcion,i.precio,ti.descripcion as desc_tipo_item 
from tb_item_detalle id
inner join tb_items i on i.cod_item = id.cod_item_hijo
inner join tb_tipoitem ti on ti.cod_tipoitem = i.cod_tipoitem
where id.cod_item_padre = @codItem
order by id.id asc 
GO

-- ----------------------------
-- Procedure structure for SP_ITEM_OBTENER_POR_TIPO
-- ----------------------------
DROP PROCEDURE [SP_ITEM_OBTENER_POR_TIPO]
GO

/*Procedure que lista los item x  Tipo
para ello recibe un parametro*/
CREATE procedure [SP_ITEM_OBTENER_POR_TIPO]
@cod_tipoitem         int
as
select t.cod_item, t.descripcion,t.cod_tipoitem,tc.descripcion as desc_tipo_item, t.precio 
from tb_items t 
inner join tb_tipoitem tc on tc.cod_tipoitem = t.cod_tipoitem 
where t.cod_tipoitem = @cod_tipoitem


GO

-- ----------------------------
-- Procedure structure for SP_PARAMETROS_OBTENER
-- ----------------------------
DROP PROCEDURE [SP_PARAMETROS_OBTENER]
GO

--procedure para llenar los datos de los combos
CREATE procedure [SP_PARAMETROS_OBTENER]
@parametro int,
@tipo int
as
IF @parametro = 1
SELECT t.cod_tipoitem AS codigo,t.descripcion as descripcion from tb_tipoitem t order by t.descripcion asc;
IF @parametro = 2
SELECT t.cod_item as codigo, t.descripcion as descripcion FROM tb_items t where t.cod_tipoitem = @tipo
IF @parametro = 3 
SELECT t.cod_raza as codigo, t.nombre_raza as raza FROM tb_raza t;


GO

-- ----------------------------
-- Procedure structure for SP_VENTA_BUSCAR_POR_FILTROS
-- ----------------------------
DROP PROCEDURE [SP_VENTA_BUSCAR_POR_FILTROS]
GO

--procedure para listar las ventas segun los filtros enviados
CREATE procedure [SP_VENTA_BUSCAR_POR_FILTROS]
@id_jugador varchar(50) = '',
@mtcn varchar(100) = '',
@serie varchar(50)='',
@fecha1 as smalldatetime=null,
@fecha2 smalldatetime=null,
--1 normales, 2 normales y cambios 3 todos
@tipobusqueda int = 1
as 

set @id_jugador=LTRIM(RTRIM(@id_jugador));
set @mtcn= LTRIM(RTRIM(@mtcn));
set @serie = LTRIM(RTRIM(@serie))

select 
	v.fecha_venta as 'Fecha Venta',
	v.id_jugador as 'Login', 
	v.cantidad as 'Cnt',
	i.descripcion as 'Item//Set',
	v.serie as Serie,
	v.nivel as 'Nivel',
	v.precioventa as 'Pagado',
	v.modalidad as 'Modalidad',
	v.observacion as Observacion,
	v.estado as 'Estado',
	v.cod_venta as 'C.Venta', 
	v.cod_item as 'C.Item',
	v.cod_usuario as 'Vendedor'
from 
	tb_venta as v
inner join tb_items as i on i.cod_item = v.cod_item
where
	1=case
		when @tipobusqueda=1 and v.estado = 'Normal' then 1
		when @tipobusqueda=2 and (v.estado = 'Normal'  or  v.estado = 'Item o Set Cambiado') then 1
		when @tipobusqueda=3 then 1
	end
	and
	1=case
		when @id_jugador='' or @id_jugador is null then 1
		when LEN(@id_jugador) > 0 and v.id_jugador = @id_jugador COLLATE SQL_Latin1_General_Cp1_CS_AS then 1
	end 
	and
	1=case 
		when @mtcn='' or @mtcn is null then 1
		when len(@mtcn)>0 and v.mtcn = @mtcn then 1
	end
	and
	1=case
		when @serie='' or @serie is null then 1
		when len(@serie) > 0 and v.serie = @serie then 1
	end
	and
	1=case
		when @fecha1 is null or @fecha2 is null then 1
		when @fecha1 is not null and @fecha2 is not null and v.fecha_venta between @fecha1 and @fecha2 then 1
	end
	order by v.cod_venta desc;


GO

-- ----------------------------
-- Procedure structure for totalventaentrefechas
-- ----------------------------
DROP PROCEDURE [totalventaentrefechas]
GO




/*Procedure que muestra la suma de las ventas*/

create procedure [totalventaentrefechas]
@fecha1 as smalldatetime,
@fecha2 smalldatetime
as
SELECT Sum(precioventa) As TOTAL FROM tb_venta
where
fecha_venta between @fecha1 and @fecha2
and (estado = 'Normal'  or  estado = 'Item o Set Cambiado')




GO

-- ----------------------------
-- Procedure structure for totalventaentrefechasNormal
-- ----------------------------
DROP PROCEDURE [totalventaentrefechasNormal]
GO



/*Procedure que muestra la suma de las ventassolo normal*/
create procedure [totalventaentrefechasNormal]
@fecha1 as smalldatetime,
@fecha2 smalldatetime
as
SELECT Sum(precioventa) As TOTAL FROM tb_venta
where
fecha_venta between @fecha1 and @fecha2
and estado = 'Normal'




GO

-- ----------------------------
-- Procedure structure for ultimocambionombreinsertado
-- ----------------------------
DROP PROCEDURE [ultimocambionombreinsertado]
GO



/*Procedure devuelve la ultima cambionombre insertatada */
create procedure [ultimocambionombreinsertado]
as 
SELECT MAX(cod_cambio)
FROM tb_cambionombre




GO

-- ----------------------------
-- Procedure structure for validarUsuario
-- ----------------------------
DROP PROCEDURE [validarUsuario]
GO
/*Valida el usuario que se quiere
conectar a la base de datos y si existe 
devuelve la fila*/
create procedure [validarUsuario]
@cod_usuario          varchar(100) ,
@password             varchar(100)
as
select*from tb_usuario where 
@cod_usuario=cod_usuario COLLATE SQL_Latin1_General_Cp1_CS_AS 
and @password=password COLLATE SQL_Latin1_General_Cp1_CS_AS


GO

-- ----------------------------
-- Indexes structure for table tb_bloqueo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_bloqueo
-- ----------------------------
ALTER TABLE [tb_bloqueo] ADD PRIMARY KEY NONCLUSTERED ([cod_bloqueo])
GO

-- ----------------------------
-- Indexes structure for table tb_cambiodatos
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_cambiodatos
-- ----------------------------
ALTER TABLE [tb_cambiodatos] ADD PRIMARY KEY ([cod_cambiodatos])
GO

-- ----------------------------
-- Indexes structure for table tb_cambionombre
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_cambionombre
-- ----------------------------
ALTER TABLE [tb_cambionombre] ADD PRIMARY KEY ([cod_cambio])
GO

-- ----------------------------
-- Indexes structure for table tb_item_detalle
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_item_detalle
-- ----------------------------
ALTER TABLE [tb_item_detalle] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table tb_items
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_items
-- ----------------------------
ALTER TABLE [tb_items] ADD PRIMARY KEY ([cod_item])
GO

-- ----------------------------
-- Indexes structure for table tb_raza
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_raza
-- ----------------------------
ALTER TABLE [tb_raza] ADD PRIMARY KEY ([cod_raza])
GO

-- ----------------------------
-- Indexes structure for table tb_tipoitem
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_tipoitem
-- ----------------------------
ALTER TABLE [tb_tipoitem] ADD PRIMARY KEY ([cod_tipoitem])
GO

-- ----------------------------
-- Indexes structure for table tb_usuario
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_usuario
-- ----------------------------
ALTER TABLE [tb_usuario] ADD PRIMARY KEY ([cod_usuario])
GO

-- ----------------------------
-- Indexes structure for table tb_venta
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_venta
-- ----------------------------
ALTER TABLE [tb_venta] ADD PRIMARY KEY ([cod_venta], [cod_item], [serie])
GO

-- ----------------------------
-- Foreign Key structure for table [tb_bloqueo]
-- ----------------------------
ALTER TABLE [tb_bloqueo] ADD FOREIGN KEY ([cod_usuario]) REFERENCES [tb_usuario] ([cod_usuario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tb_cambiodatos]
-- ----------------------------
ALTER TABLE [tb_cambiodatos] ADD FOREIGN KEY ([cod_usuario]) REFERENCES [tb_usuario] ([cod_usuario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tb_cambionombre]
-- ----------------------------
ALTER TABLE [tb_cambionombre] ADD FOREIGN KEY ([cod_raza]) REFERENCES [tb_raza] ([cod_raza]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tb_cambionombre] ADD FOREIGN KEY ([cod_usuario]) REFERENCES [tb_usuario] ([cod_usuario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tb_item_detalle]
-- ----------------------------
ALTER TABLE [tb_item_detalle] ADD FOREIGN KEY ([cod_item_hijo]) REFERENCES [tb_items] ([cod_item]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tb_item_detalle] ADD FOREIGN KEY ([cod_item_padre]) REFERENCES [tb_items] ([cod_item]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tb_items]
-- ----------------------------
ALTER TABLE [tb_items] ADD FOREIGN KEY ([cod_tipoitem]) REFERENCES [tb_tipoitem] ([cod_tipoitem]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [tb_venta]
-- ----------------------------
ALTER TABLE [tb_venta] ADD FOREIGN KEY ([cod_usuario]) REFERENCES [tb_usuario] ([cod_usuario]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [tb_venta] ADD FOREIGN KEY ([cod_item]) REFERENCES [tb_items] ([cod_item]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
