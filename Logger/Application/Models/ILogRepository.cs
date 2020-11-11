namespace Logger.Application.Models
{
    public interface ILogRepository
    {
        public void Add(ILog log);
    }
}