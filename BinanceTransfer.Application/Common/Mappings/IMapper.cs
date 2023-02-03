using AutoMapper;

namespace BinanceTransfer.Application.Common.Mappings;

public interface IMapper<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}