﻿using MediatorPattern.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
        }
    }
   
}
