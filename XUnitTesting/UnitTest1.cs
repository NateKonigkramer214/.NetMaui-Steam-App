using Moq;
using SteamInfomation.MVVM.MainViews;
using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.Services;

namespace XUnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // ImageButton_Clicked_3 testing
            var page = new SteamAppMainPage();

            // Act
            page.ImageButton_Clicked_3(null, null); // Passing nulls for EventArgs in this example


        }






    }




}