using Naming.Task4.ThirdParty;

namespace Naming.Task4.Service
{
    public interface ICustomerContactService
    {
        CustomerContact Find(float customerId);

        void Update(CustomerContact customerContactDetails);
    }
}
