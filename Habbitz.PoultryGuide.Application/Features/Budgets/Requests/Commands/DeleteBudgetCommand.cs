﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.Features.Budgets.Requests.Commands
{
    public class DeleteBudgetCommand : IRequest
    {
        public int Id { get; set; }
    }
}
