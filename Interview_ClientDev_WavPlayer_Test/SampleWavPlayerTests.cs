using System;
using System.IO;
using Interview_ClientDev_WavPlayer;
using Xunit;

namespace Interview_ClientDev_WavPlayer_Test
{
    public class SampleWavPlayerTests
    {
        Utilities utilitiesMethods = new Utilities();

        [Fact]
        public void TestIsFileBigReturnsTrueForBigFile()
        {
            // Arrange
            string filename = "testfile.bin";
            long fileSize = 200000; // 200 KB
            using (FileStream fs = new FileStream(filename, FileMode.CreateNew))
            {
                fs.Seek(fileSize - 1, SeekOrigin.Begin);
                fs.WriteByte(0);
            }

            //Act
            bool result = utilitiesMethods.isFileBig(filename);
            File.Delete(filename);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsFileBigReturnsFalseForSmallFile()
        {
            // Arrange
            string filename = "testfile.txt";
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write("This is a small file.");
            }

            // Act
            bool result = utilitiesMethods.isFileBig(filename);
            File.Delete(filename);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void SmallMediaDescription_ReturnsCorrectDescription()
        {
            // Arrange
            Language language = Language.Deutsch;
            FileStatus fileStatus = FileStatus.Opened;
            string expectedDescription = "Kleine Datei geöffnet";

            // Act
            string actualDescription = utilitiesMethods.smallMediaDescription(language, fileStatus);

            // Assert
            Assert.Equal(expectedDescription, actualDescription);
        }

        [Fact]
        public void BigMediaDescription_ReturnsCorrectDescription()
        {
            // Arrange
            Language language = Language.Deutsch;
            FileStatus fileStatus = FileStatus.Closed;
            string expectedDescription = "Große Datei geschlossen";

            // Act
            string actualDescription = utilitiesMethods.bigMediaDescription(language, fileStatus);

            // Assert
            Assert.Equal(expectedDescription, actualDescription);
        }

        [Fact]
        public void SmallMediaDescription_ShouldThrowExceptionForInvalidFileStatus()
        {
            // Arrange
            Language language = Language.Deutsch;
            FileStatus fileStatus = (FileStatus)99; // Invalid value

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => utilitiesMethods.smallMediaDescription(language, fileStatus));
        }
    }
}
