using exemploweb.Configs;

namespace exemploweb.DAO
{
    public class ProcessoDAO
    {
        private readonly Conexao _conexao;
        public ProcessoDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

    }
}
