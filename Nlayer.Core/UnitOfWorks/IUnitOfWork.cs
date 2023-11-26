namespace Nlayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task ComitAsync();
        void Comit();
    }
}
