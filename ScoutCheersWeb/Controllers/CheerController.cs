using ScoutCheersWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ScoutCheersWeb.Controllers
{
    public class CheerController : ApiController
    {
        private readonly CheersContext _db = new CheersContext();

        public IEnumerable<Cheer> Get()
        {
            return _db.Cheers.ToList();
        }

        public Cheer Get(int id)
        {
            var cheer = _db.Cheers.Find(id);
            if (cheer != null) return cheer;

            var response = new HttpResponseMessage(HttpStatusCode.NoContent)
            {
                Content = new StringContent(String.Format("Unable to find a cheer with id={0}", id))
            };

            throw new HttpResponseException(response);
        }
    }
}
