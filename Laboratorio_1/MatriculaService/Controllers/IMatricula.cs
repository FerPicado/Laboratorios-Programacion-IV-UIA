﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaService.Data;
using MatriculaService.Models;

namespace MatriculaService.Controllers
{
    public interface IMatricula
    {
        Task<MatriculaEstudianteModel> GetMatricula();
        Task<IEnumerable<MatriculaEstudianteModel>> miMatriculaDb();
    }

    public class MatriculaSystem : IMatricula
    {
        private readonly IMatriculaEstudianteRepository _repository;
        public MatriculaSystem(IMatriculaEstudianteRepository repository) 
        {
            _repository = repository;
        }
        public async Task<MatriculaEstudianteModel> GetMatricula()
        {
            MatriculaEstudianteModel matriculaModel = new MatriculaEstudianteModel();
            matriculaModel.FechaMatricula = DateTime.Now;
            matriculaModel.CupoDisponible = true;
            matriculaModel.EstadoMatricula = "Activo";
            matriculaModel.IdMatricula = 1;
            matriculaModel.IdEstudiante = 1;
            return matriculaModel;
        }

        public async Task<IEnumerable<MatriculaEstudianteModel>> miMatriculaDb()
        {
            return await _repository.miMatriculaDb();
        }
    }
}