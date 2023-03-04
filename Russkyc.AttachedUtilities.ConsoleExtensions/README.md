## Russkyc.AttachedUtilities.FileStreamExtensions
Console attached method utilities for .NET Standard, .NET Core, and .NET Framework.

### Setup
```csharp
//Dependency Import
using Russkyc.AttachedUtilities.ConsoleExtensions;
```

### Console Input Utilities

**Get** - Single Value Input.
- _`.GetChar()`_ - Returns `char` input.
- _`.GetString()`_ - Returns `string` input.
- _`.GetInt()`_ - Returns `int` input.
- _`.GetDouble()`_ - Returns `double` input.
- _`.GetFloat()`_ - Returns `float` input.
- _`.GetBool()`_ - Returns `bool` input.

**GetCollection** - Multi Value separated Input.
- _`.GetCharCollection()`_ - Returns `List<char>` from comma or space separated input.
- _`.GetStringCollection()`_ - Returns `List<string>` from comma or space separated input.
- _`.GetIntCollection()`_ - Returns `List<int>` from comma or space separated input.
- _`.GetDoubleCollection()`_ - Returns `List<double>` from comma or space separated input.
- _`.GetFloatCollection()`_ - Returns `List<float>` from comma or space separated input.
- _`.GetBoolCollection()`_ - Returns `List<bool>` from comma or space separated input.

**Get Usage:**

```csharp
// Message Prompt
string prompt = "enter input: ";

// Reads char input
// Sample input: C
char letter = prompt.GetChar();

// Reads String input
// Sample input: Hello
string word = prompt.GetString();

// Reads Whole Number input
// Sample input: 23
int number = prompt.GetInt();

// Reads Decimal Input
// Sample input: 10.99
double price = prompt.GetDouble();
float price = prompt.GetFloat();

// Reads Boolean Input (Ignores Case)
// Sample input: Y or N, Yes or No, T or F, True or False, 1 or 0
bool answer = prompt.GetBool();

```

**Get Collection Usage:**

```csharp
// Message Prompt
string prompt = "enter input: ";

// Reads input to char (Includes spaces and commas)
// Sample input: RUn?NR or C*_20
List<char> letters = prompt.GetCharCollection();

// Reads String input
// Sample input: Hello there or Hi, there
List<string> words = prompt.GetStringCollection();

// Reads Whole Number input
// Sample input: 23, 33, 41, 52 or 12 52 23 32
List<int> numbers = prompt.GetIntCollection();

// Reads Decimal Input
// Sample input: 10.99, 1.00, 9.99, or 2.93 10.20 23.30
List<double> prices = prompt.GetDoubleCollection();
List<float> prices = prompt.GetFloatCollection();

// Reads Boolean Input (Ignores Case)
// Sample input: Y,Y,N,N or true false false true
List<bool> answers = prompt.GetBoolCollection();

```