#KRAKEN Validações de Domínio

Implementação do Domain Notification Pattern  para efetuar as validações de domínio para entidades.

#O que existe neste pacote?

#Validações

Validações de acordo com os tipos

#Boolean

* VerificarSeFalso(bool valor, string propriedade, string mensagem)
* VerificarSeVerdadeiro(bool valor, string propriedade, string mensagem)


#DateTime

* VerificarSeMaiorQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
* VerificarSeMaiorIgualQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(DateTime valor, DateTime comparador, string propriedade, string mensagem)
* VerificarSeEstaEntre(DateTime valor, DateTime de, DateTime para, string propriedade, string mensagem)
* VerificarSeNulaOuTipoNullable(DateTime? valor, string propriedade, string mensagem)

#Decimal

* VerificarSeMaiorQue(decimal valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(double valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(float valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(long valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(int valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(decimal valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(double valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(float valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(long valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(int valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(decimal valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(double valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(float valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(long valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(int valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(decimal valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(double valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(float valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(long valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(int valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(decimal valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(double valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(float valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(long valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(int valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(decimal valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(double valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(float valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(long valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(int valor, decimal comparador, string propriedade, string mensagem)
* VerificarSeEstaEntre(decimal valor, decimal de, decimal para, string propriedade, string mensagem)
* VerificarSeNuloOuNullable(decimal? valor, string propriedade, string mensagem)

#Double

* VerificarSeMaiorQue(decimal valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(double valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(float valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(long valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(int valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(decimal valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(double valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(float valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(long valor, double comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(int valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(decimal valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(double valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(float valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(long valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(int valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(decimal valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(double valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(float valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(long valor, double comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(int valor, double comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(decimal valor, double comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(double valor, double comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(float valor, double comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(long valor, double comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(int valor, double comparador, string propriedade, string mensagem)
* VerificarSeSeNaoSaoIguais(decimal valor, double comparador, string propriedade, string mensagem)
* VerificarSeSeNaoSaoIguais(double valor, double comparador, string propriedade, string mensagem)
* VerificarSeSeNaoSaoIguais(float valor, double comparador, string propriedade, string mensagem)
* VerificarSeSeNaoSaoIguais(long valor, double comparador, string propriedade, string mensagem)
* VerificarSeSeNaoSaoIguais(int valor, double comparador, string propriedade, string mensagem)
* VerificarSeEstaEntre(double valor, double de, double para, string propriedade, string mensagem)
* VerificarSeNuloOuNullable(double? valor, string propriedade, string mensagem)

#Float

* VerificarSeMaiorQue(decimal valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(double valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(float valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(long valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(int valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorIgualQue(decimal valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorIgualQue(double valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorIgualQue(float valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorIgualQue(long valor, float comparador, string propriedade, string mensagem)
* VerificarSeMaiorIgualQue(int valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(decimal valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(double valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(float valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(long valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(int valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(decimal valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(double valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(float valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(long valor, float comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(int valor, float comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(decimal valor, float comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(double valor, float comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(float valor, float comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(long valor, float comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(int valor, float comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(decimal valor, float comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(double valor, float comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(float valor, float comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(long valor, float comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(int valor, float comparador, string propriedade, string mensagem)
* VerificarSeEstaEntre(float valor, float from, float to, string propriedade, string mensagem)
* VerificarSeNulaOuTipoNullable(float? valor, string propriedade, string mensagem)


#GUID

* VerificarSeSaoIguais(Guid valor, Guid comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(Guid valor, Guid comparador, string propriedade, string mensagem)
* VerificarSeEstaVazio(Guid valor, string propriedade, string mensagem)
* VerificarSeNaoEstaVazio(Guid valor, string propriedade, string mensagem)

#Int

* VerificarSeEMaiorQue(decimal valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQue(double valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQue(float valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQue(long valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQue(int valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQueOuIgual(decimal valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQueOuIgual(double valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQueOuIgual(float valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQueOuIgual(long valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMaiorQueOuIgual(int valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorQue(decimal valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorQue(double valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorQue(float valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorQue(long valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorQue(int valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorOuIgualQue(decimal valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorOuIgualQue(double valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorOuIgualQue(float valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorOuIgualQue(long valor, int comparador, string propriedade, string mensagem)
* VerificarSeEMenorOuIgualQue(int valor, int comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(decimal valor, int comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(double valor, int comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(float valor, int comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(long valor, int comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(int valor, int comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(decimal valor, int comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(double valor, int comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(float valor, int comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(long valor, int comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(int valor, int comparador, string propriedade, string mensagem)
* VerificarSeEstaEntre(int valor, int from, int to, string propriedade, string mensagem)
* VerificarSeNulaOuTipoNullable(int? valor, string propriedade, string mensagem)

#Long

* VerificarSeMaiorQue(decimal valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(double valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(float valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(int valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorQue(long valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(decimal valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(double valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(float valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(int valor, long comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(long valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(decimal valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(double valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(float valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(int valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(long valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(decimal valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(double valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(float valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(int valor, long comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(long valor, long comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(decimal valor, long comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(double valor, long comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(float valor, long comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(int valor, long comparador, string propriedade, string mensagem)
* VerificarSeSaoIguais(long valor, long comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(decimal valor, long comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(double valor, long comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(float valor, long comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(int valor, long comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(long valor, long comparador, string propriedade, string mensagem)
* VerificarSeEstaEntre(long valor, long de, long para, string propriedade, string mensagem)
* VerificarSeNuloOuNullable(long? valor, string propriedade, string mensagem)

#Objetos

* VerificarSeEstaNulo(object objeto, string propriedade, string mensagem)
* VerificarSeNaoEstaNulo(object objeto, string propriedade, string mensagem)
* VerificarSeSaoIguais(object objeto, object comparador, string propriedade, string mensagem)
* VerificarSeNaoSaoIguais(object objeto, object comparador, string propriedade, string mensagem)

#String

* VerificarSeNaoNuloOuVazio(string valor, string propriedade, string mensagem)
* VerificarSeNaoNuloOuEspacoEmBranco(string valor, string propriedade, string mensagem)
* VerificarSeNuloOuVazio(string valor, string propriedade, string mensagem)
* VerificarSeTemTamanhoMinimo(string valor, int minimo, string propriedade, string mensagem)
* VerificarSeTemTamanhoMaximo(string valor, int maximo, string propriedade, string mensagem)
* VerificarTamanho(string valor, int tamanho, string propriedade, string mensagem)
* VerificarSeContem(string valor, string texto, string propriedade, string mensagem)
* VerificarSeSaoIguais(string valor, string text, string propriedade, string mensagem, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
* VerificarSeNaoSaoIguais(string valor, string text, string propriedade, string mensagem, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
* VerificarSeEmailValido(string email, string propriedade, string mensagem)
* VerificarSeEmailInvalidoOuVazio(string email, string propriedade, string mensagem)
* VerificarSeUrl(string url, string propriedade, string mensagem)
* VerificarSeUrlOuVazio(string url, string propriedade, string mensagem)
* VerificarPadrao(string text, string pattern, string propriedade, string mensagem)
* VerificarSeDigito(string texto, string propriedade, string mensagem)
* VerificarTamanhoMinimoSeNaoForNuloOuVazio(string texto, int minimo, string propriedade, string mensagem)
* VerificarTamanhoMaximoSeNaoForNuloOuVazio(string texto, int maximo, string propriedade, string mensagem)
* VerificarTamanhoExatoSeNaoForNuloOuVazio(string texto, int tamanho, string propriedade, string mensagem)

#Timespan

* VerificarSeMaiorQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
* VerificarSeMaiorOuIgualQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
* VerificarSeMenorQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
* VerificarSeMenorOuIgualQue(TimeSpan valor, TimeSpan comparador, string propriedade, string mensagem)
* VerificarSeEstaEntre(TimeSpan valor, TimeSpan de, TimeSpan para, string propriedade, string mensagem)

#CEP
Validações para Ceps com as seguintes máscaras:
24130-110
24130110

* VerificarSeCepValido(string cep,string propriedade ,string mensagem)
* VerificarSeCepVazio(string cep,string propriedade,string mensagem)
* VerificarTamanho(string valor, string propriedade, string mensagem)

#Telefone Celular

Aceita números de telefones somente com DDD com as seguintes máscaras:
(21)99876-2345
(21)999999999

* VerificarSeTelefoneCelularComDDDEValido(string telefoneCelular, string propriedade, string mensagem)

#Telefone Fixo

Aceita números de telefones somente com DDD com as seguintes máscaras:
(21)26257821
(21)2625-7821

* VerificarSeTelefoneFixoComDDDEValido(string telefoneFixo,string propriedade,string mensagem)
* VerificarSeDDDEValido(string telefone,string propriedade,string mensagem)






#Notificações

Modo prático e simples de verificar o que está ocorrendo nas suas classes. Basta Herdar da classe Notificavel e o seu 
modelo já estará apto a gerar notificações.

#Modo de validação de Entidades

A entidade deve herdar de Notificavel

 public class Pessoa:Notificavel
 {
    public string Nome { get; set; }
    public int Idade { get; set; }
 }


 #Specification

 Será implementado futuramente.

#Design By Contract

São usados para retirar a complexidades dos códigos. Usando a classe Contrato podemos especificar que as propriedades
necessitam de validações como Valor miníno e máximo e etc... Caso alguma especificação falhe,será adicionada uma notificação
à sua classe automaticamente.

Ao Herdar da classe Notificavel é obrigatória a implementação do método "Validar". Para usar o Design By Contract,
usar o método "InserirNotificacoes" passando como parâmetro uma instância de Contrato. Como  no exemplo abaixo,
usa-se a "sintax sugar" Requer, e logo após as validações necessárias.

 public  override void Validar()
        {
            InserirNotificacoes(new Contrato()
                .Requer()
                .VerificarSeTemTamanhoMinimo(Nome, 5, "Nome da sua propriedade", "Texto da mensagem")
                .VerificarSeTemTamanhoMaximo(Nome, 10, "Nome da sua propriedade", "Texto da mensagem")
                .VerificarSeNaoNuloOuVazio(Nome, "Nome da sua propriedade", "Texto da mensagem")
                .VerificarSeMaiorQue(Idade, 18, "Nome da sua propriedade", "Texto da mensagem"));
        }

#Fail-Fast-Validations

use o Pattern para verificar se o modelo está Válido quando o dado é recebido, emitindo a falha imediatemente.

A interface IValidavel está inserida na classe Validavel sendo obrigatória a implementação do método Validar()

Para verificar se a classe está está válida e não existe nenhuma notificação,deve-se usar as propriedades "Valido" e "Invalido"

if(pessoa.Invalido)
{
  //existem erros no modelo.
}

#Mostrando as notificações

var pessoa = new Pessoa("User 10","15");

if(pessoa.Invalido)
{
	foreach(var notificacao in pessoa.Notificacoes)
	{
		 Console.WriteLine($"{notificacao.Propriedade} - {notificacao.Mensagem}");
	}
}

#Concatenando as notificações 

Conseguimos herdar a classe Notificavel em qualquer classe que se deseje , incluindo classes aninhadas para agrupar as notificações

class Program : Notificavel
{
    void Main(string[] args)
    {
        var pessoa = new Pessoa("Teste", 10);
        var ordem = new Ordem(pessoa);

        InserirNotificacoes(pessoa, ordem);
        
        if (Invalido)
        {
            foreach (var notificacao in pessoa.Notificacoes)
            {
                Console.WriteLine($"{notificacao.Propriedade} - {notificacao.Mensagem}");
            }
        }
    }
}

#Dependências

.NET Core 2.1 +

#Instalação

O pacote será disponibilizado Pelos site de pacotes do NUGET  https://www.nuget.org/packages/SagerDomainNotification

#Nuget

Install-Package SagerDomainNotification

#.Net CLI

dotnet add package SagerDomainNotification

#Usando Versão Específica

#Nuget

Install-Package SagerDomainNotification -Version x.x.x

#.Net CLI

dotnet add package SagerDomainNotification --version 1.0.0



#Como Usar





