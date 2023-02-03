using AutoMapper;
using BinanceTransfer.Application.Common.Mappings;
using BinanceTransfer.Domain.Core;

namespace BinanceTransfer.Application.Queries.GetCard;

public class CardVm : IMapper<Card>
{
    public string CardNumber { get; set; }

    public string CardOwner { get; set; }

    public string BankName { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Card, CardVm>()
            .ForMember(vm => vm.BankName,
                opt => opt.MapFrom(m => m.BankName))
            .ForMember(vm => vm.CardNumber,
                opt => opt.MapFrom(m => m.CardNumber))
            .ForMember(vm => vm.CardOwner,
                opt => opt.MapFrom(m => m.CardOwner));
    }
}