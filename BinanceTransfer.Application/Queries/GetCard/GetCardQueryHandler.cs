using AutoMapper;
using BinanceTransfer.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BinanceTransfer.Application.Queries.GetCard;

public class GetCardQueryHandler : IRequestHandler<GetCardQuery, CardVm>
{
    private readonly IDomainDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetCardQueryHandler(IDomainDbContext dbContext, IMapper mapper) 
        => (_dbContext, _mapper) = (dbContext, mapper);

    public async Task<CardVm> Handle(GetCardQuery request, CancellationToken cancellationToken) 
        => _mapper.Map<CardVm>(await _dbContext.Cards.FirstOrDefaultAsync());
}