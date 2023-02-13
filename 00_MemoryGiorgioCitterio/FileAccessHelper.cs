namespace _00_MemoryGiorgioCitterio
{
    public class FileAccessHelper
    {
        public static string GetFileLocalPath(string dbname)
        {
            return Path.Combine(FileSystem.AppDataDirectory, dbname);
        }
    }
}
