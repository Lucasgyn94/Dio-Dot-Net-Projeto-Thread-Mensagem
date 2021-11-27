using System.Runtime.Serialization;
using System;

namespace ThreadConversa
{
    public class Identidade
    {
        // [DataMember()] = Quando aplicado ao membro de um tipo, especifica que o membro faz parte de um contrato de dados e pode ser serializado.
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        public Identidade (string nome)
        {
            this.Nome = nome;
            this.Id = Guid.NewGuid().ToString(); // Guid.NewGuid = Inicializa uma nova instância da estrutura Guid.
        }
    }
}