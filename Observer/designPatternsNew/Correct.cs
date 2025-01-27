namespace designPatterns
{
    internal static class Correct
    {
    
        public interface IHub
        {
            public void Notify(ISub from, dynamic data);
            public void Add(ISub sub);
            public void Remove(ISub sub);
        }

        public interface ISub
        {
            public void Join(IHub hub);
            public void Leave();
            public void Update(dynamic data);
            public void Receive(dynamic data);
        }

        public class Hub : IHub
        {
            private readonly List<ISub> _subcribers = [];

            void IHub.Add(ISub sub)
            {
                _subcribers.Add(sub);
            }

            void IHub.Remove(ISub sub)
            {
                _subcribers.Remove(sub);
            }

            void IHub.Notify(ISub from, dynamic data)
            {
                _subcribers.ForEach(x => { if (x != from) x.Receive(data); });
            }
        }

        public class Sub(string x) : ISub
        {
            private IHub? _hub;
            private string _name = x;
            public void Join(IHub hub)
            {
                _hub = hub;
                _hub.Add(this);
            }

            public void Leave()
            {
                _hub?.Remove(this);
                _hub = null;
            }

            public void Receive(dynamic data)
            {
                Console.WriteLine($"{_name}: {data}");
            }

            public void Update(dynamic data)
            {
                _hub?.Notify(this, data);
            }
        }


    }
}
