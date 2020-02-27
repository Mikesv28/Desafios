using System;
using NUnit.Framework;

namespace CSharpMikeVieira
{
    [TestFixture]
    public class AssertNUnit
    {
        public bool VerificaNomeMike(string nome)
        {
            return nome.Equals("Mike");
            
        }

        public bool VerificaIdade(int idade)
        {
            return idade.Equals(28);
        }

        [Test]
        public void MetodoBool()
        {
            Assert.IsTrue(VerificaNomeMike("Mike"));
            Assert.IsTrue(VerificaIdade(28));

        }

        [Test]
        public void VerificaString()
        {
            string nome = "Mike";
            Assert.IsFalse(nome.Contains("Renan"));
        }

        [Test]
        public void VerificarIntIdade()
        {
            int idade = 28;
            Assert.AreEqual(28, idade);

        }
    }
}
