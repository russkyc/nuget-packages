## Russkyc.AttachedUtilities.FileStreamExtensions
Console attached method utilities for .NET Standard, .NET Core, and .NET Framework.

### Setup
```csharp
// Dependency Import
using Russkyc.AttachedUtilities.ConsoleExtensions;
```

**RichOutput** - Using `.ToRichOutput()` is required to use the Input and Output Utilities
```csharp

// Use 'ToRichOutput()' before any extension
var message = "What's your name? ".ToRichOutput();

// You can now use any extension from this library
message.GetString();

```

---

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

### Console Output Utilities

**Get Usage:**

```csharp
// Message Prompt
var prompt = "enter input: ".ToRichOutput();

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
var prompt = "enter input: ".ToRichOutput();

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

---

### Console Output Utilities

**Formatting** - Formats console output. Can be used continuously in a builder pattern
- _`.SetForeground()`_ - Sets the console output text color.
- _`.SetBackground()`_ - Sets the console output background color.
- _`.SetMode()`_ - Sets the output mode to Console(Default) or Debug.

**Output** - Writes output to the console.
- _`.Write()`_ - Works like `Console.Write()`.
- _`.WriteLine()`_ - Works like `Console.WriteLine`.
- _`.WriteAll()`_ - Works like `Console.Write()` but prints a `List<T>` or `T[]` with custom delimiters

### Console Output Utilities

**Formatting Usage:**

```csharp
// Message Prompt
var message = "Hello Worls".ToRichOutput();

// Sets Foreground for this output
message.SetForeground(Foreground.Green);

// Sets Background for this output
message.SetBackground(Background.Red);

// Sets Output Mode for this output
message.SetMode(OutputMode.Console);

// Can be used in a builder pattern
message.SetForeground(Foreground.Green)
       .SetBackGround(Background.Blue)
       .SetMode(Output.Debug);

```

**Output Usage:**

```csharp
// Message Prompt
var message = "Hello World".ToRichOutput();

// Message Collection
List<string> fruits = new List<string>
{
    "apple",
    "banana",
    "cherry",
    "date",
    "elderberry"
};

// Writes
message.Write();

// Writes a new line
message.WriteLine();

// Writes collection content on a line delimited by commas
fruits.WriteAll(", ");

// Can be used after the Formatters
message.SetForeground(Foreground.White)
       .SetBackground(Background.Blue)
       .WriteLine();
```

**Colors under Foreground and Background:**

| Color       | Preview                              |
|-------------|--------------------------------------|
| Black       | <span style="color:#000000">■</span> |
| Blue        | <span style="color:#0000FF">■</span> |
| DarkBlue    | <span style="color:#00008B">■</span> |
| Green       | <span style="color:#008000">■</span> |
| DarkGreen   | <span style="color:#006400">■</span> |
| Cyan        | <span style="color:#00FFFF">■</span> |
| DarkCyan    | <span style="color:#008B8B">■</span> |
| Red         | <span style="color:#FF0000">■</span> |
| DarkRed     | <span style="color:#8B0000">■</span> |
| Magenta     | <span style="color:#FF00FF">■</span> |
| DarkMagenta | <span style="color:#800080">■</span> |
| Yellow      | <span style="color:#FFFF00">■</span> |
| DarkYellow  | <span style="color:#808000">■</span> |
| White       | <span style="color:#FFFFFF">■</span> |
| Gray        | <span style="color:#808080">■</span> |
| DarkGray    | <span style="color:#A9A9A9">■</span> |

