﻿using System.Drawing;
char opcion = ' ';
string[,] cubo = { { "▄▄","▄▄" } ,
                   { "▄▄","▄▄"}};
string[,] L = { { "[]" },{ "[]"} };
string vacio = "[]";
string[,] tablerov = { { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },
                       { "[]" ,"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]" },};
while (opcion != 's')
{
    
    Console.WriteLine("Bienvenido a TETRIS: \n[I]Iniciar\n[S]Salir");
    opcion = char.Parse(Console.ReadLine().ToLower());
    switch (opcion)
    {
        case 'i':
            tetris();
            break;

        default:
            Console.WriteLine("ingrese una opcion valida");
            break;
    }

}
void tetris()
{
    int i= 0;
    char finciclo = ' ';
    while (finciclo != 's')
    {

        tablero();
        if (tablerov[18,0] == cubo[0,0] && tablerov[18,1] == cubo[0,1] && tablerov[19, 0] == cubo[1,0] && tablerov[19, 1] == cubo[1,1] )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FIIIIIIIIIIIIIIIIIIIIIIIIIIIIIN");
            finciclo = 's';
        }
        else
        {
            if(i!=0)
            { 
                tablerov[i - 1,0] = vacio;
                tablerov[i - 1,1] = vacio;
            }
            tablerov[i, 0] = cubo[0, 0];
            tablerov[i, 1] = cubo[0, 1];
            tablerov[i+1, 0] = cubo[1, 0];
            tablerov[i+1, 1] = cubo[1, 1];
            i++;
            
        }
      


        


    }
}
void tablero()
{
    //Console.Clear();
    char finciclo = ' ';
    int lineahecha=0;
    string pieza = "";
   
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("-------------");
    Console.ForegroundColor= ConsoleColor.Red;
    Console.Write("T");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("E");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("T");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("R");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("I");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("S");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("--------------");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    //filas=i
  for (int i = 0; i<=19; i++)
    {
        //linea
      
            if (i == 0)
            {
                Console.Write("     Lineas ");
            }
            if (i == 1)
            {
                Console.Write(lineahecha + "           ");
            }
            if (i != 0 && i != 1)
            {
                Console.Write("            ");
            }
            Console.Write(tablerov[i, 0] + tablerov[i, 1] + tablerov[i, 2] + tablerov[i, 3] + tablerov[i, 4] + tablerov[i, 5] +
                 tablerov[i, 6] + tablerov[i, 7] + tablerov[i, 8] + tablerov[i, 9]);
        Console.WriteLine();
        
  
    }





}
