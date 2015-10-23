using App.Models.Users;
using AutoMapper;
using Models;

namespace App.App_Start
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<User, UserViewModelMinified>();
        }
    }
}