class Numeros{
    public int Num;
    public void LeerNumeros(){
        int b=0;
        double Total=0.0;
        Console.WriteLine("Ingrese numeros");
        do{
        Num = Convert.ToInt16(Console.ReadLine());
        Total=Total+Num;b++;
        }while(Num!=0);
        Console.WriteLine("Media aritmetica;");
        Console.WriteLine(Total/(b-1));
    }
}