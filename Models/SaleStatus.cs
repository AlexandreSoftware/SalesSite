namespace SalesSite.Models
{
    public enum SaleStatus
    {
        PendingPayment=0,
        PendingShipping=1,
        PendingDelivery=2,
        Delivered=3,
        Canceled=-1
    }
}