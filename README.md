# 🚗 OOP Generic — C# Vehicle Management

A C# .NET Framework 4.8 console application demonstrating core Object-Oriented Programming (OOP) principles and Generics through a vehicle hierarchy system.

## 🎯 What This Project Covers

This project is a hands-on demonstration of the following C# and OOP concepts:

- **Abstraction** — `vehicle` is an `abstract` class with an abstract `details()` method
- **Inheritance** — `fourwheeler` and `twowheeler` extend `vehicle`; `car` and `motorcycle` are sealed leaf classes
- **Interfaces** — `IInteriordesign`, `IExteriordesign`, `Igenericdetail<T>`, `Ivehicledetail<T>`
- **Generics** — `Igenericdetail<T>`, `Ivehicledetail<T>`, `genericdetailimp<T>`, `vehicledetailimp<T>`
- **Generic Constraints** — `where T : vehicle` used in `vehicledetailimp` and `Ivehicledetail`
- **Sealed Classes** — `car` and `motorcycle` cannot be further subclassed
- **Enum** — `vehicletype` enum (`personal`, `family`, `sports`, `racing`)
- **`params` keyword** — used in design interfaces for flexible argument passing

---

## 🏗️ Class Hierarchy

```
vehicle  (abstract)
├── fourwheeler  : vehicle, IInteriordesign
│   └── car  (sealed)
└── twowheeler   : vehicle, IExteriordesign
    └── motorcycle  (sealed)
```

---

## 📐 Interfaces

| Interface | Methods | Implemented By |
|---|---|---|
| `IInteriordesign` | `addInteriordesign(params string[])`, `getInteriordesign()` | `fourwheeler` |
| `IExteriordesign` | `addExteriordesign(params string[])`, `getExteriordesign()` | `twowheeler` |
| `Igenericdetail<T>` | `getdetail<T>(T obj)` | `genericdetailimp<T>` |
| `Ivehicledetail<T>` | `getdetail<T1>(T1 obj) where T1 : vehicle` | `vehicledetailimp<T>` |

---

## 📁 Project Structure

oop_generic/
│
├── vehicle.cs                  # Abstract base class — model, cc, yearmake, noofgear, vehicletype
├── fourwheeler.cs              # Inherits vehicle + implements IInteriordesign
├── twowheeler.cs               # Inherits vehicle + implements IExteriordesign
├── car.cs                      # Sealed — extends fourwheeler
├── motorcycle.cs               # Sealed — extends twowheeler
│
├── vehicletype.cs              # Enum: personal, family, sports, racing
│
├── IInteriordesign.cs          # Interface for interior design features
├── IExteriordesign.cs          # Interface for exterior design features
├── Igenericdetail.cs           # Generic interface — no vehicle constraint
├── Ivehicledetail.cs           # Generic interface — constrained to vehicle
│
├── vehicledetailimp.cs         # Implements Ivehicledetail<T> — uses constraint
├── genericdetailimp.cs         # Implements Igenericdetail<T> — uses type checking
│
└── Program.cs                  # Entry point — demo of car and motorcycle

## 🔍 Key Design Decisions

### Two Generic Implementations

The project intentionally provides two different approaches to the same problem — getting vehicle details generically:

**`vehicledetailimp<T>`** uses a **generic constraint**:
```csharp
public string getdetail<T1>(T1 obj) where T1 : vehicle
{
    return obj.details(); // safe — compiler guarantees T1 is a vehicle
}


**`genericdetailimp<T>`** uses **runtime type checking**:
```csharp
public string getdetail<T1>(T1 obj)
{
    if (obj is vehicle v)
        return v.details();
    else
        return "not a vehicle";
}


This contrast shows the difference between **compile-time safety** (constraints) and **runtime flexibility** (type checking).



## 🖥️ Sample Output

Running `Program.cs` produces:


6,  6, BMW,  1500,  2021, 5, personal
auto drive,miusic sestem

R15,  50,  2017, 5, personal, air cool, disk, drum, hero,   50
vip horn


The program creates:
- A `car` (BMW, 1500cc, 2021, 6-door, 6-seat) with interior designs added
- A `motorcycle` (R15, 50cc, 2017) with an exterior design added



## ▶️ Getting Started

### Prerequisites

- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- Or [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/download/dotnet-framework/net48)

### Run in Visual Studio

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/oop_generic.git
   ```
2. Open `oop_generic.csproj` in Visual Studio
3. Press `F5` to build and run

### Run via Command Line

```bash
cd oop_generic
msbuild oop_generic.csproj
bin\Debug\oop_generic.exe
```

---

## 📦 `vehicletype` Enum

```csharp
public enum vehicletype
{
    personal,
    family,
    sports,
    racing
}


Used to categorize any vehicle at construction time.



## 🤝 Contributing

Pull requests are welcome. Feel free to extend the hierarchy with new vehicle types (e.g., `truck`, `bus`) or add new interfaces (e.g., `IFueltype`, `IEngine`).

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

> Built with C# .NET Framework 4.8 — focused on clean OOP design and Generics

