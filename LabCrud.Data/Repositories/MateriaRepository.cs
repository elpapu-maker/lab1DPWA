using LabCrud.Data.Interfaces;
using LabCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabCrud.Data.Repositories
{
    public class MateriaRepository : Repository<Materia>, IMateriaRepository
    {
        private readonly ApplicationDbContext _db;
        public MateriaRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void DeleteHabilitada()
        {
            var habilitadas = _db.Materias.Where(c => c.Habilitada == true).ToList();
            _db.RemoveRange();
            _db.SaveChanges();
        }
    }
}
