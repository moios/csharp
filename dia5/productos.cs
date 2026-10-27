

List<Producto> inventario = new List<Producto>();

inventario.Add(new Producto("123", "papa", 5400, 89, 20));
inventario.Add(new Producto("4548", "mandioca", 7400, 30, 20));
inventario.Add(new Producto("89755", "batata", 15400, 10, 20));

// Cargar stock de batata
Console.WriteLine("Antes de reponer:");
Console.WriteLine(inventario[2].Mostrar());

inventario[2].Reponer(10);

Console.WriteLine("\nDespués de reponer:");
Console.WriteLine(inventario[2].Mostrar());

//Vender batata
bool resp = inventario[2].Vender(20);
if (resp) {
    Console.WriteLine("\nVenta realizado");
}

// Verificar batata
Console.WriteLine("Stock actual: ");
Console.WriteLine(inventario[2].Mostrar());

class Producto
{
    private int _stock;
    private double _precioVenta;

    public string Codigo { get; }
    public string Nombre { get; }
    public int StockMinimo { get; }

    public double PrecioVenta
    {
        get { return _precioVenta; }
        set
        {
            if (value >= 0)
            {
                _precioVenta = value;
            }
        }
    }

    public int Stock
    {
        get { return _stock; }
    }

    public Producto(string cod, string nomb, double pv, int st, int stm)
    {
        Codigo = cod;
        Nombre = nomb;
        PrecioVenta = pv;
        _stock = st;
        StockMinimo = stm;
    }

    public bool Vender(int cant)
    {
        if (cant <= 0 || cant > _stock)
        {
            Console.WriteLine("Stock insuficiente o cantidad inválida");
            return false;
        }

        _stock -= cant;
        return true;
    }

    public void Reponer(int cant)
    {
        if (cant > 0)
        {
            _stock += cant;
        }
    }

    public bool NecesitaReposicion()
    {
        return _stock <= StockMinimo;
    }

    public string Mostrar()
    {
        return $"{Nombre} -> Stock: {_stock}, Precio: {_precioVenta}";
    }
}
