using Newtonsoft.Json;
using PhoenixBL.interfaces;
using System.Net;

namespace PhoenixBL
{
    public class RepositoryBL
    {
        /// <summary>
        /// get all repositories from api, convert the return data to IRepository list, and return the lits
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public List<IRepository>? GetRepositoryByName(string text)
        {
            try
            {
                List<IRepository> list = new List<IRepository>();
                string url = "https://api.github.com/search/repositories?q=" + text;

                using (WebClient wb = new WebClient())
                {
                    wb.Headers.Add("user-agent", "Only a test!");
                    string result = wb.DownloadString(url);
                    Root? data = JsonConvert.DeserializeObject<Root>(result);

                    foreach (var item in data!.items!)
                    {
                        IRepository x = new IRepository();
                        x.avatar = item.owner!.avatar_url;
                        x.id = item.id;
                        x.isBookmark = false;
                        x.name = item.full_name;
                        list.Add(x);
                    }

                    return list;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}