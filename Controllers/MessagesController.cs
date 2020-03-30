using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using System;


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
    public ActionResult<IEnumerable<Message>> Get(string group, DateTime postDate)
    {
      var query = _db.Messages.AsQueryable();

      if (group != null)
      {
        query = query.Where(entry => entry.Group == group);
      }
      if (postDate != null)
      {
        query = query.Where(entry => entry.PostDate == postDate);
      }


      return query.ToList();
    }
    
    [HttpGet("{id}")]
    public ActionResult<Message> Get(int id)
    {
      return _db.Messages.FirstOrDefault(entry => entry.MessageId == id);
    }

    // POST api/messages
    [HttpPost]
    public void Post([FromBody] Message message)
    {
      _db.Messages.Add(message);
      _db.SaveChanges();
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Message message)
    {
      message.MessageId = id;
      _db.Entry(message).State = EntityState.Modified;
      _db.SaveChanges();
    }
    // DELETE api/messages/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var messageToDelete = _db.Messages.FirstOrDefault(entry => entry.MessageId == id);
      _db.Messages.Remove(messageToDelete);
      _db.SaveChanges();
    }
  }
}