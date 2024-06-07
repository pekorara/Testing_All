using Testing_DependencyInjection.DTO;

namespace Testing_DependencyInjection.Interface
{
    public interface IOrderValidator
    {
        bool IsValid(Order order);
    }
}
