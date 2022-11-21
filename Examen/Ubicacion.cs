class Ubicacion
{
    public string CX {get; set;}
    public string CY {get; set;}
    public int Dtripulados {get; set;}
    public int fechaR {get; set;}
    public int horaR {get; set;}

    public Ubicacion(string CX, string CY, int Dtripulados, int fechaR, int hooraR){
        this.CX = CX;
        this.CY = CY;
        this.Dtripulados = Dtripulados;
        this.fechaR = fechaR;
        this.horaR = horaR;
    }
    public void imprimir(){
        System.Console.WriteLine("Coordenadas x: "+CX);
        System.Console.WriteLine("Coordenadas y: "+CY);
        System.Console.WriteLine("Dias tripulados: "+Dtripulados);
        System.Console.WriteLine("Fecha de registro: "+fechaR);
        System.Console.WriteLine("Hora de registro: "+horaR);
    }
}