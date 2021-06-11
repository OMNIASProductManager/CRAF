-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Omnias
-- Create date: June 2021
-- Description:	Procédure stockée pour permettre de vérifier si l'identifiant et le mot de passe sont corrects
-- Éxécution : 
-- EXECUTE spLogCheck N'test@gmail.com', N'monmotdepasse';  
-- Où
-- EXEC HumanResources.uspGetEmployeesTest2 @email = N'test@gmail.com', @pwd = N'monmotdepasse'; GO;
-- =============================================
IF OBJECT_ID('spLogCheck', 'P') IS NOT NULL  
    DROP PROCEDURE spLogCheck;  
GO  
CREATE PROCEDURE spLogCheck
	-- Add the parameters for the stored procedure here
	@email VARCHAR(255) = NULL,
	@pwd VARCHAR(255) = NULL
AS	DECLARE @found INT = 0; 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @email IS NULL
		PRINT N'[ERREUR] : L''email ne peut être vide!'
		RETURN
	IF @pwd IS NULL
		PRINT N'[ERREUR] : Le mot de passe ne peut être vide!'
		RETURN
	

	-- Je suppose ici que je compare l'adresse email et le mot de passe en brute(pas celui qui est hash)
	-- Si il faut comparer le hash, alors voici un exemple(peut être à modifier) :
	/**
		SET @found = (SELECT count(idUtilisateur) from dbo.Utilisateur WHERE dbo.Utilisateur.adresseMail=@email AND dbo.Utilisateur.mdp=Fn_varbintohexstr(HASHBYTES('SHA1', @pwd));
	*/
    -- Insert statements for procedure here
	SET @found = (SELECT count(idUtilisateur) from dbo.Utilisateur WHERE dbo.Utilisateur.adresseMail=@email AND dbo.Utilisateur.mdp=@pwd);
	IF @found = 1
		RETURN 1;
	ELSE
		RETURN 0;
END
GO

-- =============================================
-- Description:	Procédure stockée pour générer un mot de passe aléatoire lorsque l'utilisateur va dans la section mot de passe oublié
-- Source : https://www.c-sharpcorner.com/blogs/generate-random-password-using-sql-stored-procedure
-- Éxécution : EXECUTE spResetPassword;
-- =============================================
IF OBJECT_ID('spResetPassword', 'P') IS NOT NULL  
    DROP PROCEDURE spResetPassword;  
GO
CREATE PROCEDURE spResetPassword
AS
BEGIN  
SET NOCOUNT ON  
declare @LENGTH INT,@CharPool varchar(26),@PoolLength varchar(26),@LoopCount  INT  
DECLARE @RandomString VARCHAR(10),@CHARPOOLINT VARCHAR(9)  
  
    
SET @CharPool = 'A!B@C!D#E@FG#H$IJ$K%LM%N*PQR%ST&U*V(W)X_YZ'  
DECLARE @TMPSTR VARCHAR(3)  

SET @PoolLength = DataLength(@CharPool)  
SET @LoopCount = 0  
SET @RandomString = ''  
  
    WHILE (@LoopCount <10)  
    BEGIN  
        SET @TMPSTR =   SUBSTRING(@Charpool, CONVERT(int, RAND() * @PoolLength), 1)           
        SELECT @RandomString  = @RandomString + CONVERT(VARCHAR(5), CONVERT(INT, RAND() * 10))  
        IF(DATALENGTH(@TMPSTR) > 0)  
        BEGIN   
            SELECT @RandomString = @RandomString + @TMPSTR    
            SELECT @LoopCount = @LoopCount + 1  
        END  
    END  
    SET @LOOPCOUNT = 0    
    RETURN @RandomString  
END