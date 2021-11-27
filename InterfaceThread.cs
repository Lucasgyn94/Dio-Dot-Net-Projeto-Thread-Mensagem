using System.Collections.Generic;
using System.Linq;
using System;

namespace ThreadConversa
{
    public interface interfaceThread // Uma interface contém definições para um grupo de funcionalidades relacionadas que um não abstrato class ou um struct deve implementar.
    {
        public void SincronizaThread();
        public IEnumerable<Mensagem> AdicionaMensagem (Mensagem mensagem);
        public IEnumerable<Mensagem> AdicionaMensagens (IEnumerable<Mensagem> mensagens);
        public string MostraThread();
        public void RemoveMensagem (string id);

    }
}