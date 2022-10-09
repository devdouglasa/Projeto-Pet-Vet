namespace pet_vet.Models
{
    public class Dados
    {
        public static Agendamento AgendamentoAtual = new Agendamento();

        public static void Inserir(Agendamento agenda)
        {
            AgendamentoAtual.nome = agenda.nome;
            AgendamentoAtual.data = agenda.data;
            AgendamentoAtual.contato = agenda.contato;
            AgendamentoAtual.animal = agenda.animal;
            AgendamentoAtual.necessidade = agenda.necessidade;
        }

        public static Agendamento Listar()
        {
            return AgendamentoAtual;
        }
    }
}
