using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class IntegrationBaseEvent
    {
		public Guid Id { get; private set; }
		public DateTime CreationDate { get; private set; }

		// If no values are passed to the constructor then we will set it over here
		public IntegrationBaseEvent()
		{
			Id = Guid.NewGuid();
			CreationDate = DateTime.UtcNow;
		}

		public IntegrationBaseEvent(Guid id, DateTime createDate)
		{
			Id = id;
			CreationDate = createDate;
		}

	}
}
