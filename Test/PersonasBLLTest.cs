using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamoConDetalle.BLL;
using PrestamoConDetalle.Modelos;
using System;
using System.Collections.Generic;
using System.Text;


namespace PrestamosDetalle.Test
{
    [TestClass()]
    public class PersonasBLLTest
    {
          [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Personas personas = new Personas();

            personas.PersonaId = 0;
            personas.Nombres = "Enmanuel";
            personas.Cedula = "40215207107";
            personas.Telefono = "0000000200";
            personas.Direccion = "PruebaTest";
            personas.FechaNacimiento = Convert.ToDateTime("09/01/1999");
            personas.Balance = 0;

            paso = PersonasBLL.Guardar(personas);

            Assert.AreEqual(paso, true);
        }

         [TestMethod()]
        public void ExisteTest()
        {
            bool paso;
            paso = PersonasBLL.Existe(4);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso;
            Personas personas = new Personas();

            personas.PersonaId = 0;
            personas.Nombres = "Prueba1";
            personas.Cedula = "00000000";
            personas.Telefono = "0000000000";
            personas.Direccion = "PruebaTest";
            personas.FechaNacimiento = DateTime.Now;
            personas.Balance = 0;
            paso = PersonasBLL.Guardar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Personas personas = new Personas();

            personas.PersonaId = 2;
            personas.Nombres = "Juan";
            personas.Cedula = "00000000";
            personas.Telefono = "0000000000";
            personas.Direccion = "PruebaTest";
            personas.FechaNacimiento = DateTime.Now;
            personas.Balance = 0;
            paso = PersonasBLL.Modificar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            if (PersonasBLL.Eliminar(2))
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            var persona = PersonasBLL.Buscar(2);
            if (persona != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            var lista = PersonasBLL.GetList(x => true);

            if (lista != null)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }
        
    }
}