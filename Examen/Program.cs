internal class Program
{
    private static void Main(string[] args)
    {
        Barco barco1 = new Barco("Tercaro A", "Pesquero", 10, 30000);
        barco1.imrpimir();
        Ubicacion gps = new Ubicacion("8´24´54", "9´23´21", 30, 18/11/2022, 0900);
        gps.imprimir();
        Capitan capitan1 = new Capitan("Marcos", 098432123, 23339876542, 20, 20, "M", "Tercero B", 5000, 4500);
        capitan1.imprimir();
        JefeF jefe = new JefeF("Juan", 098432123, 2339876542, 23, 15, "M", "Tercero B", 3500,50, 180);
        jefe.imprimir();
        Marinero marinero1 = new Marinero("Pedro", 098432123, 23339876542, 19, 10, "M", "Tercero B",1750);
    }
}