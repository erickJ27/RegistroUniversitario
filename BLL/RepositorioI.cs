﻿using RegistroUniversitario.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUniversitario.BLL
{
    public class RepositorioI<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto _contexto;

        public RepositorioI()
        {
            _contexto = new Contexto();
        }
        public virtual bool Guardar(T entity)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                {
                   //x foreach(var item in )
                    _contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public virtual bool Modificar(T entity)
        {
            bool paso = false;
            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public virtual bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);

                if (_contexto.SaveChanges() > 0)
                    paso = true;

                _contexto.Dispose();
            }
            catch (Exception)
            { throw; }
            return paso;
        }


        public virtual T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }


        public virtual List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = new List<T>();
            try
            {
                Lista = _contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        List<T> IRepository<T>.GetList(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Buscar(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Guardar(T entity)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Modificar(T entity)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
