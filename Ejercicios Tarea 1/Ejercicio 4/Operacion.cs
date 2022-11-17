class Operacion{
    public int NUM1;
    public void Numeros(){
        do{
        Console.WriteLine("Ingrese numeros");
        NUM1=Convert.ToInt16(Console.ReadLine());
        }while(NUM1!=0);
        Console.WriteLine("Terminado");
    }
}