using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerceariaMVCLm.Models;

namespace MerceariaMVCTests
{
    public class ClienteTests
    {
        [Fact]

        public void Verificar_Cliente_Invalido_se_MenorDeIdade()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "Teste@gmail.com",
                Idade = 17,
                Ativo = true
            };

            //Act

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);

        }
        [Fact]
        public void Verificar_Cliente_Invalido_se_IdadeNula()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "Teste@gmail.com",
                Ativo = true
            };

            //Act

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);

        }
        [Fact]
        public void Verificar_Email_Invalido_se_ForadePadrao()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "testegmail.com",
                Idade = 20,
                Ativo = true
            };

            //Act

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);

        }

        [Fact]
        public void Verificar_Email_Invalido_se_Nulo()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "",
                Idade = 20,
                Ativo = true
            };

            //Act

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);

        }

        [Fact]
        public void Verificar_Nome_Invalido_se_Nulo()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "",
                Email = "teste@gmail.com",
                Idade = 20,
                Ativo = true
            };

            //Act

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);

        }

        [Fact]
        public void Verificar_Cliente_Invalido_se_Inativo()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "teste@gmail.com",
                Idade = 20,
                Ativo = false
            };

            //Act

            var resultado = cliente.PodeComprar();

            //Assert

            Assert.False(resultado);

        }

        public void Verificar_Cliente_Invalido_se_Inativo_e_MenorDeIdade()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "teste@gmail.com",
                Idade = 17,
                Ativo = false
            };

            //Act

            var resultado = cliente.PodeComprar();

            //Assert

            Assert.False(resultado);

        }

        [Fact]
        public void Verificar_NomeValido_MaiorDeIdade_EmailValido_Ativo()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "teste@gmail.com",
                Idade = 20,
                Ativo = true
            };

            //Act

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.True(resultado);

        }
        [Fact]
        public void Verificar_PodeComprar_SeAtivo_e_MaiorDeIdade()
        {
            //arrange

            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Lucas",
                Email = "teste@gmail.com",
                Idade = 19,
                Ativo = true
            };

            //Act

            var resultado = cliente.PodeComprar();

            //Assert

            Assert.True(resultado);

        }
    }
}
