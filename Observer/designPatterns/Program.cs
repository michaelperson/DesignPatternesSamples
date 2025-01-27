namespace designPatterns
{
    //Attention c'est à l'envers ---A refondre
    internal class Program
    {
        //Observer Pattern
        //Permet de notifier les objets entre eux a partir d'un/de plusieurs évenement
        //Le sujet est le "centre" qui contient tout les objets observer
        //si un observer produit un évenement il envoie une notification au sujet qui la relaye au autre observer
        static void Main(string[] args)
        {
            Sub subject = new();

            TestObject obj1 = new("obj1");
            TestObject obj2 = new("obj2");
            TestObject obj3 = new("obj3");

            

            subject.addObserver(obj1);
            subject.addObserver(obj2);
            subject.addObserver(obj3);

            while (true)
            {
                Console.Write(">");
                string? lineIn = Console.ReadLine();
                switch (lineIn)
                {
                    case "update":
                        subject.Notify();
                        break;
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// sert à regrouper les objets qui peuvent être des observer
        /// et définir la méthode utilisée pour répercuter les changements d'états
        /// </summary>
        interface IObs
        {
            void Reaction();
            void addObserve();

        }

        interface IRegarder
        {
            void Notify();
        }

        /// <summary>
        /// Sub = Subject ??? 
        /// Contient les mattés --> style recherche sur un site de rencontre
        /// </summary>
        class Sub
        {
            private List<IObs> observerList = [];
            /// <summary>
            /// Ceux qui mattent
            /// </summary>
            /// <param name="x">nom du mateur</param>
            public void addObserver(IObs x)
            {
                observerList.Add(x);
            }

            /// <summary>
            /// Un cri dans la nuit
            /// </summary>
            public void Notify()
            {
                observerList.ForEach(x => x.Reaction());
            }
        }

        /// <summary>
        /// Ceux qui observe
        /// </summary>
        /// <param name="x">donner un nom pour afficher dans la console</param>
        class TestObject(string x) : IObs
        {
            public string name { get; private set; } = x;
            void IObs.Reaction()
            {
                
                Console.WriteLine($"{name}: Update Received !");
            }
        }
    }
}
