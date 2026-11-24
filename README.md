# Coffee Shop Application

Software Construction Lab 10 – Version Control (Git & GitHub).

A small C# console application (refactored in earlier labs) that takes coffee / sandwich
orders, calculates the total amount and sends it to a payment processor.

## Classes
| Class | Responsibility |
|-------|----------------|
| `Menu` | Stores coffee and sandwich prices and allows them to be updated |
| `PaymentProcessor` | Processes the payment for an order |
| `CoffeeShop` | Calculates the order total and processes orders |
| `Program` | Entry point – places sample orders |

## Run
Open `Coffee Shop Refactored.sln` in Visual Studio and press **F5**, or:

```
msbuild "Coffee Shop Refactored.sln"
"Coffee Shop Refactored\bin\Debug\Coffee Shop Refactored.exe"
```

**Author:** Muhammad Asad (02-131242-072)
