using DataService.Interface;

namespace ServiceLayer.Order
{
    public class OrderService
    {
        //Field 
        IOrderDataService _dataLayer;

        DataService.Order GetSingleOrder(int id)
        {
            return _dataLayer.GetSingleOrder(id);
        }
    }
}
