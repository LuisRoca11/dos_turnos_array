// Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde).
// Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
// Imprimir los gastos en sueldos de cada turno.

using System;
using System.Diagnostics.CodeAnalysis;

namespace dos_turnos_array
{
    class dos_turnos_array
    {
        private float[] turnoMan;
        private float[] turnoTar;

        float suma1 = 0;
        float suma2 = 0;


        public void Cargar()
        {
            turnoMan = new float[4];
            turnoTar = new float[4];


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el sueldo {i + 1} de la mañana: ");
                turnoMan[i] = float.Parse(Console.ReadLine());
                suma1 = suma1 + turnoMan[i];
            }

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"Ingrese el sueldo {j + 1} de la tarde: ");
                turnoTar[j] = float.Parse(Console.ReadLine());
                suma2 = suma2 + turnoTar[j];
            }

        }

        public void Imprimir()
        {
            //suma1 = suma1 + turnoMan[i];
            //suma2 = suma2 + turnoTar[j];
            Console.WriteLine($"La suma de los sueldos de la mañana es: {suma1}");
            Console.WriteLine($"La suma de los sueldos de la tarde es: {suma2}");
        }

        static void Main(string[] args)
        {
            dos_turnos_array pv = new dos_turnos_array();
            pv.Cargar();
            pv.Imprimir();
        }
        
    }
}