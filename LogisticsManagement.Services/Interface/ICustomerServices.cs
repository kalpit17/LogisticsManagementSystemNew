using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Services.Interface
{
    public interface ICustomerServices
    {
        void ViewAllProducts();
        void ViewProductDetails(int productId);

        bool ValidateQuantity(int productId, int quantity);

        bool BuyProduct(int userId, int productId, int quantity);

        void ViewAllOrders(int userId);

        void ViewOrderDetails(int userId, int orderId);

    }
}
