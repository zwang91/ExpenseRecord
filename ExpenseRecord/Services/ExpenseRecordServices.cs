using ExpenseRecord.Item;
using ExpenseRecord.Services;
namespace WebApplication2.Services
{
    public class ExpenseRecordServices : IExpenseRecordServices
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ExpenseRecordServices(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public async Task<string> CreateItemAsync (RecordItem recordItem)
        {
            var id = Guid.NewGuid().ToString();
            var recordGetItem = new RecordItem
            {
                Id = id,
                Description = recordItem.Description,
                Type = recordItem.Type,
                Amount = recordItem.Amount,
                Date = DateTime.Now
            };
            _applicationDbContext.RecordItem.Add(recordGetItem);
            await _applicationDbContext.SaveChangesAsync();
            return id;

        }
    }
}
