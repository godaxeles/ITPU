using Naming.Task4.ThirdParty;

namespace Naming.Task4.Service
{
    public class CustomerContactService : ICustomerContactService
    {
        private readonly ICustomerContactRepository _customerContactRepository;

        public CustomerContactService(ICustomerContactRepository customerContactRepository)
        {
            _customerContactRepository = customerContactRepository;
        }

        public CustomerContact Find(float customerId)
        {
            return _customerContactRepository.FindById(customerId);
        }

        public void Update(CustomerContact customerContactDetails)
        {
            _customerContactRepository.Update(customerContactDetails);
        }
    }
}
