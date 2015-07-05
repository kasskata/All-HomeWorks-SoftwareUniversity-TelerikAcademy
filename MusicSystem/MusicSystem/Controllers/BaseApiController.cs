namespace MusicSystem.Controllers
{
    using System.Web.Http;
    using Data;

    public class BaseApiController : ApiController
    {
          private IMusicSystemData data;

        protected BaseApiController()
            : this(new MusicSystemData(new ApplicationDbContext()))
        {
        }

        protected BaseApiController(MusicSystemData data)
        {
            this.Data = data;
        }

        public MusicSystemData Data { get; set; }
    }
}