using System.Diagnostics;
double porciento = 0.00;
int dinero = 0;
main(dinero, porciento);

static void main(int dinero, double porciento)
{
   Console.Clear();
   Console.CursorVisible = false;
   while (!Console.KeyAvailable)
   {
       Console.Write("---WELCOME---");
       Thread.Sleep(500);
       Console.Clear();
       Thread.Sleep(500);
   }
   Console.ReadKey();
   Console.CursorVisible = true;
   Console.Clear();

dinero:
   try
   {
       Console.Write("Ingrese su dinero: ");
       dinero = Convert.ToInt32(Console.ReadLine());
       if (dinero < 30 || dinero > 500)
       {
           Console.Write("Cantidad no valida...");
           Console.ReadKey();
           main(dinero, porciento);
       }
       programa(dinero, porciento);
   }
   catch (Exception)
   {
       Console.Clear(); goto dinero;
   }
}

static void programa(int dinero, double porciento)
{
   Console.Clear();
   Stopwatch stopwatch = new Stopwatch();
menu:
   bool confirSuspencion = false;
   Console.Write("MENU\n[1] Caffes\n[2] Jugos\n[3] Vatidas\n[4] Empanadas\n[5] Sandwiches\n[6] Combos\n[A] ADMINISTRADOR\n\nElegir pedido: ");
   stopwatch.Start();
   while (stopwatch.ElapsedMilliseconds < 10000)
   {
       if (Console.KeyAvailable)
       {
           char seleccionado = Convert.ToChar(Console.ReadKey().KeyChar);
           Console.Clear(); stopwatch.Restart();
           switch (seleccionado)
           {
               case '1':
                   funcCaffe(seleccionado, dinero, porciento);
                   confirSuspencion = true;
                   break;
               case '2':
                   funcJugos(seleccionado, dinero, porciento);
                   confirSuspencion = true;
                   break;
               case '3':
                   funcVatidas(seleccionado, dinero, porciento);
                   confirSuspencion = true;
                   break;
               case '4':
                   funcEmpanadas(seleccionado, dinero, porciento);
                   confirSuspencion = true;
                   break;
               case '5':
                   funcSandwiches(seleccionado, dinero, porciento);
                   confirSuspencion = true;
                   break;
               case '6':
                   funcCombos(seleccionado, dinero, porciento);
                   confirSuspencion = true;
                   break;
               default:
                   Console.Clear();
                   goto menu;
           }
           Console.Clear();

       }
       if (confirSuspencion == true)
       {
           break;
       }
   }
   if (confirSuspencion != true)
   {
       suspencion(' ', dinero, porciento);
   }
}

static void funcCaffe(char num, int dinero, double porciento)
{
selec:
   Stopwatch stopwatch = new Stopwatch();
   dynamic[,] caffe = { { 0, Convert.ToInt32(90-(90 * porciento)), "Capullino    " }, { 1, Convert.ToInt32(70-(70 * porciento)), "Con leche    " }, { 2, Convert.ToInt32(100-(100 * porciento)), "Ratatá       " } };

   Console.WriteLine("+-------------------------------+\n| Tipo de Cafe\t\t| Coste\t|\n+-------------------------------+");
   for (int i = 0; i < caffe.Length / 3; i++)
   {
       Console.WriteLine($"| [{caffe[i, 0] + 1}] {caffe[i, 2]}\t| ${caffe[i, 1]}\t|");
   }
   Console.WriteLine("+-------------------------------+\n| [0] Salir\t\t \t|\n+-------------------------------+");
   Console.Write("\nSelecciona uno: ");

   stopwatch.Start();
   bool confirSuspencion = false;
   while (stopwatch.ElapsedMilliseconds < 10000)
   {
       if (Console.KeyAvailable)
       {
           try
           {
               char selec = Convert.ToChar(Console.ReadKey().KeyChar);
               if ((int)selec == 48)
               {
                   programa(dinero, porciento);
               }
               else if ((int)selec - 48 < 1 || (int)selec - 48 > caffe.Length / 3)
               {
                   Console.Clear(); goto selec;
               }
               for (int i = 0; i < caffe.Length / 3; i++)
               {
                   if ((int)selec - 48 == caffe[i, 0] + 1)
                   {
                       if (caffe[i, 1] > dinero)
                       {
                           Console.Write("\nCantidad de dinero insuficiente.");
                           Console.ReadKey();
                           repertir(dinero, porciento);
                       }
                       dinero -= caffe[i, 1];
                       Console.Clear();
                       Console.Write($"\nHas seleccionado: {caffe[i, 2]}\nDinero restante: ${dinero}");
                       Console.ReadKey(); Console.Clear();
                       confirSuspencion = true;
                   };
               }
               azucar(dinero, porciento);
               break;
           }
           catch (Exception)
           {
               Console.Clear(); goto selec;
           }
       }
       if (confirSuspencion == true)
       {
           break;
       }
   }
   if (confirSuspencion != true)
   {
       suspencion(num, dinero, porciento);
   }
}

