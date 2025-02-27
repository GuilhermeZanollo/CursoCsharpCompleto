using System;
using Projeto41.Entities;
using Projeto41.Entities.Exceptions;

namespace Projeto41
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Problema exemplo
                 Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data de entrada e data de saída) e mostrar
                os dados da reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e
                mostrar novamente a reserva com os dados de entrada e saída, atualizar a reserva, e mostrar novamente a reserva com os dados 
                atualizados. O programa não deve aceitar os dados inválidos para a reserva, conforme as seguintes regras:
                - Alterações de reserva só podem ocorrer para datas futuras
                - A data de saída deve ser maior que a data de entrada


                OBSERVAÇÃO: ESSE É UM MÉTODO MT RUIM, FAREMOS UM MÉTOODO RUIM NO PRÓXIMO PROJETO (40)  E UM DE TRATAMENTO DE EXCEÇÕES NO (41)
                */
            try // bloco para tentar executar tudo isso
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut); // Na hora de executar esse construtor, gerou uma exceção
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut); // Na hora de executar o updatedates, dentro do método foi verificado as condições
                Console.WriteLine("Reservation: " + reservation);
            } 
            catch (DomainException e) // possiveis exceções do meu programa
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            } 
        }
    }
}

