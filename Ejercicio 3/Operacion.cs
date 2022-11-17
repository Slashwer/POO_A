class Operacion{
    public int NUM1;
    public int NUM2;
    public int NUM3;
    public void NumeroMayor(){
        Console.WriteLine("Ingrese TRES numeros");
        NUM1=Convert.ToInt16(Console.ReadLine());
        NUM2=Convert.ToInt16(Console.ReadLine());
        NUM3=Convert.ToInt16(Console.ReadLine());
        if(NUM1>NUM2 && NUM1>NUM3){
            Console.WriteLine("Numero mayor: "+NUM1);
        }else
         if(NUM2>NUM1 && NUM2>NUM3){
            Console.WriteLine("Numero mayor: "+NUM2);
        }else{
            Console.WriteLine("Numero mayor: "+NUM3);
        }
    }
}