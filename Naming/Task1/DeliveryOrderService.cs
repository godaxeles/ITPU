using Naming.Task1.ThirdParty;

namespace Naming.Task1
{
    public class DeliveryOrderService : IOrderService
    {
        private readonly IDeliveryService _deliveryService;
        private readonly IOrderFulfilmentService _orderFulfilmentService;

        public DeliveryOrderService(IDeliveryService deliveryService, IOrderFulfilmentService orderFulfilmentService)
        {
            _deliveryService = deliveryService;
            _orderFulfilmentService = orderFulfilmentService;
        }

        public void Submit(IOrder order)
        {
            if (_deliveryService.IsDeliverable())
            {
                var products = order.GetProducts();
                _orderFulfilmentService.FulfilProducts(products);
            }
            else
            {
                throw new NotDeliverableOrderException();
            }
        }
    }
}
