public enum cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}
public class Empleado 
{    
    public string Nombre;
    public string Apellido;
    public DateTime FechaDeNacimiento;
    public char EstadoCivil;
    public char Genero;
    public DateTime FechaDeIngreso;
    public double Sueldo;
    public cargo cargo;

    DateTime fechaActual = DateTime.Today;
    int faltan;
    double salario;
    public int Antiguedad(DateTime fecha)
    {
        int antiguedad = fechaActual.Year - fecha.Year; 
        if(fechaActual.Month > fecha.Month){
            return antiguedad-=1;
        } else {
            return antiguedad;
        }
    }

    public int Jubilacion(char genero, DateTime fecha){
        if(Char.ToLower(genero)=='f'){      //convierto a minuscula para que no haya errores si el usuario ingreso con mayusculas
            faltan = 60 - Antiguedad(fecha);  //las mujeres se jubilan a los 60 años
        }else{
            faltan = 65 - Antiguedad(fecha);  //los varones se jubilan a los 65 años
        }
        return faltan;
    }

    public double Salario(double sueldo, cargo cargo, char estadoCivil, int antiguedad){
        double adicional = 0;

        if(antiguedad < 20){
            adicional = (sueldo * 0.01) * antiguedad;
        }else{
            adicional = 0.25 * sueldo;
        }

        if(cargo == cargo.Ingeniero || cargo == cargo.Especialista){
            adicional = adicional * 1.50;
        }

        if(Char.ToLower(estadoCivil)=='c'){
            adicional = adicional + 15000;
        }

        salario = sueldo + adicional;

        return salario;
    }
}