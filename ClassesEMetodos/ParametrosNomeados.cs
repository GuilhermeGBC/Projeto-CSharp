using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("A data é: {0:D2}/{1:D2}/{2}", dia, mes, ano); // D:10 coloca 0 a esquerda para completar o tamanho exato de números,
                                                                   // D2 significa que o numero for apenas com 1 digito, ele vai colocar um 0 antes para que fique com 2 digitos.
        }
        
        public static void Executar() {
            Formatar(mes: 1, dia: 6, ano: 2021); // Chamamos os parâmetros nomeados da forma (mês, dia e ano), invertemos a ordem de como foi passado nos parâmetros
            Formatar(mes:7,dia: 4,ano: 2002); //É bom sempre escrever um pouco mais para deixar o código mais claro de se entender.
            Formatar(mes: 10,dia: 7, ano: 2002);
        }
    }
}
