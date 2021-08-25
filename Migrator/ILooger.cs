namespace Migrator
{
    public interface ILooger
    {
        public void LogError(string info);
        public void LogInfo(string info);

        public void LogWarning(string info);
    }
}

