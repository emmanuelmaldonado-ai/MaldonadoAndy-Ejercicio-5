// Evaluación de préstamo bancario por reglas

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

switch (solicitante)
{
    case 1:
        if (antiguedad >= 6 && ingresomensual >= 1000)
        {
            estado = "aprobado";
            motivo = "perfil estable";
        }
        else
        {
            motivo = "antiguedad o ingreso insuficiente";
        }
        break;
    case 2:
        if (antiguedad >= 12 && ingresomensual >= 1500)
        {
            estado = "Aprobado con condiciones";
            motivo = "Es un empleado temporal";
        }
        break;
    case 3:
        if (ingresomensual >= 2500)
        {
            if (antiguedad >= 24)
            {
                estado = "Aprovado";
                motivo = "independiente";
            }
            else
            {
                motivo = "Ingreso bajo para trabajar independiente";
            }
        }
        break;
        if (fiador == "s")
        {
            if(montosoli <= 5000)
            {
                estado = "Aprobado con condiciones";
                motivo = "Depende de un fiador";
            }
            else
            {;
                motivo = "monto exede limite para estudiante";
            }
        }
        else
        {
            motivo = "Requiere un fiador";
        }
        break;
}

if (Histrial == 4)
{
    estado = "rechazado";
    motivo = "historial crediticio malo"; 
    if (fiador == "s")
    {
        if (montosoli <= 2000)
        {
            estado = "Aprobado con condiciones";
            motivo = "Monto minimo y fiador";
        }
    }
}
else if (Histrial == 1)
{
    if (estado == "Rechazado")
    {
        estado = "aprobado con condiciones";
        motivo = "Exelente Historial crediticio";
    }
}

if (montosoli > (ingresomensual * 12))
{
    estado = "Rechazado";
    motivo = "monto solicitado es exesivo";
}
else if(montosoli  > (ingresomensual * 6))
{
    if (estado == "Aprobado")
    {
        estado = "Aprobado con condiciones";
        estado = "Monto elevad";
    }
}

Console.WriteLine("Resultados de la solicitud");
Console.WriteLine($"Estado: {estado}");
Console.WriteLine($"Motivo Principal:´{motivo}");
