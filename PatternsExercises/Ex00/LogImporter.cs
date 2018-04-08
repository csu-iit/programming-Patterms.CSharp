namespace Patterns.Ex00
{
    /// <summary>
    /// Этот файл нельзя менять по условиям задания
    /// Требуется именно расширить функциональность текущего класса, а не изменить ее
    /// </summary>
    public class LogImporter
    {
        private readonly ILogReader _reader;

        public LogImporter(ILogReader reader)
        {
            _reader = reader;
        }

        public void ImportLogs(string source)
        {
            var file = _reader.ReadLogFile(source);
            // Do smth
        }

    }
}