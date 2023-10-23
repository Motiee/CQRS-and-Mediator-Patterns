using DemoLibrary.commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;

namespace DomainLibrary.Handlers;
public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
{
    private readonly IDataAccess _data;

    public InsertPersonHandler(IDataAccess data)
    {
        _data=data;
    }
    public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
    {
       return Task.FromResult(_data.InsertPerson(request.FirstName,request.LastName));
       
    }
}
