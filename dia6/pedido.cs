using System;

Cliente cliente = new Cliente("Moises","0983883170");
Producto gaseosa = new Producto("Gaseosa Pulp 2L", 13000);
Producto alfajor = new Producto("Alfajor Tatakua", 10000);

Pedido pedido = new Pedido(cliente);
pedido.Agregar(gaseosa, 3);
pedido.Agregar(alfajor, 10);

pedido.Mostrar();



public class Persona { 
    public string Nombre { get; }

    public Persona(string nombre) {
        Nombre = nombre;
    }
    public void Prestestarse() {
        Console.WriteLine($"Hola, soy {Nombre}");
    }
}

//cliente hereda de persona
public class Cliente : Persona { 
    public string Telefono { get; }

    public Cliente(string nombre, string telefono) :base(nombre) { 
        Telefono = telefono;
    }
}

public class Producto {
    public string Nombre { get; }
    public double Precio { get; }

    public Producto(string nombre, double precio) { 
        Nombre = nombre;
        Precio = precio;
    }
}

public class PedidoDetalle { 
    public Producto Producto { get; }
    public int Cantidad { get; }

    public PedidoDetalle(Producto producto, int cantidad) { 
        Producto = producto;
        Cantidad = cantidad;
    }

    public double Subtotal() {
        return Producto.Precio * Cantidad;
    }

}

public class Pedido {
    private List<PedidoDetalle> _detalles = new List<PedidoDetalle>();
    public Cliente Cliente { get; }

    public Pedido(Cliente cliente) {
        Cliente = cliente;
    }

    public void Agregar(Producto producto, int cantidad) {
        _detalles.Add(new PedidoDetalle(producto, cantidad));
    }

    public double Total()
    {
        return _detalles.Sum(d => d.Subtotal());
    }

    public void Mostrar() {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"\nPedido del cliente: {Cliente.Nombre}, Tel.: {Cliente.Telefono}");
        Console.WriteLine($"Cantidad Descripcion\t\t\t\tSubtotal");
        foreach (PedidoDetalle d in _detalles) {
            Console.WriteLine($"{d.Cantidad} \t| {d.Producto.Nombre} \t\t\t| {d.Subtotal().ToString("N0")}");
        }
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine($"Totales: {Total().ToString("N0")}");
    
    }

}