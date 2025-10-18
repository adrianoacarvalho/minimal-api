using MinimalApi.Dominio.DTOs;
using MininalApi.Dominio.Entidades;
using MininalApi.DTOs;
using MininalApi.Infraestrutura.Db;

namespace MininalApi.Dominio.Servicos
{
    public class AdministradorServico : IAdminitradorServico
    {

        public readonly DbContexto _contexto;

        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public bool Login(LoginDTO loginDTO)
        {
           return (_contexto.Administradores.Any(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Password)).Count > 0)
          
           }
    }
}