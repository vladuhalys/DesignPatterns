using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.State
{
    public interface IState<T>
    {
        public void InitState(T value);
        public void SetState(T value);
        public void Dispose();
        public void Build();
    }
    public abstract class State<T> : IState<T>
    {
        public abstract void InitState(T value);
        public abstract void SetState(T value);
        public abstract void Dispose();
        public abstract void Build();
    }
}
