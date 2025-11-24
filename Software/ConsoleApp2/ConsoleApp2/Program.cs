// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresar cantidad de conductores:");
var conductores = int.Parse(Console.ReadLine());

decimal velocidad_total = 0;

for (int i = 0; i < conductores; i++)
{

    Console.WriteLine($"Conductor {i + 1}\n");

    Console.WriteLine("Ingresar distancia recorrida");
    var distancia = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingresar tiempo:");
    var tiempo = decimal.Parse(Console.ReadLine());

    velocidad_total += distancia / tiempo;

}

//var velocidad_total = distancia_total / tiempo_total;
//var velocidad_promedio = velocidad_total / conductores;

//Console.WriteLine($"\nVelocidad total: {velocidad_total} km/h");
Console.WriteLine($"Velocidad promedio por conductor: {conductores / velocidad_total} km/h");


