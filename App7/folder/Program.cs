using System;
using System.Collections.Generic;

namespace App7
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Patient patient1 = new Patient( 1, "Max", "Ilchishin", 12 );
            Patient patient2 = new Patient( 2, "Andrei", "Andrich", 5 );
            Patient patient3 = new Patient( 3, "Petya", "Sergeev",30 );
            Patient patient4 = new Patient( 4, "Nikolas", "Tkachuk", 9);
            QueuePatients queuePatientsS = new QueuePatients();
            
            // Добавление пациентов в список;
            queuePatientsS.AddPatient(patient1);
            queuePatientsS.AddPatient(patient2);
            queuePatientsS.AddPatient(patient3);
            queuePatientsS.AddPatient(patient4);
            
            // Вывод исходного списка пациентов;
            Console.WriteLine("\nИсходный список пациентов: ");
            foreach (Patient patient in queuePatientsS.PatientsInQueue())
            {
                Console.WriteLine(patient.ToString());
            } 
            
            // Поиск и вывод пациента по индексу;
            Console.WriteLine($"\nПоиск пациента с индексом 1: \n{ queuePatientsS.FindPatientId(1) }\n");
            
            // Удаление пациента по индексу;
            Console.WriteLine("Удаление пациента по id с номером 1 ");
            queuePatientsS.RemovePatient();
            
            // Вывод итогового списка пациентов;
            Console.WriteLine("\n\nИтоговый список пациентов: ");
            foreach (Patient patient in queuePatientsS.PatientsInQueue())
            {
                Console.WriteLine(patient.ToString());
            }
        }
    }
}