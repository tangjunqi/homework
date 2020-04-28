﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12
{
    public class OrderItem
    {



        public String GoodsName { get; set; }

        public uint Quantity { get; set; }

        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(String goodsName, double price, uint quantity)
        {
            this.GoodsName = goodsName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double TotalPrice
        {
            get => Price * Quantity;
        }

        public override string ToString()
        {
            return $"[goods:{GoodsName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   GoodsName == item.GoodsName;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
