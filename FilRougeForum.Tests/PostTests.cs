using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetiersPortable;

namespace FilRougeForum.Tests
{
    [TestClass]
    /// <summary>
    /// Test sur la classe Post
    /// </summary>
    public class PostTests
    {
        /// <summary>
        /// Test de création d'un nouveau post
        /// </summary>
        [TestMethod]
        public void TestCreationPost()
        {
            string expectedString = "Test de Post";
            Post post = new Post(2, "Test de Post");

            Assert.AreEqual(post.PostContent, expectedString);
        }
    }
}
