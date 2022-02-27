
/****
Classes estáticas não precisam ser instanciadas.
No ASP.NET Core MVC, classes estáticas vivem do início 
ao fim da execução do programa.
Por isso, Dados deve ser usado para manipular as informações
dos pedidos.
Exemplos de uso:
Dados.PedidoAtual.PropriedadeDePedido = "Algum Valor";
Dados.PedidoAtual.MetodoDePedido();
*****/
using AT3_UC05.Models;

namespace MVC.models{
  public static class Dados{
   public static Agendamento AgendamentodoAtual { get; set;}
   static Dados()
   {
       AgendamentodoAtual = new Agendamento();
   }
}
}
