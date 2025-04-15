using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext //Herança do IdentityDbContext para autenticação
    {
        //Construtor que recebe as opções de configuração do DbContext
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }

        //Propriedades Dbset para cada tabela

        //Sobrecarga do método OnModelCreating para configurar o modelo a partir do IdentityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chama o método onModelCreating da classe base para a criação das tabelas padrão
            base.OnModelCreating(modelBuilder);

            //Configurar a criação de tabelas adicionais aqui
        }
    }
}
