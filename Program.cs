using System;
using Projeto_DIO.src.Entities;

namespace Projeto_DIO {

    class Program {

        static void Main(string[] args) {

            Knight arus = new Knight("Arus", 23, "Knight");
            Wizards wizard = new Wizards("Jenica", 25, "White Wizard");
            blackWizard blackmagic = new blackWizard ("Breno", 45, "Black Wizard");
            Ninja ninja = new Ninja("Oshikuru", 50, "Ninja");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(blackmagic.Attack(6));
            Console.WriteLine(ninja.Attack(8));

        }

    }
}