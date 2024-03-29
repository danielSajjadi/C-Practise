﻿using System;
namespace BuildingSurveillanceSystemApplication
{
    /**
     * the abstract class Observer is there to make the base of observer subject with the help of interface IObserver
     */
    public abstract class Observer : IObserver<ExternalVisitor>
    {
        IDisposable? _cancellation ;
        protected List<ExternalVisitor> _externalVisitors = new(); //List<ExternalVisitor>();

        public abstract void OnCompleted();

        public abstract void OnError(Exception error);

        public abstract void OnNext(ExternalVisitor value);

        // to subscribe the observable object
        public void Subscribe(IObservable<ExternalVisitor> provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public void UnSubscribe()
        {
            _cancellation?.Dispose();
            _externalVisitors.Clear();
        }
    }
}