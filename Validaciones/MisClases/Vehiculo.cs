public class Vehiculo
{
    public int VelocidadMaxima { get; set; }
    public double CapacidadTanque { get; set; }
    public double ConsumoCombustible { get; set; }
    protected int VelocidadActual;
    protected string Estado;  // "apagado", "encendido", "en movimiento"
    public Chofer? Piloto { get; set; }
    
    public Vehiculo(int velocidadMaxima, int capacidadTanque, int consumoCombustible)
    {
        VelocidadMaxima = velocidadMaxima;
        CapacidadTanque = capacidadTanque;
        ConsumoCombustible = consumoCombustible;
        VelocidadActual = 0;
        Estado = "apagado";
        Piloto = null; // Nullable property allows this assignment
    }

    public void Acelerar(int incremento)
    {
        if (VelocidadActual + incremento > VelocidadMaxima)
        {
            Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.");
        }
        else
        {
            VelocidadActual += incremento;
            Estado = "en movimiento";
        }
    }

    public void Frenar()
    {
        VelocidadActual = 0;
        Estado = "encendido";
        Console.WriteLine("El vehículo ha detenido.");
    }

    public void Apagar()
    {
        if (VelocidadActual == 0)
        {
            Estado = "apagado";
            Console.WriteLine("El vehículo está apagado.");
        }
        else
        {
            Console.WriteLine("No se puede apagar el vehículo en movimiento.");
        }
    }

    public virtual void InformacionVehiculo()
    {
        Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
        Console.WriteLine($"Velocidad máxima: {VelocidadMaxima} km/h");
         Console.WriteLine($"Capacidad del tanque: {CapacidadTanque}");
        Console.WriteLine($"Consumo de combustible: {ConsumoCombustible}");
        Console.WriteLine($"Estado del vehículo: {Estado}");
        if (Piloto != null)
        {
            Console.WriteLine($"Piloto asignado: {Piloto.Nombre}");
        }
    }
}
