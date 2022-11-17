class PersonalServicio:Persona{
    public string? Asignacion;
    public PersonalServicio(String Nombre, String Apellidos,int Identificacion,string EstadoCivil,string Asignacion):base(Nombre,Apellidos,Identificacion,EstadoCivil){
        this.Asignacion=Asignacion;
     }
     public void Translado(){
            Console.WriteLine("Ingrese nuevo traslado de seccion");
            Asignacion=Console.ReadLine();
    }

     public override void ImprimirDatos(){
        Console.WriteLine("Datos Personal de servicio");
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Apellidos: "+Apellidos);
        Console.WriteLine("Identificacion: "+Identificacion);
        Console.WriteLine("Estado civil: "+EstadoCivil);
        Console.WriteLine("Asignacion: "+Asignacion);
    }
}