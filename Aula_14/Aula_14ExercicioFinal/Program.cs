using System;
using System.Collections.Generic;

NotificacaoService service = new NotificacaoService();

// enviar uma única notificação
Notificacao n1 = new Notificacao("Aviso", "Ester", "Você foi contratada pela RDI!.");
NotificacaoService.Enviar(n1);

Console.WriteLine("-----");

// enviar uma lista de notificações
List<Notificacao> lista = new List<Notificacao>
{
    new Notificacao("Surpresa", "Ester", "Você ganhou 1 milhão!"),
    new Notificacao("Lembrete", "Ester", "Fazer os exercícios!")
};

service.Enviar(lista);
