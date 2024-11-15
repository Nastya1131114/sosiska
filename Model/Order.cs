using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public virtual ICollection<DishOrder> DishOrders {get; set; }= new List<DishOrder>();
        public Client Clients { get; set; }

        public double TotalCost
        {
            get
            {
                //todo: сюда добавить логику по рассчету стоимости всех блюд, входящих в заказ

                return 10;
            }
        }
        //public Dish Dish { get; set; }  // убрать если что отсюда 

    }
}
