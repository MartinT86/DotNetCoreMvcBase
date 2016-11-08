using System;
using MvcMovie.Models;

namespace MvcMovie.Services
{
    public class HomeModelService : IGetHomeModels
    {
        public Home GetHomeModel()
        {
            return new Home()
            {
                ID = 123,
                Title = "Tester from service"
            };
        }
    }
}