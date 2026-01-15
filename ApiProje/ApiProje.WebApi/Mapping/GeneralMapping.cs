using ApiProje.WebApi.Dtos.AboutDtos;
using ApiProje.WebApi.Dtos.CategoryDtos;
using ApiProje.WebApi.Dtos.FeatureDtos;
using ApiProje.WebApi.Dtos.GroupReservationDtos;
using ApiProje.WebApi.Dtos.ImageDtos;
using ApiProje.WebApi.Dtos.MessageDtos;
using ApiProje.WebApi.Dtos.NotificationDtos;
using ApiProje.WebApi.Dtos.ProductDtos;
using ApiProje.WebApi.Dtos.ReservationDtos;
using ApiProje.WebApi.Entities;
using AutoMapper;

namespace ApiProje.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();


            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.CategoryName)).ReverseMap();

            CreateMap<Notification, ResultNotificationDto>().ReverseMap();
            CreateMap<Notification, CreateNotificationDto>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
            CreateMap<Notification, GetNotificationByIdDto>().ReverseMap();

            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutByIdDto>().ReverseMap();

            CreateMap<Reservation, ResultReservationDto>().ReverseMap();
            CreateMap<Reservation, CreateReservationDto>().ReverseMap();
            CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
            CreateMap<Reservation, GetReservationByIdDto>().ReverseMap();

            CreateMap<Image, ResultImageDto>().ReverseMap();
            CreateMap<Image, CreateImageDto>().ReverseMap();
            CreateMap<Image, UpdateImageDto>().ReverseMap();
            CreateMap<Image, GetImageByIdDto>().ReverseMap();

            CreateMap<GroupReservation, ResultGroupReservationDto>().ReverseMap();
            CreateMap<GroupReservation, CreateGroupReservationDto>().ReverseMap();
            CreateMap<GroupReservation, UpdateGroupReservationDto>().ReverseMap();
            CreateMap<GroupReservation, GetByIdGroupReservationDto>().ReverseMap();

        }
    }
}
