using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace AgenciaViajes
{
    internal class Program
    {
        //Definir constante para un maximo de 100 elementos en el arreglo 
        const int MAX = 100;

        //Definir los arreglos para el programa de agencia 
        static int[] numPasaje = new int[MAX];
        static int[] numAsiento = new int[MAX];
        static string[] nombre = new string[MAX];
        static int[] piso = new int[MAX];
        static int[] mes = new int[MAX];
        static string[] origen = new string[MAX];
        static string[] destino = new string[MAX];
        static double[] precio = new double[MAX];
        static DateTime[] fechaEmision = new DateTime[MAX];
        static DateTime[] fechaViaje = new DateTime[MAX];
        static int contador = 0;
        static void Main(string[] args)
        {
            //Definir la variable de opcion de menu 
            int opcion;
            do
            {
                Console.Clear(); //Limpiar la conosla 
                //Definir el menu 
                Console.WriteLine("\n--- AGENCIA CRUZ DEL SUR ---");
                Console.WriteLine("1. Agregar pasajero");
                Console.WriteLine("2. Modificar pasajero");
                Console.WriteLine("3. Eliminar pasajero");
                Console.WriteLine("4. Consultar por número de pasaje");
                Console.WriteLine("5. Buscar por asiento o nombre");
                Console.WriteLine("6. Reporte de pasajeros ordenados por número de pasaje");
                Console.WriteLine("7. Mostrar pasajes y asientos disponibles");
                Console.WriteLine("8. Imprimir boleto de viaje");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarPasajero(); break;
                    case 2: ModificarPasajero(); break;
                    case 3: EliminarPasajero(); break;
                    case 4: ConsultarPasajero(); break;
                    case 5: BuscarPasajero(); break;
                    case 6: ReportePasajeros(); break;
                    case 7: MostrarDisponibles(); break;
                    case 8: ImprimirBoleto(); break;

                }
                //Pausa 
                Console.ReadKey();
            } while (opcion != 0);
        }
        //Definir metodos u operaciones 
        static void AgregarPasajero()
        {
            if (contador >= MAX)
            {
                Console.WriteLine("No se pueden registrar más pasajeros.");
                return;
            }

            Console.Write("Número de pasaje (1-900): ");
            int nPasaje = int.Parse(Console.ReadLine());
            if (nPasaje < 1 || nPasaje > 900 || ExistePasaje(nPasaje))
            {
                Console.WriteLine("Número de pasaje inválido o ya registrado.");
                return;
            }

            Console.Write("Número de asiento (1-52): ");
            int asiento = int.Parse(Console.ReadLine());
            if (asiento < 1 || asiento > 52 || ExisteAsiento(asiento))
            {
                Console.WriteLine("Asiento inválido o ya ocupado.");
                return;
            }

            Console.Write("Nombre del pasajero: ");
            string nom = Console.ReadLine();

            Console.Write("Mes de viaje (1-12): ");
            int m = int.Parse(Console.ReadLine());
            if (m < 1 || m > 12)
            {
                Console.WriteLine("Mes inválido.");
                return;
            }

            Console.Write("Origen: ");
            string ori = Console.ReadLine();
            Console.Write("Destino: ");
            string dest = Console.ReadLine();

            double pre = CalcularPrecio(ori, dest);
            if (pre == -1)
            {
                Console.WriteLine("Ruta inválida.");
                return;
            }

            // Fecha de emisión automática 
            DateTime emision = DateTime.Now;
            Console.WriteLine($"Fecha de emisión del boleto: {emision:dd/MM/yyyy}");

            // Solicitar fecha de viaje 
            DateTime viaje;
            while (true)
            {
                Console.Write("Ingrese fecha de viaje (dd/mm/aaaa): ");
                if (!DateTime.TryParse(Console.ReadLine(), out viaje))
                {
                    Console.WriteLine("Formato incorrecto. Intente de nuevo.");
                    continue;
                }

                if (viaje.Date < emision.Date)
                {
                    Console.WriteLine("La fecha de viaje no puede ser anterior a la fecha de emisión.");
                }
                else
                {
                    break; // Fecha válida 
                }
            }

            // Guardar datos 
            numPasaje[contador] = nPasaje;
            numAsiento[contador] = asiento;
            nombre[contador] = nom;
            piso[contador] = (asiento <= 12) ? 1 : 2;
            mes[contador] = m;
            origen[contador] = ori;
            destino[contador] = dest;
            precio[contador] = pre;
            fechaEmision[contador] = emision;
            fechaViaje[contador] = viaje;

            contador++;
            Console.WriteLine("Pasajero registrado correctamente.");
        }

        static double CalcularPrecio(string ori, string dest)
        {
            string ruta = ori.ToLower() + "-" + dest.ToLower();

            if (ruta == "lima-chiclayo" || ruta == "chiclayo-lima")
                return 120.00;
            else if (ruta == "lima-piura" || ruta == "piura-lima")
                return 170.00;
            else if (ruta == "lima-trujillo" || ruta == "trujillo-lima")
                return 60.00;
            else if (ruta == "lima-ica" || ruta == "ica-lima")
                return 45.00;
            else if (ruta == "lima-arequipa" || ruta == "arequipa-lima")
                return 90.00;
            else if (ruta == "lima-tacna" || ruta == "tacna-lima")
                return 110.00;
            else if (ruta == "lima-tumbes" || ruta == "tumbes-lima")
                return 190.00;
            else
                return -1;
        }

        static void ModificarPasajero()
        {
            Console.Write("Ingrese número de pasaje: ");
            int n = int.Parse(Console.ReadLine());
            int pos = BuscarPosicionPorPasaje(n);
            if (pos == -1)
            {
                Console.WriteLine("Pasajero no encontrado.");
                return;
            }

            Console.Write("Nuevo nombre: ");
            nombre[pos] = Console.ReadLine();
            Console.WriteLine("Pasajero modificado.");
        }

        static void EliminarPasajero()
        {
            Console.Write("Ingrese número de pasaje: ");
            int n = int.Parse(Console.ReadLine());
            int pos = BuscarPosicionPorPasaje(n);
            if (pos == -1)
            {
                Console.WriteLine("Pasajero no encontrado.");
                return;
            }
            for (int i = pos; i < contador - 1; i++)
            {
                numPasaje[i] = numPasaje[i + 1];
                numAsiento[i] = numAsiento[i + 1];
                nombre[i] = nombre[i + 1];
                piso[i] = piso[i + 1];
                mes[i] = mes[i + 1];
                origen[i] = origen[i + 1];
                destino[i] = destino[i + 1];
                precio[i] = precio[i + 1];
            }
            contador--;
            Console.WriteLine("Pasajero eliminado.");
        }

        static void ConsultarPasajero()
        {
            Console.Write("Ingrese número de pasaje: ");
            int n = int.Parse(Console.ReadLine());
            int pos = BuscarPosicionPorPasaje(n);
            if (pos == -1)
            {
                Console.WriteLine("Pasajero no encontrado.");
                return;
            }
            MostrarPasajero(pos);
        }

        static void BuscarPasajero()
        {
            Console.Write("Buscar por nombre o número de asiento: ");
            string dato = Console.ReadLine();

            for (int i = 0; i < contador; i++)
            {
                if (nombre[i].Equals(dato, StringComparison.OrdinalIgnoreCase) ||
                    numAsiento[i].ToString() == dato)
                {
                    MostrarPasajero(i);
                }
            }
        }

        static void ReportePasajeros()
        {
            int[] indices = new int[contador];
            for (int i = 0; i < contador; i++) indices[i] = i;

            // Ordenar por número de pasaje 
            Array.Sort(indices, (a, b) => numPasaje[a].CompareTo(numPasaje[b]));

            Console.WriteLine("REPORTE DE PASAJEROS ORDENADOS POR NÚMERO DE PASAJE:");
            foreach (int i in indices)
                MostrarPasajero(i);
        }

        static void MostrarPasajero(int i)
        {
            Console.WriteLine($"Pasaje: {numPasaje[i]}, Asiento: {numAsiento[i]}, Nombre: {nombre[i]}, Piso: {piso[i]}, Mes: {mes[i]}, Origen: {origen[i]}, Destino: {destino[i]}, Precio: {precio[i]:C}");
        }

        static int BuscarPosicionPorPasaje(int n)
        {
            for (int i = 0; i < contador; i++)
                if (numPasaje[i] == n) return i;
            return -1;
        }
        static void MostrarDisponibles()
        {
            Console.WriteLine("\n--- NÚMEROS DE PASAJE DISPONIBLES ---");
            for (int i = 1; i <= 900; i++)
            {
                if (!ExistePasaje(i))
                    Console.Write(i + " ");
            }

            Console.WriteLine("\n\n--- NÚMEROS DE ASIENTO DISPONIBLES ---");
            for (int i = 1; i <= 52; i++)
            {
                if (!ExisteAsiento(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static bool ExistePasaje(int n)
        {
            for (int i = 0; i < contador; i++)
                if (numPasaje[i] == n)
                    return true;
            return false;
        }

        static bool ExisteAsiento(int a)
        {
            for (int i = 0; i < contador; i++)
                if (numAsiento[i] == a)
                    return true;
            return false;
        }
        static void ImprimirBoleto()
        {
            Console.Write("Ingrese número de pasaje: ");
            int n = int.Parse(Console.ReadLine());
            int pos = BuscarPosicionPorPasaje(n);

            if (pos == -1)
            {
                Console.WriteLine("Pasajero no encontrado.");
                return;
            }

            string nombreArchivo = $"Boleto_{numPasaje[pos]}_{numAsiento[pos]}_{fechaEmision[pos]:yyyyMMdd}.pdf";
            string rutaArchivo = Path.Combine(Environment.CurrentDirectory, nombreArchivo);

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            var titulo = new Paragraph("AGENCIA CRUZ DEL SUR\nBOLETO DE VIAJE\n\n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph($"Pasaje Nº     : {numPasaje[pos]}"));
            doc.Add(new Paragraph($"Nombre        : {nombre[pos]}"));
            doc.Add(new Paragraph($"Asiento Nº    : {numAsiento[pos]} (Piso {piso[pos]})"));
            doc.Add(new Paragraph($"Origen        : {origen[pos]}"));
            doc.Add(new Paragraph($"Destino       : {destino[pos]}"));
            doc.Add(new Paragraph($"Mes de Viaje  : {mes[pos]}"));
            doc.Add(new Paragraph($"Fecha Emisión : {fechaEmision[pos]:dd/MM/yyyy}"));
            doc.Add(new Paragraph($"Fecha Viaje   : {fechaViaje[pos]:dd/MM/yyyy}"));
            doc.Add(new Paragraph($"Precio        : S/. {precio[pos]:0.00}"));
            doc.Add(new Paragraph("\nGracias por viajar con nosotros."));

            doc.Close();

            Console.WriteLine($"Boleto guardado como: {nombreArchivo}");
        }


    }
}