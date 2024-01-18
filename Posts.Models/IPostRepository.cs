namespace Posts.Models
{
    public interface IPostRepository
    {
        int SendPost(Post post);
    }

    public class Post
    {


    }

    public interface IBadWordsChecker
    {
    }

    public class PostService
    {
        public PostService(IBadWordsChecker bdChecker, IPostRepository postRepository)
        {
            throw new ArgumentNullException();
        }
    }
}