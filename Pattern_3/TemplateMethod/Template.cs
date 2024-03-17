using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.TemplateMethod
{
    public interface ITemplateCollection<T>
    {
        bool AddToBack(T item);
        bool AddToFront(T item);
        bool RemoveFromBack();
        bool RemoveFromFront();
        T GetFromBack();
        T GetFromFront();
        bool IsEmpty();
        bool IsNotEmpty();
        bool Contains(T Item);
        bool Remove(T Item);
        bool RemoveAt(int index);
        void ShowCollection();
    }
    public abstract class TemplateCollection<T> : ITemplateCollection<T>
    {
        public virtual bool AddToBack(T item) {
            throw new NotImplementedException();
        }
        public virtual bool AddToFront(T item) {
            throw new NotImplementedException();
        }
        public virtual bool RemoveFromBack() {
            throw new NotImplementedException();
        }
        public virtual bool RemoveFromFront(){
            throw new NotImplementedException();
        }
        public virtual T GetFromBack(){
            throw new NotImplementedException();
        }
        public virtual T GetFromFront(){
            throw new NotImplementedException();
        }
        public virtual bool IsEmpty(){
            throw new NotImplementedException();
        }
        public virtual bool IsNotEmpty(){
            throw new NotImplementedException();
        }
        public virtual bool Contains(T Item){
            throw new NotImplementedException();
        }
        public virtual bool Remove(T Item){
            throw new NotImplementedException();
        }
        public virtual bool RemoveAt(int index){
            throw new NotImplementedException();
        }
        public virtual void ShowCollection(){
            throw new NotImplementedException();
        }
    }
}
