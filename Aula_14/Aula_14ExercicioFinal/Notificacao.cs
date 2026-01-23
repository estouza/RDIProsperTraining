using System;

public class Notificacao
{
	public string Assunto {  get; set; }
	public string Destinatario { get; set; }
	public string Mensagem { get; set; }	
	
	public Notificacao(string assunto, string destinatario, string mensagem)
	{
		Assunto = assunto;
		Destinatario = destinatario;
		Mensagem = mensagem;
	}
	public void Enviar()
	{
		Console.WriteLine($"A notificação \"{Assunto}\" com a mensagem  \"{Mensagem}\" foi enviada para {Destinatario}.");
    }
	
}
