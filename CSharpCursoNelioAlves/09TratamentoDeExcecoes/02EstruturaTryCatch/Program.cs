using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._09TratamentoDeExcecoes._02EstruturaTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====Bloco try=====
                    *Contém o código que representa a execução normal do trexo de código que pode acarretar em 
                    uma exceção    

                =====Bloco catch=====
                    *Contém o código a ser executado caso uma exceção ocorra
                    *Deve ser especificado o tipo da exceção a ser tratada(ipcasting é permitido)
             */

            try //tenta executar, se acontecer alguma exceção (ex:divir 10/0), ela será capturada pelo bloco catch
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            } catch (DivideByZeroException e) {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException e) { //int.Parse(CR) recebe uma letra
                Console.WriteLine("Format error!" + e.Message);
            }
        }
    }
}
