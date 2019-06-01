using System;

namespace HNShop.Common.Exception
{
    public class NameDuplicatedException : SystemException
    {
        public NameDuplicatedException()
        {
        }

        public NameDuplicatedException(string message)
        : base(message)
        {
        }

        public NameDuplicatedException(string message, SystemException inner)
        : base(message, inner)
        {
        }
    }
}