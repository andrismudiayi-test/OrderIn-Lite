using AutoMapper;
using OrderInLite.Models.Repository;
using OrderInLite.Models.Business;
using System.Collections.Generic;


namespace OrderInLite.Repository
{
    public class MenuItemProfile: Profile
    {
        public  MenuItemProfile()
        {
            CreateMap<FoodSearchResultItem, MenuItem>()
                .ForMember(dest => dest.RestaurantId, opt => opt.MapFrom(src => src.RestaurantId))
                .ForMember(dest => dest.Restaurant.LogoPath, opt => opt.MapFrom(src => src.LogoPath))
                .ForMember(dest => dest.Restaurant.Name, opt => opt.MapFrom(src => src.RestaurantName))
                .ForMember(dest => dest.Restaurant.Suburb, opt => opt.MapFrom(src => src.SuburbName))
                .ForMember(dest => dest.Restaurant.Rank, opt => opt.MapFrom(src => src.RankNumber))
                .ForMember(dest => dest.Restaurant.MenuItem, opt => opt.MapFrom(src => src.MenuItems))
                .ReverseMap();
            CreateMap<MenuItemModel, MenuItem>()
                .ForMember(dest => dest.Id , opt => opt.MapFrom(src => src.MenuItemId))
                .ForMember(dest=>dest.Name, opt => opt.MapFrom(src => src.Name))                
                .ForMember(dest => dest.Price , opt => opt.MapFrom(src => src.Price))
                .ReverseMap();
                
         
        }
    }
}
