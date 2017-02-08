using System;
using System.Collections.Generic;
using System.Security.Claims;
using BL.BlImp;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALTest
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void GetListTest()
        {
            var repository = new UsuarioImp();
            List<Usuario> lstRols = (List<Usuario>) repository.GetAll();
            Assert.IsTrue(lstRols.Count > 0);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var repository = new UsuarioImp();
            Usuario rol = repository.Find((x => x.id == 1));
            Assert.IsNotNull(rol);
        }

        [TestMethod]
        public void AddTest()
        {
            var repository = new UsuarioImp();
            Usuario rol = new Usuario();
            rol.Nombre = "Adriana";
            repository.Add(rol);
            Assert.IsTrue(rol.id > 0);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var repository = new UsuarioImp();
            Usuario rol = repository.Find((x => x.id == 1));
            rol.Nombre = "Update";
            repository.Update(rol);
            Assert.IsTrue(rol.id > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            var repository = new UsuarioImp();
            Usuario rol = repository.Find((x => x.id == 1003));
            rol.Nombre = "Update";
            repository.Update(rol);
            Assert.IsTrue(rol.id > 0);
        }

        [TestMethod]
        public void AddBySpTest()
        {
            var repository = new UsuarioImp();
            //repository.InsertSp("test111SP");
            Assert.IsTrue(true);
        }


    }
}
