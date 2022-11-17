class Estudiantes:Persona{
    public string? Curso;
    public Estudiantes(String Nombre, String Apellidos,int Identificacion,string EstadoCivil,string Curso):base(Nombre,Apellidos,Identificacion,EstadoCivil){
        this.Curso=Curso;
    }
    public void MatricularNuevoCurso(){
            Console.WriteLine("Ingrese nuevo curso");
            Curso=Console.ReadLine();
    }
    public override void ImprimirDatos(){
        Console.WriteLine("Datos Estudiante");
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Apellidos: "+Apellidos);
        Console.WriteLine("Identificacion: "+Identificacion);
        Console.WriteLine("Estado civil: "+EstadoCivil);
        Console.WriteLine("Curso: "+Curso);
    }
}