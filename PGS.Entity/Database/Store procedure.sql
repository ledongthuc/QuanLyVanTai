Create PROCEDURE [dbo].[spGetMaxRequestCode]
    @StoreID int    
AS 
select Max(CAST(SUBSTRING(r.Code, 1, CHARINDEX(s.StoreCode, r.Code) - 1) as int)) from dbo.[EQ.Requests] r, Stores s
where r.StoreIDSend = s.Store_ID and s.Store_ID = @StoreID and YEAR(r.CreatedDate)=YEAR(SYSDATETIME())
