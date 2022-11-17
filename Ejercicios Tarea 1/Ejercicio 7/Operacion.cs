class Operacion{
    public double LADO1;
    public double LADO2;
    public double LADO3;
    public char Opcion;
    public void TipoDeTriangulo()
    {
        do{
        Console.WriteLine("Ingrese 1 lado");
        LADO1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese 2 lado");
        LADO2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese 3 lado");
        LADO3=Convert.ToDouble(Console.ReadLine());
        if(LADO1==LADO2 && LADO2==LADO3)
			{
			Console.WriteLine("Triangulo Equilatero");
		}else{
		if(LADO1==LADO2 || LADO1==LADO3 || LADO2==LADO3)
		{
		Console.WriteLine("Triangulo Isoseles");
		}else{
            if(LADO1!=LADO2 || LADO1!=LADO3 || LADO3!=LADO2)
		    Console.WriteLine("Triangulo Escaleno");}
        }
        Console.WriteLine("¿Desea continuar? s/n");
            Opcion = Convert.ToChar(Console.ReadLine());
        }while(Opcion!='n');
    }
}