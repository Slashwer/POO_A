internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------------------------------------------------------------------");
        Persona Marco = new Persona("Marco","Gutierrez",3434,"Casado");
        Marco.ImprimirDatos();
        Console.WriteLine("------------------------------------------------------------------------");
        Empleados Jorge = new Empleados("Jorge","Diaz",4544,"Casado",1999,29);
        Jorge.ImprimirDatos();
        Console.WriteLine("------------------------------------------------------------------------");
        Estudiantes Jostyn = new Estudiantes("Jostyn","Muentes",4456,"Casado","Sistemas operativos");
        Jostyn.ImprimirDatos();
        Console.WriteLine("------------------------------------------------------------------------");
        Profesores Julio = new Profesores("Julio","Romero",5478,"Soltero","Quimica");
        Julio.ImprimirDatos();
        Console.WriteLine("------------------------------------------------------------------------");
        PersonalServicio Antonio = new PersonalServicio("Antonio","Balle",2345,"Casado","Limpieza");
        Antonio.ImprimirDatos();
        Console.WriteLine("------------------------------------------------------------------------");
        int opcion=0;
        do{
            Console.WriteLine("Elija una opcion \n"
            + "1. Cambiar estado civil de una persona \n"
            + "2. Reasignar despacho a un empleado \n"
            + "3. Matricular a un estudiante a un nuevo curso \n"
            + "4. Traslado de seccion de un empleado del personal del servicio \n"
            + "5. Imprimir datos actualizados \n"
            + "6. Salir");
            opcion=Convert.ToInt16(Console.ReadLine());
        switch(opcion){
            case 1:
            Console.WriteLine("------------------------------------------------------------------------");
            Marco.CambiarEstadoCivil();
            Console.WriteLine("------------------------------------------------------------------------");
            break;
            case 2:
            Console.WriteLine("------------------------------------------------------------------------");
            Jorge.ReasignarDespacho();
            Console.WriteLine("------------------------------------------------------------------------");
            break;
            case 3:
            Console.WriteLine("------------------------------------------------------------------------");
            Jostyn.MatricularNuevoCurso();
            Console.WriteLine("------------------------------------------------------------------------");
            break;
            case 4:
            Console.WriteLine("------------------------------------------------------------------------");
            Antonio.Translado();
            Console.WriteLine("------------------------------------------------------------------------");
            break;
            case 5:
            Console.WriteLine("------------------------------------------------------------------------");
            Marco.ImprimirDatos();
            Console.WriteLine("------------------------------------------------------------------------");
            Jorge.ImprimirDatos();
            Console.WriteLine("------------------------------------------------------------------------");
            Jostyn.ImprimirDatos();
            Console.WriteLine("------------------------------------------------------------------------");
            Julio.ImprimirDatos();
            Console.WriteLine("------------------------------------------------------------------------");
            Antonio.ImprimirDatos();
            Console.WriteLine("------------------------------------------------------------------------");
            break;
            default:
            break;
        }
        }while(opcion!=6);
    }
}