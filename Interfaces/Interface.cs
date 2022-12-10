using concilig.Models;
using System.Collections.Generic;

namespace concilig.Interfaces
{
    public interface IAtividade
    {
        List<Atividade> List();

        Atividade Participants(int Participantes);

    }
}
