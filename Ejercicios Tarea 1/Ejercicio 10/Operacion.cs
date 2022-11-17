class Operacion{
    public int NUM;
    public int FACTORIAL=1;
    public void FactorialDeNumero(){
        Console.WriteLine("Ingrese un numero");
        NUM = Convert.ToInt16(Console.ReadLine());
        for(int cont=2;cont<=NUM;cont++){
            FACTORIAL=FACTORIAL*cont;
        }
        Console.WriteLine("Factorial: "+FACTORIAL);
    }
}