using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetByIdPetUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson()
        {
            Id = id,
            Name = "Mailon",
            Type = PetType.Dog,
            Birthday = new DateTime(year: 2020, month: 7, day: 10)
        };
    }
}