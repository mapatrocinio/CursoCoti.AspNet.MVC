﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.Contracts; //importando
using Projeto.BLL.Contracts; //importando

namespace Projeto.BLL.Business
{
    public class BaseBusiness<T> : IBaseBusiness<T>
        where T : class
    {
        //atributo
        private IBaseRepository<T> repository;

        //construtor para entrada de argumentos
        public BaseBusiness(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }

        public virtual void Cadastrar(T obj)
        {
            repository.Insert(obj);
        }

        public virtual void Atualizar(T obj)
        {
            repository.Update(obj);
        }

        public virtual void Excluir(T obj)
        {
            repository.Remove(obj);
        }

        public virtual List<T> ConsultarTodos()
        {
            return repository.FindAll();
        }

        public virtual T ConsultarPorId(int id)
        {
            return repository.FindById(id);
        }
    }
}
