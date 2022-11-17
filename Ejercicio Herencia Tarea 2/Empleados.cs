class Empleados:Persona{
    public int AñoIngresoF{get;set;}
    public int NumeroD{get;set;}
    public Empleados(String Nombre,String Apellidos,int Identificacion,string EstadoCivil,int AñoIngresoF,int NumeroD):base(Nombre,Apellidos,Identificacion,EstadoCivil){
        this.AñoIngresoF=AñoIngresoF;
        this.NumeroD=NumeroD;
    }

    public void ReasignarDespacho(){
        Console.WriteLine("Ingrese nuevo despacho");
        NumeroD=Convert.ToInt16(Console.ReadLine());
    }

    public override void ImprimirDatos(){
        Console.WriteLine("Datos Empleado");
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Apellidos: "+Apellidos);
        Console.WriteLine("Identificacion: "+Identificacion);
        Console.WriteLine("Estado civil: "+EstadoCivil);
        Console.WriteLine("Año de ingreso: "+AñoIngresoF);
        Console.WriteLine("Numero de despacho: "+NumeroD);
    }
}