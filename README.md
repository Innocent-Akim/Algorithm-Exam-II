# RUDOLF Accounting (Algorithm Exam II)

Commercial and accounting management application developed in Visual Basic .NET. This project allows for the management of products, customers/suppliers, as well as the tracking of accounting movements (debit/credit) and supplies.

## 📋 Features

- **Secure Authentication**: Access protected by username and password.
- **Product Management**: Add, modify, and view products with images and barcodes.
- **Tier Management**: Tracking of Customers and Suppliers.
- **Accounting Operations**: Recording of debit and credit operations.
- **Movements & Stock**: Tracking of entries/exits and stock management.
- **Reports & Statements**: Generation of reports (Journal, General Ledger, Balance, Invoices) via Crystal Reports.

## 🛠 Prerequisites

- Windows Operating System
- Microsoft Visual Studio (to open and compile the project)
- .NET Framework 4.5.2 or later
- Microsoft Access Database Engine 2010 (for connecting to the `.accdb` database)

## 🚀 Installation and Setup

To run the application, you must configure the access path to the Access database.

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Innocent-Akim/Algorithm-Exam-II.git
   ```

2. **Database Configuration**:
   The application reads the database path from a specific text file.

   - Create a folder named `tpVb` at the root of your `C:` drive (`C:\tpVb`).
   - Inside this folder, create a text file named `conFileExamen.txt` (`C:\tpVb\conFileExamen.txt`).
   - Open this file and paste the full path to the `bd_Rudolf.accdb` database file located in the project folder.

     *Example content for C:\tpVb\conFileExamen.txt:*
     ```text
     C:\Path\To\Your\Folder\Algorithm-Exam-II\ExamenVB\bd_Rudolf.accdb
     ```

3. **Launch**:
   - Open the `ComptabiliteRUDOLF.sln` solution file with Visual Studio.
   - Run the application (F5).

## 🔑 Login

Use the default credentials to log in:

- **Username**: `RUDOLF`
- **Password**: `1002`

## 📂 Project Structure

- **ExamenVB/Formulaires**: Contains user interfaces (Login, Dashboard, Product Management, etc.).
- **ExamenVB/Classes**: Contains business logic and data management (`clsGlossiaire`, `clsConnexion`, etc.).
- **ExamenVB/bd_Rudolf.accdb**: Microsoft Access Database.

## 👤 Author

Eugene Tondeka
