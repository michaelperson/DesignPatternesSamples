using System.Collections.ObjectModel;

namespace designPatterns
{
    internal static class Correct
    {
    
        internal interface IHub
        {
            
            void Notify(ISub from, dynamic data);
            void Add(ISub sub);
            void Remove(ISub sub);
        }

        internal interface ISub
        {
            void Join(IHub hub);
            void Leave();
            void Update(dynamic data);
            void Receive(dynamic data);
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
            private readonly string _name = x;
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
