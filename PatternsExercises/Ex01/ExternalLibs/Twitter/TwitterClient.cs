using System;

namespace Patterns.Ex01.ExternalLibs.Twitter
{
    /// <summary>
    /// Этот файл нельзя менять по условиям задания
    /// В реальном проекте такой класс скорее всего будет в составе базовой библиотеки, доступа к изменению которого не будет
    /// </summary>
    public class TwitterClient
    {
        public long GetUserIdByName(string name)
        {
            return 1;
        }

        public String GetUserNameById(long id)
        {
            return "";
        }

        public TwitterUser[] GetSubscribers(long userId)
        {
            return new TwitterUser[0];
        }
    }
}