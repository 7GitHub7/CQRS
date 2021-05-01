

using AutoMapper;
using CQRS_strona.Application.Functions.Categories.Commands;
using CQRS_strona.Application.Functions.Categories.Queries.GetCategoryList;
using CQRS_strona.Application.Functions.Categories.Queries.GetCategoryListWithPosts;
using CQRS_strona.Application.Functions.Posts;
using CQRS_strona.Application.Functions.Posts.Commands;
using CQRS_strona.Application.Functions.Posts.Queries.GetPostDetail;
using CQRS_strona.Application.Functions.Webinars.Queries;
using CQRS_strona.Domain.Entities;
using EduZbieracz.Application.Functions.Webinars.Command.UpdateWebinar;
using CQRS_strona.Application.Functions.Webinars.Command.UpdateWebinar;
using CQRS_strona.Application.Functions.Webinars.Queries.GetWebinar;

namespace CQRS_strona.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostInListViewModel>()
                            .ReverseMap();
            CreateMap<Post, PostDetailViewModel>()
                .ReverseMap();
            CreateMap<Category, CategoryDto>();

            CreateMap<Category, CategoryInListViewModel>();
            CreateMap<Category, CategoryPostDto>();
            CreateMap<Category, CategoryPostListViewModel>();
            CreateMap<Post, CategoryPostDto>();

            CreateMap<Post, CreatedPostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();

            CreateMap<Category, CreatedCategoryCommand>().ReverseMap();
            
            CreateMap<Webinar, WebinarsByDateViewModel>().ReverseMap();
            CreateMap<Webinar, CreatedCategoryCommand>().ReverseMap();

            CreateMap<Webinar, UpdateWebinarCommand>().ReverseMap();

            CreateMap<Webinar, WebinarViewModel>().ReverseMap();



        }
    }
}
