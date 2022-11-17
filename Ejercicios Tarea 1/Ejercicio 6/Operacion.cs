class Operacion{
    public int NUM1;
    public int TOTAL;
    public void Numeros(){
        int cont=0;
        do{
        cont++;
        Console.WriteLine("Ingrese numero "+cont);
        NUM1=Convert.ToInt16(Console.ReadLine());
        TOTAL=TOTAL+NUM1;
        }while(NUM1!=0);
        Console.WriteLine("Suma total de numeros "+TOTAL);
    }
}