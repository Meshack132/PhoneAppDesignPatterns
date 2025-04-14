# PhoneAppDesignPatterns

**Created by Meshack Mthimkhulu**  
**ASP.NET Core Application Demonstrating Design Patterns**

## 📝 Overview
This project is a C# ASP.NET Core application that implements three fundamental design patterns:
1. **Singleton Pattern** - For centralized logging
2. **Strategy Pattern** - For flexible payment processing
3. **Observer Pattern** - For order status notifications

## 🏗️ Project Structure
```
PhoneAppDesignPatterns/
├── Controllers/
│   ├── PaymentController.cs       # Handles payment processing
│   └── OrderController.cs         # Manages order status updates
│
├── Models/
│   ├── Payment/                   # Strategy Pattern implementation
│   │   ├── IPaymentStrategy.cs    # Strategy interface
│   │   ├── PaymentContext.cs      # Context class
│   │   └── Strategies/            # Concrete strategies
│   │       ├── CreditCardPayment.cs
│   │       ├── PayPalPayment.cs
│   │       └── CryptoPayment.cs
│   │
│   ├── Order/                     # Observer Pattern implementation
│   │   ├── Order.cs               # Subject
│   │   ├── IOrderObserver.cs      # Observer interface
│   │   └── Observers/             # Concrete observers
│   │       ├── NotificationService.cs
│   │       └── InventoryService.cs
│   │
│   └── Logging/                   # Singleton Pattern implementation
│       ├── IAppLogger.cs          # Logger interface
│       └── Logger.cs              # Singleton logger
│
├── Program.cs                     # Application configuration
└── README.md                      # This file
```

## 🎯 Design Pattern Implementations

### 1. Singleton Pattern (Logger)
- **Location**: `Models/Logging/`
- **Purpose**: Ensure a single logger instance across the application
- **Key Features**:
  - Thread-safe initialization
  - Global access point via `Logger.Instance`
  - Prevents multiple logger instantiations

### 2. Strategy Pattern (Payment Processing)
- **Location**: `Models/Payment/`
- **Purpose**: Encapsulate different payment algorithms
- **Key Features**:
  - Easy to add new payment methods
  - Runtime algorithm selection
  - Decouples payment logic from clients

### 3. Observer Pattern (Order Status)
- **Location**: `Models/Order/`
- **Purpose**: Notify multiple services about order changes
- **Key Features**:
  - Loose coupling between subject and observers
  - Dynamic observer registration
  - Automatic notifications on state changes

## 🚀 Getting Started

### Prerequisites
- .NET 6.0 SDK
- IDE (Visual Studio 2022 or VS Code recommended)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/PhoneAppDesignPatterns.git
   ```
2. Navigate to project directory:
   ```bash
   cd PhoneAppDesignPatterns
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```

### Running the Application
```bash
dotnet run
```
The application will start on:
- `http://localhost:5000`
- `https://localhost:5001`

## 🧪 Testing the API

### Payment Processing (Strategy Pattern)
```bash
# Credit Card Payment
curl -X POST "http://localhost:5000/api/payment/process?method=creditcard&amount=100"

# PayPal Payment
curl -X POST "http://localhost:5000/api/payment/process?method=paypal&amount=50"

# Cryptocurrency Payment
curl -X POST "http://localhost:5000/api/payment/process?method=crypto&amount=200"
```

### Order Status Updates (Observer Pattern)
```bash
# Update order status
curl -X PUT "http://localhost:5000/api/order/status?newStatus=processing"
```

Check the console output for observer notifications.

## 🤝 Contribution
Contributions are welcome! Please fork the repository and create a pull request.

## 📜 License
This project is licensed under the MIT License.

## ✉️ Contact
**Meshack Mthimkhulu**  

GitHub: [@Meshack132](https://github.com/Meshack132)
