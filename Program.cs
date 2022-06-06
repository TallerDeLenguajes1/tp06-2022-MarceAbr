// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Sistema de administracion");
Empleado[] empleado = new Empleado[3];

for (int i = 0; i < 1; i++)
{
    int valor;
    empleado[i] = new Empleado(); 
    Console.WriteLine("Indique los datos del empleado " + i+1);

    Console.Write("Nombre: ");
    empleado[i].Nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    empleado[i].Apellido = Console.ReadLine();
    Console.Write("Fecha de nacimiento (dd/mm/aaaa): ");
    empleado[i].FechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
    Console.Write("Estado civil (S-Soltero / C-Casado / V-Viudo): ");
    empleado[i].EstadoCivil = char.Parse(Console.ReadLine());
    Console.Write("Genero: (M-Mujer / H-Hombre): ");
    empleado[i].Genero = char.Parse(Console.ReadLine());
    Console.Write("Fecha de ingreso a la empresa (dd/mm/aaaa): ");
    empleado[i].FechaDeIngreso = Convert.ToDateTime(Console.ReadLine());
    Console.Write("Sueldo: ");
    empleado[i].Sueldo = double.Parse(Console.ReadLine());
    Console.Write("Cargo: (1-Auxiliar, 2-Administrativo, 3-Ingeniero, 4-Especialista, 5-Investigador):");
    valor = int.Parse(Console.ReadLine());
    switch (valor)
    {
        case 1:
            empleado[i].cargo = cargo.Auxiliar;
            break;
        case 2:
            empleado[i].cargo = cargo.Administrativo;
            break;
        case 3:
            empleado[i].cargo = cargo.Ingeniero;
            break;
        case 4:
            empleado[i].cargo = cargo.Especialista;
            break;
        case 5:
            empleado[i].cargo = cargo.Investigador;
            break;
    }
}

for (int i = 0; i < 1; i++)
{
    Console.Write("\nNombre del empleado: " + empleado[i].Nombre);
    Console.Write("\nApellido del empleado: " + empleado[i].Apellido);
    Console.Write("\nFecha de nacimiento: " + empleado[i].FechaDeNacimiento.ToShortDateString());
    Console.Write("\nEstado civil: " + empleado[i].EstadoCivil);
    Console.Write("\nGenero: " + empleado[i].Genero);
    Console.Write("\nFecha de ingreso a la empresa: " + empleado[i].FechaDeIngreso.ToShortDateString());
    Console.Write("\nSueldo: " + empleado[i].Sueldo);
    Console.Write("\nCargo: " + empleado[i].cargo);
    Console.Write("\nAntiguedad: " + empleado[i].Antiguedad(empleado[i].FechaDeIngreso) + " Anios");
    Console.Write("\nEdad: " + empleado[i].Antiguedad(empleado[i].FechaDeNacimiento) + " Anios");
    Console.Write("\nAnios que faltan para jubilarse: " + empleado[i].Jubilacion(empleado[i].Genero, empleado[i].FechaDeNacimiento));
    Console.Write("\nSalario adicional: " + empleado[i].Salario(empleado[i].Sueldo, empleado[i].cargo, empleado[i].EstadoCivil, empleado[i].Antiguedad(empleado[i].FechaDeIngreso)));
}