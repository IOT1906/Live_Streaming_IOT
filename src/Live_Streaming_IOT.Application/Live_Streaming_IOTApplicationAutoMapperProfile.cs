using AutoMapper;
using Live_Streaming_IOT.Brand;
using Live_Streaming_IOT.Classify;
using static Live_Streaming_IOT.DTO.ProductDTo;

namespace Live_Streaming_IOT;

public class Live_Streaming_IOTApplicationAutoMapperProfile : Profile
{
    public Live_Streaming_IOTApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Brand_ListDTO, Brand_List>();
        CreateMap<Category_listingsDTO, Category_listings>();
        CreateMap<DetalisDTO, Detalis>();
        CreateMap<ShowcaseDTO, Showcase>();
        CreateMap<SKUDTO, SKU>();
        CreateMap<SPUDTO, SPU>();
    }
}
