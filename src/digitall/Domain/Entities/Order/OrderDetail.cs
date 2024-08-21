using System.Collections;
using System.Text.Json;
using Domain.Common;
using Domain.Entities.Marzban;
using Domain.Entities.Sanaei;
using Domain.Entities.Transaction;
using Domain.Enums.Order;

namespace Domain.Entities.Order;

public class OrderDetail : BaseEntity
{
    #region properties

    public long OrderId { get; set; }

    public long? ProductId { get; set; }

    public int Count { get; set; }

    public long ProductPrice { get; set; }

    public OrderDeatilType OrderDeatilType { get; set; }

    #endregion

    #region relations

    public Order Order { get; set; }
    public Product.Product? Product { get; set; }
    public ICollection<MarzbanUser> MarzbanUsers { get; set; }
    public ICollection<AgentsIncomesDetail> AgentsIncomesDetails { get; set; }

    #endregion
}