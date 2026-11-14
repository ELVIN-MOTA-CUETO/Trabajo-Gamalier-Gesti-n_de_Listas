namespace Gestión_de_Listas
{
    internal class Program
    {

        static void añadir(List<string> nombreproductos, string nombreproducto, List <int>preciosproductos, int precio)
        {
            nombreproductos.Add(nombreproducto);

            preciosproductos.Add(precio);
        }

        static void Main(string[] args)
        {
            List<string> productos = new List<string>();

            List<int> preciosproductos = new List<int>();

            while (true)
            {
                Console.WriteLine("|| Menú ||");

                Console.WriteLine("Opción-1 | agregar producto");
                Console.WriteLine("Opción-2 | Mostrar todos los productos");
                Console.WriteLine("Opción-3 | buscar un producto");
                Console.WriteLine("Opción-4 | Modificar un producto");
                Console.WriteLine("Opción-5 | Eliminar un producto");
                Console.WriteLine("Opción-6 | Mostrar estadisticas(total, precio mayor, menor y promedio)");
                Console.WriteLine("Opción-7 | Ordenar Lista");
                Console.WriteLine("Opción-0 | Salir");

                Console.WriteLine("Opción");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("añade un producto");
                       string producto = Console.ReadLine();

                        Console.WriteLine("añade su precio");
                        int precio = Convert.ToInt32(Console.ReadLine());

                        añadir(productos, producto, preciosproductos, precio);

                        break;

                    case 2:

                        for (int i = 0; i < productos.Count; i++)
                        {
                             Console.WriteLine("-------------------------------------------");
;                            Console.WriteLine("nombre-producto: $" + productos[i]);
                            Console.WriteLine("precio: $" + preciosproductos[i]);
                            Console.WriteLine("--------------------------------------------");

                        }

                        break;


                    case 3:

                        Console.WriteLine("qué producto quieres buscar?");
                        string busqueda = Console.ReadLine();

                        

                            for (int i = 0; i < productos.Count; i++)
                            {
                            

                                if (busqueda == productos[i]) {
                                    
                                Console.WriteLine("----------");
;                            Console.WriteLine("nombre-producto: $" + productos[i]);
                            Console.WriteLine("precio: $" + preciosproductos[i]);
                            Console.WriteLine("----------");
                                }
                            }

                        break;

                    case 4:

                        Console.WriteLine("qué producto quieres modificar?");
                        string busquedademodificacion = Console.ReadLine();



                        for (int i = 0; i < productos.Count; i++)
                        {


                            if (busquedademodificacion == productos[i])
                            {

                                Console.WriteLine("el producto: " + productos[i] + ", cómo se llamará ahora?");
                                string cambionombre = Console.ReadLine();

                                productos[i] = cambionombre;

                                Console.WriteLine("El precio que tenia: " + preciosproductos[i] + ", cómo será ahora?");
                                int cambioprecio = Convert.ToInt32(Console.ReadLine());

                                preciosproductos[i] = cambioprecio;
                            }
                        }


                        break;


                    case 5:

                        Console.WriteLine("qué producto quieres eliminar?");

                        string busquedadeelminar = Console.ReadLine();



                        for (int i = 0; i < productos.Count; i++)
                        {


                            if (busquedadeelminar == productos[i])
                            {

                                productos.RemoveAt(i);

                                preciosproductos.RemoveAt(i);
                            }
                        }
                        break;

                    case 6:

                        double total = 0;

                        double mayor = 0;

                        double menor = 0;


                        for (int i = 0; i < productos.Count; i++) {

                            total = total + preciosproductos[i];

                           if (preciosproductos[i] < menor)
                            {

                                menor = preciosproductos[i];
                            }
                        }

                        for (int i = 0; i < productos.Count; i++) {
                        
                           if (preciosproductos[i] > mayor) {

                                mayor = preciosproductos[i];
                            }
                        }

                        double sumas = 0;

                        for (int i = 0; i < productos.Count; i++)
                        {
                            sumas = sumas + preciosproductos[i];
                        }

                        double promedio = sumas / preciosproductos.Count;

                        Console.WriteLine(" El Total es: " + total);
                        

                        Console.WriteLine(" El precio mayor es: " + mayor);
                        

                        Console.WriteLine(" El precio menor es: " + menor);
                        

                        Console.WriteLine(" El promedio es: " + promedio);
                        break;




                }

            }
        }
    }
}
