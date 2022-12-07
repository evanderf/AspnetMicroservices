using AutoMapper;
using Order.Application.Features.Orders.Commands.CheckoutOrder;
using Order.Application.Features.Orders.Queries.GetOrdersList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrder = Order.Domain.Entities.Order;

namespace Order.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerOrder, OrdersVm>().ReverseMap();
            CreateMap<CustomerOrder, CheckoutOrderCommand>().ReverseMap();
            //CreateMap<CustomerOrder, UpdateOrderCommand>().ReverseMap();
        }
    }
}
