using Microsoft.EntityFrameworkCore;
using PrestamosDetalle.DAL;
using  PrestamosDetalle.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrestamosDetalle.BLL
{
    public class MorasBLL
    {
         public static bool Guardar(Moras mora)
        {
            if (!Existe(mora.MoraId))
                return Insertar(mora);
            else
                return Modificar(mora);
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Moras.Any(x => x.MoraId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static bool Insertar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Moras.Add(mora);
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM DetalleMora where MoraId = {mora.MoraId}");

                foreach (var item in mora.DetalleMora)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(mora).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

                var mora = contexto.Moras.Find(id);

                if (mora != null)
                {
                    contexto.Moras.Remove(mora);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Moras Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Moras mora = new Moras();

            try
            {
                mora = contexto.Moras
                    .Where(e => e.MoraId == id)
                    .Include(e => e.DetalleMora)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return mora;
        }

        public static List<Moras> GetList(Expression<Func<Moras, bool>> criterio)
        {
            List<Moras> lista = new List<Moras>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Moras.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Moras> GetMoras()
        {
            List<Moras> lista = new List<Moras>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Moras.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}