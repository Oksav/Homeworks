using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
   

    class Medium
    {
        public delegate void BreakingNewsHandler(object medium, DateTime e);
        public event BreakingNewsHandler BreakingNews;

        public void SendBreakingNews(string news, string bulshit, DateTime time) 
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"On {time} , A {news}, and ALSO {bulshit}");
            OnBreakingNews();
        }

        protected virtual void OnBreakingNews()
        {
            if(BreakingNews != null)
            {
                BreakingNews(this, DateTime.Now );
            }
        }

    }

    class Follower
    {
        public string Name;

        public Follower(string name)
        {
            Name = name;
        }

        public void Subscribe(Medium medium)
        {
            medium.BreakingNews += Medium_BreakingNews;
        }

        private void Medium_BreakingNews(object medium, DateTime e)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"{Name} have subscribed to {medium} on {DateTime.Now}");
        }
    }
    // HomeWork part 2
    public class GenericList<T>
    {
        private T[] Type = new T[10];
        public int Count;

        public void Add(T element)
        {
            T[] Type = new T[] { element };
        }
        public void Remove(int index)
        {
            Array.Resize(ref Type, index);
            
        }
        public void GetElementByIndex(int index)
        {
            var x = Type[index];
            Console.WriteLine($"The index at {index} position is {x}");
        }
        public T this[int i]
        {
            get
            {
                return Type[i];
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            #region Mediums
            Medium cnn = new Medium();
            Medium a1 = new Medium();
            #endregion

            #region Followers
            Follower john = new Follower("John");
            Follower zvonko = new Follower("Zvonko");
            Follower zivko = new Follower("Zivko");
            #endregion

            #region Subscriptions
            john.Subscribe(cnn);
            john.Subscribe(a1);

            zvonko.Subscribe(a1);

            zivko.Subscribe(cnn);
            #endregion

            #region SendingNews
            cnn.SendBreakingNews("Man died eating", "lorem ipsum...", DateTime.Now);
            a1.SendBreakingNews("Cat bitten by a spider, looks like a ballon", "lorem ipsum...", DateTime.Now);
            #endregion
       

            Console.ReadLine();
        }
    }
}
