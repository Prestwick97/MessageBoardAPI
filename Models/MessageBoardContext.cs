using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
    : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
  builder.Entity<Message>()
      .HasData(
          new Message { MessageId = 3, Content = "where the tp", Group = "Shopping Boi's", UserName = "Female" },
          new Message { MessageId = 4, Content = "Pip", Group = "Shark", UserName="leggo"},
          new Message { MessageId = 5, Content = "Bartholomew's fancy hats", Group = "Shark", UserName = "noodle_boi_hat" }
      );
    }
  }
}