namespace Patterns.Ex01.ExternalLibs.Instagram
{
    /// <summary>
    /// Этот файл нельзя менять по условиям задания
    /// В реальном проекте такой класс скорее всего будет в составе базовой библиотеки, доступа к изменению которого не будет
    /// </summary>
    public class InstagramClient
    {
        public InstagramUser[] GetSubscribers(string userName)
        {
            return new InstagramUser[0];
        }
    }
}