static void funcJugos(char num, int dinero, double porciento)
{
selec:
   Stopwatch stopwatch = new Stopwatch();
   dynamic[,] jugos = { { 0, Convert.ToInt32(50-(50 * porciento)), "Manzana      " }, { 1, Convert.ToInt32(60-(60 * porciento)), "Mango        " }, { 2, Convert.ToInt32(45-(45 * porciento)), "Cereza       " } };

   Console.WriteLine("+-------------------------------+\n| Tipo de Jugos\t\t| Coste\t|\n+-------------------------------+");
   for (int i = 0; i < jugos.Length / 3; i++)
   {
       Console.WriteLine($"| [{jugos[i, 0] + 1}] {jugos[i, 2]}\t| ${jugos[i, 1]}\t|");
   }
   Console.WriteLine("+-------------------------------+\n| [0] Salir\t\t \t|\n+-------------------------------+");
   Console.Write("\nSelecciona uno: ");

   stopwatch.Start();
   bool confirSuspencion = false;
   while (stopwatch.ElapsedMilliseconds < 10000)
   {
       if (Console.KeyAvailable)
       {
           try
           {
               char selec = Convert.ToChar(Console.ReadKey().KeyChar);
               if ((int)selec == 48)
               {
                   programa(dinero, porciento);
               }
               else if ((int)selec - 48 < 1 || (int)selec - 48 > jugos.Length / 3)
               {
                   Console.Clear(); goto selec;
               }
               for (int i = 0; i < jugos.Length / 3; i++)
               {
                   if ((int)selec - 48 == jugos[i, 0] + 1)
                   {
                       if (jugos[i, 1] > dinero)
                       {
                           Console.Write("\nCantidad de dinero insuficiente.");
                           Console.ReadKey();
                           repertir(dinero, porciento);
                       }
                       dinero -= jugos[i, 1];
                       Console.Clear();
                       Console.Write($"\nHas seleccionado: {jugos[i, 2]}\nDinero restante: ${dinero}");
                       Console.ReadKey(); Console.Clear();
                       confirSuspencion = true;
                   };
               }
               azucar(dinero, porciento);
               break;
           }
           catch (Exception)
           {
               Console.Clear(); goto selec;
           }
       }
       if (confirSuspencion == true)
       {
           break;
       }
   }
   if (confirSuspencion != true)
   {
       suspencion(num, dinero, porciento);
   }
}

static void funcVatidas(char num, int dinero, double porciento)
{
selec:
   Stopwatch stopwatch = new Stopwatch();
   dynamic[,] vatidas = { { 0, Convert.ToInt32(90-(90 * porciento)), "Zapote       " }, { 1, Convert.ToInt32(80-(80 * porciento)), "Granadillo   " }, { 2, Convert.ToInt32(100-(100 * porciento)), "Lechoza      " } };

   Console.WriteLine("+-------------------------------+\n| Tipos de Vatidas\t| Coste\t|\n+-------------------------------+");
   for (int i = 0; i < vatidas.Length / 3; i++)
   {
       Console.WriteLine($"| [{vatidas[i, 0] + 1}] {vatidas[i, 2]}\t| ${vatidas[i, 1]}\t|");
   }
   Console.WriteLine("+-------------------------------+\n| [0] Salir\t\t \t|\n+-------------------------------+");
   Console.Write("\nSelecciona uno: ");

   stopwatch.Start();
   bool confirSuspencion = false;
   while (stopwatch.ElapsedMilliseconds < 10000)
   {
       if (Console.KeyAvailable)
       {
           try
           {
               char selec = Convert.ToChar(Console.ReadKey().KeyChar);
               if ((int)selec == 48)
               {
                   programa(dinero, porciento);
               }
               else if ((int)selec - 48 < 1 || (int)selec - 48 > vatidas.Length / 3)
               {
                   Console.Clear(); goto selec;
               }
               for (int i = 0; i < vatidas.Length / 3; i++)
               {
                   if ((int)selec - 48 == vatidas[i, 0] + 1)
                   {
                       if (vatidas[i, 1] > dinero)
                       {
                           Console.Write("\nCantidad de dinero insuficiente.");
                           Console.ReadKey();
                           repertir(dinero, porciento);
                       }
                       dinero -= vatidas[i, 1];
                       Console.Clear();
                       Console.Write($"\nHas seleccionado: {vatidas[i, 2]}\nDinero restante: ${dinero}");
                       Console.ReadKey(); Console.Clear();
                       confirSuspencion = true;
                   };
               }
               azucar(dinero, porciento);
               break;
           }
           catch (Exception)
           {
               Console.Clear(); goto selec;
           }
       }
       if (confirSuspencion == true)
       {
           break;
       }
   }
   if (confirSuspencion != true)
   {
       suspencion(num, dinero, porciento);
   }
}

