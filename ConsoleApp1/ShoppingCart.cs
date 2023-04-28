using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShoppingCart
    {
        private int vip;
        private int vipDiscount;
        private int cost;
        private int mass;
        private int massDiscount;
        private int newCost;
        public ShoppingCart()
        {
            vip = 0; vipDiscount = 0;
            cost = 0; newCost = 0;
            mass = 0; massDiscount = 100;
        }
        public void setVip(int vip, int vipDiscount)
        {
            this.vip = vip;
            this.vipDiscount = vipDiscount;
        }

        public void setMass(int mass, int massDiscount)
        {
            this.mass = mass;
            this.massDiscount = massDiscount;
        }
        public void setCost(int cost)
        {
            this.cost = cost;
        }
        public void computeCost()
        {
            newCost = cost;
            if (vip == 1)
            {
                newCost = newCost * vipDiscount / 100;
            }
            if (cost >= mass)
            {
                newCost = newCost * massDiscount / 100;
            }
        }
        public int getCost()
        {
            return newCost;
        }
    }

    

}
