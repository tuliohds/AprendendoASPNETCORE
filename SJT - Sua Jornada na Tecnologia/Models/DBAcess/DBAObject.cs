using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models.DBAcess
{
    public class DBAObject
    {
        private readonly Contexto contexto;

        public DBAObject(Contexto _contexto)
        {
            contexto = _contexto;
        }

        public IEnumerable<Pergunta> ListarPerguntas()
        {
            return contexto.Perguntas;
        }

        public IEnumerable<Resposta> ListarRespostas()
        {
            return contexto.Respostas;
        }

        public IEnumerable<Resposta> ListarRespostas(int perguntaId)
        {
            return contexto.Respostas.Where(r => r.PerguntaId == perguntaId);
        }

        public IEnumerable<Jornada> ListarJornada(int usuarioId)
        {
            return contexto.Jornadas.Where(j => j.UsuarioId == usuarioId);
        }

        public async Task<Usuario> ProcurarUsuario(string usuarioNome)
        {
            return await contexto.Usuarios.SingleOrDefaultAsync(u => u.Nome.Trim().ToLower() == usuarioNome.Trim().ToLower());
        }

        public IEnumerable<Profissao> ListarProfissoes()
        {
            return contexto.Profissoes;
        }
    }
}
