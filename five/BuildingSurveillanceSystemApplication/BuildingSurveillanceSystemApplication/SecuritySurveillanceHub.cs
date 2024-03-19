using System;
namespace BuildingSurveillanceSystemApplication
{
	public class SecuritySurveillanceHub : IObservable<ExternalVisitor>
    {
        private List<ExternalVisitor> _externalVisitorList;
        private List<IObserver<ExternalVisitor>> _observerList;

        public SecuritySurveillanceHub()
        {
            _externalVisitorList = new List<ExternalVisitor>();
            _observerList = new List<IObserver<ExternalVisitor>>();
        }

        public IDisposable Subscribe(IObserver<ExternalVisitor> observer)
        {
            if (!_observerList.Contains(observer))
                _observerList.Add(observer);// add observer to the observer list

            foreach (var externalVisitor in _externalVisitorList)
                observer.OnNext(externalVisitor);

            return new UnSubscriber<ExternalVisitor>(_observerList, observer);

        }

        public void ConfirmExternalVisitorEntersBuilding(int id, string firstName, string lastName, string companyName, string jobTitle, DateTime entryDateTime, int employeeContactId)
        {
            ExternalVisitor externalVisitor = new ExternalVisitor
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                CompanyName = companyName,
                JobTitle = jobTitle,
                EntryDateTime = entryDateTime,
                InBuilding = true,
                EmployeeContactId = employeeContactId
            };

            _externalVisitorList.Add(externalVisitor);

            foreach (var observer in _observerList)
                observer.OnNext(externalVisitor);

        }
        public void ConfirmExternalVisitorExitsBuilding(int externalVisitorId, DateTime exitDateTime)
        {
            var externalVisitor = _externalVisitorList.FirstOrDefault(e => e.Id == externalVisitorId);

            if (externalVisitor != null)
            {
                externalVisitor.ExitDateTime = exitDateTime;
                externalVisitor.InBuilding = false;

                foreach (var observer in _observerList)
                    observer.OnNext(externalVisitor);
            }
        }
        public void BuildingEntryCutOffTimeReached()
        {
            if (_externalVisitorList.Any(e => e.InBuilding == true))
            {
                return;
            }

            foreach (var observer in _observerList)
                observer.OnCompleted();
        }
    }

}

