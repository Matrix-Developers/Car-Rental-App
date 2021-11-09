using AutoMapper;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraDeVeiculos.WebApplication.Models;
using static LocadoraDeVeiculos.WebApplication.Models.ParceiroViewModel;

namespace LocadoraDeVeiculos.WebApplication.AutoMapperConfig
{
    public class ParceiroProfile : Profile
    {
        public ParceiroProfile()
        {
            ConfigurarConversaoDeDominioParaVM();

            ConfigurarConversaoDeVMParaDominio();
        }

        private void ConfigurarConversaoDeVMParaDominio()
        {
            CreateMap<ParceiroCreateViewModel, Parceiro>();
            CreateMap<ParceiroEditViewModel, Parceiro>();
        }

        private void ConfigurarConversaoDeDominioParaVM()
        {
            CreateMap<List<Parceiro>, ParceiroIndexViewModel>().ForMember(dest => dest.registros, opt => opt.MapFrom(a => a));

            CreateMap<Parceiro, ParceiroEditViewModel>();
            CreateMap<Parceiro, ParceiroDeleteViewModel>();
            CreateMap<Parceiro, ParceiroDetailsViewModel>();
            CreateMap<Parceiro, ParceiroListViewModel>();
        }
    }
}
