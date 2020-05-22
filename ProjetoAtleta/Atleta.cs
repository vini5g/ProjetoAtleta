using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;

        public string Nome 
        { 
            set 
            { 
                if (value.Trim() != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("o campo 'nome' não foi preenchido!");
                }
            }

            get
            {
                return this.nome;
            }
        }
        public double Altura 
        {
            set
            {
                if (value < 1)
                {
                    throw new Exception("A altura precisa ser um número maior que 0");
                }
                else 
                {
                    this.altura = value;
                }
            }

            get
            {
               return this.altura;
            }
        }
        public double Peso 
        {
            set
            {
                if (value < 1)
                {
                    throw new Exception("O peso precisa ser um número maior que 0");
                }
                else
                {
                    this.peso = value;
                }         
            }
            get
            {
                return this.peso;
            }
        }
        public int Idade 
        {
            set
            {
                if (value < 1)
                {
                    throw new Exception("A idade precisa ser um número maior que 0");
                }
                else
                {
                    this.idade = value;
                }
            }
            get
            {
                return this.idade;
            }
        }

        public double CalculaIMC()
        {
            double imc = this.Peso/(Math.Pow(this.Altura, 2));

            return imc;
        }
    }
}
