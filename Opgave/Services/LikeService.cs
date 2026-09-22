namespace Opgave.Services
{
    public class LikeService
    {
        public int Service { get; set; }

        public void Add(int like)
        {
            Service += like;
        }
        public void Remove(int like)
        {
            Service -= like;
        }
    }
}
