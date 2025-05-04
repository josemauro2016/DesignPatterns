using System;

namespace ChainOfResponsability.Middlewares
{
    public abstract class Middleware
    {
        private Middleware next;

        public Middleware LinkWith(Middleware next)
        {
            this.next = next;

            return this.next;
        }

        public abstract Boolean Check(string email, string password);

        protected Boolean CheckNext(string email, string password)
        {
            if (this.next == null)
            {
                return true;
            }
            return this.next.Check(email, password);
        }
    }
}
