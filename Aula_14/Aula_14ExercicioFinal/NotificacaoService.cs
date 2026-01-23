using System;
using System.Collections.Generic;

public class NotificacaoService 
 // faz sentido que seja estática porque ela está apenas oferecendo serviços, sem manter estado
{
    public static void Enviar(Notificacao notificacao)
    {
        notificacao.Enviar();
    }

    public void Enviar(List<Notificacao> notificacoes)
    {
        Console.WriteLine("Enviando uma lista de notificações...");
        foreach (Notificacao n in notificacoes)
        {
            n.Enviar();
        }
    }
}
