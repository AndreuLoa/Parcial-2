using System;
using Andreu;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ahorro()
        {
            string Nombre = "nada";
            double Monto1 = 500;
            double Monto2 = 400;
            Company Objeto = new Company(Nombre,Monto1);
            double montoesperado = 900;

            Objeto.Save(Monto2);
            double obtenido = Objeto.SaveProject;

            Assert.AreEqual(obtenido, montoesperado);
        }


        [TestMethod]
        public void s()
        {
            string Nombre = "nada";
            double Monto1 = 500;
            string nombre2 = "todo";
            Company Objeto = new Company(Nombre, Monto1);
            string esperado = "todo";

            Objeto.ChangeName(nombre2);
            string obtenido = Objeto.Name;

            Assert.AreEqual(obtenido, esperado);
        }
    }
}
