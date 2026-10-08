using System.Runtime.CompilerServices;

namespace Flag;

public struct Flag : IEquatable<Flag>
{
    private byte _value;
        
    private static void Validate(int bit)
    {
        if ((uint)bit >= 8) 
            throw new ArgumentOutOfRangeException(nameof(bit), "Bit index must be between 0 and 7.");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Set(int bit)
    {
        Validate(bit);
        _value |= (byte)(1 << bit);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Clear(int bit)
    {
        Validate(bit);
        _value &= (byte)~(1 << bit);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has(int bit)
    {
        Validate(bit);
        return (_value & (1 << bit)) != 0;
    }
        
    public readonly bool Equals(Flag other) => _value == other._value;
    public readonly override bool Equals(object obj) => obj is Flag flags && Equals(flags);
    public readonly override int GetHashCode() => _value.GetHashCode();
    
    public readonly override string ToString() => Convert.ToString(_value, 2).PadLeft(8, '0');
}