namespace designPatterns
{
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

        interface IObs
        {
            void Update();
        }

        class Sub
        {
            private List<IObs> observerList = [];
            public void addObserver(IObs x)
            {
                observerList.Add(x);
            }

            public void Notify()
            {
                observerList.ForEach(x => x.Update());
            }
        }

        class TestObject(string x) : IObs
        {
            public string name { get; private set; } = x;
            void IObs.Update()
            {
                Console.WriteLine($"{name}: Update Received !");
            }
        }
    }
}
