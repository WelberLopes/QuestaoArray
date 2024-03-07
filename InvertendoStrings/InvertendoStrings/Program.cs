using System;
using System.Runtime.InteropServices;

namespace QuetoesEstagio {
    class Program {
        public static void Main(string[] args) {

            string _entradaUser = Console.ReadLine();


            char[] _arr = _entradaUser.ToCharArray();

            int i;
            int _tamanhoArray = _arr.Length;

            for (i = 0; i < _arr.Length; i++) {


                // Console.WriteLine(" {0}: {1}", i, _arr[i]);

               // Console.Write("{0}", _arr[i]);

           }
            
            while (i <= _arr.Length && _tamanhoArray >0) {
                Console.Write(_arr[_tamanhoArray - 1]);

                _tamanhoArray = _tamanhoArray - 1;
            }
            Console.ReadKey();

        }
    }
}
    

