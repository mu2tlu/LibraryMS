using Application.Features.Publishers.Constants;
using Application.Features.Publishers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Publishers.Constants.PublishersOperationClaims;
using Application.Features.LibraryMembers.Constants;

namespace Application.Features.Publishers.Commands.Create;

public class CreatePublisherCommand : IRequest<CreatedPublisherResponse>, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest, ISecuredRequest
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public string[] Roles => [Admin, Write, PublishersOperationClaims.Create, PublishersOperationClaims.Employee];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetPublishers"];

    public class CreatePublisherCommandHandler : IRequestHandler<CreatePublisherCommand, CreatedPublisherResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPublisherRepository _publisherRepository;
        private readonly PublisherBusinessRules _publisherBusinessRules;

        public CreatePublisherCommandHandler(IMapper mapper, IPublisherRepository publisherRepository,
                                         PublisherBusinessRules publisherBusinessRules)
        {
            _mapper = mapper;
            _publisherRepository = publisherRepository;
            _publisherBusinessRules = publisherBusinessRules;
        }

        public async Task<CreatedPublisherResponse> Handle(CreatePublisherCommand request, CancellationToken cancellationToken)
        {
            Publisher publisher = _mapper.Map<Publisher>(request);
            await _publisherBusinessRules.CheckIfPhoneNumberAlreadyExists(publisher.PhoneNumber, cancellationToken);
            await _publisherRepository.AddAsync(publisher);

            CreatedPublisherResponse response = _mapper.Map<CreatedPublisherResponse>(publisher);
            return response;
        }
    }
}