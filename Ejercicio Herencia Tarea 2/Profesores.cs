class Profesores:Persona{
     public string? Departamento;
     public Profesores(String Nombre, String Apellidos,int Identificacion,string EstadoCivil,string Departamento):base(Nombre,Apellidos,Identificacion,EstadoCivil){
        this.Departamento=Departamento;
     }
     public void CambioDepartamento(){
            Console.WriteLine("Ingrese nuevo departamento");
            Departamento=Console.ReadLine();
    }
    public override void ImprimirDatos(){
        Console.WriteLine("Datos Profesor");
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Apellidos: "+Apellidos);
        Console.WriteLine("Identificacion: "+Identificacion);
        Console.WriteLine("Estado civil: "+EstadoCivil);
        Console.WriteLine("Departamento: "+Departamento);
    }

}