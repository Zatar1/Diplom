//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOrders
    {
        public int OrderId { get; set; }
        public int OrderType { get; set; }
        public Nullable<int> OrderClient { get; set; }
        public string OrderDetails { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int OrderUser { get; set; }
        public int OrderCost { get; set; }
        public bool OrderComplete { get; set; }
    
        public virtual TClients TClients { get; set; }
        public virtual TOrdersTypes TOrdersTypes { get; set; }
        public virtual TUsers TUsers { get; set; }
    }
}