static void funcEmpanadas(char num, int dinero, double porciento)
{
selec:
   Stopwatch stopwatch = new Stopwatch();
   dynamic[,] empanada = { { 0, Convert.ToInt32(40-(40 * porciento)), "Doble queso  " }, { 1, Convert.ToInt32(30-(30 * porciento)), "Pollo        " }, { 2, Convert.ToInt32(35-(35 * porciento)), "Jamon y queso" } };

   Console.WriteLine("+-------------------------------+\n| Tipos de Empadas\t| Coste\t|\n+-------------------------------+");
   for (int i = 0; i < empanada.Length / 3; i++)
   {
       Console.WriteLine($"| [{empanada[i, 0] + 1}] {empanada[i, 2]}\t| ${empanada[i, 1]}\t|");
   }
   Console.WriteLine("+-------------------------------+\n| [0] Salir\t\t \t|\n+-------------------------------+");
   Console.Write("\nSelecciona uno: ");

   stopwatch.Start();
   bool confirSuspencion = false;
   while (stopwatch.ElapsedMilliseconds < 10000)
   {
       if (Console.KeyAvailable)
       {
           try
           {
               char selec = Convert.ToChar(Console.ReadKey().KeyChar);
               if ((int)selec == 48)
               {
                   programa(dinero, porciento);
               }
               else if ((int)selec - 48 < 1 || (int)selec - 48 > empanada.Length / 3)
               {
                   Console.Clear(); goto selec;
               }
               for (int i = 0; i < empanada.Length / 3; i++)
               {
                   if ((int)selec - 48 == empanada[i, 0] + 1)
                   {
                       if (empanada[i, 1] > dinero)
                       {
                           Console.Write("\nCantidad de dinero insuficiente.");
                           Console.ReadKey();
                           repertir(dinero, porciento);
                       }
                       dinero -= empanada[i, 1];
                       Console.Clear();
                       Console.Write($"\nHas seleccionado: {empanada[i, 2]}\nDinero restante: ${dinero}");
                       Console.ReadKey(); Console.Clear();
                       confirSuspencion = true;
                   };
               }

               repertir(dinero, porciento);
               break;
           }
           catch (Exception)
           {
               Console.Clear(); goto selec;
           }
       }
       if (confirSuspencion == true)
       {
           break;
       }
   }
   if (confirSuspencion != true)
   {
       suspencion(num, dinero, porciento);
   }
}

