using System;

namespace ThreadConversa
{
    public class Texto : Mensagem
    {
        public new string Conteudo { get; set; }

        // A palavra-chave base é usada para acessar membros de classe base de dentro de uma classe derivada; 
        // Um acesso de classe base é permitido somente em um construtor, em um método de instância ou em um acessador de propriedade de instância.
        public Texto (string id, string conteudo, DateTime datahora, Identidade emissor) : base(id, conteudo, datahora, emissor)
        {

        }
        
    }
}