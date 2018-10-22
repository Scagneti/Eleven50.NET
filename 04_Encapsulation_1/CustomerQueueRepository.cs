using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_1
{
	public class CustomerQueueRepository
	{
		private Queue<Customer> _CustomerQueue;

		public CustomerQueueRepository()
		{
			_CustomerQueue = new Queue<Customer>();
		}

		public Queue<Customer> GetClientQueue()
		{
			return _CustomerQueue;
		}

		public void AddCustomerToQueue(Customer caller)
		{
			_CustomerQueue.Enqueue(caller);
		}
		public Customer RemoveCustomerFromQue()
		{
			var client = _CustomerQueue.Dequeue();
			return client;
		}
		public void PeekAtNextCaller()
		{
			_CustomerQueue.Peek();

			
			
		}
	}
}
