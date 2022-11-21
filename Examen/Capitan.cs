class Capitan:Tripulacion,Imetodos
{
    public int hExperticia {get; set;}
    public double sueldo {get; set;}
    public double sueldoTotal {get; set;}
    public double bono {get; set;}


    public Capitan(string nombre, long telefono, long cedula, int edad, int tEmpresa, string sexo, string barco, int hExperticia, double sueldo):base(nombre, telefono, cedula, edad, tEmpresa, sexo, barco){
        this.hExperticia = hExperticia;
        this.sueldo = sueldo;
        this.barco = barco;
    }

    public double CalculoBono(){
        if(hExperticia >= 5000 && hExperticia < 150000){
            return bono =sueldo * 0.20;

        }
        if(hExperticia>=150000 && hExperticia < 300000){
            return bono = sueldo * 0.40;
            
        }
        if(hExperticia>=300000){
            return bono =sueldo * 0.75;
        }
        else{
            return bono = sueldo;
        }
    }
    public double CalculoSueldo(){
        return sueldoTotal = sueldo + bono;
    }
    public void imprimir(){
        System.Console.WriteLine("Cedula: "+cedula);
        System.Console.WriteLine("Nombre: "+nombre);
        System.Console.WriteLine("sexo: "+sexo);
        System.Console.WriteLine("Edad: "+edad);
        System.Console.WriteLine("Telefono: "+telefono);
        System.Console.WriteLine("Tiempo en la empresa: "+tEmpresa);
        System.Console.WriteLine("Sueldo base: "+sueldo);
        System.Console.WriteLine("Bono: "+CalculoBono());
        System.Console.WriteLine("Seldo Total: "+CalculoSueldo());
    }
}