namespace Patterns.Ex00.ExternalLibs
{
    /// <summary>
    /// Этот файл нельзя менять по условиям задания
    /// В реальном проекте такой класс скорее всего будет в составе базовой библиотеки, доступа к изменению которого не будет
    /// </summary>
    public class FtpClient
    {
        /// <summary>
        /// Читает файл с удаленного FTP
        /// </summary>
        /// <param name="login">Логин к FTP серверу</param>
        /// <param name="password">Пароль пользователя FTP сервера</param>
        /// <param name="filePath">Путь к файлу на удаленном сервере</param>
        /// <returns></returns>
        public string ReadFile(string login, string password, string filePath)
        {
            return "";
        }
    }
}