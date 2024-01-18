namespace PostsTests
{
    public class PostTest
    {
        /*
         1. with bdChecker null throw argument null exception
         2. with PostRepository null throw argument null exception

         
         */
        [Test]
        public void When_BdCheckerNull_ThrowsArgumentNullExcep()
        {
            IBadWordsChecker bdChecker = null;
            IPostRepository postRepository = null;
            //Arrange

            //Act

            //Assert
        }

    }
}


/*
        public class PostService{

        Atributtes
            BadWordsChecker
            PostRepository
        Methods
            PostService(BadWordsChecker bdChecker,PostRepository postRepository)
            int CreatePost(Post post)
        }
        ```

        ```
        public class BadWordsChecker{

        Atributtes
            BadWordsGlobalList
        Methods
            BadWordsChecker(BadWordsGlobalList bwList)
            List<string> CheckerText(string post)
        }
        ```

        ```
        public class PostRepository{

        Atributtes
            APIUrl
        Methods
            int SendPost(Post post)
        }
 */