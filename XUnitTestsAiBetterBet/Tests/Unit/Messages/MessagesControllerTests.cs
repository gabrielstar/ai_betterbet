using ai_betterbet.Controllers;
using System;
using System.Linq;
using Xunit;

namespace XUnitTestsAiBetterBet
{
    /// <summary>
    /// File reading is an IO operation so we want to do it once for all tests
    /// Example is rather lousy, we should be reading that from a resource file
    /// To be refactored, otherwise will produce inconsistent results
    /// </summary>
    public class FileReaderFixture : IDisposable
    {
        private const string URLS_FILE_NAME = "urls.txt";
        private const string URLS_FILE_PATH = @"C:\Users\swelse";

        public FileReaderFixture()
        {
            try
            {
                Urls = System.IO.File.ReadAllLines(@$"{URLS_FILE_PATH}\{URLS_FILE_NAME}"); //no escape chars
            }
            catch (Exception)
            {
                Console.WriteLine($"File {URLS_FILE_NAME} not found. Using defaults.");
                Urls = new string[] { "https://github.com" };
            }
        }

        public void Dispose()
        {
            //do nothing, file is closed
        }

        public string[] Urls { get; private set; }
    }

    //Our tests will contain Fixture, an object shared in all test in class
    public class MessagesControllerTests : IClassFixture<FileReaderFixture>
    {
        private readonly FileReaderFixture fileReaderFixture;
        private readonly MessagesController messagesController;

        public MessagesControllerTests(FileReaderFixture fileReaderFixture)
        {
            this.fileReaderFixture = fileReaderFixture;
            this.messagesController = new MessagesController();
        }

        [Fact]
        public void MessageContainsGithubURL()
        {
            //arrange
            string githubURL = fileReaderFixture.Urls.First();
            //act
            string message = messagesController.GetMessages();
            //assert
            Assert.Contains(githubURL, message);
        }
    }
}