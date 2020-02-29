using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ExampleAPI.Models;

namespace ExampleAPI.Maps
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<Book> entityBuilder)
        {
            entityBuilder.HasKey(x => x.BookId);

            entityBuilder.Property(x => x.BookName).HasColumnName("book_name");
        }
    }
}