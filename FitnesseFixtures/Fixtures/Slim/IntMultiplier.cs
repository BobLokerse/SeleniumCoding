using System.Diagnostics.CodeAnalysis;

namespace Tahzoo.FitnesseFixtures.Fixtures.Slim
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnassignedField.Global")]
    public class IntMultiplier
    {
        private int _second;

        // public field can be "set"
        public int First;

        // a setter method, optionally prefixed with "set" also works
        public void SetSecond(int value)
        {
            _second = value;
        }

        // and of couse a property works
        public int Third { get; set; }

        // this is called automatically
        public void Execute()
        {
            Result = First * _second * Third;
        }

        public int Result { get; private set; }
    }
}
