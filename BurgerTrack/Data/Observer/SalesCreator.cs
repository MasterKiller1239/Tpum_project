using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Observer
{
    public class SalesCreator : IObservable<Burvent>
    {
        private IList<IObserver<Burvent>> observers;

        public SalesCreator()
        {
            observers = new List<IObserver<Burvent>>();
        }

        public IDisposable Subscribe(IObserver<Burvent> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        public class Unsubscriber : IDisposable
        {
            private IList<IObserver<Burvent>> _observers;
            private IObserver<Burvent> _observer;

            public Unsubscriber(IList<IObserver<Burvent>> observers, IObserver<Burvent> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                Dispose(true);
            }
            private bool _disposed = false;
            protected virtual void Dispose(bool disposing)
            {
                if (_disposed)
                {
                    return;
                }
                if (disposing)
                {
                    if (_observer != null && _observers.Contains(_observer))
                    {
                        _observers.Remove(_observer);
                    }
                }
                _disposed = true;
            }
        }
        public void Sale(Burvent burger)
        {
            foreach (var observer in observers)
            {
                if (burger == null)
                {
                    observer.OnError(new ArgumentNullException());
                }
                observer.OnNext(burger);
            }
        }
        public void End()
        {
            foreach (var observer in observers.ToArray())
            {
                observer.OnCompleted();
            }
            observers.Clear();
        }
    }
}
