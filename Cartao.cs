using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        private string token = "aslkdfnakdvbnaskjdfnkasjdcvshabdci98232iubva9s8dgv87afbkjsbv";
        protected string cvv { get; set; }

        public void AprovarCompra(){
            Console.WriteLine("Compra aprovada!");
        }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }return false;

        }
        protected bool ValidarCompra(){
            return true;
        }
    }
}