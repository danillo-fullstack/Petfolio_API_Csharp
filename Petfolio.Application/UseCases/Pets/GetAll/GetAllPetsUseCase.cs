using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson
        {
            Pets =
            [
                new ResponseShortPetJson()
                {
                    Id = 1,
                    Name = "Mailon",
                    Type = PetType.Dog
                },
                new ResponseShortPetJson()
                {
                    Id = 2,
                    Name = "Jerry",
                    Type = PetType.Cat
                }
            ]
        };
    }
}