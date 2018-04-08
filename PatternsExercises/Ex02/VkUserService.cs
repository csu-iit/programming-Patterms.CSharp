namespace Patterns.Ex02
{
    public class VkUserService
    {
        /// <summary>
        /// Этот метод содержить дублирование с TwitterUserService.GetUserInfo
        /// необходимо избавиться от дублирования (см. задание)
        /// </summary>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(string pageUrl)
        {
            var userId = Parse(pageUrl);
            UserInfo result = new UserInfo
            {
                Name = GetName(userId),
                UserId = userId
            };

            VkUser[] users = GetFriendsById(result.UserId);
            UserInfo[] friends = ConvertToUserInfo(users);
            result.Friends = friends;
            return result;
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private string GetName(string userId)
        {
            return "NAME";
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private VkUser[] GetFriendsById(string userId)
        {
            return new VkUser[0];
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        private string Parse(string pageUrl)
        {
            return "USER_ID";
        }


        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="friends"></param>
        /// <returns></returns>
        private UserInfo[] ConvertToUserInfo(VkUser[] friends)
        {
            return new UserInfo[0];
        }
    }
}