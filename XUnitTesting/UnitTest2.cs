using Moq;
using SteamInfomation.MVVM.MainViews;
using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.Services;

namespace XUnitTesting
{
    public class UnitTest2
    {


        [Fact]
        public void Test2()
        {
            // Arrange
            var page = new SteamAppMainPage();
            var launcherMock = new Mock<ILauncher>();
            page.Launcher = launcherMock.Object;

            // Act
            page.ImageButton_Clicked(null, null);

            // Assert
            launcherMock.Verify(l => l.OpenAsync(new Uri("https://forms.gle/ge3gq1dReqeMhUp76")), Times.Once);


        }





    }




}