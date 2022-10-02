using System;

namespace MarketPlace.Domain
{
    public class UserId
    {

        private readonly Guid _value;

        public UserId(Guid value)
        {
            if (value == default)
            {
                throw new ArgumentException(nameof(value), "User Id Cannot be emtpy.");
                
            }

            _value = value;
        }

    }
}