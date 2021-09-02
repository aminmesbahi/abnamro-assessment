using Assessment.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Assessment.Api.Services
{
    public interface ICalculationService
    {
        public Guid CreateNew(int inputValue);
        public bool IsExist(Guid requestId);
        public bool Remove(Guid requestId);
        public List<Calculation> GetCalculationList();
        public Calculation GetCalculation(Guid id);
        public Status GetCalculationStatus(Guid id);
        public Task Calculate(Guid id, CancellationToken cancellationToken);
        public List<Calculation> Calculations { get; }

    }
    public class InMemoryCalculationService : ICalculationService
    {
        List<Calculation> calculations;
        public InMemoryCalculationService()
        {
            calculations = new List<Calculation>();
        }
        public List<Calculation> Calculations { get { return calculations; } }
        public Guid CreateNew(int inputValue)
        {
            Guid id = Guid.NewGuid();
            calculations.Add(new Calculation(id, inputValue));
            return id;
        }
        public List<Calculation> GetCalculationList()
        {
            return calculations;
        }
        public Calculation GetCalculation(Guid id)
        {
            return calculations.Where(c => c.Id == id).FirstOrDefault();
        }
        public Status GetCalculationStatus(Guid id)
        {
            return calculations.Where(c => c.Id == id).FirstOrDefault().Status;
        }
        public bool IsExist(Guid requestId)
        {
            if (calculations.Where(c => c.Id == requestId).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task Calculate(Guid id, CancellationToken cancellationToken)
        {
            var rnd = new Random();
            var time = rnd.Next(20, 60);
            calculations.Where(c => c.Id == id).FirstOrDefault().Status.State = State.Running.ToDescriptionString();
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(time*10);
                calculations.Where(c => c.Id == id).FirstOrDefault().Status.Progress += 1;
            }
            var inputVal = calculations.Where(c => c.Id == id).FirstOrDefault().InputValue;
            calculations.Where(c => c.Id == id).FirstOrDefault().Status.Result = time + inputVal;
            calculations.Where(c => c.Id == id).FirstOrDefault().Status.State = State.Completed.ToDescriptionString();
        }
        public bool Remove(Guid requestId)
        {
            if (IsExist(requestId))
            {
                return false;
            }
            else
            {
                calculations.Remove(calculations.Where(c => c.Id == requestId).First());
                return true;
            }
        }
    }
}
