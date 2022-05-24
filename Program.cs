// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int continuar, valor, cantidad;
double numero;
bool bandera = true;
Console.WriteLine("===== CALCULADORA =====");
do
{    
    Calculadora calc = new Calculadora(0);
    while (bandera)
    {
        Console.WriteLine("Indique la operacion que desea realizar: 1-SUMA / 2-RESTA / 3-MULTIPLICACION / 4-DIVISION");
        valor = int.Parse(Console.ReadLine());
        Console.WriteLine("Idique el numero para operar: ");
        numero = double.Parse(Console.ReadLine());
        switch (valor)
        {
            case 1:
                calc.Sumar(numero);
                Console.WriteLine("Resultado: " + calc.resultado);
                break;
            case 2:
                calc.Restar(numero);
                Console.WriteLine("Resultado: " + calc.resultado);
                break;
            case 3:
                calc.Producto(numero);
                Console.WriteLine("Resultado: " + calc.resultado);
                break;
            case 4:
                calc.Cociente(numero);
                Console.WriteLine("Resultado: " + calc.resultado);
                break;
        }
    }
    Console.WriteLine("Quiere hacer otra operacion: 1-SI / 0-NO");
    continuar = int.Parse(Console.ReadLine());
} while (continuar > 0);