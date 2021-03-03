

/****** Object:  Table [dbo].[Employee]    Script Date: 22-02-2021 09:54:51 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
	/****** Object:  Table [dbo].[Employee]    Script Date: 22-02-2021 09:54:51 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON
	
	CREATE TABLE [dbo].[Employee](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
	[Age] [int] NULL,
	[Salary] [int] NULL,
	PRIMARY KEY CLUSTERED 
	(
		[EmpId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]	

END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Departmet]') AND type in (N'U'))
BEGIN
	/****** Object:  Table [dbo].[Departmet]    Script Date: 22-02-2021 09:53:33 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	CREATE TABLE [dbo].[Departmet](
		[DeptID] [int] NOT NULL,
		[DeptName] [varchar](50) NULL,
		[IsActive] [bit] NULL
	) ON [PRIMARY]

END






