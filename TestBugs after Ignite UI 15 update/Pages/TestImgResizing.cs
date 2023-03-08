using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_after_Ignite_UI_15_update.Pages;

namespace TestBugs_after_Ignite_UI_15_update
{
	public class TestImgResizing
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<ImgResizing>();
			Assert.NotNull(componentUnderTest);
		}
	}
}