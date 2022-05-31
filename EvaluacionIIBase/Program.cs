using LibreriaEvaluacion.DAL;
using LibreriaEvaluacion.DTO;

const string nombreAlumno = "Rodrigo Gutiérrez";

while (Menu(nombreAlumno))
{
    Console.ReadKey(); // pausa, solicitar la entrada de una tecla
}


static bool Menu(string nombreAlumno)
{ 
    bool continuar = true;

    Console.Clear(); // Limpia la pantalla
    Console.Title = $"Evaluación II: {nombreAlumno}";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("================");
    Console.WriteLine("1) Listar préstamos");
    Console.WriteLine("2) Agregar préstamo");
    Console.WriteLine("3) Actualizar préstamo");
    Console.WriteLine("4) Eliminar préstamo");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");

    string opcion = Console.ReadLine().Trim(); // " 1 " => "1"

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Listado de préstamos registrados");
            OpcionListar();
            break;
        case "2":
            Console.WriteLine("Insertar un nuevo préstamo");
            OpcionInsertar();
            break;
        case "3":
            Console.WriteLine("Actualizar un préstamo existente");
            OpcionActualizar();
            break;
        case "4":
            Console.WriteLine("Eliminar un préstamo existente");
            OpcionEliminar();
            break;
        case "0":
            Console.WriteLine("Saliendo del programa ...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    return continuar;
}

// ToDo: lógica de GUI

static void OpcionEliminar()
{
    PrestamoDAL prestamoDAL = new PrestamoDAL();

    Console.WriteLine("Ingrese el ID del prestamo que desea eliminar:");
    int id = int.Parse(Console.ReadLine().Trim());

    bool resultadoEliminacion = prestamoDAL.Eliminar(id);

    if (resultadoEliminacion)
    {
        Console.WriteLine("Se ha eliminado el prestamo");
    }
    else
    {
        Console.WriteLine("no se ha eliminado el prestamo debido a que está mal ingresado el id o no existe");
    }

    Console.ReadKey();
}

static bool OpcionActualizar()
{
    throw new NotImplementedException();
}

static void OpcionInsertar()
{
    PrestamoDAL prestamoDal = new PrestamoDAL();
    try
    {
        Console.WriteLine("Ingrese el ID del prestamo:");
        int id = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Ingrese Monto Prestado:");
        int monto = int.Parse(Console.ReadLine().Trim());

        

        PrestamoDTO nuevoPrestamo = new PrestamoDTO()
        {
            Id = id,
            Monto = monto,
                       
        };
        
        bool resultadoInsertar = prestamoDal.Insertar(nuevoPrestamo);

        if (resultadoInsertar)
        {
            Console.WriteLine($"Se ha registrado el prestamo del id n° {id}");
        }
        else
        {
            Console.WriteLine($"Hubo un error al ingresar el prestamo del id n° {id}");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"datos erroneos, por favor completar con los datos pedidos");
    }

    Console.ReadKey();
}


static void OpcionListar()
{
    PrestamoDAL prestamoDAL = new PrestamoDAL();
    List<PrestamoDTO> datosLista = prestamoDAL.Listar();

    foreach (PrestamoDTO dato in datosLista)
    {
        Console.WriteLine(dato.ToString());
    }

    Console.ReadKey();

}

