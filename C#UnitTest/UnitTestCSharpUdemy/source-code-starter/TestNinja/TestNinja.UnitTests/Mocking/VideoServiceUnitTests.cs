using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceUnitTests
    {
        private Mock<IFileReader> _mockFileReader;
        private Mock<IVideoRepository> _videoRepository;
        private VideoService _videoService;
        [SetUp]
        public void SetUp()
        {
            _mockFileReader = new Mock<IFileReader>();
            _videoRepository = new Mock<IVideoRepository>();
            _videoService = new VideoService();
        }
        [Test]
        public void ReadVideoTitle_PassEmptyFile_ReturnErrorMessage()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Object.Read("video.txt");
            //This is just a object that implement a fileReader, but we need to give it an implementation.
            _mockFileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            //this is equivalent to creating a fakeFileReader.
            
            _videoService = new VideoService();
            //vs.FileReader = new FakeFileReader(); //dependency injection via property
            var val = _videoService.ReadVideoTitle(_mockFileReader.Object);
            Assert.That(val, Does.Contain("error").IgnoreCase);
        }
        [Test]
        //This only use fileReader
        public void ReaderVideoTitle_PassValidFile_ReturnVideoTitle()
        {
            _mockFileReader = new Mock<IFileReader>();
            var video = @"
            {
                ""Id"": 0,
                ""Title"":""My Title"",
                ""IsProcessed"": true
                


            }";

            _mockFileReader.Setup(fr => fr.Read(It.IsAny<string>())).Returns(video);

            //when we create a mock object, the paramerter passing must match otherwise will use the normal read method.
            _videoService = new VideoService();
            var result = _videoService.ReadVideoTitle(_mockFileReader.Object);
            Assert.That(result, Is.EqualTo("My Title"));
        }
        //Two scenario
        //1.Empty video return-> Empty string
        //2.Video Present return-> video string
        //This onlyUse videoRepsitory
        [Test]
        public void GetUnprocessedVideosAsCsv_WhereVideoObjectIsNull_ReturnEmptyResult()
        {
            
            _videoRepository.Setup(obj => obj.GetVideo()).Returns(new List<Video>()) ;
            var result = _videoService.GetUnprocessedVideosAsCsv(_videoRepository.Object);
            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void GetUnProcessedVideosAsCsv_WhenVideoObjectPresent_ReturnVideoId()
        {
            _videoRepository.Setup(obj=>obj.GetVideo()).Returns(new List<Video> { new Video {Id=10 },new Video {Id=11 } });
            var result = _videoService.GetUnprocessedVideosAsCsv(_videoRepository.Object);
            Assert.That(result, Is.EqualTo("10,11"));
            
        }
        

        
    }
}
