using ApplicationCore.Dtos;
using AutoMapper;
using Camp_for_Codes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore
{
    public class Profiling : Profile
    {
        public void AppFormProfile()
        {
            CreateMap<AppFormDto, AppForm>().ReverseMap();
        }
    }
}
