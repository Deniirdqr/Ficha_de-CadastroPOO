using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discurssiva
{
    internal class Identificacao : Jovem
    {//Declarando list 
        static List<Identificacao> identificacaos = new List<Identificacao>();

        static int MaxId = 0;
        protected int _Cpf;

        //Construtores
        public Identificacao()
        {
            _Cpf = 0;
        }
        public Identificacao(int id, string nome, int cpf, int idade, Sexo sexo,
            Trabalha trabalha)
            : base(id, nome, idade, sexo, trabalha)
        {
            _Cpf = cpf;
        }
        public Identificacao(string nome, int cpf, int idade, Sexo sexo,
            Trabalha trabalha)
            : base(nome, idade, sexo, trabalha)
        {
            _Cpf = cpf;
        }
        public Identificacao(int cpf)
        {
            Identificacao tc = identificacaos.Find(c => c.Cpf == cpf);
            _Id = tc.Id;
            _Nome = tc.Nome;
            _Cpf = tc.Cpf;
            _Idade = tc.Idade;
            _Sexo = tc.SexO;
            _Trabalha = tc.Trabalho;
        }

        // get e set do CPF
        public int Cpf
        {
            set { _Cpf = Cpf; }
            get { return _Cpf; }
        }

        //Metodos
        public void Incluir()
        {
            MaxId++;
            _Id = MaxId;
            identificacaos.Add(this);
        }
        public static List<Identificacao> Consultar()
        {
            return identificacaos;
        }
        public static List<Identificacao> Consultar(int cpf)
        {
            return identificacaos.FindAll(i => i.Cpf == cpf);
        }
        public void Alterar()
        {
            int i;
            i = identificacaos.FindIndex(c => c.Id == _Id);
            identificacaos[i].Cpf = _Cpf;
            identificacaos[i].Nome = _Nome;
            identificacaos[i].Idade = _Idade;
            identificacaos[i].SexO = _Sexo;
            identificacaos[i].Trabalho = _Trabalha;

        }
        public static void Excluir(int cpf)
        {
            int i;
            i = identificacaos.FindIndex(c => c.Cpf == cpf);
            identificacaos.Remove(identificacaos[i]);

        }

        public static void Preencher()
        {
            Identificacao c;
            c = new Identificacao("Denior", 1231, 30, Sexo.Masculino, Trabalha.Empregado);
            c.Incluir();
            c = new Identificacao("Vanessa", 1232, 31, Sexo.Feminino, Trabalha.Empregado);
            c.Incluir();
            c = new Identificacao("Bella", 1233, 20, Sexo.Feminino, Trabalha.Desempregado);
            c.Incluir();
            c = new Identificacao("Diego", 1234, 18, Sexo.Masculino, Trabalha.Empregado);
            c.Incluir();
            c = new Identificacao("Bruna", 1235, 25, Sexo.Feminino, Trabalha.Desempregado);
            c.Incluir();
            c = new Identificacao("Julia", 1236, 35, Sexo.Feminino, Trabalha.Desempregado);
            c.Incluir();
            c = new Identificacao("Deivid", 1237, 23, Sexo.Masculino, Trabalha.Empregado);
            c.Incluir();
            c = new Identificacao("Marcelo", 1238, 19, Sexo.Masculino, Trabalha.Empregado);
            c.Incluir();
            c = new Identificacao("Magela", 1239, 34, Sexo.Feminino, Trabalha.Desempregado);
            c.Incluir();
            c = new Identificacao("Tabata", 1230, 21, Sexo.Feminino, Trabalha.Desempregado);
            c.Incluir();
        }
    }
}
