using Microsoft.EntityFrameworkCore;
using System;

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
          new Message { MessageId = 1, Content = "where the tp", Group = "Shopping Boi's", UserName = "Female", PostDate = new DateTime(2015, 06, 15) },
          new Message { MessageId = 2, Content = "Pip", Group = "Shark", UserName="leggo", PostDate = new DateTime(2020, 02, 03)},
          new Message { MessageId = 3, Content = "Bartholomew's fancy hats", Group = "Shark", UserName = "noodle_boi_hat", PostDate = new DateTime(2017, 07, 11) },
          new Message { MessageId = 4, Content = "Pip", Group = "Shopping Boi's", UserName = "noodle_boi_hat", PostDate = new DateTime(2019, 05, 20) },
          new Message { MessageId = 5, Content = "doppledonger", Group = "Firework Sales", UserName = "Female", PostDate = new DateTime(2017, 07, 11)  },
          new Message { MessageId = 6, Content = "bart", Group = "Shark", UserName = "Female", PostDate = new DateTime(2015, 06, 15) },
          new Message { MessageId = 7, Content = "bart", Group = "Firework Sales", UserName = "leggo", PostDate = new DateTime(2019, 05, 20) }
      );
    }
  }
}