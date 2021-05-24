using API.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerBasket> CreateOrPaymentIntent(string basketId);

    }
}
