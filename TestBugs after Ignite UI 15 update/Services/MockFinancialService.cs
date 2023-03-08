namespace Bugs_after_Ignite_UI_15_update.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }
    }
}