static void funcSandwiches(char num, int dinero, double porciento)
{
selec:
   Stopwatch stopwatch = new Stopwatch();
   dynamic[,] sandwiches = { { 0, Convert.ToInt32(90-(90 * porciento)), "Jamon y queso" }, { 1, Convert.ToInt32(120-(120 * porciento)), "Completo     " }, { 2, Convert.ToInt32(80-(80 * porciento)), "De vegetales " } };

   Console.WriteLine("+-------------------------------+\n| Tipo de Sandwiches\t| Coste\t|\n+-------------------------------+");
   for (int i = 0; i < sandwiches.Length / 3; i++)
   {
       Console.WriteLine($"| [{sandwiches[i, 0] + 1}] {sandwiches[i, 2]}\t| ${sandwiches[i, 1]}\t|");
   }
   Console.WriteLine("+-------------------------------+\n| [0] Salir\t\t \t|\n+-------------------------------+");
   Console.Write("\nSelecciona uno: ");

   stopwatch.Start();
   bool confirSuspencion = false;
   while (stopwatch.ElapsedMilliseconds < 10000)
   {
       if (Console.KeyAvailable)
       {
           try
           {
               char selec = Convert.ToChar(Console.ReadKey().KeyChar);
               if ((int)selec == 48)
               {
                   programa(dinero, porciento);
               }
               else if ((int)selec - 48 < 1 || (int)selec - 48 > sandwiches.Length / 3)
               {
                   Console.Clear(); goto selec;
               }
               for (int i = 0; i < sandwiches.Length / 3; i++)
               {
                   if ((int)selec - 48 == sandwiches[i, 0] + 1)
                   {
                       if (sandwiches[i, 1] > dinero)
                       {
                           Console.Write("\nCantidad de dinero insuficiente.");
                           Console.ReadKey();
                           repertir(dinero, porciento);
                       }
                       dinero -= sandwiches[i, 1];
                       Console.Clear();
                       Console.Write($"\nHas seleccionado: {sandwiches[i, 2]}\nDinero restante: ${dinero}");
                       Console.ReadKey(); Console.Clear();
                       confirSuspencion = true;
                   };
               }

               repertir(dinero, porciento);
               break;
           }
           catch (Exception)
           {
               Console.Clear(); goto selec;
           }
       }
       if (confirSuspencion == true)
       {
           break;
       }
   }
   if (confirSuspencion != true)
   {
       suspencion(num, dinero, porciento);
   }
}

static void funcCombos(char num, int dinero, double porciento)
{
selec:
   Stopwatch stopwatch = new Stopwatch();
   dynamic[,] combito = { { 0, 200, "Completo   ", "1 Vatida De Lechoza + 1 Sandwich jamon y queso + 1 Empanada de pollo" }, { 1, 110, "Saludable  ", "1 Jugo De Cereza + 1 Sandwich de Vegetales                          " }, { 2, 160, "Despertino ", "1 Caffe Capuccino + 1 Sandwich de jamon y queso                     " } };
   Console.WriteLine("+------------------------------------------------------------------------------------------------+\n| Combo\t\t  | Complementos\t\t\t\t\t\t\t | Coste |\n+------------------------------------------------------------------------------------------------+");
   for (int i = 0; i < combito.Length / 4; i++)
   {
       Console.WriteLine($"| [{combito[i, 0] + 1}] {combito[i, 2]} | {combito[i, 3]} | ${combito[i, 1]}\t |");
   }
   Console.WriteLine("+------------------------------------------------------------------------------------------------+\n| [0] Salir\t\t \t\t\t\t\t\t\t\t\t |\n+------------------------------------------------------------------------------------------------+");
   Console.Write("\nSelecciona uno: ");
   stopwatch.Start();
   bool confirSuspencion = false;
   while (stopwatch.ElapsedMilliseconds < 10000)
   {
       if (Console.KeyAvailable)
       {
           try
           {
               char selec = Convert.ToChar(Console.ReadKey().KeyChar);
               if ((int)selec == 48)
               {
                   programa(dinero, porciento);
               }
               else if ((int)selec - 48 < 1 || (int)selec - 48 > combito.Length / 4)
               {
                   Console.Clear(); goto selec;
               }
               for (int i = 0; i < combito.Length / 4; i++)
               {
                   if ((int)selec - 48 == combito[i, 0] + 1)
                   {
                       if (combito[i, 1] > dinero)
                       {
                           Console.Write("\nCantidad de dinero insuficiente.");
                           Console.ReadKey();
                           repertir(dinero, porciento);
                       }
                       dinero -= combito[i, 1];
                       Console.Clear();
                       Console.Write($"\nHas seleccionado: {combito[i, 2]}\nDinero restante: ${dinero}");
                       Console.ReadKey(); Console.Clear();
                       confirSuspencion = true;
                   };
               }
               azucar(dinero, porciento);
               Console.ReadKey();
               repertir(dinero, porciento);
               break;
           }
           catch (Exception)
           {
               Console.Clear(); goto selec;
           }
       }
       if (confirSuspencion == true)
       {
           break;
       }
   }
   if (confirSuspencion != true)
   {
       suspencion(num, dinero, porciento);
   }
}

