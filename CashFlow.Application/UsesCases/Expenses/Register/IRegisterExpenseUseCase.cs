using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UsesCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
	ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request);
}
