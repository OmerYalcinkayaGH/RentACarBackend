using Core.Entities;

namespace Entities.Concrete
{
    public class PaymentMethod:IEntity
    {
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }

    }
 }

