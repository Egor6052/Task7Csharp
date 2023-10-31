using System;
using System.Collections.Generic;

namespace App7
{
    public class Patient
    {
        // Использование Queue по условию задачи;
        Queue<QueuePatients> queuePatients = new Queue<QueuePatients>();

        /// <summary>
        /// Добавление нового пациента в очередь.
        /// </summary>
        /// <param name="newPatient">Новая запись</param>
        /// <exception cref="ArgumentException">В случае, если пациент с таким Id уже есть в очереди.</exception>
        public void AddPatient(QueuePatients newPatient)
        {
            if (!queuePatients.Contains(newPatient))
            {
                queuePatients.Enqueue(newPatient);
            }
            else
            {
                throw new ArgumentException("Пациент с таким Id уже есть в очереди.");
            }
        }

        /// <summary>
        /// Извлечение первого пациента из очереди.
        /// </summary>
        /// <param name="findPatientId">Поиск по id</param>
        /// <returns>Первый пациент в очереди</returns>
        /// <exception cref="InvalidOperationException">В случае, если очередь пуста.</exception>
        public QueuePatients RemovePatirnt(QueuePatients findPatientId)
        {
            if (queuePatients.Count > 0)
            {
                return queuePatients.Dequeue();
            }
            else
            {
                throw new InvalidOperationException("Очередь пуста.");
            }
        }

        /// <summary>
        /// Поиск записи пациента по id в очереди.
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns>Пациент из очереди</returns>
        /// <exception cref="ArgumentException">В случае, если такой записи нет в очереди.</exception>
        public QueuePatients FindPatientId(int patientId)
        {
            foreach (QueuePatients queuePatient in queuePatients)
            {
                if (queuePatient.Id == patientId)
                {
                    return queuePatient;
                }
            }
            throw new ArgumentException("Записи не найдено.");
        }

        /// <summary>
        /// Вывод всех пациентов в очереди.
        /// </summary>
        /// <returns>Все элементы очереди.</returns>
        public Queue<QueuePatients> PatientsInQueue()
        {
            return queuePatients;
        }
    }
}
