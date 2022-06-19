namespace OBS.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
