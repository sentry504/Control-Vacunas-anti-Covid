USE [Covid_Vacunas_DB]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/10/2022 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Codigo_Usuario] [varchar](50) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Password] [varchar](10) NULL,
	[Tipo_Usuario] [varchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Codigo_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewUsuarios]    Script Date: 17/10/2022 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewUsuarios]
AS
SELECT        dbo.Usuarios.*
FROM            dbo.Usuarios
GO
/****** Object:  Table [dbo].[Centros_Asistencia]    Script Date: 17/10/2022 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Centros_Asistencia](
	[Codigo_Centro_Medico] [varchar](50) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Capacidad] [int] NULL,
	[Numero_Medicos] [int] NULL,
	[Numero_Enfermeras] [int] NULL,
	[Numero_Pacientes] [int] NULL,
	[Tipo_Centro_Medico] [varchar](50) NULL,
 CONSTRAINT [PK_Centros_Asistencia] PRIMARY KEY CLUSTERED 
(
	[Codigo_Centro_Medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudadanos]    Script Date: 17/10/2022 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudadanos](
	[Identidad] [varchar](15) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Edad] [int] NULL,
	[Residencia] [varchar](100) NULL,
	[Vacunas] [int] NULL,
	[ID_Vacuna] [varchar](10) NULL,
	[Fecha_Ultima_Dosis] [date] NULL,
 CONSTRAINT [PK_Ciudadanos] PRIMARY KEY CLUSTERED 
(
	[Identidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacuna]    Script Date: 17/10/2022 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacuna](
	[ID_Vacuna] [varchar](10) NOT NULL,
	[Nombre_Vacuna] [varchar](100) NOT NULL,
 CONSTRAINT [PK_vacuna_1] PRIMARY KEY CLUSTERED 
(
	[ID_Vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacunas]    Script Date: 17/10/2022 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacunas](
	[Registro] [varchar](50) NOT NULL,
	[Fecha_registro] [date] NULL,
	[ID_Vacuna] [varchar](10) NULL,
	[Cantidad] [int] NULL,
	[Tipo_registro] [varchar](50) NULL,
	[Origen] [varchar](150) NULL,
	[Destino] [varchar](150) NULL,
 CONSTRAINT [PK_Vacunas] PRIMARY KEY CLUSTERED 
(
	[Registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VacunasCiudadano]    Script Date: 17/10/2022 21:08:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VacunasCiudadano](
	[Identidad] [varchar](15) NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_VacunasCiudadano] PRIMARY KEY CLUSTERED 
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ciudadanos]  WITH CHECK ADD  CONSTRAINT [FK_Ciudadanos_Vacuna] FOREIGN KEY([ID_Vacuna])
REFERENCES [dbo].[Vacuna] ([ID_Vacuna])
GO
ALTER TABLE [dbo].[Ciudadanos] CHECK CONSTRAINT [FK_Ciudadanos_Vacuna]
GO
ALTER TABLE [dbo].[Vacunas]  WITH CHECK ADD  CONSTRAINT [FK_Vacunas_Vacuna] FOREIGN KEY([ID_Vacuna])
REFERENCES [dbo].[Vacuna] ([ID_Vacuna])
GO
ALTER TABLE [dbo].[Vacunas] CHECK CONSTRAINT [FK_Vacunas_Vacuna]
GO
ALTER TABLE [dbo].[VacunasCiudadano]  WITH CHECK ADD  CONSTRAINT [FK_VacunasCiudadano_Ciudadanos] FOREIGN KEY([Identidad])
REFERENCES [dbo].[Ciudadanos] ([Identidad])
GO
ALTER TABLE [dbo].[VacunasCiudadano] CHECK CONSTRAINT [FK_VacunasCiudadano_Ciudadanos]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuarios"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewUsuarios'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewUsuarios'
GO
