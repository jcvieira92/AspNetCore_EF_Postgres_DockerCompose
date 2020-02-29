using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteAPI.Models;

namespace TesteAPI.Maps
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