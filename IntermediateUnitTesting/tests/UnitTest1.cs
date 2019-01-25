using lib;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var mockDataStore = new Mock<IDataStore>();
            var client = new Client(mockDataStore.Object);
            mockDataStore.Setup(m => m.Save(It.IsAny<Dto>())).Returns(new Dto());
            //mockDataStore.Setup(m => m.Save(It.Is<Dto>(d => d.Id == 0))).Returns(new Dto());

            // Act
            client.Save(new Contract());

            // Assert
            mockDataStore.Verify(m => m.Save(It.IsAny<Dto>()), Times.Once);
        }

        //[Test]
        //public void Test2()
        //{
        //    // Arrange
        //    var mockDataStore = new Mock<IDataStore>();
        //    var client = new Client(mockDataStore.Object);
        //    mockDataStore.Setup(m => m.Save(It.IsAny<Dto>())).Returns(new Dto());

        //    // Act
        //    client.Save(new Contract());

        //    // Assert
        //    mockDataStore.Verify(m => m.Save(It.IsAny<Dto>()), Times.Never);
        //}

        //[Test]
        //public void Test3()
        //{
        //    // Arrange
        //    var mockDataStore = new Mock<IDataStore>();
        //    var client = new Client(mockDataStore.Object);

        //    // Act
        //    // Assert
        //    Assert.Throws<Exception>(() => client.Save(new Contract()));
        //}
    }
}