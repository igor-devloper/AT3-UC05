using System;
using System.Collections.Generic;

namespace AT3_UC05.Models
{
  public class Agendamento
  {
    private List<ItemAgendamento> listaDeAgendamento;
    public Agendamento(){
      listaDeAgendamento = new List<ItemAgendamento>();
    }
    public void AddAgendamento(ItemAgendamento Ag)
    {
        listaDeAgendamento.Add(Ag);
    }

    public List<ItemAgendamento> InfosDoAgendamento()
    {
      return listaDeAgendamento;
    }
   
  }

}