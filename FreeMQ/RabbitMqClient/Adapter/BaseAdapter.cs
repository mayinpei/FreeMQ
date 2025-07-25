using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeMQ
{
    partial class RabbitMqClient
    {
        protected internal enum UseType
        {
            Pooling,
        }

        protected internal abstract partial class BaseAdapter
        {
            public static ThreadLocal<Random> _rnd = new ThreadLocal<Random>(() => new Random());
            public UseType UseType { get; protected set; }
            protected internal RabbitMqClient TopOwner { get; protected set; }
        }
    }
}
