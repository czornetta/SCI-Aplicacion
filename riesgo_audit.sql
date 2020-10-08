USE [SCIDB]
GO

/****** Object:  Table [LAPTOP-8VO8MIH3\czorn].[riesgo_audit]    Script Date: 04/10/2020 1:04:00 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit](
	[idriesgoaudit] [int] IDENTITY(1,1) NOT NULL,
	[idriesgo] [int] NOT NULL,
	[idmatrizcontrol] [int] NOT NULL,
	[idareanegocio] [int] NOT NULL,
	[nombre] [varchar](max) NOT NULL,
	[idclasificacionriesgo] [int] NOT NULL,
	[idestadoriesgo] [int] NOT NULL,
	[observacion] [varchar](max) NULL,
	[comentario] [varchar](max) NULL,
	[tipotransaccion] [varchar](1) NOT NULL,
	[idusuario] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_riesgo_audit] PRIMARY KEY CLUSTERED 
(
	[idriesgoaudit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_audit_area_negocio] FOREIGN KEY([idareanegocio])
REFERENCES [LAPTOP-8VO8MIH3\czorn].[area_negocio] ([idareanegocio])
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit] CHECK CONSTRAINT [FK_riesgo_audit_area_negocio]
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_audit_Clasificacion_riesgo] FOREIGN KEY([idclasificacionriesgo])
REFERENCES [LAPTOP-8VO8MIH3\czorn].[Clasificacion_riesgo] ([idclasificacionriesgo])
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit] CHECK CONSTRAINT [FK_riesgo_audit_Clasificacion_riesgo]
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_audit_Estado_Riesgo] FOREIGN KEY([idestadoriesgo])
REFERENCES [LAPTOP-8VO8MIH3\czorn].[Estado_Riesgo] ([idestadoriesgo])
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit] CHECK CONSTRAINT [FK_riesgo_audit_Estado_Riesgo]
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_audit_matriz_control] FOREIGN KEY([idmatrizcontrol])
REFERENCES [LAPTOP-8VO8MIH3\czorn].[matriz_control] ([idmatrizcontrol])
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit] CHECK CONSTRAINT [FK_riesgo_audit_matriz_control]
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_audit_usuario] FOREIGN KEY([idusuario])
REFERENCES [LAPTOP-8VO8MIH3\czorn].[usuario] ([idusuario])
GO

ALTER TABLE [LAPTOP-8VO8MIH3\czorn].[riesgo_audit] CHECK CONSTRAINT [FK_riesgo_audit_usuario]
GO

