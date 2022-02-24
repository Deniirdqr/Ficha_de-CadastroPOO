using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discurssiva
{
    class Jovem
    {// criando variaveis
        public enum Sexo { vazio , Masculino, Feminino }
        public enum Trabalha { vazio,  Empregado, Desempregado }

        protected int _Id;
        protected string _Nome;
        protected int _Idade;
        protected Sexo _Sexo;
        protected Trabalha _Trabalha;

        //Construtores
        public Jovem()
        {
            _Id = 0;
            _Nome = "";
            _Idade = 0;
            _Sexo = Sexo.Feminino;
            _Trabalha = Trabalha.Empregado;
        }
        public Jovem(int id, string nome, int idade, Sexo sexo, Trabalha trabalha)
        {
            _Id = id;
            _Nome = nome;
            _Idade = idade;
            _Sexo = sexo;
            _Trabalha = trabalha;
        }
        public Jovem(string nome, int idade, Sexo sexo, Trabalha trabalha)
        {
            _Id = 0;
            _Nome = nome;
            _Idade = idade;
            _Sexo = sexo;
            _Trabalha = trabalha;
        }      

        // get e set
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public string Nome
        {
            set { _Nome = value; }
            get { return _Nome; }
        }
        public int Idade
        {
            set { _Idade = value; }
            get { return _Idade; }
        }
        public Sexo SexO
        {
            set { _Sexo = value; }
            get { return _Sexo; }
        }
        public Trabalha Trabalho
        {
            set { _Trabalha = value; }
            get { return _Trabalha; }
        }
      
    }
}
