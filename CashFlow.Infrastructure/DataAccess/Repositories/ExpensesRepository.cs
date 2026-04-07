using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAccess.Repositories;

internal class ExpensesRepository
{
	public void Add(Expense expense)
	{
		var DbContext = new CashFlowDbContext();

		DbContext.Expenses.Add(expense);
	}
}
