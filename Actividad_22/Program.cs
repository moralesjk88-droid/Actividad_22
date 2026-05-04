// See https://aka.ms/new-console-template for more information
using System;
class Usuario
{
    private string nombre;
    private string ip;

    public Usuario(string nombre, string ip)
    {
        this.Nombre = nombre;
        this.Ip = ip;
    }

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length >= 3)
                nombre = value;
            else
            {
                Console.WriteLine("Nombre inválido (mínimo 3 caracteres)");
                Environment.Exit(0);
            }
        }
    }

    public string Ip
    {
        get { return ip; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                ip = value;
            else
            {
                Console.WriteLine("Error: IP inválida");
                Environment.Exit(0);
            }
        }
    }



    public void MostrarDatos ()
    {
        Console.WriteLine("Nombre:_ " + Nombre);
        Console.WriteLine("IP:_ "+Ip);
    
    }

}

class UsuarioAdmin : Usuario
{
    private string nivel;
    public UsuarioAdmin(string nombre, string ip, string nivel)
        : base(nombre, ip)
    { this.Nivel = nivel; }
    
    public string Nivel
    { get { return nivel; }
        set { if (value.ToLower()== "alto"|| value.ToLower()=="medio")
            {
                nivel = value;              
}
            else
            {
                Console.WriteLine("Error: Nivel inválido(alto/medio)");
                Environment.Exit(0);
            }
        }
    }


    public void MostrarAdmin()
    {
        Console.WriteLine("------Usuario con privilegios-------");
        MostrarDatos();
        Console.WriteLine("Nivel: " + Nivel);

    }
}
    class UsuarioBasico : Usuario 
{
    private string estado;

    public UsuarioBasico(string nombre, string ip, string estado)
        : base(nombre, ip) 
    {
        this.Estado = estado; }

    public string Estado
    {
        get { return estado; }
        set
        {
            if (value.ToLower() == "activo" || value.ToLower() == "inactivo")
            {
                estado = value;
            }
            else
            {
                Console.WriteLine("Error: Estado inválido(activo/inactivo)");
                Environment.Exit(0);
            }
        }
    }
    public void MostrarBasico()
    {
        Console.WriteLine("-------Usuario Básico-----");
        MostrarDatos();
        Console.WriteLine("Estado:_  " + Estado);

    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("********Registro de admin******");
        Console.WriteLine("Nombre:_ ");
        string NombreAdmin = Console.ReadLine();
        Console.WriteLine("Ip:_ ");
        string IpAdmin = Console.ReadLine();
        Console.WriteLine("Nivel (Alto/medio):_ ");
        string nivel = Console.ReadLine();

        UsuarioAdmin admin = new UsuarioAdmin(NombreAdmin, IpAdmin, nivel);

        Console.WriteLine("\n *******Registro de usuario Básico****");

        Console.WriteLine("Nombre: ");
        string NombreBasico = Console.ReadLine();
        Console.WriteLine("Ip:_ ");
        string IpBasico = Console.ReadLine();
        Console.WriteLine("Estado (Activo/Inactivo):_ ");
        string Estado = Console.ReadLine();

        UsuarioBasico basico = new UsuarioBasico(NombreBasico, IpBasico, Estado);

        Console.WriteLine("\n ----- Informacion en sistema----");
        admin.MostrarAdmin();
        Console.WriteLine();
        basico.MostrarBasico();

        Console.ReadKey();



    }
}
    