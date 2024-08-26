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
            CardNumber = "6037691610791079",
            MaximumAmountForUser = 2000000,
            MinimalAmountForUser = 10000,
            MaximumAmountForAgent = 2000000,
            MinimalAmountForAgent = 100000,
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