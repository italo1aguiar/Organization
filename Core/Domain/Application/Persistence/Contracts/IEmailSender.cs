using System;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Persistence.Contracts
{
	public interface IEmailSender
	{
		Task<bool> SendEmail(Email email);
	}
}

