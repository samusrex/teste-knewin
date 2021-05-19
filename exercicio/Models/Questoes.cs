using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio.Models
{
    public class Questoes
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

               
        public int primeiro_indice_encontrado_duplicado {get; set;}

        public bool isPalindrome { get; set;}


        public bool ReconhecerPalindrome (string alpha){

            string reverse = "";
            isPalindrome = false;

            int length = alpha.Length;

            for(int i = length -1; i>=0 ; i--){

                reverse = reverse + alpha.ElementAt(i);
                
                Console.WriteLine(reverse);

                if(alpha.Equals(reverse)){
                    isPalindrome = true;
                }
                else{
                    isPalindrome = false;
                }

            }  

            return isPalindrome;
        }

        public int ReconhecerDuplicadosLista( List <int> dados ){

          
            

            dados.Sort();

            for(int i = 0 ; i < dados.Count() ;  i++){

                int atual = dados[i];
                int prox = dados[i+1];

                if(atual==prox){

                    primeiro_indice_encontrado_duplicado = atual;
                    break;
                }
                
            }



            return primeiro_indice_encontrado_duplicado;

        }
    }
}
