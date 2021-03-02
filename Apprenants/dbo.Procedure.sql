CREATE PROCEDURE [dbo].[Procedure]
	@id int = 0,
	@nom nvarchar,
	@prenom nvarchar,
	@CIN nvarchar,
	@Adress nvarchar

AS
Begin
update [dbo].[Procedure]
SET [nom]=@nom,[prenom]=@prenom,[CIN]=@CIN,[Adress]=@Adress WHERE id=@id
end

