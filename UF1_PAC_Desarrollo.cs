using System;

namespace PAC_desarrollo_UF1
{
    class PAC_desarrollo_UF1
    {
        static void Main(string[] args)
        {
            //La variable almacena los datos leidos del teclado.
            string s;
            //La variable indica el Nº de filas de una Matriz
            int row;
            //La variable para indicar el Nº de columnas de una Matriz
            int column;
            //Variable Matriz A
            int[,] m_A;
            //Variable Matriz B
            int[,] m_B;
            //Variable para controlar si dos matrices son iguales, se inicializa a "verdad". 
            bool equal = true;

            /* Primero se deberá pedir el número de filas y de columnas que deberá tener la primera matriz*/
            Console.Clear();
            Console.Write("Por favor, añadir un Nº entero [1 - n] de FILAS de la 1ª Matriz A:");
            s = Console.ReadLine();
            //Se verifica el dato "Filas" entero en el intervalo [1..n] 
            while ((!int.TryParse(s, out row)) || (row <= 0))
            {
                Console.WriteLine("¡ERROR! dato no válido");
                Console.Write("Agregue un Nº entero positivo en el intervalo [1 - n], FILAS 1ª Matriz A:");
                s = Console.ReadLine();
            }

            Console.Write("Por favor, añadir un Nº entero [1 - n] de COLUMNAS de la 1ª Matriz A:");
            s = Console.ReadLine();
            //Se verifica el dato "Filas" entero en el intervalo [1..n]        
            while ((!int.TryParse(s, out column)) || (column <= 0))
            {
                Console.WriteLine("¡ERROR! dato no válido.");
                Console.Write("Agregue un Nº entero positivo en el intervalo [1 - n], COLUMNAS 1ª Matriz A:");
                s = Console.ReadLine();
            }
            //inicializar la variable 1ª matriz A e informamos al usuario
            m_A = new int[row, column];
            Console.WriteLine("Matriz A de {0} filas x {1} columnas", row, column);
            Console.WriteLine();

            /* 2º Se deberá pedir el número de filas y de columnas que deberá tener la segunda matriz*/
            Console.Write("Por favor, añadir un Nº entero [1 - n] de FILAS de la 2ª Matriz B:");
            s = Console.ReadLine();
            //Se verifica el dato "Filas" entero en el intervalo [1..n] 
            while ((!int.TryParse(s, out row)) || (row <= 0))
            {
                Console.WriteLine("¡ERROR! dato no válido.");
                Console.Write("Agregue un Nº entero positivo en el intervalo [1 - n], FILAS 2ª Matriz B:");
                s = Console.ReadLine();
            }

            Console.Write("Por favor, añadir un Nº entero [1 - n] de COLUMNAS de la 2ª Matriz B:");
            s = Console.ReadLine();
            //Se verifica el dato "Filas" entero en el intervalo [1..n]        
            while ((!int.TryParse(s, out column)) || (column <= 0))
            {
                Console.WriteLine("¡ERROR! dato no válido.");
                Console.Write("Agregue un nº entero positivo en el intervalo [1 - n], COLUMNAS 2ª Matriz B:");
                s = Console.ReadLine();
            }
            //inicializar la variable 2ª matriz B e informamos al usuario
            m_B = new int[row, column];
            Console.WriteLine("Matriz B de {0} filas x {1} columnas", row, column);
            Console.WriteLine();

            /* 3º El usuario agregará los elementos de la primera matriz*/
            Console.Write("Agregar los elementos de la 1ª Matriz A de {0}x{1}. ", m_A.GetLength(0), m_A.GetLength(1));
            Console.WriteLine("Si un elemento no es un Nº Entero, se pedirá de nuevo.");
            for (int i = 0; i < m_A.GetLength(0); i++)
                for (int j = 0; j < m_A.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write("Por favor, agregue el elemento de la 1ª Matriz A[{0},{1}]:", i, j);
                        s = Console.ReadLine();
                    } while (!int.TryParse(s, out m_A[i, j]));
                }

            /* 4º El usuario agregará los elementos de la segunda matriz*/
            Console.WriteLine();
            Console.Write("Agregar los elementos de la 2º Matriz B de {0}x{1}. ", m_B.GetLength(0), m_B.GetLength(1));
            Console.WriteLine("Si un elemento no es un Nº Entero, se pedirá de nuevo.");
            for (int i = 0; i < m_B.GetLength(0); i++)
                for (int j = 0; j < m_B.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write("Por favor, agregue el elemento de la 2ª Matriz B[{0},{1}]:", i, j);
                        s = Console.ReadLine();
                    } while (!int.TryParse(s, out m_B[i, j]));
                }

            /* 5º Se mostrará por pantalla el contenido de la primera matriz*/
            Console.WriteLine();
            Console.Write("1ª Matriz A de " + m_A.GetLength(0) + " filas x " + m_A.GetLength(1) + " columnas:");
            for (int i = 0; i < m_A.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m_A.GetLength(1); j++)
                {
                    Console.Write(m_A[i, j] + " \t");
                }
            }
            //Salto de linea para "formatear salida"
            Console.WriteLine();
            Console.Write("Pulsar 'Intro' para continuar");
            Console.ReadLine();

            /* 6º Se mostrará por pantalla el contenido de la segunda matriz*/
            Console.WriteLine();
            Console.Write("2ª Matriz B de " + m_B.GetLength(0) + " filas x " + m_B.GetLength(1) + " columnas:");
            for (int i = 0; i < m_B.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m_B.GetLength(1); j++)
                {
                    Console.Write(m_B[i, j] + " \t");
                }
            }
            //Salto de línea para "formatear salida"
            Console.WriteLine();
            Console.Write("Pulsar 'Intro' para Cerrar programa \t Autor: Rubén Gámez Torrijos");
            Console.ReadLine();

            /* 7º El programa debería comprobar si las matrices se pueden comparar o no con la siguiente salida en pantalla:
                 "Las matrices no pueden ser comparadas"
                 "Las matrices pueden ser comparadas"
            Si las matrices pueden ser comparadas, deberán salir los siguientes mensajes en pantalla:
                 "Las matrices son iguales"
                 "Las matrices no son iguales"*/
            //Dos matrices se pueden comparar si tienen el mismo tamaño n filas x m columnas.  
            if (((m_A.GetLength(0) == m_B.GetLength(0))) && (m_A.GetLength(1) == m_B.GetLength(1)))
            {
                Console.WriteLine();
                Console.WriteLine("Las matrices pueden ser comparadas");
                /* Comparamos elememto a elemento de cada matriz. 
                   Si detecta una desigualdad no es necesario recorrer el resto de elementos de las matrices.*/
                for (int i = 0; (i < row) && (equal); i++)
                {
                    for (int j = 0; (j < column) && (equal); j++)
                    {
                        if (m_A[i, j] != m_B[i, j])
                        {
                            equal = false;
                        }
                    }
                }
                if (equal)
                {
                    Console.WriteLine();
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Las matrices NO son iguales");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Las matrices MO pueden ser comparadas");
            }
        }
    }
}
