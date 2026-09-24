using Opgave.Components.Pages;
using Opgave.Models;

namespace Opgave.Repository
{
    public class BookRepo
    {
        private readonly List<BookModel> books = new()
        {
        new BookModel{ Title = "The Shining", Author = "Stephen King", Pages = 447, Genre = BookGenre.Horror },
        new BookModel{ Title = "It", Author = "Stephen King", Pages = 1138, Genre = BookGenre.Horror },
        new BookModel{ Title = "The Exorcist", Author = "William Peter Blatty", Pages = 340, Genre = BookGenre.Supernatural },
        new BookModel{ Title = "Psycho", Author = "Robert Bloch", Pages = 160, Genre = BookGenre.Psychological },
        new BookModel{ Title = "The Silence of the Lambs", Author = "Thomas Harris", Pages = 352, Genre = BookGenre.Psychological },
        new BookModel{ Title = "The Texas Chain Saw Massacre", Author = "Tobe Hooper", Pages = 90, Genre = BookGenre.Slasher },
        new BookModel{ Title = "The Thing", Author = "John W. Campbell Jr.", Pages = 120, Genre = BookGenre.Monster },
        new BookModel{ Title = "The Fly", Author = "George Langelaan", Pages = 80, Genre = BookGenre.Bodyhorror }, 
        new BookModel { Title = "The Mist", Author = "Stephen King", Pages = 160, Genre = BookGenre.Thriller },
        new BookModel { Title = "The Babadook", Author = "Jennifer Kent", Pages = 90, Genre = BookGenre.Supernatural }
        };
        public async Task<List<BookModel>> GetBooksAsync()
        {
            await Task.Delay(500);

            return books;
        }
    }
 }
