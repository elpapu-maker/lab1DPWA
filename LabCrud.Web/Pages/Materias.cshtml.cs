using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabCrud.Data.Interfaces;
using LabCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LabCrud.Web.Pages
{
    public class MateriaModel : PageModel
    {

        private readonly IMateriaRepository _materiaRepository;

        public MateriaModel(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public IEnumerable<Materia> Materias { get; set; }
        public IActionResult OnGet()
        { 
            Materias = _materiaRepository.List();
            return Page();
        }
    }
}
