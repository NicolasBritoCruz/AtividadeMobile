using System;
using System.Collections.Generic;
using AtividadeMobile.Models;
using AtividadeMobile.Repositories;

namespace AtividadeMobile.Services
{
    public class CadastroServices
    {
        private readonly CadastroRepository _cadastroRepository;

        public CadastroServices()
        {
            _cadastroRepository = new CadastroRepository();
        }

        public List<Cadastro> ObterCadastros()
        {
            return _cadastroRepository.Read();
        }

        public bool Cadastrar(Cadastro cadastro)
        {
            try
            {
                _cadastroRepository.Create(cadastro);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool AtualizarCadastro(Cadastro cadastro)
        {
            try
            {
                _cadastroRepository.Update(cadastro);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeletarCadastro(Cadastro cadastro)
        {
            try
            {
                _cadastroRepository.Delete(cadastro);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Cadastro Login(string email, string senha)
        {
            var cadastros = ObterCadastros();
            foreach (var cadastro in cadastros)
            {
                if (cadastro.Email == email && cadastro.Senha == senha)
                {
                    return cadastro;
                }
            }
            return null;
        }
    }
}
