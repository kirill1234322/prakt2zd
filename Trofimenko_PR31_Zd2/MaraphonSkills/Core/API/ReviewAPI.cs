using MaraphonSkills.Core.ModelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MaraphonSkills.Core.API
{
    public class ReviewAPI
    {
        public static List<Core.ModelAPI.Review> GetReviewsList()
        {
            var client = new WebClient();
            try
            {
                return JsonObject.Deserialize<Response<List<Core.ModelAPI.Review>>>(client.DownloadString(Manager.RootUrl + "/reviews")).data;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
