SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Input.Others]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Input.Others](
	[ID] [uniqueidentifier] NOT NULL,
	[InputID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[ContractID] [uniqueidentifier] NULL,
	[OrderID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.InputContract] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Ouput.Inputs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Ouput.Inputs](
	[ID] [uniqueidentifier] NOT NULL,
	[OutputID] [uniqueidentifier] NULL,
	[InputID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Ouput.Inputs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cars]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cars](
	[CarID] [uniqueidentifier] NOT NULL,
	[CarModel] [nvarchar](250) NULL,
	[CarName] [nvarchar](250) NULL,
	[CarNumber] [nvarchar](50) NULL,
	[CarDescription] [ntext] NULL,
	[CarNoms] [float] NULL,
	[BoughtDate] [datetime] NULL,
	[KMRuns] [float] NULL,
	[Active] [bit] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bảng số xe' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Cars', @level2type=N'COLUMN', @level2name=N'CarNumber'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Định mức xăng / 100km' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Cars', @level2type=N'COLUMN', @level2name=N'CarNoms'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày mua xe' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Cars', @level2type=N'COLUMN', @level2name=N'BoughtDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số km đã chạy' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Cars', @level2type=N'COLUMN', @level2name=N'KMRuns'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StatusCollections]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StatusCollections](
	[StatusID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Abbreviation] [nvarchar](15) NULL,
	[StatusGroup] [nvarchar](50) NULL,
	[Active] [bit] NULL,
	[Notes] [nvarchar](250) NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_StatusCollections] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Units]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Units](
	[UnitID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[UnitGroup] [nvarchar](150) NULL,
	[Active] [bit] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Stores]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Stores](
	[ID] [uniqueidentifier] NOT NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[StoreID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Stores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Quotes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Quotes](
	[QuoteID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](150) NULL,
	[QuoteDate] [datetime] NULL,
	[Follower] [nvarchar](250) NULL,
	[AcceptedDate] [datetime] NULL,
	[DeadLine] [datetime] NULL,
	[OtherIssues] [ntext] NULL,
	[Status] [nvarchar](50) NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Offers] PRIMARY KEY CLUSTERED 
(
	[QuoteID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số phiếu chào giá' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Quotes', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày chào giá' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Quotes', @level2type=N'COLUMN', @level2name=N'QuoteDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Người theo dõi' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Quotes', @level2type=N'COLUMN', @level2name=N'Follower'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày tổng hợp báo cáo GĐ' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Quotes', @level2type=N'COLUMN', @level2name=N'AcceptedDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Thời hạn chót để nộp chào giá' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Quotes', @level2type=N'COLUMN', @level2name=N'DeadLine'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đánh giá bảng chào giá' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Quotes', @level2type=N'COLUMN', @level2name=N'OtherIssues'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Quote.Requests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Quote.Requests](
	[ID] [uniqueidentifier] NOT NULL,
	[QuoteID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Quote.Requests] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Contract.Requests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Contract.Requests](
	[ID] [uniqueidentifier] NOT NULL,
	[ContractID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Contract.Requests] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Contracts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Contracts](
	[ContractID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](150) NULL,
	[Date] [datetime] NULL,
	[SupplierID] [uniqueidentifier] NULL,
	[StoreID] [uniqueidentifier] NULL,
	[SignedDate] [datetime] NULL,
	[ContractPrice] [nvarchar](250) NULL,
	[DeliveryDate] [datetime] NULL,
	[LatestDeliveryDate] [datetime] NULL,
	[PersonInCharge] [nvarchar](250) NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Contracts] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số phiếu hợp đồng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày hợp đồng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'Date'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tàu yêu cầu' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'StoreID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngay ký HĐ' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'SignedDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Trị giá hợp đồng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'ContractPrice'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày giao hàng thực tế' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'DeliveryDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày giao hàng cuối cùng theo HĐ' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'LatestDeliveryDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Người theo dõi HĐ' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Contracts', @level2type=N'COLUMN', @level2name=N'PersonInCharge'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Requests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Requests](
	[RequestID] [uniqueidentifier] NOT NULL,
	[StoreID] [uniqueidentifier] NULL,
	[Code] [nvarchar](150) NULL,
	[RequestDate] [datetime] NULL,
	[ProcedureCode] [nvarchar](150) NULL,
	[Priority] [nvarchar](100) NULL,
	[EQCatID] [uniqueidentifier] NULL,
	[DeliveryDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Requests] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Kho yêu cầu' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Requests', @level2type=N'COLUMN', @level2name=N'StoreID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số phiếu' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Requests', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày yêu cầu' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Requests', @level2type=N'COLUMN', @level2name=N'RequestDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số quy trình' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Requests', @level2type=N'COLUMN', @level2name=N'ProcedureCode'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Inputs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Inputs](
	[InputID] [uniqueidentifier] NOT NULL,
	[StoreID] [uniqueidentifier] NULL,
	[Code] [nvarchar](150) NULL,
	[Date] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Inputs] PRIMARY KEY CLUSTERED 
(
	[InputID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đơn vị (Tàu/Kho) nhận - lấy từ PYC' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Inputs', @level2type=N'COLUMN', @level2name=N'StoreID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số phiếu nhập kho' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Inputs', @level2type=N'COLUMN', @level2name=N'Code'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Inventory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Inventory](
	[InventoryID] [uniqueidentifier] NOT NULL,
	[StoreID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[MinLevel] [float] NULL,
	[Quantity] [float] NULL,
	[InUseQuantity] [float] NULL,
	[VNPriceTotal] [money] NULL,
	[InOrderQuantity] [float] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Inventory] PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng giới hạn thấp nhất' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Inventory', @level2type=N'COLUMN', @level2name=N'MinLevel'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Là số lượng những vật tư "tái sử dụng" nhưng ko làm tăng tổng giá trị trong kho' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Inventory', @level2type=N'COLUMN', @level2name=N'InUseQuantity'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tổng trị giá' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Inventory', @level2type=N'COLUMN', @level2name=N'VNPriceTotal'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Outputs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Outputs](
	[OutputID] [uniqueidentifier] NOT NULL,
	[SentStoreID] [uniqueidentifier] NULL,
	[ReceiveStoreID] [uniqueidentifier] NULL,
	[Code] [nvarchar](150) NULL,
	[Date] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Outputs] PRIMARY KEY CLUSTERED 
(
	[OutputID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đơn vị (Tàu/Kho) xuất, cũng là đơn vị nhận' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Outputs', @level2type=N'COLUMN', @level2name=N'SentStoreID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số phiếu xuất kho' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Outputs', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày xuất kho' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Outputs', @level2type=N'COLUMN', @level2name=N'Date'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Repairs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Repairs](
	[RepairID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](150) NULL,
	[Date] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Mat.Repairs] PRIMARY KEY CLUSTERED 
(
	[RepairID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số phiếusửa chữa' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Repairs', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày yêu cầu sửa chữa' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Repairs', @level2type=N'COLUMN', @level2name=N'Status'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Categories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Categories](
	[EQCatID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](100) NULL,
	[Name] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[Active] [bit] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[EQCatID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CoTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CoTypes](
	[CoTypeID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[Active] [bit] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_CoTypes] PRIMARY KEY CLUSTERED 
(
	[CoTypeID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Departments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Departments](
	[DeptID] [uniqueidentifier] NOT NULL,
	[ParentID] [uniqueidentifier] NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[Active] [bit] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DeptID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[NickName] [nvarchar](150) NULL,
	[Birthday] [datetime] NULL,
	[BirthLocation] [nvarchar](200) NULL,
	[Address] [ntext] NULL,
	[Phone] [nvarchar](250) NULL,
	[Email] [nvarchar](250) NULL,
	[Website] [nvarchar](250) NULL,
	[Picture] [image] NULL,
	[IDNo] [nvarchar](50) NULL,
	[IDIssuedDate] [datetime] NULL,
	[IDIssuer] [nvarchar](250) NULL,
	[PassportNo] [nvarchar](50) NULL,
	[PassportIssuedDate] [datetime] NULL,
	[PassportExpiredDate] [datetime] NULL,
	[PassportIssuer] [nvarchar](250) NULL,
	[Active] [bit] NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Categories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Categories](
	[MatCatID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[Active] [bit] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Mat.Category] PRIMARY KEY CLUSTERED 
(
	[MatCatID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Requests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Requests](
	[RequestID] [uniqueidentifier] NOT NULL,
	[ProdecureCode] [nvarchar](150) NULL,
	[Code] [nvarchar](150) NULL,
	[SendDeptID] [uniqueidentifier] NULL,
	[ReceiveDeptID] [uniqueidentifier] NULL,
	[Date] [datetime] NULL,
	[RequestForWhen] [nvarchar](250) NULL,
	[Priority] [nvarchar](100) NULL,
	[Status] [nvarchar](50) NULL,
	[Description] [ntext] NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số PYC' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Requests', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày yêu cầu' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Requests', @level2type=N'COLUMN', @level2name=N'Date'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Yêu cầu cho Tháng/Năm/Quý' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Requests', @level2type=N'COLUMN', @level2name=N'RequestForWhen'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Roles](
	[RoleID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](100) NULL,
	[Name] [nvarchar](255) NULL,
	[Active] [bit] NULL,
	[Description] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stores]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Stores](
	[StoreID] [uniqueidentifier] NOT NULL,
	[ParentID] [uniqueidentifier] NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](250) NULL,
	[Type] [nvarchar](50) NULL,
	[Address] [ntext] NULL,
	[PersonInCharge] [nvarchar](250) NULL,
	[Active] [bit] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED 
(
	[StoreID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Order.Requests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Order.Requests](
	[ID] [uniqueidentifier] NOT NULL,
	[OrderID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Order.Requests] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Orders]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Orders](
	[OrderID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](150) NULL,
	[Date] [datetime] NULL,
	[SupplierID] [uniqueidentifier] NULL,
	[StoreID] [uniqueidentifier] NULL,
	[Priority] [nvarchar](50) NULL,
	[Receiver] [nvarchar](250) NULL,
	[DeliveryDate] [datetime] NULL,
	[DeliveryLocation] [nvarchar](250) NULL,
	[Pricing] [ntext] NULL,
	[PaymentTerm] [ntext] NULL,
	[Quality] [ntext] NULL,
	[Warranty] [ntext] NULL,
	[RegardingTo] [ntext] NULL,
	[Notes] [ntext] NULL,
	[PersonInCharge] [nvarchar](250) NULL,
	[Status] [nvarchar](50) NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đơn vị (Kho/Tàu) nhận hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'StoreID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Người nhận hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'Receiver'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Thời gian giao' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'DeliveryDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Địa điểm giao' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'DeliveryLocation'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Căn cứ vào' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'Pricing'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Điều kiện thanh toán' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'PaymentTerm'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Chất lượng hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'Quality'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Quy định bảo hành' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'Warranty'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ghi chú khác' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'Notes'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Người theo dõi' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Orders', @level2type=N'COLUMN', @level2name=N'PersonInCharge'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Car.Maintenances]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Car.Maintenances](
	[MaintenanceID] [uniqueidentifier] NOT NULL,
	[RequestPerson] [nvarchar](250) NULL,
	[RequestReason] [ntext] NULL,
	[CarID] [uniqueidentifier] NULL,
	[MaintenanceBeginDate] [datetime] NULL,
	[MaintenanceEndDate] [datetime] NULL,
	[MaintenanceType] [nvarchar](250) NULL,
	[MaintenanceCost] [money] NULL,
	[AfterMaintenance] [ntext] NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_CarMaintenances] PRIMARY KEY CLUSTERED 
(
	[MaintenanceID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bảng số xe' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Car.Maintenances', @level2type=N'COLUMN', @level2name=N'CarID'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Car.Schedules]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Car.Schedules](
	[ScheduleID] [uniqueidentifier] NOT NULL,
	[Subject] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[RequestPerson] [nvarchar](250) NULL,
	[CarID] [uniqueidentifier] NULL,
	[DriverID] [uniqueidentifier] NULL,
	[StartDate] [datetime] NULL,
	[StartTime] [smalldatetime] NULL,
	[EndDate] [datetime] NULL,
	[EndTime] [smalldatetime] NULL,
	[DistanceUsed] [float] NULL,
	[BenzinUsed] [float] NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Car.Schedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Quãng đường đi được' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Car.Schedules', @level2type=N'COLUMN', @level2name=N'DistanceUsed'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng xăng sử dụng (lit)' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Car.Schedules', @level2type=N'COLUMN', @level2name=N'BenzinUsed'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Repair.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Repair.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[RepairID] [uniqueidentifier] NULL,
	[MaterialID] [uniqueidentifier] NULL,
	[SupplierID] [uniqueidentifier] NULL,
	[Quantity] [float] NULL,
	[RepairCost] [money] NULL,
	[ReturnDate] [datetime] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Mat.Repair.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng sửa chữa' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Repair.Details', @level2type=N'COLUMN', @level2name=N'Quantity'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Chi phí sửa chữa' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Repair.Details', @level2type=N'COLUMN', @level2name=N'RepairCost'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày trả hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Repair.Details', @level2type=N'COLUMN', @level2name=N'ReturnDate'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Equipments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Equipments](
	[ID] [uniqueidentifier] NOT NULL,
	[ParentID] [uniqueidentifier] NULL,
	[Code] [nvarchar](250) NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [ntext] NULL,
	[PartNumber] [nvarchar](250) NULL,
	[ReferCode] [nvarchar](250) NULL,
	[StoreID] [uniqueidentifier] NULL,
	[UnitID] [uniqueidentifier] NULL,
	[EQCatID] [uniqueidentifier] NULL,
	[Origin] [nvarchar](250) NULL,
	[IsCritical] [bit] NULL,
	[IsReusable] [bit] NULL,
	[Picture] [image] NULL,
	[EquipmentLevel] [int] NULL CONSTRAINT [DF_Equipments_EquipmentLevel]  DEFAULT ((0)),
	[Active] [bit] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Equipments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Xác định Equipment cha của nó' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Equipments', @level2type=N'COLUMN', @level2name=N'ParentID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã thiết bị' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Equipments', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số IMEI' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Equipments', @level2type=N'COLUMN', @level2name=N'PartNumber'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đơn vị tính' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Equipments', @level2type=N'COLUMN', @level2name=N'UnitID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Xuất xứ của thiết bị' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Equipments', @level2type=N'COLUMN', @level2name=N'Origin'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Chỉ ra Equipment này là con ở cấp mấy trong hệ thống' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Equipments', @level2type=N'COLUMN', @level2name=N'EquipmentLevel'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Materials]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Materials](
	[MaterialID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[MatCatID] [uniqueidentifier] NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
	[UnitID] [uniqueidentifier] NULL,
	[USPrice] [money] NULL,
	[VNPrice] [money] NULL,
	[LastBoughtDate] [datetime] NULL,
	[IMEI] [nvarchar](50) NULL,
	[Origin] [nvarchar](250) NULL,
	[Active] [bit] NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số vật tư' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Materials', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đơn vị tính' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Materials', @level2type=N'COLUMN', @level2name=N'UnitID'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Giá mua lần cuối cùng lúc' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Materials', @level2type=N'COLUMN', @level2name=N'LastBoughtDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Xuất xứ của vật tư' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Materials', @level2type=N'COLUMN', @level2name=N'Origin'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Quote.Suppliers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Quote.Suppliers](
	[ID] [uniqueidentifier] NOT NULL,
	[QuoteID] [uniqueidentifier] NULL,
	[SupplierID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.QuoteSupplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Quote.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Quote.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[QuoteID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[Quantity] [float] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Quote.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Contract.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Contract.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[ContractID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[RequestQuantity] [float] NULL,
	[ContractQuantity] [float] NULL,
	[VNPrice] [money] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Contract.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Request.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Request.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[RequestID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[InStockQuantity] [float] NULL,
	[RequestedQuantity] [float] NULL,
	[ApprovedQuantity] [float] NULL,
	[NotYetOrderQuantity] [float] NULL,
	[NotYetInputQuantity] [float] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Request.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'số lượng yêu cầu' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Request.Details', @level2type=N'COLUMN', @level2name=N'RequestedQuantity'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'số lượng được duyệt' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Request.Details', @level2type=N'COLUMN', @level2name=N'ApprovedQuantity'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng chưa được đặt hàng so với ApprovedQuantity' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Request.Details', @level2type=N'COLUMN', @level2name=N'NotYetOrderQuantity'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng chưa nhập hàng so với ApprovedQuantity' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Request.Details', @level2type=N'COLUMN', @level2name=N'NotYetInputQuantity'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Input.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Input.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[InputID] [uniqueidentifier] NULL,
	[OrderID] [uniqueidentifier] NULL,
	[ContractID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[OrderQuantity] [float] NULL,
	[InputQuantity] [float] NULL,
	[NotYetOutputQuantity] [float] NULL,
	[VNPrice] [money] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Input.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Inventory.Locations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Inventory.Locations](
	[ID] [uniqueidentifier] NOT NULL,
	[InventoryID] [uniqueidentifier] NULL,
	[LocationID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[Quantity] [float] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Inventory.Locations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Output.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Output.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[OutputID] [uniqueidentifier] NULL,
	[InputID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[Quantity] [float] NULL,
	[VNPrice] [money] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Output.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng xuất' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Output.Details', @level2type=N'COLUMN', @level2name=N'Quantity'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EQ.Order.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EQ.Order.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[OrderID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[EquipmentID] [uniqueidentifier] NULL,
	[RequestQuantity] [float] NULL,
	[OrderQuantity] [float] NULL,
	[VNPrice] [money] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_EQ.Order.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng hàng đặt' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'EQ.Order.Details', @level2type=N'COLUMN', @level2name=N'OrderQuantity'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserRoles](
	[ID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NULL,
	[RoleID] [uniqueidentifier] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Input.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Input.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[InputID] [uniqueidentifier] NULL,
	[MaterialID] [uniqueidentifier] NULL,
	[Quantity] [float] NULL,
	[USPrice] [money] NULL,
	[VNPrice] [money] NULL,
	[WarrantyTime] [nvarchar](200) NULL,
	[ReceiveDeptID] [uniqueidentifier] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Mat.Input.Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Thời gian bảo hành' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Input.Details', @level2type=N'COLUMN', @level2name=N'WarrantyTime'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Suppliers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](100) NULL,
	[Name] [nvarchar](255) NULL,
	[ShortName] [nvarchar](150) NULL,
	[CoTypeID] [uniqueidentifier] NULL,
	[Address] [ntext] NULL,
	[Phone] [nvarchar](250) NULL,
	[Fax] [nvarchar](250) NULL,
	[Email] [nvarchar](250) NULL,
	[Website] [nvarchar](250) NULL,
	[AccountNo] [nvarchar](150) NULL,
	[TaxNo] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](250) NULL,
	[ContactMobile] [nvarchar](250) NULL,
	[Notes] [ntext] NULL,
	[Active] [bit] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Users](
	[UserID] [uniqueidentifier] NOT NULL,
	[DeptID] [uniqueidentifier] NULL,
	[EmployeeID] [uniqueidentifier] NULL,
	[UserName] [nvarchar](150) NULL,
	[UserPwd] [nvarchar](150) NULL,
	[Position] [nvarchar](200) NULL,
	[IsLogin] [bit] NULL,
	[Active] [bit] NULL,
	[Notes] [ntext] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Car.Drivers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Car.Drivers](
	[DriverID] [uniqueidentifier] NOT NULL,
	[EmployeeID] [uniqueidentifier] NULL,
	[CarID] [uniqueidentifier] NULL,
	[DriverLicense] [nvarchar](50) NULL,
	[DriverInfo] [ntext] NULL,
	[DriverNotes] [ntext] NULL,
	[Active] [bit] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_Car.Drivers] PRIMARY KEY CLUSTERED 
(
	[DriverID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Inputs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Inputs](
	[InputID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](150) NULL,
	[Date] [datetime] NULL,
	[OrderID] [uniqueidentifier] NULL,
	[SupplierID] [uniqueidentifier] NULL,
	[Status] [nvarchar](50) NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Mat.Inputs] PRIMARY KEY CLUSTERED 
(
	[InputID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Order.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Order.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[OrderID] [uniqueidentifier] NULL,
	[MaterialID] [uniqueidentifier] NULL,
	[Quantity] [float] NULL,
	[USPrice] [money] NULL,
	[VNPrice] [money] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Mat.OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng đặt hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Order.Details', @level2type=N'COLUMN', @level2name=N'Quantity'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Orders]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Orders](
	[OrderID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](250) NULL,
	[Date] [datetime] NULL,
	[ContactPerson] [nvarchar](250) NULL,
	[SupplierID] [uniqueidentifier] NULL,
	[RequestID] [uniqueidentifier] NULL,
	[OrderReason] [ntext] NULL,
	[Status] [nvarchar](50) NULL,
	[Priority] [nvarchar](100) NULL,
	[DeliveryDate] [datetime] NULL,
	[DeliveryLocation] [nvarchar](250) NULL,
	[Receiver] [nvarchar](250) NULL,
	[OtherInfo] [ntext] NULL,
	[Notes] [ntext] NULL,
	[Creator] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_PurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số ĐĐH' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Orders', @level2type=N'COLUMN', @level2name=N'Code'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày đặt hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Orders', @level2type=N'COLUMN', @level2name=N'Date'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Người liên lạc' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Orders', @level2type=N'COLUMN', @level2name=N'ContactPerson'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nguyên nhân đặt hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Orders', @level2type=N'COLUMN', @level2name=N'OrderReason'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày giao hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Orders', @level2type=N'COLUMN', @level2name=N'DeliveryDate'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Địa điểm giao hàng' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Orders', @level2type=N'COLUMN', @level2name=N'DeliveryLocation'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Người nhận' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Orders', @level2type=N'COLUMN', @level2name=N'Receiver'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mat.Request.Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mat.Request.Details](
	[ID] [uniqueidentifier] NOT NULL,
	[RequestID] [uniqueidentifier] NULL,
	[MaterialID] [uniqueidentifier] NULL,
	[RequestedQuantity] [float] NULL,
	[ApprovedQuantity] [float] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Mat.ReqDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng yêu cầu' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Request.Details', @level2type=N'COLUMN', @level2name=N'RequestedQuantity'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sớ lượng được duyệt' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'Mat.Request.Details', @level2type=N'COLUMN', @level2name=N'ApprovedQuantity'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Store.Locations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Store.Locations](
	[LocationID] [uniqueidentifier] NOT NULL,
	[StoreID] [uniqueidentifier] NULL,
	[Location] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[Active] [bit] NULL,
	[Updator] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Store.Locations] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Car.Maintenances_Cars]') AND parent_object_id = OBJECT_ID(N'[dbo].[Car.Maintenances]'))
ALTER TABLE [dbo].[Car.Maintenances]  WITH CHECK ADD  CONSTRAINT [FK_Car.Maintenances_Cars] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Car.Schedules_Car.Drivers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Car.Schedules]'))
ALTER TABLE [dbo].[Car.Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Car.Schedules_Car.Drivers] FOREIGN KEY([DriverID])
REFERENCES [dbo].[Car.Drivers] ([DriverID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Car.Schedules_Cars]') AND parent_object_id = OBJECT_ID(N'[dbo].[Car.Schedules]'))
ALTER TABLE [dbo].[Car.Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Car.Schedules_Cars] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Repair.Details_Mat.Repairs]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Repair.Details]'))
ALTER TABLE [dbo].[Mat.Repair.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Repair.Details_Mat.Repairs] FOREIGN KEY([RepairID])
REFERENCES [dbo].[Mat.Repairs] ([RepairID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Repair.Details_Materials]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Repair.Details]'))
ALTER TABLE [dbo].[Mat.Repair.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Repair.Details_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Equipments_EQ.Categories]') AND parent_object_id = OBJECT_ID(N'[dbo].[Equipments]'))
ALTER TABLE [dbo].[Equipments]  WITH CHECK ADD  CONSTRAINT [FK_Equipments_EQ.Categories] FOREIGN KEY([EQCatID])
REFERENCES [dbo].[EQ.Categories] ([EQCatID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Equipments_Units]') AND parent_object_id = OBJECT_ID(N'[dbo].[Equipments]'))
ALTER TABLE [dbo].[Equipments]  WITH CHECK ADD  CONSTRAINT [FK_Equipments_Units] FOREIGN KEY([UnitID])
REFERENCES [dbo].[Units] ([UnitID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Materials_Mat.Categories]') AND parent_object_id = OBJECT_ID(N'[dbo].[Materials]'))
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD  CONSTRAINT [FK_Materials_Mat.Categories] FOREIGN KEY([MatCatID])
REFERENCES [dbo].[Mat.Categories] ([MatCatID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Materials_Units]') AND parent_object_id = OBJECT_ID(N'[dbo].[Materials]'))
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD  CONSTRAINT [FK_Materials_Units] FOREIGN KEY([UnitID])
REFERENCES [dbo].[Units] ([UnitID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Quote.Suppliers_EQ.Quotes]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Quote.Suppliers]'))
ALTER TABLE [dbo].[EQ.Quote.Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Quote.Suppliers_EQ.Quotes] FOREIGN KEY([QuoteID])
REFERENCES [dbo].[EQ.Quotes] ([QuoteID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Quote.Details_EQ.Quotes1]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Quote.Details]'))
ALTER TABLE [dbo].[EQ.Quote.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Quote.Details_EQ.Quotes1] FOREIGN KEY([QuoteID])
REFERENCES [dbo].[EQ.Quotes] ([QuoteID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Quote.Details_Equipments]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Quote.Details]'))
ALTER TABLE [dbo].[EQ.Quote.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Quote.Details_Equipments] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipments] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Contract.Details_EQ.Contracts]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Contract.Details]'))
ALTER TABLE [dbo].[EQ.Contract.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Contract.Details_EQ.Contracts] FOREIGN KEY([ContractID])
REFERENCES [dbo].[EQ.Contracts] ([ContractID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Contract.Details_Equipments]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Contract.Details]'))
ALTER TABLE [dbo].[EQ.Contract.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Contract.Details_Equipments] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipments] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Request.Details_EQ.Requests1]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Request.Details]'))
ALTER TABLE [dbo].[EQ.Request.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Request.Details_EQ.Requests1] FOREIGN KEY([RequestID])
REFERENCES [dbo].[EQ.Requests] ([RequestID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Request.Details_Equipments]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Request.Details]'))
ALTER TABLE [dbo].[EQ.Request.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Request.Details_Equipments] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipments] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Input.Details_EQ.Inputs]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Input.Details]'))
ALTER TABLE [dbo].[EQ.Input.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Input.Details_EQ.Inputs] FOREIGN KEY([InputID])
REFERENCES [dbo].[EQ.Inputs] ([InputID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Inventory.Locations_EQ.Inventory]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Inventory.Locations]'))
ALTER TABLE [dbo].[EQ.Inventory.Locations]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Inventory.Locations_EQ.Inventory] FOREIGN KEY([InventoryID])
REFERENCES [dbo].[EQ.Inventory] ([InventoryID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Output.Details_EQ.Outputs]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Output.Details]'))
ALTER TABLE [dbo].[EQ.Output.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Output.Details_EQ.Outputs] FOREIGN KEY([OutputID])
REFERENCES [dbo].[EQ.Outputs] ([OutputID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Order.Details_EQ.Orders]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Order.Details]'))
ALTER TABLE [dbo].[EQ.Order.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Order.Details_EQ.Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[EQ.Orders] ([OrderID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EQ.Order.Details_Equipments]') AND parent_object_id = OBJECT_ID(N'[dbo].[EQ.Order.Details]'))
ALTER TABLE [dbo].[EQ.Order.Details]  WITH CHECK ADD  CONSTRAINT [FK_EQ.Order.Details_Equipments] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipments] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserRoles_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserRoles]'))
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserRoles_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserRoles]'))
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Input.Details_Mat.Inputs]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Input.Details]'))
ALTER TABLE [dbo].[Mat.Input.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Input.Details_Mat.Inputs] FOREIGN KEY([InputID])
REFERENCES [dbo].[Mat.Inputs] ([InputID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Input.Details_Materials]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Input.Details]'))
ALTER TABLE [dbo].[Mat.Input.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Input.Details_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Suppliers_CoTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Suppliers]'))
ALTER TABLE [dbo].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Suppliers_CoTypes] FOREIGN KEY([CoTypeID])
REFERENCES [dbo].[CoTypes] ([CoTypeID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_Departments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Departments] FOREIGN KEY([DeptID])
REFERENCES [dbo].[Departments] ([DeptID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Car.Drivers_Employees]') AND parent_object_id = OBJECT_ID(N'[dbo].[Car.Drivers]'))
ALTER TABLE [dbo].[Car.Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Car.Drivers_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Inputs_Mat.Orders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Inputs]'))
ALTER TABLE [dbo].[Mat.Inputs]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Inputs_Mat.Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Mat.Orders] ([OrderID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Order.Details_Mat.Orders]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Order.Details]'))
ALTER TABLE [dbo].[Mat.Order.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Order.Details_Mat.Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Mat.Orders] ([OrderID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Order.Details_Materials]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Order.Details]'))
ALTER TABLE [dbo].[Mat.Order.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Order.Details_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Orders_Mat.Requests]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Orders]'))
ALTER TABLE [dbo].[Mat.Orders]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Orders_Mat.Requests] FOREIGN KEY([RequestID])
REFERENCES [dbo].[Mat.Requests] ([RequestID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Request.Details_Mat.Requests]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Request.Details]'))
ALTER TABLE [dbo].[Mat.Request.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Request.Details_Mat.Requests] FOREIGN KEY([RequestID])
REFERENCES [dbo].[Mat.Requests] ([RequestID])
ON DELETE CASCADE
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Mat.Request.Details_Materials]') AND parent_object_id = OBJECT_ID(N'[dbo].[Mat.Request.Details]'))
ALTER TABLE [dbo].[Mat.Request.Details]  WITH CHECK ADD  CONSTRAINT [FK_Mat.Request.Details_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Store.Locations_Stores]') AND parent_object_id = OBJECT_ID(N'[dbo].[Store.Locations]'))
ALTER TABLE [dbo].[Store.Locations]  WITH CHECK ADD  CONSTRAINT [FK_Store.Locations_Stores] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Stores] ([StoreID])
ON DELETE CASCADE
