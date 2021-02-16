using LabCrud.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabCrud.Data.Interfaces
{
    public interface IMateriaRepository : IRepository<Materia>
    {
        void DeleteHabilitada();
    }
    }

