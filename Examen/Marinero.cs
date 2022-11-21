class Marinero:Tripulacion,Imetodos
{
    public double pesopescado {get; set;}
    public double sueldo {get; set;}
    public double bono {get; set;}
    public double sueldototal {get; set;}
    
    public Marinero(string nombre, long telefono, long cedula, int edad, int tEmpresa, string sexo, string barco, double bono):base(nombre, telefono, cedula, edad, tEmpresa, sexo, barco){
        this.barco = barco;
        this.bono = bono;
    }
    public double CalculoBono(){
        return bono;
    }
    public double CalculoSueldo(){
        return sueldototal = sueldo + bono;
    }
    public void imprimir (){
        System.Console.WriteLine("Cedula: "+cedula);
        System.Console.WriteLine("Nombre: "+nombre);
        System.Console.WriteLine("sexo: "+sexo);
        System.Console.WriteLine("Edad: "+edad);
        System.Console.WriteLine("Telefono: "+telefono);
        System.Console.WriteLine("Tiempo en la empresa: "+tEmpresa);
        System.Console.WriteLine("Sueldo base: "+sueldo);
        System.Console.WriteLine("Monto del bono: "+CalculoBono());
        System.Console.WriteLine("Seldo Total: "+CalculoSueldo());
    }
}