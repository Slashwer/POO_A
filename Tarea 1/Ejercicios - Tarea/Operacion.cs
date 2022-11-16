class Operacion{
    public void NumeroMayor(){
        int NUM1, NUM2;
        Console.WriteLine("Ingrese un numero");
        NUM1=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        NUM2=Convert.ToInt16(Console.ReadLine());
        if(NUM1>NUM2){
            Console.WriteLine("Numero mayor: "+NUM1);
        }else{
            Console.WriteLine("Numero mayor: "+NUM2);;
        }
    }
}