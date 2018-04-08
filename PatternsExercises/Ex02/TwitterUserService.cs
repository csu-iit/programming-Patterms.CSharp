using System;
using System.Linq;
using System.Text.RegularExpressions;
using Patterns.Ex01.ExternalLibs.Twitter;

namespace Patterns.Ex02
{
    public class TwitterUserService
    {
        readonly TwitterClient _client = new TwitterClient();

        /// <summary>
        /// Этот метод содержить дублирование с VkUserService.GetUserInfo
        /// необходимо избавиться от дублирования (см. задание)
        /// </summary>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(String pageUrl)
        {
            var regex = new Regex("twitter.com/(.*)");
            var userName = regex.Match(pageUrl).Groups[0].Value;

            var userId = GetUserId(userName);

            TwitterUser[] subscribers = _client.GetSubscribers(userId);

            UserInfo[] friends = subscribers
                .Select(c =>
                {
                    UserInfo userInfo = new UserInfo
                    {
                        UserId = c.UserId.ToString(),
                        Name = _client.GetUserNameById(c.UserId)
                    };
                    return userInfo;
                })
                .ToArray();

            var result = new UserInfo
            {
                Name = userName,
                UserId = userId.ToString(),
                Friends = friends
            };
            return result;
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        private long GetUserId(String userName)
        {
            //TODO: Return userId from userName
            return 0;
        }
    }
}