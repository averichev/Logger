namespace Logger.Application.Models
{
    public interface ILogWriter
    {
        public void Write(ILog log);
    }
}