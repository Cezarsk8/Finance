using MediatR;

namespace Finance.Commands
{
    public class CreateTransactionCommand : IRequest<Guid>
    {
    }
}
