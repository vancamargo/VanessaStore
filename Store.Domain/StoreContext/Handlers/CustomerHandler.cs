using FluentValidator;
using Store.Domain.Commands.CustomerCommands.Input;
using System;
using Store.Shared.Commands;
using Store.Domain.Commands.CustomerCommands.Outputs;
using Store.Domain.StoreContext.ValueObjects;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.Repositories;
using Store.Domain.StoreContext.Services;
using Store.Domain.Commands;

namespace Store.Domain.StoreContext.Handlers
{
    public class CustomerHandler : Notifiable, ICommandHandler<CreateCustomerCommand>, ICommandHandler<AddAddressCommands>
    {
       
        private readonly ICustomerRepository _repository;
        private readonly IEmailService _emailService;

        public CustomerHandler()
        {
        }

        public CustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

       
        public ICommandResult Handle(CreateCustomerCommand command)
        {

            if (_repository.ChekDocument(command.Document))
                AddNotification("documento", "este cpf já esta em uso");

            if (_repository.ChekDocument(command.Email))
                AddNotification("email", "este email já esta em uso");
            //verifica se o cpf ja existe na base
            //verifica se o email ja existe na base
            // criar os vos
            var name = new Name(command.FirstName, command.LastName);
            var documment = new Document(command.Document);
            var email = new Email(command.Email);
            //criar entidade
            var customer = new Customer(name, documment, email, command.Phone);

            //validas entidades e vos
            AddNotifications(name.Notifications);
            AddNotifications(documment.Notifications);
            AddNotifications(customer);
            if (Invalid)
                return null;

            _repository.Save(customer);
            _emailService.Send(email.Adress, "hello@vanessa.com", "bem vindo", "seja bem vindo");
       
            // enviar um email
            //retornar o resulta para tela
            return new CreateCustomerCommandResult(customer.Id, name.ToString(), email.Adress);
        }

        public ICommandResult Handle(AddAddressCommands command)
        {
            throw new NotImplementedException();
        }
    }
}