static void azucar(int dinero, double porciento)
{
   int azucar = 0;
   while (true)
   {
   azucar:
       try
       {
           Console.Clear();
           Console.Write($"Gramo de azucar a $2\n\nCuanta azucar desea (+/-): {azucar}\nDinero restante: ${dinero}");
           char cantidadAzucar = Console.ReadKey().KeyChar;

           if (cantidadAzucar == '+')
           {
               if (dinero > 0)
               {
                   azucar++;
                   dinero -= 2;
                   if (azucar > 6)
                   {
                       dinero += 2;
                       azucar--;
                   }
               }
               else
               {
                   Console.Clear();
                   Console.Write("Cantidad de dinero insuficiente.");
                   Console.ReadKey();
                   repertir(dinero, porciento);
               }
           }
           else if (cantidadAzucar == '-')
           {
               if (dinero > 0)
               {
                   azucar--;
                   dinero += 2;
                   if (azucar < 0)
                   {
                       dinero -= 2;
                       azucar++;
                   }
               }
               else
               {
                   Console.Clear();
                   Console.Write("Cantidad de dinero insuficiente.");
                   Console.ReadKey();
                   repertir(dinero, porciento);
               }
           }
           else if (cantidadAzucar == 13)
           {
               break;
           }
       }
       catch (Exception)
       {
           Console.Clear(); goto azucar;
       }
   }
   Console.Clear();
   Console.Write($"Gramos de azucar: {azucar}\nDinero restante ${dinero}");
   Console.ReadKey();
   repertir(dinero, porciento);
}

static void suspencion(char num, int dinero, double porciento)
{
   Stopwatch stopwatch = new Stopwatch();
   stopwatch.Start(); Console.Clear();
   while (stopwatch.ElapsedMilliseconds <= 10000)
   {

       if (!Console.KeyAvailable)
       {
           Console.CursorVisible = false;
           Console.Write("---WELCOME---"); // Mostrar la palabra con retorno de carro para sobrescribir.
           Thread.Sleep(500); // Esperar 0.5 segundos.
           Console.Clear();
           Thread.Sleep(500); // Esperar 0.5 segundos antes del siguiente parpadeo.
           Console.CursorVisible = true;

       }
       else
       {
           switch (num)
           {
               case '1':
                   funcCaffe(num, dinero, porciento);
                   break;
               case '2':
                   funcJugos(num, dinero, porciento);
                   break;
               case '3':
                   funcVatidas(num, dinero, porciento);
                   break;
               case '4':
                   funcEmpanadas(num, dinero, porciento);
                   break;
               case '5':
                   funcSandwiches(num, dinero, porciento);
                   break;
               case '6':
                   funcCombos(num, dinero, porciento);
                   break;
               default:
                   programa(dinero, porciento);
                   break;
           }
       }
   }

   if (stopwatch.ElapsedMilliseconds >= 10000)
   {
       Console.Write("Programa en reinicio...");
       Thread.Sleep(3000);
       Console.Clear();
       porciento = 0.00;
       main(dinero, porciento);
   }
}

static void repertir(int dinero, double porciento)
{
   Console.Clear();
   if (dinero <= 2)
   {
       fin(dinero, porciento);
   }
repetir:
   try
   {
       Console.Write($"Dinero restante: ${dinero}\n¿Desea hacer otra compra (Y/N)?\n");
       char repetir = Convert.ToChar(Console.ReadLine()!.ToUpper());

       if (repetir != 'Y' && repetir != 'N')
       {
           Console.Clear(); goto repetir;
       }
       else if (repetir == 'Y')
       {
           double[] descuentos = { 0.05, 0.1, 0.2 };
           Random random = new Random();
           if (random.Next(1, 3) == 2)
           {
               Console.Clear();
               porciento = descuentos[random.Next(0, descuentos.Length)];
               double descuento = porciento * 100;
               Console.WriteLine($"Descuento de {descuento}% a tu siguiente compra.\nNota: Los descuentos no aplican para combos.");
               Console.ReadKey();
           }

           programa(dinero, porciento);
       }
       else
       {
           fin(dinero, porciento);
       }
   }
   catch (Exception)
   {
       Console.Clear(); goto repetir;
   }
}

static void fin(int dinero, double porciento)
{
   Console.Clear();
   Console.WriteLine($"¡Gracias por tu compra! Hasta luego...\nDevuelta: ${dinero}");
   Thread.Sleep(5000);
   porciento = 0.00;
   main(dinero, porciento);
}

