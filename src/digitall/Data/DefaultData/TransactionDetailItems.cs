using Domain.Entities.Transaction;

namespace Data.DefaultData;

public class TransactionDetailItems
{
    public static List<TransactionDetail> TransactionDetails = new List<TransactionDetail>()
    {
        new TransactionDetail()
        {
            Id = 1,
            Description = "توضیحات",
            CardNumber = "6037-6916-1079-1079",
            MaximumAmount = 2000000,
            MinimalAmount = 200000,
            CardHolderName = "حسین فرجی",
            IsDelete = false,
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1,
            AgentId = 100001
        }
    };
}