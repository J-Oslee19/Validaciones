class Program
{
    static void Main(string[] args)
    {
         // Crear choferes con diferentes tipos de licencia
        //Validacion de tipo de licencia en edad adecuado en Guatemala
        Chofer pilotoA = new Chofer("Carlos", 25, "A");
        Chofer pilotoB = new Chofer("Ana", 21, "B");
        Chofer pilotoC = new Chofer("Luis", 16, "C");
        Chofer pilotoM = new Chofer("María", 16, "M");

        pilotoA.mostrarInformacion();
        Console.WriteLine();
        pilotoB.mostrarInformacion();
        Console.WriteLine();
        pilotoC.mostrarInformacion(); 
        Console.WriteLine(); 
        pilotoM.mostrarInformacion();
        Console.WriteLine();

        // Crear vehículo (Moto)
        Moto moto1 = new Moto(150, 10, 1)
        {
            Piloto = pilotoM
        };

        Moto miMoto = new Moto(150, 10, 1); // Pasa los valores requeridos al constructor
        Console.WriteLine($"Capacidad del tanque: {miMoto.CapacidadTanque}");
        Console.WriteLine($"Consumo de combustible: {miMoto.ConsumoCombustible}");
        Console.WriteLine($"Velocidad máxima: {miMoto.VelocidadMaxima}");
        Console.WriteLine();

        // Mostrar información del vehículo
        moto1.InformacionVehiculo();
        Console.WriteLine();

        // Acelerar la moto
        moto1.Acelerar(50);
        moto1.InformacionVehiculo();
        Console.WriteLine();

        // Hacer caballito con la moto
        moto1.HacerCaballito();
        Console.WriteLine();

        // Frenar la moto
        moto1.Frenar();
        moto1.InformacionVehiculo();
        Console.WriteLine();

        // Apagar la moto
        moto1.Apagar();

        }
}
   