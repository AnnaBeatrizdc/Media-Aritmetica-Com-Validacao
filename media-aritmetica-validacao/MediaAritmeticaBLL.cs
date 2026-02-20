using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_aritmetica_validacao
{
    class MediaAritmeticaBLL
    {
        public static void validaDados(MediaAritmetica nota)
        {
            Erro.setErro(false);
            if (nota.getN1().Length == 0)
            {
                Erro.setErro("O campo Nota 1 é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(nota.getN1());
                }
                catch
                {
                    Erro.setErro("O campo Nota 1 deve ser numérico...");
                    return;
                }
                if (float.Parse(nota.getN1()) <= 0)
                {
                    Erro.setErro("O campo Nota 1 deve ser maior que zero.");
                    return;
                }
            }

            if (nota.getN2().Length == 0)
            {
                Erro.setErro("O campo Nota 2 é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(nota.getN2());
                }
                catch
                {
                    Erro.setErro("O campo Nota 2 deve ser numérico...");
                    return;
                }
                if (float.Parse(nota.getN2()) <= 0)
                {
                    Erro.setErro("O campo Nota 2 deve ser maior que zero.");
                    return;
                }
            }

            if (nota.getN3().Length == 0)
            {
                Erro.setErro("O campo Nota 3 é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(nota.getN3());
                }
                catch
                {
                    Erro.setErro("O campo Nota 3 deve ser numérico...");
                    return;
                }
                if (float.Parse(nota.getN3()) <= 0)
                {
                    Erro.setErro("O campo Nota 3 deve ser maior que zero.");
                    return;
                }
            }

            if (nota.getN4().Length == 0)
            {
                Erro.setErro("O campo Nota 4 é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(nota.getN4());
                }
                catch
                {
                    Erro.setErro("O campo Nota 4 deve ser numérico...");
                    return;
                }
                if (float.Parse(nota.getN4()) <= 0)
                {
                    Erro.setErro("O campo Nota 4 deve ser maior que zero.");
                    return;
                }
            }
        }
    }
}
