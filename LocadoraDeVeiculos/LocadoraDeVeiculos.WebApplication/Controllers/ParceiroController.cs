using AutoMapper;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.WebApplication.AutoMapperConfig;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LocadoraDeVeiculos.WebApplication.Models.ParceiroViewModel;

namespace LocadoraDeVeiculos.WebApplication.Controllers
{
    public class ParceiroController : Controller
    {
        IRepository<Parceiro> parceiroRepository;
        IMapper mapper;

        public ParceiroController(IRepository<Parceiro> parceiroRepository, IMapper mapper)
        {
            this.parceiroRepository = parceiroRepository;
            this.mapper = mapper;
    }



        // GET: ParceiroController
        public ActionResult Index()
        {
            var parceiros = parceiroRepository.SelecionarTodos();

            var parceiroIndexVM = mapper.Map<ParceiroIndexViewModel>(parceiros);

            return View(parceiroIndexVM);
        }

        // GET: ParceiroController/Details/5
        public ActionResult Details(int id)
        {
            var parceiro = parceiroRepository.SelecionarPorId(id);

            var parceiroDetailsVM = mapper.Map<ParceiroDetailsViewModel>(parceiro);

            return View(parceiroDetailsVM);
        }

        // GET: ParceiroController/Create
        public ActionResult Create()
        {
            var parceiroCreateVM = new ParceiroCreateViewModel();

            return View(parceiroCreateVM);
        }

        // POST: ParceiroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParceiroCreateViewModel parceiroCreateViewModel)
        {
            try
            {
                var parceiro = mapper.Map<Parceiro>(parceiroCreateViewModel);

                parceiroRepository.InserirNovo(parceiro);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParceiroController/Edit/5
        public ActionResult Edit(int id)
        {
            var parceiro = parceiroRepository.SelecionarPorId(id);

            var parceiroDetailsVM = mapper.Map<ParceiroEditViewModel>(parceiro);

            if (parceiroDetailsVM == null)
            {
                return NotFound();
            }


            return View(parceiroDetailsVM);
        }

        // POST: ParceiroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ParceiroEditViewModel parceiroEditViewModel)
        {
            try
            {
                var parceiro = mapper.Map<Parceiro>(parceiroEditViewModel);

                parceiroRepository.Editar(id, parceiro);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParceiroController/Delete/5
        public ActionResult Delete(int id)
        {
            var parceiro = parceiroRepository.SelecionarPorId(id);

            var parceiroDeleteViewModel = mapper.Map<ParceiroDeleteViewModel>(parceiro);

            if (parceiroDeleteViewModel == null)
            {
                return NotFound();
            }

            return View(parceiroDeleteViewModel);
        }

        // POST: ParceiroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ParceiroDeleteViewModel parceiroDeleteViewModel)
        {
            try
            {
                parceiroRepository.Excluir(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
