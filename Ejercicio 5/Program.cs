// Evaluación de´préstamo bancario por reglas

Console.WriteLine("Decisión de prestamo aprobado");
Console.WriteLine("Tipo de solicitante: 1 Empleado fijo; 2 Temporal, 3 Independiente, 4 Estudiante");
int solicitante = int.Parse(Console.ReadLine());
Console.WriteLine("Ingreso mensual");
double ingresomensual = double.Parse(Console.ReadLine());
Console.WriteLine("Antiguedad laboral (en meses)");
int antiguedad = int.Parse(Console.ReadLine());
Console.WriteLine("Monto solicitado");
int montosoli = int.Parse(Console.ReadLine());
Console.WriteLine("Historial crediticio: 1 Exelente, 2 Bueno, 3 Regular, 4 Malo");
int Histrial = int.Parse(Console.ReadLine());
Console.WriteLine("tiene fiador (s/n)");
string fiador = Console.ReadLine();

string estado = "Rechazado";
string motivo = "No cumple con un buen perfil";

