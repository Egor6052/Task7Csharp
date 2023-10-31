using System;
using System.Collections.Generic;

namespace App7
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            QueuePatients patient1 = new QueuePatients( 1, "Max", "Ilchishin", 12 );
            QueuePatients patient2 = new QueuePatients( 2, "Andrei", "Andrich", 5 );
            QueuePatients patient3 = new QueuePatients( 3, "Petya", "Sergeev",30 );
            QueuePatients patient4 = new QueuePatients( 4, "Nikolas", "Tkachuk", 9);
            Patient patients = new Patient();
            
            // Добавление пациентов в список;
            patients.AddPatient(patient1);
            patients.AddPatient(patient2);
            patients.AddPatient(patient3);
            patients.AddPatient(patient4);
            
            // Вывод исходного списка пациентов;
            Console.WriteLine("\nИсходный список пациентов: ");
            foreach (QueuePatients patient in patients.PatientsInQueue())
            {
                Console.WriteLine(patient.ToString());
            } 
            
            // Поиск и вывод пациента по индексу;
            Console.WriteLine($"\nПоиск пациента с индексом 1: \n{ patients.FindPatientId(1) }\n");
            
            // Удаление пациента по индексу;
            Console.WriteLine("Удаление пациента по id с номером 1 ");
            patients.RemovePatirnt(patients.FindPatientId(1));
            
            // Вывод итогового списка пациентов;
            Console.WriteLine("\n\nИтоговый список пациентов: ");
            foreach (QueuePatients patient in patients.PatientsInQueue())
            {
                Console.WriteLine(patient.ToString());
            }
        }
    }
}