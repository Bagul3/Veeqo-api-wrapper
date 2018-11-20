using System;
using System.Collections.Generic;

namespace VeeqoRepository.Models 
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public short? OrderLine { get; set; }
        public short? Flag { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Deldate { get; set; }
        public int? UniqueRef { get; set; }
        public int? Plu { get; set; }
        public int? Size { get; set; }
        public short? Location { get; set; }
        public short? OnOrder { get; set; }
        public int? Delivered { get; set; }
        public int? Minimum { get; set; }
        public int UniqOrdLineN { get; set; }
        public short? Supplier { get; set; }
        public float? Cost { get; set; }
        public float? Retail { get; set; }
        public short? ColourRef { get; set; }
        public string SuppColourRef { get; set; }
        public short? Tktprt { get; set; }
        public DateTime? CutOffDate { get; set; }
        public bool BalanceCancelled { get; set; }
        public short? Printed { get; set; }
        public short? Changed { get; set; }
        public int? QtyCancelled { get; set; }
        public float? HomeCost { get; set; }
    }
}
