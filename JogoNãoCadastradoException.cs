using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoDeJogos11.Exceptions
{
    public class JogoNãoCadastradoException : Exception
    {
        public JogoNãoCadastradoException()
            :base("Este jogo não está cadastrado")
        { }
    }
}
