# Cafe Order

A Windows Forms order screen for a coffee bar: pick drinks and quantities, then see the itemised order and its total in rand.

[![CI](https://github.com/blaisedegier/cafe-order-winforms/actions/workflows/ci.yml/badge.svg)](https://github.com/blaisedegier/cafe-order-winforms/actions/workflows/ci.yml)

## What it does

- Choose a drink from a fixed menu and a quantity of 1 or more, then press **Add Item** to put it on the order.
- Press **Display** to list every line (drink, quantity, unit price, line total) and the order total.

| Drink      | Price |
| ---------- | ----- |
| Americano  | R15   |
| Espresso   | R20   |
| Cappuccino | R25   |
| Latte      | R30   |

## How it works

`Item` is one order line. Its constructor looks the unit price up from the drink name with a `switch` expression and
throws for a name that is not on the menu or a quantity below 1, so an item can never be priced at zero by accident.
The form backs this up at the edge: the drink box is a drop-down list (no free text), the quantity spinner starts at
1, and the add handler asks for a selection before it builds an `Item`.

`Basket` holds the lines in a `List<Item>` and formats the summary, summing the line totals with LINQ.

## Running it

Prerequisites: Windows and the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

```bash
git clone https://github.com/blaisedegier/cafe-order-winforms.git
cd cafe-order-winforms
dotnet build CafeApp/CafeApp.sln -c Release
dotnet run --project CafeApp/CafeApp.csproj
```

Run the commands from the repository root: the root holds no project file, so they name the solution and project
by path. Visual Studio users can open `CafeApp/CafeApp.sln`.

## Tech

C# 12, .NET 8 (`net8.0-windows`), Windows Forms. No NuGet packages.

## Known limitations

- The menu and prices are hard-coded in `Item.cs`.
- Lines cannot be removed or edited once added, and adding the same drink twice gives two lines.
- The order is held in memory only and is lost when the window closes.
- Windows only, as Windows Forms is.
- No automated tests.
