﻿using Model.Enum;

namespace Model.QueryModel
{
    public class ObterUsuarioFuncionario
    {
        public int IdUsuario { get; set; }
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
        public SenhaTemporaria SenhaTemporaria { get; set; }
        public EntidadeAtiva Ativo { get; set; }

    }
}
