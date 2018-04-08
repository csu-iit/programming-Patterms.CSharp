namespace Patterns.Ex00
{
    /// <summary>
    /// Этот файл нельзя менять по условиям задания
    /// В реальном проекте такой класс скорее всего будет использоваться в каких-нибудь других местах 
    /// и изменить его - значт сломать какую-то другую часть проекта
    /// </summary>
    public class FileLogReader : ILogReader
    {
        public string ReadLogFile(string identificator)
        {
            return "FILE";
        }
    }
}