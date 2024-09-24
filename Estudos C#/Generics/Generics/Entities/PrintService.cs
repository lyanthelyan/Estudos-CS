
namespace Generics.Entities
{
    internal class PrintService<T>//O TIPO É ESCOLHIDO NO PROGRAMA PRINCIPAl, Usando Generics, se eu quisesse que o programa PrintService usasse int, e depois mudasse para string eu teria que mudar o codigo todo
       //Mas usando generics, mudando o tipo para o tipo T, posso usar tanto string, int, double, sem mudar o coidog todo
    {
       private  T[] _values = new T[10];
        private int _count = 0;

        //Também podemos transformar apenas o método em genérico, sem mudar a classe toda
        // public T AddValue<T>(T value) {}
        public void AddValue(T value)
        {
            if (_count == 10){ throw new InvalidOperationException("PrintService is Full"); }
            _values[_count] = value;
            _count++;

        }

        public T First()
        {
            if (_count == 0) { throw new InvalidOperationException("PrintService is Empty"); }
            return _values[0];
        }
        public T Last()
        {
            if (_count == 0) { throw new InvalidOperationException("PrintService is Empty"); }
            return _values[_count-1];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i]+", ");
            }
            if(_count>0){ Console.Write(_values[_count-1]); }//Ultima posição do vetor, usando count-1'
            Console.WriteLine("]");
        }
    }
}
