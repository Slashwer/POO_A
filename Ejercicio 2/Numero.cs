class Numero{
    public int NUM;
    public void NumeroPar(){
        Console.WriteLine("Ingrese un numero");
        NUM=Convert.ToInt16(Console.ReadLine());
        if(NUM % 2 == 0){
            Console.WriteLine("El numero "+NUM+" es par");
        }else{
            Console.WriteLine("El numero "+NUM+" es impar");}
    }
}