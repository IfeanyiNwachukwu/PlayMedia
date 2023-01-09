using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Core.Messages;

namespace CQRS.Core.Events
{
    public abstract class BaseEvent : Message
    {
        protected BaseEvent(string type)
        {
            this.Type = type;
        }
        //when we replay the latest state of the aggregate
        public int Version { get; set; }
        //discriminator property when we do polymorphic databinding
        public string Type { get; set; }
    }
}