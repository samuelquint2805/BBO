using Employee;
using Time;

Employ emp1 = new fulltimeemployee
{
    id = 1,
    fullName = "Juan Perez",
    Document = 123456,
    role = "Desarrollador",
    Birthday = new Getime(1990, 5, 15),//new Mydate(datos)
    salary = 3000000

};
Employ emp2 = new halftimeEmployee
{
    id = 2,
    fullName = "Maria Gomez",
    Document = 654321,
    role = "Diseñadora",
    Birthday = new Getime(1992, 8, 22),//new Mydate(datos)
    hourValue = 50000,
    workedHours = 80
};
Employ emp3 = new ComissionEmployee
{
    id = 3,
    fullName = "Carlos Lopez",
    Document = 789012,
    role = "Vendedor",
    Birthday = new Getime(1988, 3, 10),//new Mydate(datos)
    salary = 2000000,
    comissionRate = 500000
};
bool Regre = true;
while (Regre) { 
//menu de opciones
Console.ForegroundColor = ConsoleColor.Green;
string border = new string('*', 50);
Console.WriteLine(border);
Console.WriteLine("*        Sistema de Gestión de Empleados        *");
Console.WriteLine(border);
Console.ResetColor(); 
Console.WriteLine("Seleccione el tipo de empleado:                  ");
Console.WriteLine("1) Empleado de tiempo completo                   ");
Console.WriteLine("2) Empleado a tiempo parcial");
Console.WriteLine("3) empleado comisionado");
Console.WriteLine("4) mostrar Nómina completa");
Console.WriteLine("5) salir");
int opc = int.Parse(Console.ReadLine());


    // Validación de la opción ingresada y la información del empleado
    switch (opc)
    {
        case 1:

            Console.WriteLine(emp1);
            break;
        case 2:

            Console.WriteLine(emp2);
            break;
        case 3:

            Console.WriteLine(emp3);
            break;
        case 4:
            List<Employ> employees = new List<Employ> {
            emp1,
            emp2,
            emp3
            };
            Payroll payroll = new Payroll
            {
                id = 1,
                description = "Nómina de septiembre",
                date = new Getime(2023, 9, 30),
                employees = employees
            };
            Console.WriteLine(payroll);
            break;
        case 5:
            Regre = false;
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            break;
    }
}





