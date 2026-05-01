// See https://aka.ms/new-console-template for more information
using System;
class Usuario
{
    private string nombre;
    private string ip;

    public Usuario(string nombre, string ip)
    {
        this.nombre = nombre;
        this.ip = ip;
    }

    public string Nombre
    {
        get { return nombre;  }
        set { nombre = value; }
    }

    public string Ip
    {
        get { return ip; }
        set { ip = value; }
    }



    public void MostrarDatos ()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("IP:_ "+ip);
    
    }

}

class UsuarioAdmin : Usuario
{
    private string nivel;
    public UsuarioAdmin(string nombre, string ip, string nivel)
        : base(nombre, ip)
    { this.nivel = nombre; }

    public void MostrarAdmin()
    {
        Console.WriteLine("------Usuario con privilegios-------");
        MostrarDatos();
        Console.WriteLine("Nivel: " + nivel);

    }
}
    class UsuarioBasico : Usuario 
{
    private string estado;

    public UsuarioBasico(string nombre, string ip, string estado)
        : base(nombre, ip) 
    {
        this.estado = estado; }

    public void MostrarBasico()
    {
        Console.WriteLine("-------Usuario Básico-----");
        MostrarDatos();
        Console.WriteLine("Estado:_  " + estado);

    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("********Registro de admin******");
        Console.WriteLine("Nombre:_ ");
        string NombreAdmin=Console.ReadLine();
        Console.WriteLine("Ip:_ ");
        string IpAdmin=Console.ReadLine();
        Console.WriteLine("Nivel (Alto/medio):_ ");
        string nivel = Console.ReadLine();

        UsuarioAdmin admin = new UsuarioAdmin(NombreAdmin, IpAdmin, nivel);



    }
}
    