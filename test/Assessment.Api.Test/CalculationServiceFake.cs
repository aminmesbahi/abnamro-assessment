using Assessment.Api.Models;
using Assessment.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assessment.Api.Test
{
    class CalculationServiceFake : ICalculationService
    {
        public List<Calculation> Calculations { get { return _calculations; } }
        private readonly List<Calculation> _calculations;
        public CalculationServiceFake()
        {
            _calculations = new List<Calculation>()
            {
                new Calculation() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c100"),
                    InputValue = 10, Status= new Status(){ Progress=10, Result=-1, State=State.Running.ToDescriptionString() } },
                new Calculation() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    InputValue = 20, Status= new Status(){ Progress=20, Result=-1, State=State.Running.ToDescriptionString() } },
                new Calculation() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c300"),
                    InputValue = 30, Status= new Status(){ Progress=100, Result=40, State=State.Completed.ToDescriptionString() } }
            };
        }

        public async Task Calculate(Guid id, string conId, CancellationToken cancellationToken)
        {
            var rnd = new Random();
            var time = 30;
            _calculations.Where(c => c.Id == id).FirstOrDefault().Status.State = State.Running.ToDescriptionString();
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(time * 10);
                _calculations.Where(c => c.Id == id).FirstOrDefault().Status.Progress += 1;
            }
            var inputVal = _calculations.Where(c => c.Id == id).FirstOrDefault().InputValue;
            _calculations.Where(c => c.Id == id).FirstOrDefault().Status.Result = time + inputVal;
            _calculations.Where(c => c.Id == id).FirstOrDefault().Status.State = State.Completed.ToDescriptionString();

        }

        public Guid CreateNew(int inputValue, string conId)
        {
            Guid id = Guid.NewGuid();
            _calculations.Add(new Calculation(id, inputValue, conId));
            return id;
        }

        public Calculation GetCalculation(Guid id)
        {
            return _calculations.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Calculation> GetCalculationList()
        {
            return _calculations;
        }

        public Status GetCalculationStatus(Guid id)
        {
            return _calculations.Where(c => c.Id==id).FirstOrDefault().Status;
        }

        public bool IsExist(Guid requestId)
        {
            if (_calculations.Where(c => c.Id == requestId).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(Guid requestId)
        {
            if (IsExist(requestId))
            {
                return false;
            }
            else
            {
                _calculations.Remove(_calculations.Where(c => c.Id == requestId).First());
                return true;
            }
        }
    }
}
