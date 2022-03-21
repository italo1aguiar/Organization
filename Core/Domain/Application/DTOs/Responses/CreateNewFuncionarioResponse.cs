using System;
namespace Application.DTOs.Responses
{
	public class CreateNewFuncionarioResponse
	{
        public CreateNewFuncionarioResponse(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
	}
}

