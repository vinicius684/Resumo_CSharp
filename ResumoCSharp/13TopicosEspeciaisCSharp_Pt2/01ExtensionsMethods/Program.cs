
namespace CSharp._13TopicosEspeciaisCSharp_Pt2._01ExtensionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             =====Extension methods=====
                -São métodos que estedem a funcionalidade de um tipo, sem precisar alterar o código fonte deste tipo, nem 
                herdar desse tipo
                
                -Como fazer um extension method?
                    -Criar uma classe estática
                    -Na classe, cria r um método estático
                    -O primeiro parâmetro deverá ter o prefixo this,s eguido da declaração de um parâmetro do tipo que se 
                    deseja estender. Esta será uma referência para o próprio objetos

                -Obs: s1. chave de de fenda(propriedade), cubo(metodos comuns), cubo com seta pra baixo(extensions metods)
             */

            /*
                Demonstração 1 
                    criar um extension method chamado "ElapsedTime()" no struct DateTime para apresentar um objeto DateTime na 
                    forma de tempo decorrido, podendo ser em horas (se menor que 24h) ou em dias caso contrário. Por exemplo:
             */

            DateTime dt = new DateTime(2023, 11, 14, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            /*
                Demonstrção 2
                     Vamos criar um extension method chamado "Cut(int)" na classe String para receber um valor inteiro como parâmetro e 
                     gerar um recorte do string original daquele tamanho. Por exemplo:
             */

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
