using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.DTO
{
    public class StudentDTO : IStudent
    {
        private IRepository _repository;
        private IUnitOfWork _unitOfWork;
        public StudentDTO(IRepository repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Student student)
        {
            this._repository.CreateAsync(student);
            this._unitOfWork.Commit();
        }
    }
}
