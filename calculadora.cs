public class Calculadora 
{
    public double resultado;

    public Calculadora(double valorIncial)
    {
        resultado = valorIncial;
    }

    public void Sumar(double valor)
    {
        resultado += valor;
    }
    public void Restar(double valor)
    {
        resultado -= valor;
    }
    public void Producto(double valor)
    {
        resultado *= valor;
    }
    public void Cociente(double valor)
    {
        resultado /= valor;
    }
}

