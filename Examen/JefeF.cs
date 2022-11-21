class JefeF:Tripulacion,Imetodos
{
    public int pesoP {get; set;}
    public int pesoM {get; set;}
    public double sueldototal {get; set;}
    public double bonopes {get; set;}
    public double bonomar {get; set;}
    public double sueldo {get; set;}
    
    public JefeF(string nombre, long telefono, long cedula, int edad, int tEmpresa, string sexo, string barco, double sueldo, double bonopes, double bonomar):base(nombre, telefono, cedula, edad, tEmpresa, sexo, barco){
        this.bonopes = bonopes;
        this.bonomar = bonomar;
        this.barco = barco;
    }
    public double CalculoBono(){
        
        return 0 ;
        }
    
    public double CalculoSueldo(){
        return sueldototal = bonopes+bonomar;
    }
    public void imprimir(){
        System.Console.WriteLine("Cedula: "+cedula);
        System.Console.WriteLine("Nombre: "+nombre);
        System.Console.WriteLine("sexo: "+sexo);
        System.Console.WriteLine("Edad: "+edad);
        System.Console.WriteLine("Telefono: "+telefono);
        System.Console.WriteLine("Tiempo en la empresa: "+tEmpresa);
        System.Console.WriteLine("Sueldo base: "+sueldo);
        System.Console.WriteLine("Bono por pescado: "+bonopes);
        System.Console.WriteLine("Bono por mariscos: "+bonomar);
        System.Console.WriteLine("Seldo Total: "+CalculoSueldo());
    }
}
