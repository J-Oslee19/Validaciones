public class Moto : Vehiculo
{
    public Moto(int velocidadMaxima, int capacidadTanque, int consumoCombustible)
        : base(velocidadMaxima, capacidadTanque, consumoCombustible)
    {
        VelocidadMaxima = 150;  // Ejemplo de valor para una moto
        CapacidadTanque = 10;   // Ejemplo de valor para una moto
        ConsumoCombustible = 1; // Ejemplo de valor para una moto
    }

    public void HacerCaballito()
    {
        if (VelocidadActual > 0)
        {
            Console.WriteLine("¡La moto está haciendo un caballito!");
        }
        else
        {
            Console.WriteLine("La moto debe estar en movimiento para hacer un caballito.");
        }
    }

    public override void InformacionVehiculo()
    {
        base.InformacionVehiculo();
        Console.WriteLine($"Tipo de vehículo: Moto");
    }
}
