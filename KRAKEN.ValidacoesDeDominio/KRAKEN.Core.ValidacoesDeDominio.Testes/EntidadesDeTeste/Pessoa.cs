using KRAKEN.Core.ValidacoesDeDominio.Validacoes;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.EntidadesDeTeste
{
    public class Pessoa:Notificavel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;

            Validar();
        }

        public  override void Validar()
        {
            InserirNotificacoes(new Contrato()
                .Requer()
                .VerificarSeTemTamanhoMinimo(Nome, 5, "Nome", "O nome deve conter no mínimo 5 caracteres")
                 .VerificarSeTemTamanhoMaximo(Nome, 10, "Nome", "O nome deve conter no máximo 10 caracteres")
                .VerificarSeNaoNuloOuVazio(Nome, "Nome", "O nome é obrigatório")
                .VerificarSeMaiorQue(Idade, 18, "Idade", "A idade deve ser maior que 18"));
        }
    }
}
