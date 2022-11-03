using MediatorPattern;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
    //you can also just use class
    //public class GetPersonListQuery : IRequest<List<PersonModel>>;
    //{
    //}
}
