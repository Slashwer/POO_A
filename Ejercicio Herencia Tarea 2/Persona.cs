class Persona{
    public string Nombre{get;set;}
    public string Apellidos{get;set;}
    public int Identificacion{get;set;}
    public string? EstadoCivil{get;set;}
    public Persona(string Nombre, string Apellidos, int Identificacion, string EstadoCivil){
        this.Nombre=Nombre;
        this.Apellidos=Apellidos;
        this.Identificacion=Identificacion;
        this.EstadoCivil=EstadoCivil;
    }
    public virtual void CambiarEstadoCivil()
    {
        Console.WriteLine("Ingrese nuevo estado civil");
        EstadoCivil=Console.ReadLine();
    }
    public virtual void ImprimirDatos(){
        Console.WriteLine("Datos Persona");
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Apellidos: "+Apellidos);
        Console.WriteLine("Identificacion: "+Identificacion);
        Console.WriteLine("Estado civil: "+EstadoCivil);
    }

}