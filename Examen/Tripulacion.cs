class Tripulacion
{
    public string nombre {get; set;}
    public long cedula {get; set;}
    public long telefono {get; set;}
    public int edad {get; set;}
    public int tEmpresa {get; set;}
    public string sexo {get; set;}
    public string barco {get; set;}

    public Tripulacion(string nombre, long telefono, long cedula, int edad, int tEmpresa, string sexo, string barco){
        this.nombre = nombre;
        this.telefono = telefono;
        this.cedula = cedula;
        this.edad= edad;
        this.tEmpresa = tEmpresa;
        this.sexo = sexo;
        this.barco = barco;
    }
}