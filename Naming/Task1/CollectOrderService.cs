using Naming.Task1.ThirdParty;

namespace Naming.Task1
{
    public class CollectOrderService : IOrderService
    {
        private readonly ICollectionService _collectionService;
        private readonly INotificationManager _notificationManager;
        private const int InfoNotificationLevel = 4;
        private const int CriticalNotificationLevel = 1;

        public CollectOrderService(ICollectionService collectionService, INotificationManager notificationManager)
        {
            _collectionService = collectionService;
            _notificationManager = notificationManager;
        }

        public void Submit(IOrder order)
        {
            if (_collectionService.IsEligibleForCollect(order))
            {
                _notificationManager.NotifyCustomer(Message.ReadyForCollect, InfoNotificationLevel);
            }
            else
            {
                _notificationManager.NotifyCustomer(Message.ImpossibleToCollect, CriticalNotificationLevel);
            }
        }
    }
}
