using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Bugs_after_Ignite_UI_15_update.Pages;
using Bugs_after_Ignite_UI_15_update.Financial;

namespace TestBugs_after_Ignite_UI_15_update
{
	public class TestTestingComponents
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDatePickerModule),
				typeof(IgbTabsModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<TestingComponents>();
			Assert.NotNull(componentUnderTest);
		}
	}
}