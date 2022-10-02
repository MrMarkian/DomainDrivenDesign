using System;

namespace MarketPlace.Domain
{
    public class ClassifiedAdId
    {
        private readonly Guid _value;

        public ClassifiedAdId(Guid value)
        {
            if (value == default)
                throw new ArgumentException(nameof(value), "Classified Ad ID Cannot be empty");

            _value = value;
        }
    }
}