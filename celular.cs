namespace AulaPOOcelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado; 
        public string ligar(){
            ligado = true;
            return "celular ligando";
        }
        public string desligar(){
            ligado = false;
            return "o celular esta desligando";
        }
        public string FazerLigacao(){
            return "Realizando Ligação";
        }
        public string EnviarMensagem(){
            return "Enviando mensagem";
        }
        public string Reiniciar(){
            return "o celular esta reiniciando";
        }

    
    }


    
}