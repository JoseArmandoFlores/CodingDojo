using CodigoDojo2;
using CodigoDojo2.Interfaces;

namespace CodignDojo2.Tests
{
    public class PostTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenReceiveGoodPostReturnId()
        {
            Post newP = new Post();
            //  newP.Title = new Mock<IPostRepository>();
            newP.Title = "Titulo de prueba";
            newP.Body = "Esto es un body de prueba";
           
        }
    }
}