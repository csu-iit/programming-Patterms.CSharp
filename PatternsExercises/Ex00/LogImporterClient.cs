namespace Patterns.Ex00
{
    public class LogImporterClient
    {
        /// <summary>
        /// TODO: Изменения нужно вносить в этом методе
        /// </summary>
        public void DoMethod()
        {
            LogImporter importer = new LogImporter(new FileLogReader());
            importer.ImportLogs("ftp://log.txt");
        }

    }
}