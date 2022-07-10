using AutoMapper;
using Habbitz.PoultryGuide.Application.DTOs.Sales.Validators;
using Habbitz.PoultryGuide.Application.Exceptions;
using Habbitz.PoultryGuide.Application.Features.Sales.Requests.Commands;
using Habbitz.PoultryGuide.Application.Models;
using Habbitz.PoultryGuide.Application.Persistence.Contracts;
using Habbitz.PoultryGuide.Application.Persistence.Infrastructure;
using Habbitz.PoultryGuide.Application.Responses;
using Habbitz.PoultryGuide.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.Application.Features.Sales.Handlers.Commands
{
    public class CreateSaleCommandHandler : IRequestHandler<CreateSaleCommand, BaseCommandResponse>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public CreateSaleCommandHandler(ISaleRepository saleRepository, IMapper mapper, IEmailSender emailSender)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }
        public async Task<BaseCommandResponse> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateSaleDtoValidator();
            var validationResult = await validator.ValidateAsync(request.SaleDto);

            if (validationResult.IsValid == false)
                response.Success = false;
                response.Message="Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();

            var sale = _mapper.Map<Sale>(request.SaleDto);
            sale = await _saleRepository.Add(sale);

            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = sale.Id;
             
            return response;
        }
    }
}
