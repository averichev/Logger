namespace Logger.Application.LoggerType
{
    public static class TypeBuilder
    {
        public static Types Build(string type)
        {
            var result = Types.Filesystem;
            if (type == "Database")
            {
                result = Types.Database;
            }

            return result;
        }
    }
}