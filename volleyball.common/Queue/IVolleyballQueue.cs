using System;
using System.Threading.Tasks;
using volleyball.common.message;

namespace volleyball.common.queue
{
    public interface IVolleyballQueue
    {
        Task Publish(BaseVolleyballMessage message);
        Task Consume(string queue);
    }
}