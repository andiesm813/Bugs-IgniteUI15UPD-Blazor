using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_after_Ignite_UI_15_update.Pages;
using Bugs_after_Ignite_UI_15_update.MovieAppData;

namespace TestBugs_after_Ignite_UI_15_update
{
	public class TestMovieApp
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbTabsModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbDatePickerModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule));
			ctx.Services.AddScoped<IMovieAppDataService>(sp => new MockMovieAppDataService());
			var componentUnderTest = ctx.RenderComponent<MovieApp>();
			Assert.NotNull(componentUnderTest);
		}
	}
}