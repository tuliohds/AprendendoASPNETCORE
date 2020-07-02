using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models.Contextos
{
    public class DbInitializer
    {
        public static void Initialize(Contexto contexto)
        {
            contexto.Database.EnsureCreated();
            if (contexto.Perguntas.Any())
            {
                return;
            }
            else 
            {
                InsertData(contexto);
            }
            
        }

        private static void InsertData(Contexto context)
        {
            Pergunta pergunta1 = new Pergunta() { Descricao = "Qual sua tecnologia preferida?" };
            Pergunta pergunta2 = new Pergunta() { Descricao = "Qual tipo de tecnologia é mais importante pra você?" };
            Pergunta pergunta3 = new Pergunta() { Descricao = "Como você prefere passar seu tempo" };

            Profissao prof = new Profissao() { Nome = "Dev" };

            Resposta resp1Perg1 = new Resposta()
            {
                Descricao = "PHP",
                Pergunta = pergunta1,
                Profissao = prof
            };
            Resposta resp2Perg1 = new Resposta()
            {
                Descricao = "C#",
                Pergunta = pergunta1,
                Profissao = prof
            };

            pergunta2.Resposta = new List<Resposta>()
            {
                new Resposta() { Descricao = "Machine Learning",Profissao = prof },
                new Resposta() { Descricao = "Realidade Aumentada",Profissao = prof }
            };

            context.Perguntas.AddRange(pergunta1, pergunta2, pergunta3);
            context.Respostas.AddRange(resp1Perg1, resp2Perg1);

            context.SaveChanges();
        }
    }
}
