using Microsoft.EntityFrameworkCore;
using System;
using PrestamosDetalle.Modelos;
using PrestamosDetalle.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrestamosDetalle.BLL
{
    public class PrestamosBLL
    {
         public static bool Guardar(Prestamos prestamos)
        {
            if (!Existe(prestamos.PrestamoId))
                return Insertar(prestamos);
            else
                return Modificar(prestamos);
        }

        public static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Prestamos.Any(e => e.PrestamoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;
        }

        public static bool Insertar(Prestamos prestamos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Prestamos.Add(prestamos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Prestamos prestamos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(prestamos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var prestamos = db.Prestamos.Find(id);

                if (prestamos != null)
                {
                    db.Prestamos.Remove(prestamos);
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Prestamos Buscar(int id)
        {
            Contexto db = new Contexto();
            Prestamos prestamos;

            try
            {
                prestamos = db.Prestamos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return prestamos;
        }

        public static List<Modelos.Prestamos> GetList(Expression<Func<Prestamos, bool>> criterio)
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto db = new Contexto();
            try
            {
                lista = db.Prestamos.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }

        public static void LlenarBalance(int Id, decimal BalancePrestamo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            var persona = db.Personas.Find(Id);

            if (persona != null)
            {
                persona.Balance = GuardarInscripcion(persona.Balance, BalancePrestamo);
                paso = (db.SaveChanges() > 0);
            }

        }
        public static decimal GuardarInscripcion(decimal BalancePersona, decimal NuevoBalance)
        {
            Contexto db = new Contexto();

            try
            {
                BalancePersona += NuevoBalance;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return NuevoBalance;
        }

           public static void RemoverPrestamo(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var persona = db.Personas.Find(Id);
                persona.Balance = 0;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}