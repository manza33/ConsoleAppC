using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        protected String name;
        //test

        public Animal(String name)
        {
            this.name = name;
            Console.WriteLine("Un Animal de type '" + this.name + "' vient de naître...");
        }

        public Animal() : this("Un Animal quelconque")
        {
        }

        public abstract void crier();
    }

    public abstract class Felin : Animal
    {
        public Felin(String name) : base(name)
        {
            Console.WriteLine("Un Felin de type '" + this.name + "' vient de naître...");
        }

        public Felin() : this("Un Felin quelconque")
        {
        }


        //        public override void crier() {
        //            Console.WriteLine("Veuillez le spécifier dans la classe utilisée (" + this.GetType() + ") !");
        //        }
    }

    public class Canin : Animal
    {
        public Canin(String name) : base(name)
        {
            Console.WriteLine("Un Canin de type '" + this.name + "' vient de naître...");
        }

        public Canin() : this("Un Canin quelconque")
        {
        }

        public override void crier()
        {
            Console.WriteLine("Veuillez le spécifier dans la classe utilisée (" + this.GetType() + ") !");
        }
    }

    public class Lion : Felin
    {
        public Lion(String name) : base(name)
        {
            Console.WriteLine("Un Lion de type '" + this.name + "' vient de naître...");
        }

        // Ici, nous ne mettons pas "this" (qui appelle l'objet lui même) 
        // mais "base" qui appelle l'objet "parent" donc Felin
        public Lion() : base("Un Lion quelconque")
        {
        }

        public override void crier()
        {
            Console.WriteLine("Je rugis dans la savane!");
        }
    }

    public class Chat : Felin
    {
        public Chat(String name) : base(name)
        {
            Console.WriteLine("Un Chat de type '" + this.name + "' vient de naître...");
        }

        public Chat() : this("Un Chat quelconque")
        {
        }

        public override void crier()
        {
            Console.WriteLine("Je miaule dans tes jambes!");
        }
    }

    public class Loup : Canin
    {
        public Loup(String name) : base(name)
        {
            Console.WriteLine("Un Loup de type '" + this.name + "' vient de naître...");
        }

        public Loup() : this("Un Loup quelconque")
        {
        }

        public override void crier()
        {
            Console.WriteLine("Je hurle sous la Lune!");
        }
    }

    public class Chien : Canin
    {
        public Chien(String name) : base(name)
        {
            Console.WriteLine("Un Chien de type '" + this.name + "' vient de naître...");
        }

        public Chien() : this("Un Chien quelconque")
        {
        }

        public override void crier()
        {
            Console.WriteLine("J'abboie sur le facteur!");
        }
    }

    public class Hyene : Canin
    {
        public Hyene(String name) : base(name)
        {
            Console.WriteLine("Un Hyene de type '" + this.name + "' vient de naître...");
        }

        public Hyene() : this("Un Hyene quelconque")
        {
        }

        // ICI, je ne déclare ni sur-charge la méthode "crier()", 
        // lors d'un appel "hyene.crier()", c'est la méthode dans "Canin.crier()" qui sera appelée


    }

    public class Program
    {
        // Fonction "Main" est la première fonction executée au démarrage d'un programme
        public static void Main(string[] args)
        {
            // Console.WriteLine permet l'affichage d'une ligne de texte sur la console
            Console.WriteLine("Bienvenue dans le règne animal!");

            Console.WriteLine("*******************************");
            Console.WriteLine("Instanciation d'une variable LION!");
            Animal lion = new Lion();
            Console.WriteLine("Je vais faire 'crier()' la variable LION !");
            lion.crier();

            Console.WriteLine("*******************************");
            Console.WriteLine("Instanciation d'une variable CHAT!");
            Animal chat = new Chat("Marc");
            Console.WriteLine("Je vais faire 'crier()' la variable CHAT !");
            chat.crier();

            Console.WriteLine("*******************************");
            Console.WriteLine("Instanciation d'une variable LOUP!");
            Animal loup = new Loup("Morgane");
            Console.WriteLine("Je vais faire 'crier()' la variable LOUP !");
            loup.crier();

            Console.WriteLine("*******************************");
            Console.WriteLine("Instanciation d'une variable CHIEN!");
            Animal chien = new Chien("Manon");
            Console.WriteLine("Je vais faire 'crier()' la variable CHIEN !");
            chien.crier();

            Console.WriteLine("*******************************");
            Console.WriteLine("Instanciation d'une variable HYENE!");
            Animal hyene = new Hyene();
            Console.WriteLine("Je vais faire 'crier()' la variable HYENE !");
            hyene.crier();

        }
    }

}
