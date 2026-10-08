# Flags

A small, fast bit flag utility.

## Features

- Lightweight `Flag` struct
- Bit set, clear, and check operations
- Bounds validation for 8-bit flags
- Aggressive inlining for hot paths
- No external dependencies

## Usage

```csharp
using PixelEngine;

BitFlags flags = default;

flags.Set(0);
flags.Set(3);

if (flags.Has(0))
{
    // Flag 0 is enabled
}

if (flags.Has(3))
{
    // Flag 3 is enabled
}

flags.Clear(0);
