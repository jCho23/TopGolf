using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace TopGolf
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}


		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("txt_menu_news");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'News'");

			app.ScrollDown();
			app.Screenshot("Scrolling down to see more information");
			app.Back();
			app.Screenshot("Tapped on 'Back' Button to get back to Main Menu");

			app.Tap("Leaderboards");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Leaderboards'");

			//app.Tap("spinner_location");
			//Thread.Sleep(8000);
			//app.Screenshot("Tapped on More Locations Button");

			//app.Tap("Las Vegas, NV");
			//app.Screenshot("Selected, Las Vegas");

			app.Back();
			app.Screenshot("Tapped on Back Button");

			app.Tap("txt_menu_locations");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Locations' Button");

			app.ScrollDown();
			app.Screenshot("Scrolling down to see more information");
			app.Back();
			app.Screenshot("Tapped on Back Button");

			app.Tap("txt_menu_game");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'The Games' Button");
			app.Back();
			app.Screenshot("Tapped on Back Button");

			app.Tap("txt_menu_news");
			Thread.Sleep(8000);
			app.Screenshot("Tapped on 'Menu'");

			app.ScrollDown();
			app.Screenshot("Scrolling down to see more information");

			app.Back();
			app.Screenshot("Tapped on Back Button");

			app.Tap("input_email");
			Thread.Sleep(8000);
			app.Screenshot("Tapped 'E-Mail' TextField");

			app.EnterText("@MicrosoftLovesTopgolf!");
			app.Screenshot("Typed in my E-Mail");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("login");
			app.Screenshot("Tapped in 'Login' Button");
		}


	}
}
