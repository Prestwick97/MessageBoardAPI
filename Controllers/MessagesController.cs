using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;

namespace MessageBoard.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MessagesController : ControllerBase
  {
    private MessageBoardContext _db;

    public MessagesController(MessageBoardContext db)
    {
      _db = db;
    }

    // GET api/messages
    [HttpGet]
    public ActionResult<IEnumerable<Message>> Get()
    {
      return _db.Messages.ToList();
    }

    // POST api/messages
    [HttpPost]
    public void Post([FromBody] Message message)
    {
      _db.Messages.Add(message);
      _db.SaveChanges();
    }
  }
}