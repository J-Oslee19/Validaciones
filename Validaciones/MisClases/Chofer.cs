public class Chofer : IPiloto
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    private string tipoLicencia = string.Empty;
    public string TipoLicencia
    {
        get { return tipoLicencia; }
        set
        {
            if (EsLicenciaValida(Edad, value))
            {
                tipoLicencia = value;
            }
            else
            {
                Console.WriteLine("Edad no válida para este tipo de licencia.");
            }
        }
    }

    public Chofer(string nombre, int edad, string tipoLicencia)
    {
        Nombre = nombre;
        Edad = edad;
        TipoLicencia = tipoLicencia;
    }

    private bool EsLicenciaValida(int edad, string tipoLicencia)
    {
        switch (tipoLicencia)
        {
            case "A":
                return edad >= 25;
            case "B":
                return edad >= 21;
            case "C":
                return edad >= 16;
            case "M":
                return edad >= 16;
            default:
                return false;
        }
    }
     public void mostrarInformacion()
    {
        // Mostrar la información del chofer
        Console.WriteLine($"Nombre: {this.Nombre}");
        Console.WriteLine($"Edad: {this.Edad}");
        Console.WriteLine($"Tipo de Licencia: {this.TipoLicencia}");
    }
}
