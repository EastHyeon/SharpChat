using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCore
{
    public interface IJobQueue
    {
        void Push(Action job);

    }
    public class JobQueue : IJobQueue
    {
        Queue<Action> _jobQueue = new Queue<Action>();
        object _lock = new object();
        bool _execute = false;

        public void Push(Action job)
        {
            bool execute = false;
            lock (_lock)
            {
                _jobQueue.Enqueue(job);
                if (_execute == false)
                    execute = _execute = true;
            }

            if (execute)
                Execute();
        }

        void Execute()
        {
            while (_execute)
            {
                Action action = Pop();
                if (action == null)
                {
                    return;
                }

                action.Invoke();
            }
        }

        Action Pop()
        {
            lock (_lock)
            {
                if (_jobQueue.Count == 0 )
                {
                    _execute = false;
                    return null;
                }
                return _jobQueue.Dequeue();
            }
        }
    }
}
