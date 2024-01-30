using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Tests
{
    [TestClass()]
    public class DaoTests
    {
        private Pessoa pessoa;
        [TestInitialize]
        public void Setup()
        {
            pessoa = new Pessoa() { Id = 1, Nome = "jamal"};
        }

        [TestMethod()]
        public void AddTest()
        {
            //Pessoa pessoa = new Pessoa()
            //{
            //    Id = 1,
            //    Nome = "Jamal"
            //};
            Dao.Add(pessoa);

            Assert.AreEqual(Dao.GetLenght(), 1);

        }

        [TestMethod()]
        public void ConsultaByIdTest()
        {
            
            Dao.Add(pessoa);

            Pessoa expected = Dao.GetById(1);

            Assert.AreEqual(expected, pessoa);

        }
    }
}