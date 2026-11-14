namespace Gestión_de_Listas
{
    internal class Program
    {


        /*procedimiento para añadir productos con sus respectivos precios*/
        static void añadir(List<string> nombreproductos, string nombreproducto, List <int>preciosproductos, int precio)
        {
            nombreproductos.Add(nombreproducto);
        
            preciosproductos.Add(precio);
        }

        static void mostrarproductos(List<string> listanombreproducto, List<int>listaprecio) {


            for (int i = 0; i < listanombreproducto.Count; i++)
            {
                Console.WriteLine("-------------------------------------------");
                ; Console.WriteLine("nombre-producto: $" + listanombreproducto[i]);
                Console.WriteLine("precio: $" + listaprecio[i]);
                Console.WriteLine("--------------------------------------------");

            }

        }

        static void Main(string[] args)
        {

            /*Listas de nombre de producto y su precio*/
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

                if (opcion < 0) 
                { 
                    Console.WriteLine("no se permiten numeros negativos"); break;
                } else
                {
                    if (opcion == 0) { break; }
                }
                
               
                /*switch que dependiendo la opcion se se elija del menu ejecutara el metodo correspondiente*/
                switch (opcion)
                {
                    /*si la opcion se rellena como: 1, lo que hace el switch es: añadir producto con sus respectivo precio*/
                    case 1:

                        Console.WriteLine("añade un producto");
                       string producto = Console.ReadLine();

                        Console.WriteLine("añade su precio");
                        int precio = Convert.ToInt32(Console.ReadLine());

                        añadir(productos, producto, preciosproductos, precio);

                        break;
                        /*si la opcion se rellena como: 2, lo que hace el switch es: mostrar todos los productos de las listas*/
                    case 2:

                        mostrarproductos(productos,preciosproductos);

                        break;

                    /*si la opcion se rellena como: 3, lo que hace el switch es: buscar el producto que se le indique y lo muestra junto con su precio*/
                    case 3:

                        if (productos.Count == 0)
                        { 
                            Console.WriteLine("no hay productos en la lista"); break; 
                        }

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
                    /*si la opcion se rellena como: 4, lo que hace el switch es: pedir el nombre del producto que se quiere modificar para cambiar su nombre y precio*/
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

                    /*si la opcion se rellena como: 5, lo que hace el switch es: eliminar el producto que se le indique de la lista*/
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
                    /*si la opcion se rellena como: 6, lo que hace el switch es: mostrar las estadisticas de los productos de la lista (precio mayor, menor, promedio y total de productos)*/
                    case 6:

                        double total = productos.Count;

                        double mayor = 0;

                        double menor = preciosproductos.Max();

                        for (int i = 0; i < productos.Count; i++)
                        {

                            if (preciosproductos[i] > mayor)
                            {

                                mayor = preciosproductos[i];
                            }
                        }

                        for (int i = 0; i < productos.Count; i++) {

                            

                           if (preciosproductos[i] < menor)
                            {

                                menor = preciosproductos[i];
                            }
                        }

                        

                        double sumas = 0;

                        for (int i = 0; i < productos.Count; i++)
                        {
                            sumas = sumas + preciosproductos[i];
                        }

                        double promedio = sumas / preciosproductos.Count;

                        Console.WriteLine("Total  de productos: " + total);

                        for (int i = 0; i < productos.Count; i++)
                        {
                            Console.WriteLine("-------------------------------------------");
                            ; Console.WriteLine("nombre-producto: $" + productos[i]);
                            Console.WriteLine("precio: $" + preciosproductos[i]);
                            Console.WriteLine("--------------------------------------------");

                        }

                        Console.WriteLine(" El precio mayor es: " + mayor);
                        

                        Console.WriteLine(" El precio menor es: " + menor);
                        

                        Console.WriteLine(" El promedio es: " + promedio);
                        break;

                    /*si la opcion se rellena como: 7, lo que hace el switch es: ordenar la lista segun se indique*/
                    case 7:

                        Console.WriteLine("Cómo quieres ordenar la lista? (1-decendente | 2-acendente)");
                        int opcionn = Convert.ToInt32 (Console.ReadLine());

                        if (opcionn == 1)
                        {
                            for (int i = 0; i < preciosproductos.Count; i++)
                            {
                                for (int j = i + 1; j < preciosproductos.Count; j++)
                                {
                                    if (preciosproductos[i] < preciosproductos[j])
                                    {
                                        
                                        int tempPrecio = preciosproductos[i];
                                        preciosproductos[i] = preciosproductos[j];
                                        preciosproductos[j] = tempPrecio;

                                        
                                        string tempProducto = productos[i];
                                        productos[i] = productos[j];
                                        productos[j] = tempProducto;
                                    }
                                }
                            }
                        }
                        else
                        {

                            if (opcionn == 2)
                            {
                                for (int i = 0; i < preciosproductos.Count; i++)
                                {
                                    for (int j = i + 1; j < preciosproductos.Count; j++)
                                    {
                                        if (preciosproductos[i] < preciosproductos[j])
                                        {

                                            int tempPrecio = preciosproductos[i];
                                            preciosproductos[i] = preciosproductos[j];
                                            preciosproductos[j] = tempPrecio;


                                            string tempProducto = productos[i];
                                            productos[i] = productos[j];
                                            productos[j] = tempProducto;
                                        }
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < productos.Count; i++ )
                        {
                            Console.WriteLine("----------");
                            ; Console.WriteLine("nombre-producto: $" + productos[i]);
                            Console.WriteLine("precio: $" + preciosproductos[i]) ;
                            Console.WriteLine("----------");
                        }

                        break;

                    default:
                        Console.WriteLine("este...no se que decirte... opcion incorrecta");

                        break;
                    

                }

            }

            Console.WriteLine("faaaah");
        }
    }
}
