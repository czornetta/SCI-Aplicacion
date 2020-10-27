USE [SCIPrueba]
GO
/****** Object:  StoredProcedure [dbo].[updUsuario]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updUsuario]
GO
/****** Object:  StoredProcedure [dbo].[updTraduccion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updTraduccion]
GO
/****** Object:  StoredProcedure [dbo].[updRiesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updRiesgo]
GO
/****** Object:  StoredProcedure [dbo].[updPrivilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updPrivilegio]
GO
/****** Object:  StoredProcedure [dbo].[updMatrizControl]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updMatrizControl]
GO
/****** Object:  StoredProcedure [dbo].[updIdioma]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updIdioma]
GO
/****** Object:  StoredProcedure [dbo].[updExcepcion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updExcepcion]
GO
/****** Object:  StoredProcedure [dbo].[updEtiqueta]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updEtiqueta]
GO
/****** Object:  StoredProcedure [dbo].[updDVEntidad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updDVEntidad]
GO
/****** Object:  StoredProcedure [dbo].[updControlInterno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updControlInterno]
GO
/****** Object:  StoredProcedure [dbo].[updCertificacion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updCertificacion]
GO
/****** Object:  StoredProcedure [dbo].[updAreaNegocio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[updAreaNegocio]
GO
/****** Object:  StoredProcedure [dbo].[restoreRiesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[restoreRiesgo]
GO
/****** Object:  StoredProcedure [dbo].[getUsuarios]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getUsuarios]
GO
/****** Object:  StoredProcedure [dbo].[getUsuarioPrivilegios]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getUsuarioPrivilegios]
GO
/****** Object:  StoredProcedure [dbo].[getTraducciones]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getTraducciones]
GO
/****** Object:  StoredProcedure [dbo].[getTiposRegistro]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getTiposRegistro]
GO
/****** Object:  StoredProcedure [dbo].[getTipoControl]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getTipoControl]
GO
/****** Object:  StoredProcedure [dbo].[getRoles]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getRoles]
GO
/****** Object:  StoredProcedure [dbo].[getRiesgosAudit]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getRiesgosAudit]
GO
/****** Object:  StoredProcedure [dbo].[getRiesgos]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getRiesgos]
GO
/****** Object:  StoredProcedure [dbo].[getResutadoCertificacion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getResutadoCertificacion]
GO
/****** Object:  StoredProcedure [dbo].[getPrivilegios]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getPrivilegios]
GO
/****** Object:  StoredProcedure [dbo].[getPermisos]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getPermisos]
GO
/****** Object:  StoredProcedure [dbo].[getPeriodicidadControl]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getPeriodicidadControl]
GO
/****** Object:  StoredProcedure [dbo].[getMatrizControlResumen]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getMatrizControlResumen]
GO
/****** Object:  StoredProcedure [dbo].[getMatricesControl]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getMatricesControl]
GO
/****** Object:  StoredProcedure [dbo].[getIdiomas]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getIdiomas]
GO
/****** Object:  StoredProcedure [dbo].[getEtiquetas]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getEtiquetas]
GO
/****** Object:  StoredProcedure [dbo].[getEstadosRiesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getEstadosRiesgo]
GO
/****** Object:  StoredProcedure [dbo].[getEstadosMatrizControl]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getEstadosMatrizControl]
GO
/****** Object:  StoredProcedure [dbo].[getEstadosExcepcion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getEstadosExcepcion]
GO
/****** Object:  StoredProcedure [dbo].[getEstadosControlInterno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getEstadosControlInterno]
GO
/****** Object:  StoredProcedure [dbo].[getDVEntidad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getDVEntidad]
GO
/****** Object:  StoredProcedure [dbo].[getControlesInternos]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getControlesInternos]
GO
/****** Object:  StoredProcedure [dbo].[getClasificacionesRiesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getClasificacionesRiesgo]
GO
/****** Object:  StoredProcedure [dbo].[getCertificaciones]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getCertificaciones]
GO
/****** Object:  StoredProcedure [dbo].[getBitacora]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getBitacora]
GO
/****** Object:  StoredProcedure [dbo].[getBackups]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getBackups]
GO
/****** Object:  StoredProcedure [dbo].[getAreasNegocio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[getAreasNegocio]
GO
/****** Object:  StoredProcedure [dbo].[doBackup]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[doBackup]
GO
/****** Object:  StoredProcedure [dbo].[delUsuarioPrivilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delUsuarioPrivilegio]
GO
/****** Object:  StoredProcedure [dbo].[delUsuario]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delUsuario]
GO
/****** Object:  StoredProcedure [dbo].[delTraduccion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delTraduccion]
GO
/****** Object:  StoredProcedure [dbo].[delRiesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delRiesgo]
GO
/****** Object:  StoredProcedure [dbo].[delPrivilegioHijo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delPrivilegioHijo]
GO
/****** Object:  StoredProcedure [dbo].[delPrivilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delPrivilegio]
GO
/****** Object:  StoredProcedure [dbo].[delMatrizControl]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delMatrizControl]
GO
/****** Object:  StoredProcedure [dbo].[delIdioma]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delIdioma]
GO
/****** Object:  StoredProcedure [dbo].[delEtiqueta]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delEtiqueta]
GO
/****** Object:  StoredProcedure [dbo].[delControlInterno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delControlInterno]
GO
/****** Object:  StoredProcedure [dbo].[delAreaNegocio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[delAreaNegocio]
GO
/****** Object:  StoredProcedure [dbo].[addUsuarioPrivilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addUsuarioPrivilegio]
GO
/****** Object:  StoredProcedure [dbo].[addUsuario]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addUsuario]
GO
/****** Object:  StoredProcedure [dbo].[addTraduccion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addTraduccion]
GO
/****** Object:  StoredProcedure [dbo].[addRiesgoAudit]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addRiesgoAudit]
GO
/****** Object:  StoredProcedure [dbo].[addRiesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addRiesgo]
GO
/****** Object:  StoredProcedure [dbo].[addPrivilegioHijo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addPrivilegioHijo]
GO
/****** Object:  StoredProcedure [dbo].[addPrivilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addPrivilegio]
GO
/****** Object:  StoredProcedure [dbo].[addMatrizControl]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addMatrizControl]
GO
/****** Object:  StoredProcedure [dbo].[addIncidente]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addIncidente]
GO
/****** Object:  StoredProcedure [dbo].[addIdioma]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addIdioma]
GO
/****** Object:  StoredProcedure [dbo].[addExcepcion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addExcepcion]
GO
/****** Object:  StoredProcedure [dbo].[addEtiqueta]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addEtiqueta]
GO
/****** Object:  StoredProcedure [dbo].[addControlInterno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addControlInterno]
GO
/****** Object:  StoredProcedure [dbo].[addCertificacion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addCertificacion]
GO
/****** Object:  StoredProcedure [dbo].[addBitacora]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addBitacora]
GO
/****** Object:  StoredProcedure [dbo].[addAreaNegocio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[addAreaNegocio]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuario_privilegio]') AND type in (N'U'))
ALTER TABLE [dbo].[usuario_privilegio] DROP CONSTRAINT IF EXISTS [FK_usuario_privilegio_usuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuario_privilegio]') AND type in (N'U'))
ALTER TABLE [dbo].[usuario_privilegio] DROP CONSTRAINT IF EXISTS [FK_usuario_privilegio_privilegio]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuario]') AND type in (N'U'))
ALTER TABLE [dbo].[usuario] DROP CONSTRAINT IF EXISTS [FK_usuario_DV_Entidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuario]') AND type in (N'U'))
ALTER TABLE [dbo].[usuario] DROP CONSTRAINT IF EXISTS [FK_usuario_area_negocio]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Traduccion]') AND type in (N'U'))
ALTER TABLE [dbo].[Traduccion] DROP CONSTRAINT IF EXISTS [FK_Traduccion_Idioma]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Traduccion]') AND type in (N'U'))
ALTER TABLE [dbo].[Traduccion] DROP CONSTRAINT IF EXISTS [FK_Traduccion_Etiqueta]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[riesgo_audit]') AND type in (N'U'))
ALTER TABLE [dbo].[riesgo_audit] DROP CONSTRAINT IF EXISTS [FK_riesgo_audit_usuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[riesgo]') AND type in (N'U'))
ALTER TABLE [dbo].[riesgo] DROP CONSTRAINT IF EXISTS [FK_riesgo_matriz_control]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[riesgo]') AND type in (N'U'))
ALTER TABLE [dbo].[riesgo] DROP CONSTRAINT IF EXISTS [FK_riesgo_Estado_Riesgo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[riesgo]') AND type in (N'U'))
ALTER TABLE [dbo].[riesgo] DROP CONSTRAINT IF EXISTS [FK_riesgo_Clasificacion_riesgo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[riesgo]') AND type in (N'U'))
ALTER TABLE [dbo].[riesgo] DROP CONSTRAINT IF EXISTS [FK_riesgo_area_negocio]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[privilegio_privilegio]') AND type in (N'U'))
ALTER TABLE [dbo].[privilegio_privilegio] DROP CONSTRAINT IF EXISTS [FK_privilegio_privilegio_privilegio1]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[privilegio_privilegio]') AND type in (N'U'))
ALTER TABLE [dbo].[privilegio_privilegio] DROP CONSTRAINT IF EXISTS [FK_privilegio_privilegio_privilegio]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[matriz_control]') AND type in (N'U'))
ALTER TABLE [dbo].[matriz_control] DROP CONSTRAINT IF EXISTS [FK_matriz_control_Estado_Matriz_Control]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[control_interno]') AND type in (N'U'))
ALTER TABLE [dbo].[control_interno] DROP CONSTRAINT IF EXISTS [FK_control_interno_tipo_control]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[control_interno]') AND type in (N'U'))
ALTER TABLE [dbo].[control_interno] DROP CONSTRAINT IF EXISTS [FK_control_interno_riesgo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[control_interno]') AND type in (N'U'))
ALTER TABLE [dbo].[control_interno] DROP CONSTRAINT IF EXISTS [FK_control_interno_Estado_Control_Interno]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Certificacion_Incidente]') AND type in (N'U'))
ALTER TABLE [dbo].[Certificacion_Incidente] DROP CONSTRAINT IF EXISTS [FK_Certificacion_Incidente_Certificacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Certificacion_Excepcion]') AND type in (N'U'))
ALTER TABLE [dbo].[Certificacion_Excepcion] DROP CONSTRAINT IF EXISTS [FK_Certificacion_Excepcion_Estado_Excepcion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Certificacion_Excepcion]') AND type in (N'U'))
ALTER TABLE [dbo].[Certificacion_Excepcion] DROP CONSTRAINT IF EXISTS [FK_Certificacion_Excepcion_Certificacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Certificacion]') AND type in (N'U'))
ALTER TABLE [dbo].[Certificacion] DROP CONSTRAINT IF EXISTS [FK_Certificacion_usuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Certificacion]') AND type in (N'U'))
ALTER TABLE [dbo].[Certificacion] DROP CONSTRAINT IF EXISTS [FK_Certificacion_Resultado_Certificacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Certificacion]') AND type in (N'U'))
ALTER TABLE [dbo].[Certificacion] DROP CONSTRAINT IF EXISTS [FK_Certificacion_control_interno]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[bitacora]') AND type in (N'U'))
ALTER TABLE [dbo].[bitacora] DROP CONSTRAINT IF EXISTS [FK_bitacora_usuario]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Idioma]') AND type in (N'U'))
ALTER TABLE [dbo].[Idioma] DROP CONSTRAINT IF EXISTS [DF_Idioma_principal]
GO
/****** Object:  Table [dbo].[usuario_privilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[usuario_privilegio]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[usuario]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Traduccion]
GO
/****** Object:  Table [dbo].[tipo_control]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[tipo_control]
GO
/****** Object:  Table [dbo].[riesgo_audit]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[riesgo_audit]
GO
/****** Object:  Table [dbo].[riesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[riesgo]
GO
/****** Object:  Table [dbo].[Resultado_Certificacion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Resultado_Certificacion]
GO
/****** Object:  Table [dbo].[privilegio_privilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[privilegio_privilegio]
GO
/****** Object:  Table [dbo].[privilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[privilegio]
GO
/****** Object:  Table [dbo].[periodicidad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[periodicidad]
GO
/****** Object:  Table [dbo].[matriz_control]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[matriz_control]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Idioma]
GO
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Etiqueta]
GO
/****** Object:  Table [dbo].[Estado_Riesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Estado_Riesgo]
GO
/****** Object:  Table [dbo].[Estado_Matriz_Control]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Estado_Matriz_Control]
GO
/****** Object:  Table [dbo].[Estado_Excepcion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Estado_Excepcion]
GO
/****** Object:  Table [dbo].[Estado_Control_Interno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Estado_Control_Interno]
GO
/****** Object:  Table [dbo].[DV_Entidad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[DV_Entidad]
GO
/****** Object:  Table [dbo].[copia_seguridad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[copia_seguridad]
GO
/****** Object:  Table [dbo].[control_interno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[control_interno]
GO
/****** Object:  Table [dbo].[Clasificacion_riesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Clasificacion_riesgo]
GO
/****** Object:  Table [dbo].[Certificacion_Incidente]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Certificacion_Incidente]
GO
/****** Object:  Table [dbo].[Certificacion_Excepcion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Certificacion_Excepcion]
GO
/****** Object:  Table [dbo].[Certificacion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Certificacion]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[bitacora]
GO
/****** Object:  Table [dbo].[area_negocio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
DROP TABLE IF EXISTS [dbo].[area_negocio]
GO
/****** Object:  Table [dbo].[area_negocio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[area_negocio](
	[idareanegocio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_area_negocio] PRIMARY KEY CLUSTERED 
(
	[idareanegocio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[idbitacora] [int] IDENTITY(1,1) NOT NULL,
	[idusuario] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[tipo_registro] [varchar](50) NOT NULL,
	[descripcion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_bitacora] PRIMARY KEY CLUSTERED 
(
	[idbitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Certificacion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificacion](
	[idcertificacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[idcontrolinterno] [int] NOT NULL,
	[idresultado] [int] NOT NULL,
	[idusuario] [int] NOT NULL,
 CONSTRAINT [PK_Certificacion] PRIMARY KEY CLUSTERED 
(
	[idcertificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Certificacion_Excepcion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificacion_Excepcion](
	[idexcepcion] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](max) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[idestado] [int] NOT NULL,
	[idcertificacion] [int] NOT NULL,
 CONSTRAINT [PK_Certificacion_Excepcion] PRIMARY KEY CLUSTERED 
(
	[idexcepcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Certificacion_Incidente]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificacion_Incidente](
	[idincidente] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](max) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[idcertificacion] [int] NOT NULL,
 CONSTRAINT [PK_Certificacion_Incidente] PRIMARY KEY CLUSTERED 
(
	[idincidente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clasificacion_riesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clasificacion_riesgo](
	[idclasificacionriesgo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Clasificacion_riesgo] PRIMARY KEY CLUSTERED 
(
	[idclasificacionriesgo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[control_interno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[control_interno](
	[idcontrolinterno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](max) NOT NULL,
	[idtipocontrol] [int] NOT NULL,
	[idperiodicidad] [int] NOT NULL,
	[idriesgo] [int] NOT NULL,
	[observacion] [varchar](max) NULL,
	[comentario] [varchar](max) NULL,
	[idestadocontrolinterno] [int] NOT NULL,
 CONSTRAINT [PK_control_interno] PRIMARY KEY CLUSTERED 
(
	[idcontrolinterno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[copia_seguridad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[copia_seguridad](
	[fecha] [datetime] NOT NULL,
	[idusuario] [int] NOT NULL,
	[archivo] [varchar](max) NOT NULL,
 CONSTRAINT [PK_copia_seguridad] PRIMARY KEY CLUSTERED 
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DV_Entidad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DV_Entidad](
	[iddventidad] [int] IDENTITY(1,1) NOT NULL,
	[entidad] [varchar](max) NOT NULL,
	[dventidad] [varchar](max) NOT NULL,
 CONSTRAINT [PK_DV_Entidad] PRIMARY KEY CLUSTERED 
(
	[iddventidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Control_Interno]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Control_Interno](
	[idestadocontrolinterno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[clase] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estado_Control_Interno] PRIMARY KEY CLUSTERED 
(
	[idestadocontrolinterno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Excepcion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Excepcion](
	[idestado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Estado_Excepcion] PRIMARY KEY CLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Matriz_Control]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Matriz_Control](
	[idestado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estado_Matriz_Control] PRIMARY KEY CLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Riesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Riesgo](
	[idestadoriesgo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[clase] [varchar](50) NULL,
 CONSTRAINT [PK_Estado_Riesgo] PRIMARY KEY CLUSTERED 
(
	[idestadoriesgo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etiqueta](
	[idetiqueta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Etiqueta] PRIMARY KEY CLUSTERED 
(
	[idetiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[idIdioma] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[principal] [bit] NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[idIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[matriz_control]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[matriz_control](
	[idmatrizcontrol] [int] IDENTITY(1,1) NOT NULL,
	[periodo] [int] NOT NULL,
	[idestado] [int] NOT NULL,
 CONSTRAINT [PK_matriz_control] PRIMARY KEY CLUSTERED 
(
	[idmatrizcontrol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[periodicidad]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[periodicidad](
	[idperiodicidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_periodicidad] PRIMARY KEY CLUSTERED 
(
	[idperiodicidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[privilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[privilegio](
	[idprivilegio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[llave] [varchar](50) NULL,
 CONSTRAINT [PK_privilegio] PRIMARY KEY CLUSTERED 
(
	[idprivilegio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[privilegio_privilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[privilegio_privilegio](
	[idprivilegio_padre] [int] NOT NULL,
	[idprivilegio_hijo] [int] NOT NULL,
 CONSTRAINT [PK_privilegio_privilegio] PRIMARY KEY CLUSTERED 
(
	[idprivilegio_padre] ASC,
	[idprivilegio_hijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resultado_Certificacion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resultado_Certificacion](
	[idresultado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Resultado_Certificacion] PRIMARY KEY CLUSTERED 
(
	[idresultado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[riesgo]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[riesgo](
	[idriesgo] [int] IDENTITY(1,1) NOT NULL,
	[idmatrizcontrol] [int] NOT NULL,
	[idareanegocio] [int] NOT NULL,
	[nombre] [varchar](max) NOT NULL,
	[idclasificacionriesgo] [int] NOT NULL,
	[idestadoriesgo] [int] NOT NULL,
	[observacion] [varchar](max) NULL,
	[comentario] [varchar](max) NULL,
 CONSTRAINT [PK_riesgo] PRIMARY KEY CLUSTERED 
(
	[idriesgo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[riesgo_audit]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[riesgo_audit](
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
/****** Object:  Table [dbo].[tipo_control]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_control](
	[idtipocontrol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_control] PRIMARY KEY CLUSTERED 
(
	[idtipocontrol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ididioma] [int] NOT NULL,
	[idetiqueta] [int] NOT NULL,
	[traduccion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[ididioma] ASC,
	[idetiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[clave] [varchar](50) NOT NULL,
	[idareanegocio] [int] NOT NULL,
	[dvregistro] [varchar](max) NULL,
	[iddventidad] [int] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario_privilegio]    Script Date: 27/10/2020 2:18:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario_privilegio](
	[idusuario] [int] NOT NULL,
	[idprivilegio] [int] NOT NULL,
 CONSTRAINT [PK_usuario_privilegio] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC,
	[idprivilegio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[area_negocio] ON 
GO
INSERT [dbo].[area_negocio] ([idareanegocio], [nombre]) VALUES (1, N'Auditoria')
GO
INSERT [dbo].[area_negocio] ([idareanegocio], [nombre]) VALUES (2, N'Contabilidad')
GO
INSERT [dbo].[area_negocio] ([idareanegocio], [nombre]) VALUES (3, N'Sistemas')
GO
INSERT [dbo].[area_negocio] ([idareanegocio], [nombre]) VALUES (4, N'Finanzas')
GO
INSERT [dbo].[area_negocio] ([idareanegocio], [nombre]) VALUES (6, N'Producción')
GO
INSERT [dbo].[area_negocio] ([idareanegocio], [nombre]) VALUES (7, N'Facturación')
GO
INSERT [dbo].[area_negocio] ([idareanegocio], [nombre]) VALUES (8, N'Legales')
GO
SET IDENTITY_INSERT [dbo].[area_negocio] OFF
GO
SET IDENTITY_INSERT [dbo].[bitacora] ON 
GO
INSERT [dbo].[bitacora] ([idbitacora], [idusuario], [fecha], [tipo_registro], [descripcion]) VALUES (1, 2, CAST(N'2020-10-27T14:04:49.207' AS DateTime), N'Evento', N'ValidUser')
GO
SET IDENTITY_INSERT [dbo].[bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Clasificacion_riesgo] ON 
GO
INSERT [dbo].[Clasificacion_riesgo] ([idclasificacionriesgo], [nombre]) VALUES (1, N'Alto')
GO
INSERT [dbo].[Clasificacion_riesgo] ([idclasificacionriesgo], [nombre]) VALUES (2, N'Medio')
GO
INSERT [dbo].[Clasificacion_riesgo] ([idclasificacionriesgo], [nombre]) VALUES (3, N'Bajo')
GO
SET IDENTITY_INSERT [dbo].[Clasificacion_riesgo] OFF
GO
SET IDENTITY_INSERT [dbo].[DV_Entidad] ON 
GO
INSERT [dbo].[DV_Entidad] ([iddventidad], [entidad], [dventidad]) VALUES (3, N'Usuario', N'+asWhS1FXOkgPaZPT8f5LQ==')
GO
SET IDENTITY_INSERT [dbo].[DV_Entidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado_Control_Interno] ON 
GO
INSERT [dbo].[Estado_Control_Interno] ([idestadocontrolinterno], [nombre], [clase]) VALUES (1, N'Propuesto', N'Entidades.DefMatrizControl.ControlInternoPropuesto')
GO
INSERT [dbo].[Estado_Control_Interno] ([idestadocontrolinterno], [nombre], [clase]) VALUES (2, N'Aceptado', N'Entidades.DefMatrizControl.ControlInternoAceptado')
GO
INSERT [dbo].[Estado_Control_Interno] ([idestadocontrolinterno], [nombre], [clase]) VALUES (3, N'Observado', N'Entidades.DefMatrizControl.ControlInternoObservado')
GO
INSERT [dbo].[Estado_Control_Interno] ([idestadocontrolinterno], [nombre], [clase]) VALUES (4, N'Cancelado', N'Entidades.DefMatrizControl.ControlInternoCancelado')
GO
SET IDENTITY_INSERT [dbo].[Estado_Control_Interno] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado_Excepcion] ON 
GO
INSERT [dbo].[Estado_Excepcion] ([idestado], [nombre]) VALUES (1, N'Solicitada')
GO
INSERT [dbo].[Estado_Excepcion] ([idestado], [nombre]) VALUES (2, N'Aceptada')
GO
INSERT [dbo].[Estado_Excepcion] ([idestado], [nombre]) VALUES (3, N'Rechazada')
GO
SET IDENTITY_INSERT [dbo].[Estado_Excepcion] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado_Matriz_Control] ON 
GO
INSERT [dbo].[Estado_Matriz_Control] ([idestado], [nombre]) VALUES (1, N'Relevamiento')
GO
INSERT [dbo].[Estado_Matriz_Control] ([idestado], [nombre]) VALUES (2, N'Definición')
GO
INSERT [dbo].[Estado_Matriz_Control] ([idestado], [nombre]) VALUES (3, N'Activo')
GO
INSERT [dbo].[Estado_Matriz_Control] ([idestado], [nombre]) VALUES (4, N'Cerrado')
GO
SET IDENTITY_INSERT [dbo].[Estado_Matriz_Control] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado_Riesgo] ON 
GO
INSERT [dbo].[Estado_Riesgo] ([idestadoriesgo], [nombre], [clase]) VALUES (1, N'Propuesto', N'Entidades.DefMatrizControl.RiesgoPropuesto')
GO
INSERT [dbo].[Estado_Riesgo] ([idestadoriesgo], [nombre], [clase]) VALUES (2, N'Observado', N'Entidades.DefMatrizControl.RiesgoObservado')
GO
INSERT [dbo].[Estado_Riesgo] ([idestadoriesgo], [nombre], [clase]) VALUES (3, N'Aceptado', N'Entidades.DefMatrizControl.RiesgoAceptado')
GO
INSERT [dbo].[Estado_Riesgo] ([idestadoriesgo], [nombre], [clase]) VALUES (4, N'Cancelado', N'Entidades.DefMatrizControl.RiesgoCancelado')
GO
SET IDENTITY_INSERT [dbo].[Estado_Riesgo] OFF
GO
SET IDENTITY_INSERT [dbo].[Etiqueta] ON 
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (1, N'boton_agregar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (2, N'boton_modificar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (3, N'boton_borrar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (5, N'menu_sesion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (6, N'menu_seguridad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (7, N'menu_idioma')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (8, N'menu_prueba')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (9, N'iniciar_sesion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (10, N'cerrar_sesion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (11, N'usuarios')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (12, N'permisos')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (13, N'roles')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (14, N'idiomas')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (15, N'etiquetas')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (16, N'traducciones')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (17, N'gestion_encriptado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (18, N'boton_iniciar_sesion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (19, N'boton_cancelar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (20, N'etiqueta_nombre')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (21, N'etiqueta_clave')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (22, N'cambiar_idioma')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (23, N'boton_cambiarIdioma')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (24, N'etiqueta_cambiarA')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (25, N'etiqueta_principal')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (26, N'etiqueta_idioma')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (27, N'etiqueta_etiqueta')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (28, N'etiqueta_traduccion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (29, N'boton_cancelar_seleccion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (30, N'etiqueta_permiso')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (31, N'etiqueta_llave')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (32, N'boton_sacar_privilegio')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (33, N'etiqueta_privilegio')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (34, N'radio_rol')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (35, N'radio_permiso')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (36, N'boton_sacar_rol')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (37, N'etiqueta_seleccionar_rol')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (38, N'etiqueta_reescribir_clave')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (39, N'menu_matrizControl')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (40, N'etiqueta_areaNegocio')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (41, N'etiqueta_clasificacion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (42, N'etiqueta_estado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (43, N'etiqueta_periodo')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (44, N'riesgos')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (45, N'evaluar_riesgos')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (46, N'etiqueta_observacion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (47, N'etiqueta_comentario')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (48, N'boton_aceptar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (49, N'boton_observar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (50, N'riesgosObservados')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (51, N'boton_proponer')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (52, N'finalizar_relevamiento')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (53, N'definir_controles_internos')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (54, N'etiqueta_periodicidad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (55, N'etiqueta_tipoControl')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (56, N'etiqueta_descripcion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (57, N'controles_internos')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (58, N'evaluar_matrizControl')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (59, N'etiqueta_controlInterno')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (60, N'controles_observados')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (61, N'etiqueta_riesgo')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (62, N'periodo_control')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (63, N'msg_cerrar_sesion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (64, N'msg_periodo_creado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (65, N'msg_riesgo_registrado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (66, N'msg_nombre_null')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (67, N'msg_area_null')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (68, N'msg_clasificacion_null')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (69, N'msg_riesgo_aceptado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (70, N'msg_observacion_null')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (71, N'msg_riesgo_propuesto')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (72, N'msg_riesgo_cancelado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (73, N'msg_riesgo_no_aceptado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (74, N'msg_relevamiento_finalizado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (75, N'msg_descripcion_null')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (76, N'msg_tipo_control_null')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (77, N'msg_periodicidad_null')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (78, N'msg_control_interno_registrado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (79, N'msg_riesgo_sin_control')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (80, N'msg_control_no_aceptado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (81, N'msg_matriz_aceptada')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (82, N'msg_control_observado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (83, N'msg_control_propuesto')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (84, N'msg_contraseñas')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (85, N'msg_seleccionar_privilegio')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (86, N'msg_usuario_clave')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (87, N'msg_sesion_activa')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (88, N'msg_usuario_no_registrado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (89, N'msg_clave_incorrecta')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (90, N'areas_negocio')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (91, N'matriz_activa')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (92, N'bitacora')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (93, N'etiqueta_tipo_registro')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (94, N'etiqueta_f_desde')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (95, N'etiqueta_f_hasta')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (96, N'boton_consultar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (97, N'menu_administacion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (98, N'copia_seguridad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (99, N'restaurar_bd')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (100, N'realizar_copiabd')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (101, N'msg_copia_seguridad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (102, N'msg_copia_restaurada')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (103, N'msg_confirmar_restauracion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (104, N'msg_seleccionar_bkp')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (105, N'msg_error_integridad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (106, N'msg_error_integridadE')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (107, N'msg_error_conf_integridad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (108, N'control_integridad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (109, N'auditoria_riesgo')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (110, N'configurar_integridad')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (111, N'boton_recuperar_estado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (112, N'msg_riesgo_restaurado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (113, N'msg_seleccion_estado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (114, N'msg_estado_u')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (115, N'certificar_control')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (116, N'evaluar_excepcion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (117, N'informe_resultado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (118, N'etiqueta_certificaciones')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (119, N'etiqueta_excepcion')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (120, N'etiqueta_incidente')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (121, N'etiqueta_fecha')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (122, N'etiqueta_,motivo')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (123, N'etiqueta_motivorechazo')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (124, N'boton_rechazar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (125, N'msg_excepcion_aceptada')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (126, N'msg_excepcion_rechazada')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (127, N'msg_ingresar_motivor')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (128, N'boton_certificar')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (129, N'etiqueta_resultado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (130, N'msg_selecionar_control')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (131, N'msg_selecionar_resultado')
GO
INSERT [dbo].[Etiqueta] ([idetiqueta], [nombre]) VALUES (132, N'msg_ingresar_motivo')
GO
SET IDENTITY_INSERT [dbo].[Etiqueta] OFF
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON 
GO
INSERT [dbo].[Idioma] ([idIdioma], [nombre], [principal]) VALUES (1, N'Español', 0)
GO
INSERT [dbo].[Idioma] ([idIdioma], [nombre], [principal]) VALUES (2, N'Inglés', 1)
GO
SET IDENTITY_INSERT [dbo].[Idioma] OFF
GO
SET IDENTITY_INSERT [dbo].[matriz_control] ON 
GO
INSERT [dbo].[matriz_control] ([idmatrizcontrol], [periodo], [idestado]) VALUES (1, 2020, 1)
GO
SET IDENTITY_INSERT [dbo].[matriz_control] OFF
GO
SET IDENTITY_INSERT [dbo].[periodicidad] ON 
GO
INSERT [dbo].[periodicidad] ([idperiodicidad], [nombre]) VALUES (1, N'Diaria')
GO
INSERT [dbo].[periodicidad] ([idperiodicidad], [nombre]) VALUES (2, N'Mensual')
GO
INSERT [dbo].[periodicidad] ([idperiodicidad], [nombre]) VALUES (3, N'Trimestral')
GO
INSERT [dbo].[periodicidad] ([idperiodicidad], [nombre]) VALUES (4, N'Anual')
GO
INSERT [dbo].[periodicidad] ([idperiodicidad], [nombre]) VALUES (5, N'Eventual')
GO
SET IDENTITY_INSERT [dbo].[periodicidad] OFF
GO
SET IDENTITY_INSERT [dbo].[privilegio] ON 
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (1, N'Iniciar Sesión', N'FIniciarSesion')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (2, N'CRUD Usuarios', N'FUsuario')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (3, N'Prueba', N'FPrueba1')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (4, N'Gerente Auditoria', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (5, N'Analista Auditoria', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (6, N'Administrador', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (15, N'ADM Seguridad', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (16, N'CRUD Permisos', N'FPermiso')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (17, N'CRUD Roles', N'FRol')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (18, N'CRUD Idiomas', N'FIdioma')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (19, N'CRUD Etiquetas', N'FEtiqueta')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (20, N'CRUD Traducciones', N'FTraduccion')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (21, N'ADM Idiomas', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (22, N'Acceso', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (23, N'Pruebas b', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (24, N'CRUD Riesgos', N'FRiesgo')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (25, N'RU Evaluar Riesgos', N'FEvaluarRiesgo')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (26, N'Gerente de Area', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (27, N'U Cambiar Idioma', N'FCambiarIdioma')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (28, N'RU Riesgos Observados', N'FRiesgosObservados')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (29, N'U Finalizar Relevamiento', N'FFinalizarRelevamiento')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (30, N'CRUD Controles Internos', N'FControlInterno')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (31, N'Supervisor de Area', NULL)
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (32, N'U Evaluar Matriz Control', N'FEvaluarMatrizControl')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (33, N'U Controles Observados', N'FControlesObservados')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (34, N'C Periodo de Control', N'FMatrizControlInterno')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (35, N'CRUD Area de Negocio', N'FAreaNegocio')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (36, N'Matriz Activa', N'FMatrizControlInternoVigente')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (37, N'Consulta Bitacora', N'FBitacora')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (38, N'Copia de Seguridad', N'FCopiaSeguridad')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (39, N'Restaurar Base de Datos', N'FRestaurarBD')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (40, N'Control de Integridad', N'FControlIntegridad')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (41, N'Auditoria de Riesgos', N'FRiesgoAudit')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (42, N'CR Certificar Controles', N'FCertificar')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (43, N'RU Evaluar Excepciones', N'FEvaluarExcepcion')
GO
INSERT [dbo].[privilegio] ([idprivilegio], [nombre], [llave]) VALUES (44, N'Informe de Resultados', N'FInformeResultado')
GO
SET IDENTITY_INSERT [dbo].[privilegio] OFF
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (4, 5)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (4, 32)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (4, 34)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (5, 22)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (5, 24)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (5, 28)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (5, 29)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (5, 43)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (5, 44)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (6, 15)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (6, 21)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (6, 22)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (6, 38)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (15, 2)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (15, 16)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (15, 17)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (15, 35)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (15, 37)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (15, 40)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (15, 41)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (21, 18)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (21, 19)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (21, 20)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (22, 1)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (22, 27)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (22, 36)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (23, 3)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (26, 25)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (26, 31)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (26, 33)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (31, 22)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (31, 30)
GO
INSERT [dbo].[privilegio_privilegio] ([idprivilegio_padre], [idprivilegio_hijo]) VALUES (31, 42)
GO
SET IDENTITY_INSERT [dbo].[Resultado_Certificacion] ON 
GO
INSERT [dbo].[Resultado_Certificacion] ([idresultado], [nombre]) VALUES (1, N'Sin Novedad')
GO
INSERT [dbo].[Resultado_Certificacion] ([idresultado], [nombre]) VALUES (2, N'Con Novedad')
GO
INSERT [dbo].[Resultado_Certificacion] ([idresultado], [nombre]) VALUES (3, N'Con Excepción')
GO
SET IDENTITY_INSERT [dbo].[Resultado_Certificacion] OFF
GO
SET IDENTITY_INSERT [dbo].[tipo_control] ON 
GO
INSERT [dbo].[tipo_control] ([idtipocontrol], [nombre]) VALUES (1, N'Manual')
GO
INSERT [dbo].[tipo_control] ([idtipocontrol], [nombre]) VALUES (2, N'Automático')
GO
SET IDENTITY_INSERT [dbo].[tipo_control] OFF
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 1, N'Agregar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 2, N'Modificar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 3, N'Borrar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 5, N'Sesión')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 6, N'Seguridad')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 7, N'Idioma')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 8, N'Pruebas')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 9, N'Iniciar Sesión')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 10, N'Cerrar Sesión')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 11, N'Usuarios')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 12, N'Permisos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 13, N'Roles')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 14, N'Idiomas')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 15, N'Etiquetas')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 16, N'Traducciones')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 17, N'Gestión de Encriptado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 18, N'Iniciar Sesión')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 19, N'Cancelar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 20, N'Nombre')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 21, N'Clave')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 22, N'Cambiar Idioma')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 23, N'Cambiar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 24, N'Cambiar A')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 25, N'Principal')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 26, N'Idioma')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 27, N'Etiqueta')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 28, N'Traducción')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 29, N'Cancelar Selección')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 30, N'Permiso')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 31, N'Llave')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 32, N'Sacar Privilegio')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 33, N'Privilegio')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 34, N'Rol')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 35, N'Permiso')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 36, N'Sacar Rol')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 37, N'Seleccione un Rol')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 38, N'Reescribir Contraseña')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 39, N'Matriz de Control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 40, N'Area de Negocio')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 41, N'Clasificación')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 42, N'Estado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 43, N'Período')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 44, N'Riesgos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 45, N'Evaluar Riesgos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 46, N'Observación')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 47, N'Comentario')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 48, N'Aceptar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 49, N'Observar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 50, N'Riesgos Observados')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 51, N'Proponer')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 52, N'Finalizar Relevamiento')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 53, N'Definir Controles Internos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 54, N'Periodicidad')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 55, N'Tipo Control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 56, N'Descripción')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 57, N'Controles Internos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 58, N'Evaluar Matriz de Control Interno')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 59, N'Control Interno')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 60, N'Controles Observados')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 61, N'Riesgo')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 62, N'Período de Control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 63, N', Deseas Cerrar la Sesión ?')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 64, N'Período Creado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 65, N'Riesgo Registrado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 66, N'Debe Completar el Nombre')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 67, N'Debe Completar el Area de Negocio')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 68, N'Debe Completar el Clasificación')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 69, N'Riesgo Aceptado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 70, N'Debe Completar la Observación')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 71, N'Riesgo Propuesto')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 72, N'Riesgo Cancelado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 73, N'Existen Riesgos NO Aceptados')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 74, N'Relevamiento Finalizado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 75, N'Debe Completar la Descripción')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 76, N'Debe Completar el Tipo de Control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 77, N'Debe Completar la Periodicidad')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 78, N'Control Interno Resgistrado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 79, N'Existen Riesgos sin Controles Internos Definidos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 80, N'Existen Controles Internos NO Aceptados')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 81, N'Matriz de Control Interno Aceptada')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 82, N'Control Interno Observado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 83, N'Control Interno Propuesto')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 84, N'Los campos de contraseña son distintos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 85, N'Debe seleccionar el Privilegio a agregar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 86, N'Debe Ingresar Nombre de Usuario y Contraseña')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 87, N'Ya existe una sesion activa')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 88, N'Usuario no registrado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 89, N'Contraseña Incorrecta')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 90, N'Areas de Negocio')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 91, N'Matriz de Control Interno Activa')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 92, N'Bitacora')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 93, N'Tipo Registro')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 94, N'Fecha Desde')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 95, N'Fecha Hasta')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 96, N'Consultar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 97, N'Administración')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 98, N'Copia de Seguridad')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 99, N'Restaurar Base de Datos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 100, N'Realizar Copia de Seguridad')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 101, N'Copia de seguridad Realizada')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 102, N'Base de datos Restaurada')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 103, N'La base de datos se restaurará a la fecha ')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 104, N'Debe Seleccionar un Backup')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 105, N'Error al verificar la Integridad de Base de Datos. Contacte al Administrador.')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 106, N'Error al Verificar Integridad de Entidades. Contacte al Administrador')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 107, N'Falta configuración de control de integridad. Contacte al administrador.')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 108, N'Control de Integridad')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 109, N'Auditoria - Riesgos')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 110, N'Configurar Integridad')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 111, N'Restaurar Estado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 112, N'Riesgo Restaurado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 113, N'Debe seleccionar un Estado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 114, N'El riesgo ha sido borrado, no es posible recuperar estado.')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 115, N'Certificar Controles')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 116, N'Evaluar Excepciones')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 117, N'Informe de Resultados')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 118, N'Certificaciones')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 119, N'Excepción')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 120, N'Incidente')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 121, N'Fecha')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 122, N'Motivo')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 123, N'Motivo Rechazo')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 124, N'Rechazar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 125, N'Excepción Aceptada')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 126, N'Excepción Rechazada')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 127, N'Debe Ingresar un Motivo de Rechazo')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 128, N'Certificar')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 129, N'Resultado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 130, N'Debe Seleccionar un control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 131, N'Debe Seleccionar un resultado')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (1, 132, N'Debe Ingresar un motivo')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 1, N'Add')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 2, N'Update')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 3, N'Delete')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 5, N'Session')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 6, N'Security')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 7, N'Language')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 8, N'Test')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 9, N'Log in')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 10, N'Logout')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 11, N'Users')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 12, N'Permissions')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 13, N'Roles')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 14, N'Languages')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 15, N'Labels')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 16, N'Translations')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 17, N'Encryption Management')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 18, N'Log In')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 19, N'Cancel')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 20, N'Name')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 21, N'Password')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 22, N'Change Language')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 23, N'OK')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 24, N'Switch to')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 25, N'Default')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 26, N'Language')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 27, N'Label')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 28, N'Traslation')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 29, N'Cancel Selection')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 30, N'Permission')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 31, N'Key')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 32, N'Remove Privilege')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 33, N'Privilege')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 34, N'Role')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 35, N'Permission')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 36, N'Remove Role')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 37, N'Select Role')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 38, N'Rewrite Password')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 39, N'Control Matrix')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 40, N'Business Area')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 41, N'Classification')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 42, N'Status')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 43, N'Period')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 44, N'Risks')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 45, N'Risk Assessment')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 46, N'Observation')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 47, N'Comment')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 48, N'Approve')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 49, N'Observe')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 50, N'Observed Risks')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 51, N'Propose')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 52, N'Process Assessment')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 53, N'Define internal controls')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 54, N'Frequency')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 55, N'Control type')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 56, N'Description')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 57, N'Internal Controls')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 58, N'Evaluate Internal Control Matrix')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 59, N'Internal Control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 60, N'Observed Internals Controls')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 61, N'Risk')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 62, N'Control Period')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 63, N', Do you want to close the session ?')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 64, N'Period created')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 65, N'Registered risk')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 66, N'You must complete the name')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 67, N'You must complete the Business Area')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 68, N'You must complete the Classification')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 69, N'Accepted Risk')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 70, N'You must complete the Observation')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 71, N'Proposed Risk')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 72, N'Canceled Risk')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 73, N'There are unacceptable risks')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 74, N'Survey completed')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 75, N'You must complete the description')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 76, N'You must complete the control type')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 77, N'You must complete the frequency')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 78, N'Registered internal control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 79, N'There are risks without defined internal controls')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 80, N'There are unacceptable internal control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 81, N'Internal control matrix accepted')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 82, N'Internal control observed')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 83, N'Proposed internal control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 84, N'Password fields are different')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 85, N'You must select the privilege to add')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 86, N'You must enter username and password')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 87, N'An active session already exists')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 88, N'Unregistered user')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 89, N'Incorrect password')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 90, N'Business Area')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 91, N'Active Internal Control Matrix')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 92, N'System log')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 93, N'Record Type')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 94, N'Date From')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 95, N'Date To')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 96, N'Search')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 97, N'Administration')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 98, N'Backup')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 99, N'Restore Data Base')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 100, N'Do Backup')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 101, N'Backup done')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 102, N'Database Restored')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 103, N'The database will be restored to date ')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 104, N'There are not Backup selected')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 105, N'Failed to verify Database Integrity. Contact the Administrator.')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 106, N'Error Verifying Entities Integrity. Contact the Administrator')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 107, N'Integrity check configuration missing. Contact the administrator.')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 108, N'Integrity Control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 109, N'Audit - Risks')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 110, N'Set Integrity')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 111, N'Restore State')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 112, N'Risk Restore')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 113, N'You must select a State')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 114, N'The risk has been deleted, it is not possible to recover status.')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 115, N'Certify Controls')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 116, N'Evaluate Exceptions')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 117, N'Results report')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 118, N'Certifications')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 119, N'Exception')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 120, N'Incident')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 121, N'Date')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 122, N'Cause')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 123, N'Reason for rejection')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 124, N'Reject')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 125, N'Exception accepted')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 126, N'Exception rejected')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 127, N'You must enter a reason for rejection')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 128, N'Certify')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 129, N'Result')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 130, N'You must select a control')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 131, N'You must select a result')
GO
INSERT [dbo].[Traduccion] ([ididioma], [idetiqueta], [traduccion]) VALUES (2, 132, N'You must enter a reason')
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 
GO
INSERT [dbo].[usuario] ([idusuario], [nombre], [clave], [idareanegocio], [dvregistro], [iddventidad]) VALUES (2, N'admin', N'ICy5YqxZB1uWSwcVLSNLcA==', 3, N'+t8Dhu5RWYRmeceOO8ollQ==', NULL)
GO
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
INSERT [dbo].[usuario_privilegio] ([idusuario], [idprivilegio]) VALUES (2, 4)
GO
INSERT [dbo].[usuario_privilegio] ([idusuario], [idprivilegio]) VALUES (2, 6)
GO
INSERT [dbo].[usuario_privilegio] ([idusuario], [idprivilegio]) VALUES (2, 22)
GO
INSERT [dbo].[usuario_privilegio] ([idusuario], [idprivilegio]) VALUES (2, 23)
GO
INSERT [dbo].[usuario_privilegio] ([idusuario], [idprivilegio]) VALUES (2, 26)
GO
ALTER TABLE [dbo].[Idioma] ADD  CONSTRAINT [DF_Idioma_principal]  DEFAULT ((0)) FOR [principal]
GO
ALTER TABLE [dbo].[bitacora]  WITH CHECK ADD  CONSTRAINT [FK_bitacora_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[bitacora] CHECK CONSTRAINT [FK_bitacora_usuario]
GO
ALTER TABLE [dbo].[Certificacion]  WITH CHECK ADD  CONSTRAINT [FK_Certificacion_control_interno] FOREIGN KEY([idcontrolinterno])
REFERENCES [dbo].[control_interno] ([idcontrolinterno])
GO
ALTER TABLE [dbo].[Certificacion] CHECK CONSTRAINT [FK_Certificacion_control_interno]
GO
ALTER TABLE [dbo].[Certificacion]  WITH CHECK ADD  CONSTRAINT [FK_Certificacion_Resultado_Certificacion] FOREIGN KEY([idresultado])
REFERENCES [dbo].[Resultado_Certificacion] ([idresultado])
GO
ALTER TABLE [dbo].[Certificacion] CHECK CONSTRAINT [FK_Certificacion_Resultado_Certificacion]
GO
ALTER TABLE [dbo].[Certificacion]  WITH CHECK ADD  CONSTRAINT [FK_Certificacion_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[Certificacion] CHECK CONSTRAINT [FK_Certificacion_usuario]
GO
ALTER TABLE [dbo].[Certificacion_Excepcion]  WITH CHECK ADD  CONSTRAINT [FK_Certificacion_Excepcion_Certificacion] FOREIGN KEY([idcertificacion])
REFERENCES [dbo].[Certificacion] ([idcertificacion])
GO
ALTER TABLE [dbo].[Certificacion_Excepcion] CHECK CONSTRAINT [FK_Certificacion_Excepcion_Certificacion]
GO
ALTER TABLE [dbo].[Certificacion_Excepcion]  WITH CHECK ADD  CONSTRAINT [FK_Certificacion_Excepcion_Estado_Excepcion] FOREIGN KEY([idestado])
REFERENCES [dbo].[Estado_Excepcion] ([idestado])
GO
ALTER TABLE [dbo].[Certificacion_Excepcion] CHECK CONSTRAINT [FK_Certificacion_Excepcion_Estado_Excepcion]
GO
ALTER TABLE [dbo].[Certificacion_Incidente]  WITH CHECK ADD  CONSTRAINT [FK_Certificacion_Incidente_Certificacion] FOREIGN KEY([idcertificacion])
REFERENCES [dbo].[Certificacion] ([idcertificacion])
GO
ALTER TABLE [dbo].[Certificacion_Incidente] CHECK CONSTRAINT [FK_Certificacion_Incidente_Certificacion]
GO
ALTER TABLE [dbo].[control_interno]  WITH CHECK ADD  CONSTRAINT [FK_control_interno_Estado_Control_Interno] FOREIGN KEY([idestadocontrolinterno])
REFERENCES [dbo].[Estado_Control_Interno] ([idestadocontrolinterno])
GO
ALTER TABLE [dbo].[control_interno] CHECK CONSTRAINT [FK_control_interno_Estado_Control_Interno]
GO
ALTER TABLE [dbo].[control_interno]  WITH CHECK ADD  CONSTRAINT [FK_control_interno_riesgo] FOREIGN KEY([idriesgo])
REFERENCES [dbo].[riesgo] ([idriesgo])
GO
ALTER TABLE [dbo].[control_interno] CHECK CONSTRAINT [FK_control_interno_riesgo]
GO
ALTER TABLE [dbo].[control_interno]  WITH CHECK ADD  CONSTRAINT [FK_control_interno_tipo_control] FOREIGN KEY([idtipocontrol])
REFERENCES [dbo].[tipo_control] ([idtipocontrol])
GO
ALTER TABLE [dbo].[control_interno] CHECK CONSTRAINT [FK_control_interno_tipo_control]
GO
ALTER TABLE [dbo].[matriz_control]  WITH CHECK ADD  CONSTRAINT [FK_matriz_control_Estado_Matriz_Control] FOREIGN KEY([idestado])
REFERENCES [dbo].[Estado_Matriz_Control] ([idestado])
GO
ALTER TABLE [dbo].[matriz_control] CHECK CONSTRAINT [FK_matriz_control_Estado_Matriz_Control]
GO
ALTER TABLE [dbo].[privilegio_privilegio]  WITH CHECK ADD  CONSTRAINT [FK_privilegio_privilegio_privilegio] FOREIGN KEY([idprivilegio_padre])
REFERENCES [dbo].[privilegio] ([idprivilegio])
GO
ALTER TABLE [dbo].[privilegio_privilegio] CHECK CONSTRAINT [FK_privilegio_privilegio_privilegio]
GO
ALTER TABLE [dbo].[privilegio_privilegio]  WITH CHECK ADD  CONSTRAINT [FK_privilegio_privilegio_privilegio1] FOREIGN KEY([idprivilegio_hijo])
REFERENCES [dbo].[privilegio] ([idprivilegio])
GO
ALTER TABLE [dbo].[privilegio_privilegio] CHECK CONSTRAINT [FK_privilegio_privilegio_privilegio1]
GO
ALTER TABLE [dbo].[riesgo]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_area_negocio] FOREIGN KEY([idareanegocio])
REFERENCES [dbo].[area_negocio] ([idareanegocio])
GO
ALTER TABLE [dbo].[riesgo] CHECK CONSTRAINT [FK_riesgo_area_negocio]
GO
ALTER TABLE [dbo].[riesgo]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_Clasificacion_riesgo] FOREIGN KEY([idclasificacionriesgo])
REFERENCES [dbo].[Clasificacion_riesgo] ([idclasificacionriesgo])
GO
ALTER TABLE [dbo].[riesgo] CHECK CONSTRAINT [FK_riesgo_Clasificacion_riesgo]
GO
ALTER TABLE [dbo].[riesgo]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_Estado_Riesgo] FOREIGN KEY([idestadoriesgo])
REFERENCES [dbo].[Estado_Riesgo] ([idestadoriesgo])
GO
ALTER TABLE [dbo].[riesgo] CHECK CONSTRAINT [FK_riesgo_Estado_Riesgo]
GO
ALTER TABLE [dbo].[riesgo]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_matriz_control] FOREIGN KEY([idmatrizcontrol])
REFERENCES [dbo].[matriz_control] ([idmatrizcontrol])
GO
ALTER TABLE [dbo].[riesgo] CHECK CONSTRAINT [FK_riesgo_matriz_control]
GO
ALTER TABLE [dbo].[riesgo_audit]  WITH CHECK ADD  CONSTRAINT [FK_riesgo_audit_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[riesgo_audit] CHECK CONSTRAINT [FK_riesgo_audit_usuario]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Etiqueta] FOREIGN KEY([idetiqueta])
REFERENCES [dbo].[Etiqueta] ([idetiqueta])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Etiqueta]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([ididioma])
REFERENCES [dbo].[Idioma] ([idIdioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_area_negocio] FOREIGN KEY([idareanegocio])
REFERENCES [dbo].[area_negocio] ([idareanegocio])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_area_negocio]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_DV_Entidad] FOREIGN KEY([iddventidad])
REFERENCES [dbo].[DV_Entidad] ([iddventidad])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_DV_Entidad]
GO
ALTER TABLE [dbo].[usuario_privilegio]  WITH CHECK ADD  CONSTRAINT [FK_usuario_privilegio_privilegio] FOREIGN KEY([idprivilegio])
REFERENCES [dbo].[privilegio] ([idprivilegio])
GO
ALTER TABLE [dbo].[usuario_privilegio] CHECK CONSTRAINT [FK_usuario_privilegio_privilegio]
GO
ALTER TABLE [dbo].[usuario_privilegio]  WITH CHECK ADD  CONSTRAINT [FK_usuario_privilegio_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[usuario_privilegio] CHECK CONSTRAINT [FK_usuario_privilegio_usuario]
GO
/****** Object:  StoredProcedure [dbo].[addAreaNegocio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addAreaNegocio]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert area_negocio
	(nombre)
	values
	(@nombre)
	
END
GO
/****** Object:  StoredProcedure [dbo].[addBitacora]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addBitacora]
	-- Add the parameters for the stored procedure here
	@idusuario int,
	@fecha datetime,
	@tipo_registro varchar(50),
	@descripcion varchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into bitacora
	(idusuario,
	fecha,
	tipo_registro,
	descripcion)
	values
	(@idusuario,
	@fecha,
	@tipo_registro,
	@descripcion)
	
END
GO
/****** Object:  StoredProcedure [dbo].[addCertificacion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addCertificacion]
	-- Add the parameters for the stored procedure here
	@fecha datetime,
	@idcontrolinterno int,
	@idusuario int,
	@idresultado int,
	@descincidente varchar(MAX),
	@fechaincidente datetime,
	@descexcepcion varchar(MAX),
	@idestadoexcepcion int,
	@fechaexcepcion datetime
AS

declare @idcertificacion int

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into certificacion
	--OUTPUT Inserted.idcertificacion
	(fecha,
	 idcontrolinterno,
	 idusuario,
	 idresultado)
	values
	(@fecha,
	 @idcontrolinterno,
	 @idusuario,
	 @idresultado)

	 SET @idcertificacion = SCOPE_IDENTITY()

	 if (@descincidente IS NOT NULL)
		EXEC addIncidente @idcertificacion, @descincidente, @fechaincidente;
	 
	 if (@descexcepcion IS NOT NULL)
		EXEC addExcepcion @idcertificacion, @descexcepcion, @idestadoexcepcion, @fechaexcepcion;

END
GO
/****** Object:  StoredProcedure [dbo].[addControlInterno]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addControlInterno]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50),
	@descripcion varchar(MAX),
	@idtipocontrol int,
	@idperiodicidad int,
	@idriesgo int,
	@observacion varchar(MAX),
	@comentario varchar(MAX),
	@idestado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into control_interno
	(nombre,
	descripcion,
	idtipocontrol,
	idperiodicidad,
	idriesgo,
	observacion,
	comentario,
	idestadocontrolinterno)
	values
	(@nombre,
	@descripcion,
	@idtipocontrol,
	@idperiodicidad,
	@idriesgo,
	@observacion,
	@comentario,
	@idestado)
	
END
GO
/****** Object:  StoredProcedure [dbo].[addEtiqueta]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addEtiqueta]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert etiqueta
	(nombre)
	values
	(@nombre)
	
END
GO
/****** Object:  StoredProcedure [dbo].[addExcepcion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addExcepcion]
	-- Add the parameters for the stored procedure here
	@idcertificacion int,
	@descexcepcion varchar(MAX),
	@idestadoexcepcion int,
	@fechaexcepcion datetime

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into certificacion_excepcion
	(idcertificacion,
	 descripcion,
	 fecha,
	 idestado)
	values
	(@idcertificacion,
	@descexcepcion,
	@fechaexcepcion,
	@idestadoexcepcion)

END
GO
/****** Object:  StoredProcedure [dbo].[addIdioma]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addIdioma]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50),
	@principal bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if (@principal=1) 
		update idioma set principal = 0;
	

    -- Insert statements for procedure here
	insert into idioma
	(nombre,principal)
	values
	(@nombre,@principal);

	insert into Traduccion
	(ididioma,idetiqueta,traduccion)
	(select (select ididioma from idioma where nombre=@nombre) as ididioma,
			t.idetiqueta,
			t.traduccion
	from Traduccion t, idioma i
	where t.ididioma = i.idIdioma
	and i.idIdioma = 1)

END
GO
/****** Object:  StoredProcedure [dbo].[addIncidente]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addIncidente]
	-- Add the parameters for the stored procedure here
	@idcertificacion int,
	@descincidente varchar(MAX),
	@fechaincidente datetime

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into certificacion_incidente
	(idcertificacion,
	 descripcion,
	 fecha)
	values
	(@idcertificacion,
	@descincidente,
	@fechaincidente)

END
GO
/****** Object:  StoredProcedure [dbo].[addMatrizControl]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addMatrizControl]
	-- Add the parameters for the stored procedure here
	@periodo int,
	@idestado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into matriz_control
	(periodo,idestado)
	values
	(@periodo,@idestado)
	
END
GO
/****** Object:  StoredProcedure [dbo].[addPrivilegio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addPrivilegio]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50),
	@llave varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Privilegio
	(nombre,llave)
	values
	(@nombre,@llave)
END
GO
/****** Object:  StoredProcedure [dbo].[addPrivilegioHijo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addPrivilegioHijo]
	-- Add the parameters for the stored procedure here
	@idPrivilegioPadre int,
	@idPrivilegioHijo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Privilegio_Privilegio
	( idPrivilegio_padre, idPrivilegio_hijo)
	values
	(@idPrivilegioPadre, @idPrivilegioHijo)
END
GO
/****** Object:  StoredProcedure [dbo].[addRiesgo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addRiesgo]
	-- Add the parameters for the stored procedure here
	@nombre varchar(MAX),
	@idareanegocio int,
	@idclasificacionriesgo int,
	@idmatrizcontrol int,
	@idestadoriesgo int,
	@observacion varchar(MAX),
	@comentario varchar(MAX),
	@idusuario int
AS

declare @idriesgo int

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		
	insert into riesgo
	(nombre,
	idareanegocio,
	idclasificacionriesgo,
	idmatrizcontrol,
	idestadoriesgo,
	observacion,
	comentario)
	values
	(@nombre,
	@idareanegocio,
	@idclasificacionriesgo,
	@idmatrizcontrol,
	@idestadoriesgo,
	@observacion,
	@comentario);
		 
	
	select @idriesgo = scope_identity()

	exec addRiesgoAudit
		@idriesgo,
		@nombre,
		@idareanegocio,
		@idclasificacionriesgo,
		@idmatrizcontrol,
		@idestadoriesgo,
		@observacion,
		@comentario,
		@idusuario,
		'I';
	
END
GO
/****** Object:  StoredProcedure [dbo].[addRiesgoAudit]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addRiesgoAudit]
	-- Add the parameters for the stored procedure here
	@idriesgo int,
	@nombre varchar(MAX),
	@idareanegocio int,
	@idclasificacionriesgo int,
	@idmatrizcontrol int,
	@idestadoriesgo int,
	@observacion varchar(MAX),
	@comentario varchar(MAX),
	@idusuario int,
	@tipotransaccion varchar(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into riesgo_audit
	(idriesgo,
	nombre,
	idareanegocio,
	idclasificacionriesgo,
	idmatrizcontrol,
	idestadoriesgo,
	observacion,
	comentario,
	tipotransaccion,
	idusuario,
	fecha)
	values
	(@idriesgo,
	@nombre,
	@idareanegocio,
	@idclasificacionriesgo,
	@idmatrizcontrol,
	@idestadoriesgo,
	@observacion,
	@comentario,
	@tipotransaccion,
	@idusuario,
	GETDATE())
	
END
GO
/****** Object:  StoredProcedure [dbo].[addTraduccion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addTraduccion]
	-- Add the parameters for the stored procedure here
	@idIdioma int,
	@idEtiqueta int,
	@traduccion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert traduccion
	(ididioma,idetiqueta,traduccion)
	values
	(@idIdioma,@idEtiqueta,@traduccion)
	
END
GO
/****** Object:  StoredProcedure [dbo].[addUsuario]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addUsuario]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50),
	@clave varchar(50),
	@idareanegocio int,
	@dvregistro varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into usuario
	(nombre,clave,idareanegocio,dvregistro)
	values
	(@nombre,@clave,@idareanegocio,@dvregistro)
END
GO
/****** Object:  StoredProcedure [dbo].[addUsuarioPrivilegio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addUsuarioPrivilegio]
	-- Add the parameters for the stored procedure here
	@idUsuario int,
	@idPrivilegio int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Usuario_Privilegio
	( idUsuario, idPrivilegio)
	values
	(@idUsuario, @idPrivilegio)
END
GO
/****** Object:  StoredProcedure [dbo].[delAreaNegocio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delAreaNegocio]
	-- Add the parameters for the stored procedure here
	@idareanegocio int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete area_negocio
	where idareanegocio = @idareanegocio
	
END
GO
/****** Object:  StoredProcedure [dbo].[delControlInterno]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[delControlInterno]
	-- Add the parameters for the stored procedure here
	@idcontrolinterno int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete control_interno
	where idcontrolinterno = @idcontrolinterno
	
END
GO
/****** Object:  StoredProcedure [dbo].[delEtiqueta]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delEtiqueta]
	-- Add the parameters for the stored procedure here
	@idEtiqueta int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete etiqueta
	where idEtiqueta = @idEtiqueta
	
END
GO
/****** Object:  StoredProcedure [dbo].[delIdioma]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delIdioma]
	-- Add the parameters for the stored procedure here
	@idIdioma int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete idioma
	where idIdioma = @idIdioma
	
END
GO
/****** Object:  StoredProcedure [dbo].[delMatrizControl]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delMatrizControl]
	-- Add the parameters for the stored procedure here
	@idmatrizcontrol int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete matriz_control
	where idmatrizcontrol = @idmatrizcontrol
	
END
GO
/****** Object:  StoredProcedure [dbo].[delPrivilegio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[delPrivilegio]
	-- Add the parameters for the stored procedure here
	@idPrivilegio int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete Privilegio
	where idPrivilegio =  @idPrivilegio
END
GO
/****** Object:  StoredProcedure [dbo].[delPrivilegioHijo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delPrivilegioHijo]
	-- Add the parameters for the stored procedure here
	@idPrivilegioPadre int,
	@idPrivilegioHijo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete Privilegio_Privilegio
	where idPrivilegio_padre = @idPrivilegioPadre
	and idPrivilegio_hijo = @idPrivilegioHijo
END
GO
/****** Object:  StoredProcedure [dbo].[delRiesgo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delRiesgo]
	-- Add the parameters for the stored procedure here
	@idriesgo int,
	@idusuario int
AS

DECLARE triesgo CURSOR  
   FOR  
   SELECT nombre,idareanegocio,idclasificacionriesgo,idmatrizcontrol,idestadoriesgo,observacion,comentario 
   from riesgo where idriesgo = @idriesgo;

DECLARE 
	@nombre_old varchar(MAX),
	@idareanegocio_old int,
	@idclasificacionriesgo_old int,
	@idmatrizcontrol_old int,
	@idestadoriesgo_old int,
	@observacion_old varchar(MAX),
	@comentario_old varchar(MAX)

BEGIN
	SET NOCOUNT ON;

	OPEN triesgo;  
	FETCH NEXT FROM triesgo 
	INTO @nombre_old,
		@idareanegocio_old,
		@idclasificacionriesgo_old,
		@idmatrizcontrol_old,
		@idestadoriesgo_old,
		@observacion_old,
		@comentario_old;  

	exec addRiesgoAudit
		@idriesgo,
		@nombre_old,
		@idareanegocio_old,
		@idclasificacionriesgo_old,
		@idmatrizcontrol_old,
		@idestadoriesgo_old,
		@observacion_old,
		@comentario_old,
		@idusuario,'D';
	
	CLOSE triesgo;  
	DEALLOCATE triesgo;  

	delete riesgo
	where idriesgo = @idriesgo

END
GO
/****** Object:  StoredProcedure [dbo].[delTraduccion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delTraduccion]
	-- Add the parameters for the stored procedure here
	@idIdioma int,
	@idEtiqueta int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete traduccion
	where ididioma = @idIdioma
	and idetiqueta = @idEtiqueta
	
END
GO
/****** Object:  StoredProcedure [dbo].[delUsuario]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delUsuario]
	-- Add the parameters for the stored procedure here
@idUsuario int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete usuario 
	where idusuario = @idUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[delUsuarioPrivilegio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delUsuarioPrivilegio]
	-- Add the parameters for the stored procedure here
	@idUsuario int,
	@idPrivilegio int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete Usuario_Privilegio
	where idUsuario = @idUsuario
	and idPrivilegio = @idPrivilegio
	
END
GO
/****** Object:  StoredProcedure [dbo].[doBackup]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[doBackup] 
	-- Add the parameters for the stored procedure here
	@idusuario int
--	@path VARCHAR(256)
AS

DECLARE @name VARCHAR(50)   
DECLARE @fileName VARCHAR(256)   
DECLARE @fileDate VARCHAR(20) 
DECLARE @date dateTime 
DECLARE @path VARCHAR(256)  

SET @path = 'C:\SCI_Backups\'  
SET @date = GETDATE(); 

SELECT @fileDate = CONVERT(VARCHAR(20),@date,112) + '_' + REPLACE(CONVERT(VARCHAR(20),@date,108),':','') 
 
SET @name = 'SCIPrueba'
   
BEGIN   
	SET NOCOUNT ON;
	SET @fileName = @path + @name + '_' + @fileDate + '.BAK'  

	insert into copia_seguridad
		(fecha,
		idusuario,
		archivo)
	values
		(@date,
		@idusuario,
		@fileName)

   BACKUP DATABASE @name TO DISK = @fileName  

END
GO
/****** Object:  StoredProcedure [dbo].[getAreasNegocio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getAreasNegocio]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from area_negocio
	
END
GO
/****** Object:  StoredProcedure [dbo].[getBackups]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getBackups]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select c.fecha,c.idusuario,c.archivo,u.idusuario,u.nombre
	from copia_seguridad as c, usuario as u
	where c.idusuario = u.idusuario 
	order by fecha desc
END
GO
/****** Object:  StoredProcedure [dbo].[getBitacora]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getBitacora]
	-- Add the parameters for the stored procedure here
	@idusuario int,
	@tipo_registro varchar(50),
	@fecha_desde datetime,
	@fecha_hasta datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select *
	from bitacora
	where idusuario = ISNULL(@idusuario,idusuario)
	and tipo_registro = ISNULL(@tipo_registro,tipo_registro)
	and fecha between ISNULL(@fecha_desde,fecha) and ISNULL(@fecha_hasta,fecha) 
END
GO
/****** Object:  StoredProcedure [dbo].[getCertificaciones]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getCertificaciones]
	-- Add the parameters for the stored procedure here
	@idcontrolinterno int
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select c.*,
	   r.nombre as nombreresultado,
	   ISNULL(i.idincidente,0) as idincidente,
	   i.descripcion descincidente,
	   ISNULL(i.fecha,c.fecha) as fechaincidente,
	   ISNULL(e.idexcepcion,0) as idexcepcion,
	   e.descripcion descexcepcion,
	   ISNULL(e.fecha,c.fecha) as fechaexcepcion,
	   ISNULL(e.idestado,0) as idestadoexcepcion,
	   t.nombre as nombreestado
	from certificacion as c
		join resultado_certificacion as r on c.idresultado = r.idresultado
		left join certificacion_incidente as i on c.idcertificacion = i.idcertificacion  
		left join certificacion_excepcion as e on c.idcertificacion = e.idcertificacion
		left join estado_excepcion as t on e.idestado = t.idestado
	where c.idcontrolinterno = ISNULL(@idcontrolinterno,c.idcontrolinterno)
	

	--select c.*,
	--   r.nombre as nombreresultado,
	--   ISNULL(i.idincidente,0) as idincidente,
	--   i.descripcion descincidente,
	--   ISNULL(i.fecha,c.fecha) as fechaincidente,
	--   ISNULL(e.idexcepcion,0) as idexcepcion,
	--   e.descripcion descexcepcion,
	--   ISNULL(e.fecha,c.fecha) as fechaexcepcion,
	--   ISNULL(e.idestado,0) as idestadoexcepcion,
	--   t.nombre as nombreestado
	--from riesgo as g
	--	join control_interno as ci on g.idriesgo = ci.idriesgo
	--	join certificacion as c on ci.idcontrolinterno = c.idcontrolinterno
	--	join resultado_certificacion as r on c.idresultado = r.idresultado
	--	left join certificacion_incidente as i on c.idcertificacion = i.idcertificacion  
	--	left join certificacion_excepcion as e on c.idcertificacion = e.idcertificacion
	--	left join estado_excepcion as t on e.idestado = t.idestado
	--where ci.idcontrolinterno = ISNULL(@idcontrolinterno,ci.idcontrolinterno)
	--and g.idmatrizcontrol = ISNULL(@idmatrizcontrol,g.idmatrizcontrol)

END
GO
/****** Object:  StoredProcedure [dbo].[getClasificacionesRiesgo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getClasificacionesRiesgo]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from Clasificacion_riesgo
	
END
GO
/****** Object:  StoredProcedure [dbo].[getControlesInternos]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getControlesInternos]
	-- Add the parameters for the stored procedure here
	@idriesgo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * 
	from control_interno
	where idriesgo = ISNULL(@idriesgo, idriesgo)
	
END
GO
/****** Object:  StoredProcedure [dbo].[getDVEntidad]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getDVEntidad]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from DV_Entidad
END
GO
/****** Object:  StoredProcedure [dbo].[getEstadosControlInterno]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getEstadosControlInterno]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from Estado_Control_Interno
	
END
GO
/****** Object:  StoredProcedure [dbo].[getEstadosExcepcion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getEstadosExcepcion]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Estado_Excepcion
END
GO
/****** Object:  StoredProcedure [dbo].[getEstadosMatrizControl]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getEstadosMatrizControl]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from Estado_Matriz_Control
	
END
GO
/****** Object:  StoredProcedure [dbo].[getEstadosRiesgo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getEstadosRiesgo]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from estado_riesgo
	
END
GO
/****** Object:  StoredProcedure [dbo].[getEtiquetas]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getEtiquetas]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Etiqueta order by nombre
END
GO
/****** Object:  StoredProcedure [dbo].[getIdiomas]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getIdiomas]
	-- Add the parameters for the stored procedure here
--@nombre varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[getMatricesControl]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getMatricesControl]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from matriz_control
	
END
GO
/****** Object:  StoredProcedure [dbo].[getMatrizControlResumen]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getMatrizControlResumen]
	-- Add the parameters for the stored procedure here
	@idmatrizcontrol int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select ri.idareanegocio,
		count(distinct ri.idriesgo) riesgos,
		count(distinct co.idcontrolinterno) controlesinternos
	from riesgo as ri left join control_interno as co on ri.idriesgo = co.idriesgo 
	where ri.idmatrizcontrol = @idmatrizcontrol
	group by ri.idareanegocio
	
END
GO
/****** Object:  StoredProcedure [dbo].[getPeriodicidadControl]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getPeriodicidadControl]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from periodicidad
	
END
GO
/****** Object:  StoredProcedure [dbo].[getPermisos]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getPermisos]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select *  
	from privilegio
	where llave is not null;

END
GO
/****** Object:  StoredProcedure [dbo].[getPrivilegios]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getPrivilegios]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	with privilegios as (
	select 0 as idprivilegio_padre, usr.idprivilegio  
	from privilegio usr
	where usr.llave is null
	UNION ALL 
	select pp.idprivilegio_padre, pp.idprivilegio_hijo as idprivilegio 
	from privilegio_privilegio pp 
	inner join privilegios up on pp.idprivilegio_padre = up.idprivilegio 
	)
	select p.idprivilegio,
		   p.nombre,
		   p.llave,
		   up.idprivilegio_padre
	from privilegios up
	inner join privilegio p on up.idprivilegio = p.idprivilegio;

END
GO
/****** Object:  StoredProcedure [dbo].[getResutadoCertificacion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getResutadoCertificacion]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from resultado_certificacion
END
GO
/****** Object:  StoredProcedure [dbo].[getRiesgos]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getRiesgos]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from riesgo where idriesgo != 4
	
END
GO
/****** Object:  StoredProcedure [dbo].[getRiesgosAudit]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getRiesgosAudit]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * 
	from riesgo_audit
	order by idriesgo desc,idriesgoaudit desc
END
GO
/****** Object:  StoredProcedure [dbo].[getRoles]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getRoles]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select *  
	from privilegio
	where llave is null;

END
GO
/****** Object:  StoredProcedure [dbo].[getTipoControl]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getTipoControl]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from tipo_control
	
END
GO
/****** Object:  StoredProcedure [dbo].[getTiposRegistro]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[getTiposRegistro]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select distinct tipo_registro from bitacora
	
END
GO
/****** Object:  StoredProcedure [dbo].[getTraducciones]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getTraducciones]
	-- Add the parameters for the stored procedure here
	@idIdioma int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select tr.ididioma, tr.idetiqueta, tr.traduccion,
			idm.nombre as nombreIdioma,idm.principal,
			etq.nombre as nombreEtiqueta
	from Traduccion tr, Idioma idm, Etiqueta etq
	where tr.idetiqueta = etq.idetiqueta
	and tr.ididioma = idm.idIdioma
	and tr.idIdioma = ISNULL(@idIdioma,tr.idIdioma)
END
GO
/****** Object:  StoredProcedure [dbo].[getUsuarioPrivilegios]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getUsuarioPrivilegios]
	-- Add the parameters for the stored procedure here
	@idUsuario int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	with usuario_privilegios as (
	select 0 as idprivilegio_padre, usr.idprivilegio  
	from usuario_privilegio usr
	where usr.idusuario = @idUsuario
	UNION ALL 
	select pp.idprivilegio_padre, pp.idprivilegio_hijo as idprivilegio 
	from privilegio_privilegio pp 
	inner join usuario_privilegios up on pp.idprivilegio_padre = up.idprivilegio 
	)
	select p.idprivilegio,
		   p.nombre,
		   p.llave,
		   up.idprivilegio_padre
	from usuario_privilegios up
	inner join privilegio p on up.idprivilegio = p.idprivilegio;

END
GO
/****** Object:  StoredProcedure [dbo].[getUsuarios]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getUsuarios]
	-- Add the parameters for the stored procedure here
--@nombre varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from usuario 
	--where nombre = ISNULL(@nombre,nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[restoreRiesgo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[restoreRiesgo]
	-- Add the parameters for the stored procedure here
	@idriesgoaudit int,
	@idusuario int
AS

DECLARE triesgoAudit CURSOR  
   FOR  
   SELECT idriesgo,nombre,idareanegocio,idclasificacionriesgo,idmatrizcontrol,idestadoriesgo,observacion,comentario 
   from riesgo_audit where idriesgoaudit = @idriesgoaudit;

DECLARE 
	@idriesgo_old int,
	@nombre_old varchar(MAX),
	@idareanegocio_old int,
	@idclasificacionriesgo_old int,
	@idmatrizcontrol_old int,
	@idestadoriesgo_old int,
	@observacion_old varchar(MAX),
	@comentario_old varchar(MAX)

BEGIN
	SET NOCOUNT ON;

	OPEN triesgoAudit;  
	FETCH NEXT FROM triesgoAudit 
	INTO @idriesgo_old, 
		@nombre_old,
		@idareanegocio_old,
		@idclasificacionriesgo_old,
		@idmatrizcontrol_old,
		@idestadoriesgo_old,
		@observacion_old,
		@comentario_old;  

	exec updRiesgo
		@idriesgo_old,
		@nombre_old,
	--	@idareanegocio_old,
		@idclasificacionriesgo_old,
	--	@idmatrizcontrol_old,
		@idestadoriesgo_old,
		@observacion_old,
		@comentario_old,
		@idusuario;

	CLOSE triesgoAudit;  
	DEALLOCATE triesgoAudit;  
	
END
GO
/****** Object:  StoredProcedure [dbo].[updAreaNegocio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updAreaNegocio]
	-- Add the parameters for the stored procedure here
	@idareanegocio int,
	@nombre varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update area_negocio
	set nombre = @nombre
	where idareanegocio = @idareanegocio
	
END
GO
/****** Object:  StoredProcedure [dbo].[updCertificacion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updCertificacion]
	-- Add the parameters for the stored procedure here
	@idcertificacion int,
	@idresultado int,
	@descincidente varchar(MAX),
	@fechaincidente datetime,
	@idexcepcion int,
	@descexcepcion varchar(MAX),
	@idestadoexcepcion int,
	@fechaexcepcion datetime
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update certificacion
	set idresultado = @idresultado
	where idcertificacion = @idcertificacion
	
	EXEC updExcepcion @idexcepcion, @idestadoexcepcion;

	EXEC addIncidente @idcertificacion, @descincidente, @fechaincidente;

END
GO
/****** Object:  StoredProcedure [dbo].[updControlInterno]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updControlInterno]
	-- Add the parameters for the stored procedure here
	@idcontrolinterno int,
	@nombre varchar(50),
	@descripcion varchar(MAX),
	@idtipocontrol int,
	@idperiodicidad int,
	@idriesgo int,
	@observacion varchar(MAX),
	@comentario varchar(MAX),
	@idestado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update control_interno
	set nombre = @nombre,
		descripcion = @descripcion,
		idtipocontrol = @idtipocontrol,
		idperiodicidad = @idperiodicidad,
		idriesgo = ISNULL(@idriesgo,idriesgo),
		observacion = @observacion,
		comentario = @comentario,
		idestadocontrolinterno = ISNULL(@idestado, idestadocontrolinterno)
	where idcontrolinterno = @idcontrolinterno
	
END
GO
/****** Object:  StoredProcedure [dbo].[updDVEntidad]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updDVEntidad]
	-- Add the parameters for the stored procedure here
	@entidad varchar(50),
	@dventidad varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @RowCount INTEGER

	update DV_Entidad
	set dventidad = @dventidad
	where entidad = @entidad

	SELECT @RowCount = @@ROWCOUNT
    
	if (@RowCount = 0)
	begin
		insert into DV_Entidad
		(entidad,dventidad)
		values
		(@entidad,@dventidad)
	end
END
GO
/****** Object:  StoredProcedure [dbo].[updEtiqueta]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updEtiqueta]
	-- Add the parameters for the stored procedure here
	@idEtiqueta int,
	@nombre varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update etiqueta
	set nombre = @nombre
	where idEtiqueta = @idEtiqueta
	
END
GO
/****** Object:  StoredProcedure [dbo].[updExcepcion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[updExcepcion]
	-- Add the parameters for the stored procedure here
	@idexcepcion int,
	@idestadoexcepcion int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update certificacion_excepcion
	set idestado = @idestadoexcepcion
	where idexcepcion = @idexcepcion
	 

END
GO
/****** Object:  StoredProcedure [dbo].[updIdioma]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updIdioma]
	-- Add the parameters for the stored procedure here
	@idIdioma int,
	@nombre varchar(50),
	@principal bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if (@principal=1) 
		update idioma set principal = 0;
	

    -- Insert statements for procedure here
	update idioma
	set nombre = @nombre,
		principal = @principal
	where idIdioma = @idIdioma
	
END
GO
/****** Object:  StoredProcedure [dbo].[updMatrizControl]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updMatrizControl]
	-- Add the parameters for the stored procedure here
	@idmatrizcontrol int,
	@periodo int,
	@idestado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update matriz_control
	set periodo = @periodo,
		idestado = @idestado
	where idmatrizcontrol = @idmatrizcontrol
	
END
GO
/****** Object:  StoredProcedure [dbo].[updPrivilegio]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updPrivilegio]
	-- Add the parameters for the stored procedure here
	@idPrivilegio int,
	@nombre varchar(50),
	@llave varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Privilegio
	set nombre = @nombre,
		llave = @llave
	where idPrivilegio =  @idPrivilegio
END
GO
/****** Object:  StoredProcedure [dbo].[updRiesgo]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updRiesgo]
	-- Add the parameters for the stored procedure here
	@idriesgo int,
	@nombre varchar(MAX),
	@idclasificacionriesgo int,
	@idestadoriesgo int,
	@observacion varchar(MAX),
	@comentario varchar(MAX),
	@idusuario int
AS

DECLARE triesgo CURSOR  
   FOR  
   SELECT nombre,idareanegocio,idclasificacionriesgo,idmatrizcontrol,idestadoriesgo,observacion,comentario 
   from riesgo where idriesgo = @idriesgo;

DECLARE 
	@nombre_old varchar(MAX),
	@idareanegocio_old int,
	@idclasificacionriesgo_old int,
	@idmatrizcontrol_old int,
	@idestadoriesgo_old int,
	@observacion_old varchar(MAX),
	@comentario_old varchar(MAX)

BEGIN
	SET NOCOUNT ON;

	update riesgo
	set nombre = @nombre,
		idclasificacionriesgo = @idclasificacionriesgo,
		idestadoriesgo = ISNULL(@idestadoriesgo, idestadoriesgo),
		observacion = @observacion,
		comentario = @comentario
	where idriesgo = @idriesgo;

	OPEN triesgo;  
	FETCH NEXT FROM triesgo 
	INTO @nombre_old,
		@idareanegocio_old,
		@idclasificacionriesgo_old,
		@idmatrizcontrol_old,
		@idestadoriesgo_old,
		@observacion_old,
		@comentario_old;  

	exec addRiesgoAudit
		@idriesgo,
		@nombre_old,
		@idareanegocio_old,
		@idclasificacionriesgo_old,
		@idmatrizcontrol_old,
		@idestadoriesgo_old,
		@observacion_old,
		@comentario_old,
		@idusuario,'U';
	
	CLOSE triesgo;  
	DEALLOCATE triesgo;  

	--update riesgo
	--set nombre = @nombre,
	--	idclasificacionriesgo = @idclasificacionriesgo,
	--	idestadoriesgo = ISNULL(@idestadoriesgo, idestadoriesgo),
	--	observacion = @observacion,
	--	comentario = @comentario
	--where idriesgo = @idriesgo;

END
GO
/****** Object:  StoredProcedure [dbo].[updTraduccion]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updTraduccion]
	-- Add the parameters for the stored procedure here
	@idIdioma int,
	@idEtiqueta int,
	@traduccion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update traduccion
	set traduccion = @traduccion
	where ididioma = @idIdioma
	and idetiqueta = @idEtiqueta
	
END
GO
/****** Object:  StoredProcedure [dbo].[updUsuario]    Script Date: 27/10/2020 2:18:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updUsuario]
	-- Add the parameters for the stored procedure here
	@idUsuario int,
	@nombre varchar(50),
	@clave varchar(50),
	@idareanegocio int,
	@dvregistro varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update usuario
	set clave = @clave,
		nombre = @nombre,
		idareanegocio = @idareanegocio,
		dvregistro = @dvregistro
	where idusuario = @idusuario
END
GO
